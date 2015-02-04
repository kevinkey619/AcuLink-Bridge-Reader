using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Globalization;
using System.Configuration;
using System.Diagnostics;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
using System.Reflection;

namespace AcuLink_Bridge_Reader_CSharp
{
    public partial class frmMain : Form
    {
        DataTable dtRainData = new DataTable();
        double previousRainReading = 0;
        double cumulRainDay = 0;
        double cumulRainNoReset = 0;
        double rainHour = 0;
        DataTable dtWindData = new DataTable();
        int previousDay = DateTime.Now.Day;
        string waitMessage = "Waiting for bridge data. If this takes more than 5 minutes, please check whether the correct network device is selected.";
        int noSensorDataIterations = 0;
        double windGust;
        double dewpoint;
        string windDirHex;
        double windDegrees;
        double windspeed;
        double temperature;
        double humidity;
        double pressure;
        double currRain;
        int signal;
        int signalFails;
        string battery;
        double c1;
        double c2;
        double c3;
        double c4;
        double c5;
        double c6;
        double c7;
        double a;
        double b;
        double c;
        double d;
        double pr;
        double tr;
        double d1;
        double d2;
        double dut;
        double off;
        double sens;
        double x;
        double p;
        double t;
        string sensorId;
        string sensorType;
        int skipUpdateInterval = 33;
        int skipUpdateCount = 0;

        PacketCommunicator communicator;

        // Callback function invoked by Pcap.Net for every incoming packet
        private void PacketHandler(Packet packet)
        {

            if (!BackgroundWorker1.CancellationPending == true)
            {
                try
                {
                    this.Invoke(new MethodInvoker(() => pbarProgressBar1.Visible = true));

                    if (packet.Ethernet.IpV4.Tcp.Payload != null)
                    {
                        Match match;
                        string text = Encoding.ASCII.GetString(packet.Ethernet.IpV4.Tcp.Payload.ToMemoryStream().ToArray());

                        if (Properties.Settings.Default.filterOnSensorId.ToString().Length > 0)
                        {
                            match = Regex.Match(text.ToLower(), "sensor=" + Properties.Settings.Default.filterOnSensorId.ToString() + "|mt=pressure", RegexOptions.Singleline);
                        }
                        else if (Properties.Settings.Default.sensorType.ToString().Length > 0)
                        {
                            match = Regex.Match(text.ToLower(), "mt=" + Properties.Settings.Default.sensorType.ToString() + "|mt=pressure", RegexOptions.Singleline);
                        }
                        else 
                        {
                            match = Regex.Match(text.ToLower(), "mt=", RegexOptions.Singleline);
                        }
                        
                        string[] bridgeDataArray;
                        double pressureOffset = Properties.Settings.Default.pressureOffset;

                        if (match.Success)
                        {
                            this.Invoke(new MethodInvoker(() => pbarProgressBar1.Value = progressBarValue(10)));

                            this.Invoke(new MethodInvoker(() => txtOutput.Text = txtOutput.Text.Replace(waitMessage, "")));

                            bridgeDataArray = text.Split('&');

                            if (text.IndexOf("mt=" + Properties.Settings.Default.sensorType.ToString(), StringComparison.CurrentCultureIgnoreCase) == -1)
                            {
                                noSensorDataIterations += 1;
                            }
                            else
                            {
                                noSensorDataIterations = 0;                                
                            }
                            
                            foreach (string element in bridgeDataArray)
                            {

                                if (element.IndexOf("sensor=") == 0)
                                {
                                    sensorId = element.Substring(7,5);
                                }

                                if (element.IndexOf("mt=") == 0)
                                {
                                    sensorType = element.Substring(3).ToLower();
                                }

                                if(Properties.Settings.Default.filterOnSensorId.ToString().Length == 0 || sensorId == Properties.Settings.Default.filterOnSensorId.ToString())
                                {
                                    if (element.IndexOf("winddir=") == 0 
                                        && (Properties.Settings.Default.sensorTypeWind == "" || sensorType.IndexOf(Properties.Settings.Default.sensorTypeWind) != -1)
                                        && (Properties.Settings.Default.sensorIdWind == "" || sensorId.IndexOf(Properties.Settings.Default.sensorIdWind) != -1))
                                    {
                                        windDirHex = element.Substring(8, 1);

                                        switch (windDirHex)
                                        {
                                            case "5":
                                                windDegrees = 0;
                                                break;
                                            case "7":
                                                windDegrees = 22.5;
                                                break;
                                            case "3":
                                                windDegrees = 45;
                                                break;
                                            case "1":
                                                windDegrees = 67.5;
                                                break;
                                            case "9":
                                                windDegrees = 90;
                                                break;
                                            case "B":
                                                windDegrees = 112.5;
                                                break;
                                            case "F":
                                                windDegrees = 135;
                                                break;
                                            case "D":
                                                windDegrees = 157.5;
                                                break;
                                            case "C":
                                                windDegrees = 180;
                                                break;
                                            case "E":
                                                windDegrees = 202.5;
                                                break;
                                            case "A":
                                                windDegrees = 225;
                                                break;
                                            case "8":
                                                windDegrees = 247.5;
                                                break;
                                            case "0":
                                                windDegrees = 270;
                                                break;
                                            case "2":
                                                windDegrees = 292.5;
                                                break;
                                            case "6":
                                                windDegrees = 315;
                                                break;
                                            case "4":
                                                windDegrees = 337.5;
                                                break;
                                        }
                                    }

                                    if (element.IndexOf("windspeed=") == 0 
                                        && (Properties.Settings.Default.sensorTypeWind == "" || sensorType.IndexOf(Properties.Settings.Default.sensorTypeWind) != -1)
                                        && (Properties.Settings.Default.sensorIdWind == "" || sensorId.IndexOf(Properties.Settings.Default.sensorIdWind) != -1))
                                    {
                                        windspeed = Math.Round(double.Parse(element.Substring(11, 5)) / 44.70400004, 1);

                                        dtWindData.Rows.Add(new object[] {
								        DateTime.Now,
								        windspeed
							        });

                                        windGust = calcWindGust(windspeed);
                                    }

                                    if (element.IndexOf("temperature=") == 0 
                                        && (Properties.Settings.Default.sensorTypeTemp == "" || sensorType.IndexOf(Properties.Settings.Default.sensorTypeTemp) != -1)
                                        && (Properties.Settings.Default.sensorIdTemp == "" || sensorId.IndexOf(Properties.Settings.Default.sensorIdTemp) != -1))
                                    {
                                        if (element.Substring(13, 1) == "-")
                                        {
                                            temperature = Math.Round(double.Parse(element.Substring(14, 4)) * -1 / 100 * 9 / 5 + 32, 1);
                                        }
                                        else
                                        {
                                            temperature = Math.Round(double.Parse(element.Substring(14, 4)) / 100 * 9 / 5 + 32, 1);
                                        }

                                    }

                                    if (element.IndexOf("humidity=") == 0
                                        && (Properties.Settings.Default.sensorTypeHumidity == "" || sensorType.IndexOf(Properties.Settings.Default.sensorTypeHumidity) != -1)
                                        && (Properties.Settings.Default.sensorIdHumidity == "" || sensorId.IndexOf(Properties.Settings.Default.sensorIdHumidity) != -1))
                                    {
                                        humidity = double.Parse(element.Substring(11, 3)) / 10;
                                    }

                                    if (element.IndexOf("rainfall=") == 0
                                        && (Properties.Settings.Default.sensorTypeRain == "" || sensorType.IndexOf(Properties.Settings.Default.sensorTypeRain) != -1)
                                        && (Properties.Settings.Default.sensorIdRain == "" || sensorId.IndexOf(Properties.Settings.Default.sensorIdRain) != -1))
                                    {
                                        currRain = Math.Round(double.Parse(element.Substring(10, 6)) / 2540, 3);

                                        if (currRain > 0)
                                        {
                                            cumulRainDay += currRain;
                                            cumulRainNoReset += currRain;
                                        }

                                        dtRainData.Rows.Add(new object[] { DateTime.Now, currRain });

                                        rainHour = rainLast60Minutes(currRain);
                                    }

                                    if (element.IndexOf("rssi=") == 0)
                                    {
                                        signal = int.Parse(element.Substring(5, 1));
                                    }

                                    if (element.IndexOf("battery=") == 0)
                                    {
                                        battery = element.Substring(8);
                                    }
                                }

                               
                                // Get and process pressure data
                                if (element.IndexOf("C1=") == 0)
                                {
                                    c1 = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("C2=") == 0)
                                {
                                    c2 = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("C3=") == 0)
                                {
                                    c3 = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("C4=") == 0)
                                {
                                    c4 = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("C5=") == 0)
                                {
                                    c5 = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("C6=") == 0)
                                {
                                    c6 = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("C7=") == 0)
                                {
                                    c7 = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("A=") == 0)
                                {
                                    a = Int32.Parse(element.Substring(3), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("B=") == 0)
                                {
                                    b = Int32.Parse(element.Substring(3), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("C=") == 0)
                                {
                                    c = Int32.Parse(element.Substring(3), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("D=") == 0)
                                {
                                    d = Int32.Parse(element.Substring(3), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("PR=") == 0)
                                {
                                    pr = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);
                                }

                                if (element.IndexOf("TR=") == 0)
                                {
                                    tr = Int32.Parse(element.Substring(3, 4), NumberStyles.HexNumber);

                                    d1 = pr;
                                    d2 = tr;

                                    if (d2 >= c5)
                                    {
                                        dut = d2 - c5 - ((d2 - c5) / Math.Pow(2, 7)) * ((d2 - c5) / Math.Pow(2, 7)) * a / Math.Pow(2, c);
                                    }
                                    else
                                    {
                                        dut = d2 - c5 - ((d2 - c5) / Math.Pow(2, 7)) * ((d2 - c5) / Math.Pow(2, 7)) * b / Math.Pow(2, c);
                                    }

                                    off = (c2 + (c4 - 1024) * dut / Math.Pow(2, 14)) * 4;

                                    sens = c1 + c3 * dut / Math.Pow(2, 10);

                                    x = sens * (d1 - 7168) / Math.Pow(2, 14) - off;

                                    p = x * 10 / Math.Pow(2, 5) + c7;

                                    t = 250 + dut * c6 / Math.Pow(2, 16) - dut / Math.Pow(2, d);

                                    pressure = Math.Round(p / 338.6 + pressureOffset, 2);
                                }
                                
                                if (humidity > 0)
                                {
                                    dewpoint = ((((temperature - 32) / 1.8) - (14.55 + 0.114 * ((temperature - 32) / 1.8)) * (1 - (0.01 * humidity)) - Math.Pow(((2.5 + 0.007 *
                                        ((temperature - 32) / 1.8)) * (1 - (0.01 * humidity))), 3) - (15.9 + 0.117 * ((temperature - 32) / 1.8)) *
                                        Math.Pow((1 - (0.01 * humidity)), 14)) * 1.8) + 32;
                                    dewpoint = Math.Round(dewpoint, 1);
                                }

                            }

                            if (txtOutput.Text.Length > 50000)
                            {
                                this.Invoke(new MethodInvoker(() => string.IsNullOrEmpty(txtOutput.Text)));
                            }

                            string wuResponse = null;
                            string wBugResponse = null;
                            string pwsResponse = null;
                            string aWeatherResponse = null;

                            if (pressure > 0 & (humidity > 0 || Properties.Settings.Default.filterOnSensorId.ToString() == "water" && temperature > 0) & noSensorDataIterations < 5)
                            {
                                if (Properties.Settings.Default.postToWunderground == true)
                                {
                                    string wundergroundUpdateString = "http://rtupdate.wunderground.com/weatherstation/updateweatherstation.php?ID=" + Properties.Settings.Default.wuStation +
                                        "&PASSWORD=" + System.Uri.EscapeUriString(Properties.Settings.Default.wuPwd) + "&dateutc=" +
                                        System.Uri.EscapeUriString(Convert.ToString(DateTime.Now.ToUniversalTime())) + "&winddir=" + windDegrees + "&windspeedmph=" + windspeed + "&tempf=" +
                                        temperature + "&rainin=" + rainHour + "&dailyrainin=" + cumulRainDay + "&baromin=" + pressure + "&dewptf=" + dewpoint + "&humidity=" + humidity +
                                        "&softwaretype=" + "Kevins%20Acu-Rapid%201217&action=updateraw&realtime=1&rtfreq=15" + "&windgustmph=" + windGust /*+ "&indoortempf=" + temperature +
                                        "&soiltempf=" + temperature*/;
                                    try
                                    {
                                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(wundergroundUpdateString);
                                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                                        Stream receiveStream = response.GetResponseStream();
                                        StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                                        wuResponse = readStream.ReadToEnd();

                                        readStream.Close();
                                        response.Close();

                                        if (wuResponse.IndexOf("success") != -1)
                                        {
                                            wuResponse = "ok";
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        wuResponse = "";
                                        this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "\t" + "ERROR posting data to Weather Underground. " + ex.Message +
                                            System.Environment.NewLine + txtOutput.Text));
                                    }
                                }
                                else
                                {
                                    wuResponse = "off";
                                }

                                if (Properties.Settings.Default.postToWeatherBug == true)
                                {                                    
                                    string weatherBugUpdateString = "http://data.backyard2.weatherbug.com/data/livedata.aspx?ID=" + Properties.Settings.Default.wbPub + "&Key=" +
                                        Properties.Settings.Default.wbPwd + "&num=" + Properties.Settings.Default.wbStation + "&dateutc=" +
                                        System.Uri.EscapeUriString(Convert.ToString(DateTime.Now.ToUniversalTime())) + "&winddir=" + windDegrees + "&windspeedmph=" + windspeed +
                                        "&windgustmph=" + windGust + "&tempf=" + temperature + "&rainin=" + rainHour + "&dailyrainin=" + cumulRainDay + "&baromin=" + pressure +
                                        "&dewptf=" + dewpoint + "&humidity=" + humidity + "&softwaretype=Kevin%27s%20Acu-Link";
                                    try
                                    {
                                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(weatherBugUpdateString);
                                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                                        Stream receiveStream = response.GetResponseStream();
                                        StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                                        wBugResponse = readStream.ReadToEnd();
                                        
                                        readStream.Close();
                                        response.Close();

                                        if (wBugResponse == "Successfully Received QueryString Data")
                                        {
                                            wBugResponse = "ok";
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        wBugResponse = "";
                                        this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "\t" + "ERROR posting data to Weatherbug. " + ex.Message +
                                            System.Environment.NewLine + txtOutput.Text));
                                    }

                                }
                                else
                                {
                                    wBugResponse = "off";
                                }

                                if (Properties.Settings.Default.postToPws == true)
                                {
                                    string pwsUpdateString = "http://www.pwsweather.com/pwsupdate/pwsupdate.php?ID=" + Properties.Settings.Default.pwsStation + "&PASSWORD=" +
                                        Properties.Settings.Default.pwsPwd + "&dateutc=" +
                                        DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd+HH\\%3Amm\\%3Ass") + "&winddir=" + windDegrees + "&windspeedmph=" + windspeed +
                                        "&windgustmph=" + windGust + "&tempf=" + temperature + "&rainin=" + rainHour + "&dailyrainin=" + cumulRainDay + "&baromin=" + pressure +
                                        "&dewptf=" + dewpoint + "&humidity=" + humidity + "&action=updateraw";

                                    //this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "\t" + pwsUpdateString +
                                    //        System.Environment.NewLine + txtOutput.Text));

                                    try
                                    {
                                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(pwsUpdateString);
                                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                                        Stream receiveStream = response.GetResponseStream();
                                        StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                                        pwsResponse = readStream.ReadToEnd();

                                        readStream.Close();
                                        response.Close();

                                        if (pwsResponse.IndexOf("Data Logged and posted in METAR mirror") >= 0)
                                        {
                                            pwsResponse = "ok";
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        pwsResponse = "";
                                        this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "\t" + "ERROR posting data to PWSweather. " + ex.Message +
                                            System.Environment.NewLine + txtOutput.Text));
                                    }
                                }
                                else
                                {
                                    pwsResponse = "off";
                                }

                                if (Properties.Settings.Default.postToAWeather == true)
                                {

                                    if (skipUpdateCount == 0 || skipUpdateCount >= skipUpdateInterval)
                                    {
                                        skipUpdateCount = 0;

                                        string aWeatherUpdateString = "http://www.anythingweather.com/feeds/load/WXDATAPOST.ASP?username=" + Properties.Settings.Default.awStation +
                                            "&password=" + System.Uri.EscapeUriString(Properties.Settings.Default.awPwd) + "&version=1&WXData=" +
                                            DateTime.Now.ToString("yyyy\\%2DMM\\%2Ddd+HH:mm:ss") + "%2C" + temperature + "%2C" + dewpoint + "%2C" +
                                            humidity + "%2C" + pressure + "%2C" + windDegrees + "%2C" + windspeed + "%2C" + cumulRainDay + "%2C%2C%2C" + windGust +
                                            "%2C%0D";

                                        try
                                        {
                                            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(aWeatherUpdateString);
                                            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                                            Stream receiveStream = response.GetResponseStream();
                                            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                                            aWeatherResponse = readStream.ReadToEnd();

                                            readStream.Close();
                                            response.Close();

                                            if (aWeatherResponse == "")
                                            {
                                                aWeatherResponse = "ok";
                                                //aWeatherResponse = aWeatherUpdateString;
                                            }

                                        }
                                        catch (Exception ex)
                                        {
                                            aWeatherResponse = "";
                                            this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "\t" + "ERROR posting data to Anything Weather. " + ex.Message +
                                                System.Environment.NewLine + txtOutput.Text));
                                        }
                                    }
                                    else
                                    {
                                        aWeatherResponse = "wait " + skipUpdateCount.ToString();
                                    }
                                }
                                else
                                {
                                    aWeatherResponse = "off";
                                }
                                
                                skipUpdateCount += 1;

                                if (Properties.Settings.Default.writeToCSV == true)
                                {
                                    string newFileName;

                                    if (Properties.Settings.Default.csvFilePath == "")
                                    {
                                        newFileName = "weather.csv";
                                    }
                                    else
                                    {
                                        newFileName = Properties.Settings.Default.csvFilePath;
                                    }
                                    
                                    string weatherData = DateTime.Now + "," + temperature + "," + humidity + "," + windspeed + "," + windGust + "," + windDegrees + "," +
                                            pressure + "," + rainHour + "," + cumulRainDay + "," + dewpoint + Environment.NewLine;

                                    if (!File.Exists(newFileName))
                                    {
                                        string fileHeader = "Local Time" + "," + "Temperature" + "," + "Humidity" + "," + "Wind MPH" + "," + "Wind Gust" + "," + "Wind Dir" + "," +
                                            "Pressure" + "," + "Rain Hour" + "," + "Rain Day" + "," + "Dewpoint" + Environment.NewLine;

                                        File.WriteAllText(newFileName, fileHeader);
                                    }

                                    File.AppendAllText(newFileName, weatherData);
                                }
                            }
                            else
                            {
                                wuResponse = "Need more data";
                                wBugResponse = "Need more data";
                                pwsResponse = "Need more data";
                                aWeatherResponse = "Need more data";
                            }
                            
                            this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "   " + "T:" + temperature.ToString("F1") + "   " + "H:" + humidity + "   " + "W:" +
                                windDegrees + "\t" + "WS:" + windspeed.ToString("F1") + "\t" + "Gust:" + windGust.ToString("F1") + "\t" + "RDAY:" + cumulRainDay.ToString("F2") +
                                "  " + "RHR:" + rainHour.ToString("F2") + "   " + "BAR:" + pressure.ToString("F2") + "   " + "DEW:" + dewpoint.ToString("F1") + "   " + "SI: " + sensorId +
                                "  ST: " + sensorType + "   " + "WU: " + wuResponse + "  " + "WB: " + wBugResponse + "  " + "PWS: " + pwsResponse + "  " + "AW: " + aWeatherResponse + 
                                System.Environment.NewLine + txtOutput.Text));
                                                        
                            this.Invoke(new MethodInvoker(() => txtBattery.Text = battery));

                            if (battery == "normal")
                            {
                                this.Invoke(new MethodInvoker(() => txtBattery.BackColor = Control.DefaultBackColor));
                            }
                            else
                            {
                                this.Invoke(new MethodInvoker(() => txtBattery.BackColor = Color.FromArgb(247, 247, 124)));
                            }

                            this.Invoke(new MethodInvoker(() => txtSignal.Text = signal.ToString()));

                            switch (signal)
                            {
                                case 0:
                                    this.Invoke(new MethodInvoker(() => txtSignal.BackColor = Color.Red));
                                    break;
                                case 1:
                                    this.Invoke(new MethodInvoker(() => txtSignal.BackColor = Color.FromArgb(247, 247, 124)));
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                    this.Invoke(new MethodInvoker(() => txtSignal.BackColor = Control.DefaultBackColor));
                                    break;
                            }

                            this.Invoke(new MethodInvoker(() => txtLastUpdated.Text = DateTime.Now.ToString()));


                            if (DateTime.Now.Day != previousDay)
                            {
                                cumulRainDay = 0;
                            }

                            previousDay = DateTime.Now.Day;

                            previousRainReading = currRain;

                            if (noSensorDataIterations >= 5)
                            {
                                this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "\t" + "INFO: Not receiving data from sensor. Low batteries? Too far away?" +
                                    System.Environment.NewLine + txtOutput.Text));
                                battery = "unknown";
                                signal = 0;
                                signalFails += 1;
                            }

                            this.Invoke(new MethodInvoker(() => txtSignalFails.Text = signalFails.ToString()));
                        }

                    }

                }
                catch (NullReferenceException ex)
                {
                    //Keep going

                }
                catch (Exception ex)
                {
                    this.Invoke(new MethodInvoker(() => txtOutput.Text = "ERROR: " + ex.Message + " " + ex.Source + System.Environment.NewLine + txtOutput.Text));
                }                
            }
            else
            {
                communicator.Break();
                BackgroundWorker1.CancelAsync();
                BackgroundWorker1.Dispose();
            }
        }

        public frmMain()
        {
            // This call is required by the designer.
            InitializeComponent();

            // Add any initialization after the InitializeComponent() call.
            dtRainData.Columns.Add("time", typeof(DateTime));
            dtRainData.Columns.Add("rain", typeof(double));

            dtWindData.Columns.Add("time", typeof(DateTime));
            dtWindData.Columns.Add("windSpeed", typeof(double));

            lblWuStationID.Text = Properties.Settings.Default.wuStation;
            lblWbStationID.Text = Properties.Settings.Default.wbStation;
            lblPwsStationID.Text = Properties.Settings.Default.pwsStation;
            lblAweatherStationID.Text = Properties.Settings.Default.awStation;

            if (Properties.Settings.Default.networkDevice.Length > 0)
            {
                txtOutput.Text = waitMessage;
                txtOutput.Refresh();
                pbarProgressBar1.Value = 5;

                if (BackgroundWorker1.IsBusy == false)
                {
                    BackgroundWorker1.RunWorkerAsync();
                }
            }
        }



        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            pbarProgressBar1.Value = 0;

            if (BackgroundWorker1.IsBusy == false)
            {
                txtOutput.Text = DateTime.Now + "\t" + "Attempting to resume operation. It may take a few minutes for the bridge to come back online..." +
                    System.Environment.NewLine + txtOutput.Text;
                pbarProgressBar1.Value = 5;
                BackgroundWorker1.RunWorkerAsync();
            }
        }

        private double calcWindGust(double currentWindSpeed)
        {
            string expression = "time >= '" + DateTime.Now.AddMinutes(-10) + "'";
            string sortOrder = "windSpeed DESC";
            DataRow[] foundRows = null;
            double windGust = 0;

            // Use the Select method to find all rows matching the filter.
            foundRows = dtWindData.Select(expression, sortOrder);
            windGust = double.Parse(foundRows[0][1].ToString());

            // Delete rows older than one hour
            dynamic rows = dtWindData.Select("time <= '" + DateTime.Now.AddHours(-1) + "'");
            foreach (DataRow row in rows)
            {
                row.Delete();
            }

            return windGust;
        }

        private double rainLast60Minutes(double rainNow)
        {
            Object rain;
            rain = dtRainData.Compute("Sum(rain)", "time >= '" + DateTime.Now.AddHours(-1) + "'");
            //rain = dtRainData.Compute("Sum(rain)", "time >= '" + DateTime.Now.AddMinutes(-3) + "'");

            // Delete rows older than two hours
            dynamic rows = dtRainData.Select("time <= '" + DateTime.Now.AddHours(-2) + "'");
            foreach (DataRow row in rows)
            {
                row.Delete();
            }

            return Double.Parse(rain.ToString());
        }

        public int progressBarValue(int pbarIncrement)
        {
            int pbarValue = 0;
            if (pbarProgressBar1.Value + pbarIncrement <= pbarProgressBar1.Maximum)
            {
                pbarValue = pbarProgressBar1.Value + pbarIncrement;
            }
            else
            {
                pbarValue = 5;
            }

            return pbarValue;
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.networkDevice.Length > 0)
            {
                txtOutput.Text = waitMessage;
                txtOutput.Refresh();
                lblWuStationID.Text = Properties.Settings.Default.wuStation;
                lblWbStationID.Text = Properties.Settings.Default.wbStation;
                lblPwsStationID.Text = Properties.Settings.Default.pwsStation;
                lblAweatherStationID.Text = Properties.Settings.Default.awStation;

                pbarProgressBar1.Value = 5;

                if (BackgroundWorker1.IsBusy == false)
                {
                    BackgroundWorker1.RunWorkerAsync();
                }               
            }
            else
            {
                try
                {
                    frmSetup setup = new frmSetup();
                    setup.ShowDialog();
                }
                catch (Exception ex)
                {
                    if (ex.Message.IndexOf("pcap", StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        MessageBox.Show("ERROR: " + ex.Message + System.Environment.NewLine + System.Environment.NewLine +
                            "Please go to http://www.winpcap.org , download WinPcap, and install it.");
                    }
                    else
                    {
                        MessageBox.Show("ERROR: " + ex.Message);
                    }
                }
            }
           
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            BackgroundWorker1.CancelAsync();
            this.Invoke(new MethodInvoker(() => pbarProgressBar1.Value = 0));
            this.Invoke(new MethodInvoker(() => txtOutput.Text = txtOutput.Text.Replace(waitMessage, "")));
            signalFails = 0;
            txtSignal.BackColor = Control.DefaultBackColor;
            txtSignal.Text = "";
            txtBattery.BackColor = Control.DefaultBackColor;
            txtBattery.Text = "";
            txtLastUpdated.Text = "";
            txtSignalFails.Text = "";
            this.Invoke(new MethodInvoker(() => txtOutput.Text = "Stopped." + System.Environment.NewLine + txtOutput.Text));
        }

        private void AboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Kevin's Acu-Link Bridge to Weather Underground Rapid Fire and More" + System.Environment.NewLine + "Version: " +
                Assembly.GetExecutingAssembly().GetName().Version.ToString() + System.Environment.NewLine + "© 2014  Kevin Key" +
                System.Environment.NewLine + "Comments/suggestions: kevink619@ymail.com" + System.Environment.NewLine + "http://kevin-key.blogspot.com/");
            }

        private void AcuRiteSetupToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                frmSetup setup = new frmSetup();
                setup.ShowDialog();
            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("pcap", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    MessageBox.Show("ERROR: " + ex.Message + System.Environment.NewLine + System.Environment.NewLine +
                        "Please go to http://www.winpcap.org , download WinPcap, and install it.");
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }
        }

        private void BackgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            if (string.IsNullOrEmpty(Properties.Settings.Default.networkDevice))
            {
                BackgroundWorker1.Dispose();
                pbarProgressBar1.Value = 0;
                this.Invoke(new MethodInvoker(() => txtOutput.Text = txtOutput.Text.Replace(waitMessage, "")));
                frmSetup setup = new frmSetup();
                setup.ShowDialog();
            }

            try
            {
                int deviceNumberToUse = 0;

                IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;

                int i = 0;
                while (i != allDevices.Count)
                {
                    LivePacketDevice device = allDevices[i];

                    if (Properties.Settings.Default.networkDevice.IndexOf(device.Name.ToString(), StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        deviceNumberToUse = i;
                    }

                    i += 1;
                }

                PacketDevice selectedDevice = allDevices[deviceNumberToUse];

                try
                {
                    // Open the device
                    // portion of the packet to capture
                    // 65536 guarantees that the whole packet will be captured on all the link layers
                    // promiscuous mode
                    using (communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.NoCaptureLocal, 1000))
                    //using (PacketCommunicator communicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
                    {
                        // start the capture
                        communicator.ReceivePackets(0, PacketHandler);
                    }
                }
                catch (Exception ex)
                {
                    this.Invoke(new MethodInvoker(() => txtOutput.Text = DateTime.Now + "\t" + "ERROR: " + ex.Message + System.Environment.NewLine + txtOutput.Text));
                }
            }
            catch (System.InvalidOperationException ex)
            {
                if (ex.Message.IndexOf("pcap") == 0)
                {
                    MessageBox.Show("ERROR: " + ex.Message + System.Environment.NewLine + System.Environment.NewLine +
                        "Please go to http://www.winpcap.org , download WinPcap, and install it.");
                }
                else
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                Close();
            }                

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

    }
        
}
