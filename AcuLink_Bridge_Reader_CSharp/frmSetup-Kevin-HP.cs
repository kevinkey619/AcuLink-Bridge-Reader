using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PcapDotNet.Core;
using System.IO;

namespace AcuLink_Bridge_Reader_CSharp
{
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            // This call is required by the designer.

            {
                InitializeComponent();

                // Retrieve the device list from the local machine
                IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
                string itemDescription = null;

                if (allDevices.Count == 0)
                {
                    cmbDeviceId.Items.Add("No interfaces found! Make sure WinPcap is installed.");
                    return;
                }

                // Print the list
                int i = 0;
                while (i != allDevices.Count)
                {
                    LivePacketDevice device = allDevices[i];
                    itemDescription = device.Name;
                    if (device.Description != null)
                    {
                        itemDescription += " (" + device.Description.ToString() + ")";
                    }
                    else
                    {
                        itemDescription += " (No description available)";
                    }

                    cmbDeviceId.Items.Add(itemDescription);

                    i += 1;
                }

                cmbSensorType.Items.Add("");
                cmbSensorType.Items.Add("5n1");
                cmbSensorType.Items.Add("3n1");
                cmbSensorType.Items.Add("tower");
                cmbSensorType.Items.Add("water");

                cmbSensorTypeHumidity.Items.Add("");
                cmbSensorTypeHumidity.Items.Add("5n1");
                cmbSensorTypeHumidity.Items.Add("3n1");
                cmbSensorTypeHumidity.Items.Add("tower");

                cmbSensorTypeTemperature.Items.Add("");
                cmbSensorTypeTemperature.Items.Add("5n1");
                cmbSensorTypeTemperature.Items.Add("3n1");
                cmbSensorTypeTemperature.Items.Add("tower");
                cmbSensorTypeTemperature.Items.Add("water");

                cmbSensorTypeWind.Items.Add("");
                cmbSensorTypeWind.Items.Add("5n1");
                cmbSensorTypeWind.Items.Add("3n1");

                cmbSensorTypeRain.Items.Add("");
                cmbSensorTypeRain.Items.Add("5n1");
                cmbSensorTypeRain.Items.Add("3n1");
                cmbSensorTypeRain.Items.Add("rain");
                
                // Add any initialization after the InitializeComponent() call.
                txtWuID.Text = Properties.Settings.Default.wuStation;
                txtWuPwd.Text = Properties.Settings.Default.wuPwd;
                txtPressureOffset.Text = Properties.Settings.Default.pressureOffset.ToString();
                cmbDeviceId.SelectedItem = Properties.Settings.Default.networkDevice;
                cbPostToWunderground.Checked = Properties.Settings.Default.postToWunderground;
                cbPostToWeatherbug.Checked = Properties.Settings.Default.postToWeatherBug;
                txtWbPubID.Text = Properties.Settings.Default.wbPub;
                txtWbStationNum.Text = Properties.Settings.Default.wbStation;
                txtWbPassword.Text = Properties.Settings.Default.wbPwd;
                cbWriteToCSV.Checked = Properties.Settings.Default.writeToCSV;
                cbPostToPWS.Checked = Properties.Settings.Default.postToPws;
                txtPwsStationId.Text = Properties.Settings.Default.pwsStation;
                txtPwsPassword.Text = Properties.Settings.Default.pwsPwd;
                txtFilterOnSensorId.Text = Properties.Settings.Default.filterOnSensorId;
                cmbSensorType.SelectedItem = Properties.Settings.Default.sensorType;
                txtAwID.Text = Properties.Settings.Default.awStation;
                txtAwPwd.Text = Properties.Settings.Default.awPwd;
                cbPostToAWeather.Checked = Properties.Settings.Default.postToAWeather;
                txtSensorIdHumidity.Text = Properties.Settings.Default.sensorIdHumidity;
                txtSensorIdRain.Text = Properties.Settings.Default.sensorIdRain;
                txtSensorIdTemperature.Text = Properties.Settings.Default.sensorIdTemp;
                txtSensorIdWind.Text = Properties.Settings.Default.sensorIdWind;
                cmbSensorTypeHumidity.SelectedItem = Properties.Settings.Default.sensorTypeHumidity;
                cmbSensorTypeRain.SelectedItem = Properties.Settings.Default.sensorTypeRain;
                cmbSensorTypeTemperature.SelectedItem = Properties.Settings.Default.sensorTypeTemp;
                cmbSensorTypeWind.SelectedItem = Properties.Settings.Default.sensorTypeWind;
                txtCsvFilePath.Text = Properties.Settings.Default.csvFilePath;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            double temp = 0;

            if (!double.TryParse(txtPressureOffset.Text, out temp))
            {
                MessageBox.Show("Please enter a Pressure Offset value between -9.99 and 9.99.");
                txtPressureOffset.Focus();
                return;
            }
            else if (!(double.Parse(txtPressureOffset.Text) >= -9.99) & double.Parse(txtPressureOffset.Text) <= 9.99)
            {
                MessageBox.Show("Please enter a Pressure Offset value between -9.99 and 9.99.");
                txtPressureOffset.Focus();
                return;
            }

            var _with1 = Properties.Settings.Default;
            _with1.wuStation = txtWuID.Text.ToUpper();
            _with1.wuPwd = txtWuPwd.Text;
            _with1.pressureOffset = double.Parse(txtPressureOffset.Text);
            _with1.networkDevice = cmbDeviceId.SelectedItem.ToString();
            _with1.postToWunderground = cbPostToWunderground.Checked;
            _with1.postToWeatherBug = cbPostToWeatherbug.Checked;
            _with1.wbPub = txtWbPubID.Text;
            _with1.wbPwd = txtWbPassword.Text;
            _with1.wbStation = txtWbStationNum.Text;
            _with1.writeToCSV = cbWriteToCSV.Checked;
            _with1.postToPws = cbPostToPWS.Checked;
            _with1.pwsStation = txtPwsStationId.Text;
            _with1.pwsPwd = txtPwsPassword.Text;
            _with1.filterOnSensorId = txtFilterOnSensorId.Text;
            _with1.sensorType = cmbSensorType.SelectedItem.ToString();
            _with1.awStation = txtAwID.Text;
            _with1.awPwd = txtAwPwd.Text;
            _with1.postToAWeather = cbPostToAWeather.Checked;
            _with1.sensorIdHumidity = txtSensorIdHumidity.Text;
            _with1.sensorIdRain = txtSensorIdRain.Text;
            _with1.sensorIdTemp = txtSensorIdTemperature.Text;
            _with1.sensorIdWind = txtSensorIdWind.Text;
            _with1.sensorTypeHumidity = cmbSensorTypeHumidity.SelectedItem.ToString();
            _with1.sensorTypeRain = cmbSensorTypeRain.SelectedItem.ToString();
            _with1.sensorTypeTemp = cmbSensorTypeTemperature.SelectedItem.ToString();
            _with1.sensorTypeWind = cmbSensorTypeWind.SelectedItem.ToString();
            _with1.csvFilePath = txtCsvFilePath.Text;

            Properties.Settings.Default.Save();
            
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


  

    }
}
