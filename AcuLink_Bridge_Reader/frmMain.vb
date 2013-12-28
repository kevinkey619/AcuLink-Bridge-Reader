Imports System.Collections.Generic
Imports PcapDotNet.Core
Imports PcapDotNet.Packets
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Web.HttpUtility
Imports System.Net
Imports System.Web.SessionState.HttpSessionState
Imports HtmlAgilityPack

Public Class frmMain
    Dim dtRainData As New DataTable()
    Dim previousRainReading As Double = 0
    Dim cumulRainDay As Double = 0
    Dim cumulRainNoReset As Double = 0
    Dim rainHour As Double = 0
    Dim dtWindData As New DataTable()
    Dim previousDay As Day = DatePart(DateInterval.Day, Now)
    Dim waitMessage As String = "Waiting for bridge data. If this takes more than 5 minutes, please check whether the correct network device is selected."
    Dim noSensorDataIterations As Integer = 0

    Dim windGust As Double
    Dim dewpoint As Decimal
    Dim windDirHex As String
    Dim windDegrees As Double
    Dim windspeed As Double
    Dim temperature As Double
    Dim humidity As Double
    Dim pressure As Decimal
    Dim currRain As Double
    Dim signal As Integer
    Dim battery As String
    Dim c1 As Decimal
    Dim c2 As Decimal
    Dim c3 As Decimal
    Dim c4 As Decimal
    Dim c5 As Decimal
    Dim c6 As Decimal
    Dim c7 As Decimal
    Dim a As Decimal
    Dim b As Decimal
    Dim c As Decimal
    Dim d As Decimal
    Dim pr As Decimal
    Dim tr As Decimal
    Dim d1 As Decimal
    Dim d2 As Decimal
    Dim dut As Decimal
    Dim off As Decimal
    Dim sens As Decimal
    Dim x As Decimal
    Dim p As Decimal
    Dim t As Decimal

    ' Callback function invoked by Pcap.Net for every incoming packet
    Private Sub PacketHandler(packet As Packet)
        Try
            Me.Invoke(New MethodInvoker(
                      Sub() pbarProgressBar1.Visible = True))

            If packet.Ethernet.IpV4.Tcp.Payload IsNot Nothing Then
                'Me.Invoke(New MethodInvoker(
                '          Sub() pbarProgressBar1.Value = progressBarValue(1)))

                Dim text = Encoding.ASCII.GetString(packet.Ethernet.IpV4.Tcp.Payload.ToMemoryStream().ToArray())
                Dim match = Regex.Match(text.ToLower(), "mt=5n1|mt=pressure", RegexOptions.Singleline)
                Dim path As String
                Dim bridgeDataArray As Array
                Dim pressureOffset As Decimal = My.Settings.pressureOffset

                If match.Success Then
                    Me.Invoke(New MethodInvoker(
                              Sub() pbarProgressBar1.Value = progressBarValue(10)))

                    Me.Invoke(New MethodInvoker(
                                  Sub() txtOutput.Text = Replace(txtOutput.Text, waitMessage, "")))

                    path = match.Groups("Path").Value

                    bridgeDataArray = Split(text, "&")

                    If InStr(text.ToLower, "mt=5n1") = 0 Then
                        noSensorDataIterations += 1
                    Else
                        noSensorDataIterations = 0
                    End If

                    For Each element As String In bridgeDataArray
                        If InStr(element, "winddir=") Then
                            windDirHex = Mid(element, 9, 1)

                            Select Case windDirHex
                                Case "5"
                                    windDegrees = 0

                                Case "7"
                                    windDegrees = 22.5

                                Case "3"
                                    windDegrees = 45

                                Case "1"
                                    windDegrees = 67.5

                                Case "9"
                                    windDegrees = 90

                                Case "B"
                                    windDegrees = 112.5

                                Case "F"
                                    windDegrees = 135

                                Case "D"
                                    windDegrees = 157.5

                                Case "C"
                                    windDegrees = 180

                                Case "E"
                                    windDegrees = 202.5

                                Case "A"
                                    windDegrees = 225

                                Case "8"
                                    windDegrees = 247.5

                                Case "0"
                                    windDegrees = 270

                                Case "2"
                                    windDegrees = 292.5

                                Case "6"
                                    windDegrees = 315

                                Case "4"
                                    windDegrees = 337.5
                            End Select
                        End If

                        If InStr(element, "windspeed=") Then
                            windspeed = Math.Round(Mid(element, 14, 3) / 44.7, 1)

                            dtWindData.Rows.Add(New Object() {Now, windspeed})

                            windGust = calcWindGust(windspeed)
                        End If

                        If InStr(element, "temperature=") Then
                            If Mid(element, 14, 1) = "-" Then
                                temperature = Math.Round(Mid(element, 15, 4) * -1 / 100 * 9 / 5 + 32, 1)
                            Else
                                temperature = Math.Round(Mid(element, 15, 4) / 100 * 9 / 5 + 32, 1)
                            End If
                        End If

                        If InStr(element, "humidity=") Then
                            humidity = Mid(element, 12, 3) / 10
                        End If

                        ' Get and process pressure data
                        If InStr(element, "C1=") Then
                            c1 = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "C2=") Then
                            c2 = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "C3=") Then
                            c3 = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "C4=") Then
                            c4 = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "C5=") Then
                            c5 = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "C6=") Then
                            c6 = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "C7=") Then
                            c7 = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "A=") Then
                            a = "&H" & Mid(element, 3, 2)
                        End If

                        If InStr(element, "B=") Then
                            b = "&H" & Mid(element, 3, 2)
                        End If

                        If InStr(element, "C=") Then
                            c = "&H" & Mid(element, 3, 2)
                        End If

                        If InStr(element, "D=") Then
                            d = "&H" & Mid(element, 3, 2)
                        End If

                        If InStr(element, "PR=") Then
                            pr = "&H" & Mid(element, 4, 4)
                        End If

                        If InStr(element, "TR=") Then
                            tr = "&H" & Mid(element, 4, 4)

                            d1 = pr
                            d2 = tr

                            If d2 >= c5 Then
                                dut = d2 - c5 - ((d2 - c5) / 2 ^ 7) * ((d2 - c5) / 2 ^ 7) * a / 2 ^ c
                            Else
                                dut = d2 - c5 - ((d2 - c5) / 2 ^ 7) * ((d2 - c5) / 2 ^ 7) * b / 2 ^ c
                            End If

                            off = (c2 + (c4 - 1024) * dut / 2 ^ 14) * 4

                            sens = c1 + c3 * dut / 2 ^ 10

                            x = sens * (d1 - 7168) / 2 ^ 14 - off

                            p = x * 10 / 2 ^ 5 + c7

                            t = 250 + dut * c6 / 2 ^ 16 - dut / 2 ^ d

                            pressure = Math.Round(p / 338.6 + pressureOffset, 2)

                        End If

                        If InStr(element, "currRain=") Then
                            currRain = Math.Round(Mid(element, 11, 6) / 2540, 3)

                            If currRain > 0 Then
                                cumulRainDay = currRain
                                cumulRainNoReset = currRain
                            End If

                            dtRainData.Rows.Add(New Object() {Now, cumulRainNoReset})

                            rainHour = rainLast60Minutes(cumulRainNoReset)
                        End If

                        If InStr(element, "rssi=") Then
                            signal = Mid(element, 6, 1)
                        End If

                        If InStr(element, "battery=") Then
                            battery = Mid(element, 9, 10)
                        End If


                        If humidity > 0 Then
                            dewpoint = ((((temperature - 32) / 1.8) - (14.55 + 0.114 * ((temperature - 32) / 1.8)) *
                                         (1 - (0.01 * humidity)) - ((2.5 + 0.007 * ((temperature - 32) / 1.8)) * (1 - (0.01 * humidity))) ^ 3 -
                                         (15.9 + 0.117 * ((temperature - 32) / 1.8)) * (1 - (0.01 * humidity)) ^ 14) * 1.8) + 32
                            dewpoint = Math.Round(dewpoint, 1)
                        End If

                    Next

                    If txtOutput.Text.Length > 50000 Then
                        Me.Invoke(New MethodInvoker(
                                  Sub() txtOutput.Text = ""))
                    End If

                    Dim wuResponse As String

                    If My.Settings.postToWunderground = True Then
                        If pressure > 0 And humidity > 0 And noSensorDataIterations < 5 Then
                            Dim bWU As New BrowserSession
                            Dim wundergroundUpdateString = "http://rtupdate.wunderground.com/weatherstation/updateweatherstation.php?ID=" & My.Settings.wuStation & "&PASSWORD=" & _
                                UrlEncode(My.Settings.wuPwd) & "&dateutc=" & UrlEncode(Now.ToUniversalTime) & "&winddir=" & windDegrees & "&windspeedmph=" & windspeed & "&tempf=" & _
                                temperature & "&rainin=" & rainHour & "&dailyrainin=" & cumulRainDay & "&baromin=" & pressure & "&dewptf=" & dewpoint & "&humidity=" & humidity & _
                                "&softwaretype=" & "Kevin's%20Acu-Link%20Rapid%20Fire&action=updateraw&realtime=1&rtfreq=15" & "&windgustmph=" & windGust
                            Try
                                wuResponse = bWU.[Get](wundergroundUpdateString)
                            Catch ex As Exception
                                wuResponse = ""
                                Me.Invoke(New MethodInvoker(
                                      Sub() txtOutput.Text = Now & vbTab & "ERROR posting data to Weather Underground." & vbCrLf & txtOutput.Text))
                            End Try
                        Else
                            wuResponse = "Need sensor data"
                        End If
                    Else
                        wuResponse = "option off"
                    End If

                    Me.Invoke(New MethodInvoker(
                              Sub() txtOutput.Text = Now & vbTab & "T:" & temperature.ToString("F1") & vbTab & "H:" & humidity & vbTab & "W:" & windDegrees & vbTab & _
                                  "WS:" & windspeed.ToString("F1") & vbTab & "Gust:" & windGust.ToString("F1") & vbTab & "RDAY:" & cumulRainDay.ToString("F2") & vbTab & _
                                  "RHR:" & rainHour.ToString("F2") & vbTab & "BAR:" & pressure.ToString("F2") & vbTab & "DEW:" & dewpoint.ToString("F1") & vbTab & _
                                  "WU: " & wuResponse & vbCrLf & txtOutput.Text))

                    Me.Invoke(New MethodInvoker(
                              Sub() txtBattery.Text = battery))

                    Me.Invoke(New MethodInvoker(
                            Sub() txtSignal.Text = signal))

                    Me.Invoke(New MethodInvoker(
                            Sub() txtLastUpdated.Text = Now))

                    If DatePart(DateInterval.Day, Now) <> previousDay Then
                        cumulRainDay = 0
                    End If

                    previousDay = DatePart(DateInterval.Day, Now)

                    previousRainReading = currRain

                    If noSensorDataIterations >= 5 Then
                        Me.Invoke(New MethodInvoker(
                             Sub() txtOutput.Text = Now & vbTab & "INFO: Not receiving data from 5-in-1 sensor. Low batteries? Too far away?" & vbCrLf & txtOutput.Text))
                    End If

                End If

            End If

        Catch ex As NullReferenceException
            'Keep going

        Catch ex As Exception
            Me.Invoke(New MethodInvoker(
                 Sub() txtOutput.Text = "ERROR: " & ex.Message & vbCrLf & txtOutput.Text))
        End Try

    End Sub


    Private Sub btnStart_Click1(sender As Object, e As EventArgs) Handles btnStart.Click
        txtOutput.Text = waitMessage
        txtOutput.Refresh()
        lblStationID.Text = My.Settings.wuStation
        pbarProgressBar1.Value = 5

        If BackgroundWorker1.IsBusy = False Then
            BackgroundWorker1.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        BackgroundWorker1.Dispose()
        pbarProgressBar1.Value = 0
        Me.Invoke(New MethodInvoker(
                                 Sub() txtOutput.Text = Replace(txtOutput.Text, waitMessage, "")))

    End Sub

    'Private Sub btnDeviceList_Click(sender As Object, e As EventArgs)
    '    ' Retrieve the device list from the local machine
    '    Dim allDevices As IList(Of LivePacketDevice) = LivePacketDevice.AllLocalMachine

    '    If allDevices.Count = 0 Then
    '        txtOutput.Text = "No interfaces found! Make sure WinPcap is installed."
    '        Return
    '    End If

    '    ' Print the list
    '    Dim i As Integer = 0
    '    While i <> allDevices.Count
    '        Dim device As LivePacketDevice = allDevices(i)
    '        txtOutput.Text &= ((i + 1) & ". ") + device.Name
    '        If device.Description IsNot Nothing Then
    '            txtOutput.Text &= " (" + device.Description & ")"
    '        Else
    '            txtOutput.Text &= " (No description available)"
    '        End If

    '        txtOutput.Text &= vbCrLf
    '        i += 1
    '    End While
    'End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        If My.Settings.networkDevice = "" Then
            BackgroundWorker1.Dispose()
            pbarProgressBar1.Value = 0
            Me.Invoke(New MethodInvoker(
                                 Sub() txtOutput.Text = Replace(txtOutput.Text, waitMessage, "")))
            frmSetup.ShowDialog()
        End If

        Try
            Dim deviceNumberToUse As Integer

            Dim allDevices As IList(Of LivePacketDevice) = LivePacketDevice.AllLocalMachine

            Dim i As Integer = 0
            While i <> allDevices.Count
                Dim device As LivePacketDevice = allDevices(i)
                If InStr(My.Settings.networkDevice, device.Name) Then
                    deviceNumberToUse = i
                End If

                i += 1
            End While

            Dim selectedDevice As PacketDevice = allDevices(deviceNumberToUse)

            Try
                ' Open the device
                ' portion of the packet to capture
                ' 65536 guarantees that the whole packet will be captured on all the link layers
                ' promiscuous mode
                Using communicator As PacketCommunicator = selectedDevice.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000)
                    ' start the capture
                    communicator.ReceivePackets(0, AddressOf PacketHandler)
                End Using
            Catch ex As Exception
                Me.Invoke(New MethodInvoker(
                                 Sub() txtOutput.Text = Now & vbTab & "ERROR: " & ex.Message & vbCrLf & txtOutput.Text))
            End Try
        Catch ex As System.InvalidOperationException
            If InStr(ex.Message, "pcap") Then
                MsgBox("ERROR: " & ex.Message & vbCrLf & vbCrLf & "Please go to http://www.winpcap.org , download WinPcap, and install it.")
            Else
                MsgBox("ERROR: " & ex.Message)
            End If

            Close()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.Message)
            Close()
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        pbarProgressBar1.Value = 0

        If BackgroundWorker1.IsBusy = False Then
            txtOutput.Text = Now & vbTab & "Attempting to resume operation. It may take a few minutes for the bridge to come back online..." & vbCrLf & txtOutput.Text
            pbarProgressBar1.Value = 5
            BackgroundWorker1.RunWorkerAsync()
        End If

    End Sub

    Private Function calcWindGust(ByVal currentWindSpeed As Double) As Double
        Dim expression As String = "time >= '" & DateAdd(DateInterval.Minute, -10, Now) & "'"
        Dim sortOrder As String = "windSpeed DESC"
        Dim foundRows As DataRow()
        Dim windGust As Double = 0

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtWindData.[Select](expression, sortOrder)
        windGust = foundRows(0)(1)

        ' Delete rows older than one hour
        Dim rows = dtWindData.[Select]("time >= '" & DateAdd(DateInterval.Hour, 1, Now) & "'")
        For Each row As Object In rows
            row.Delete()
        Next

        Return windGust
    End Function

    Private Function rainLast60Minutes(ByVal currentRainTotal As Double) As Double
        Dim expression As String = "time >= '" & DateAdd(DateInterval.Hour, -1, Now) & "'"
        Dim sortOrder As String = "time ASC"
        Dim foundRows As DataRow()
        Dim newRain As Double = 0.0

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtRainData.[Select](expression, sortOrder)
        newRain = currentRainTotal - foundRows(0)(1)

        ' Delete rows older than one day
        Dim rows = dtRainData.[Select]("time >= '" & DateAdd(DateInterval.Day, 1, Now) & "'")
        For Each row As Object In rows
            row.Delete()
        Next

        Return newRain
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        dtRainData.Columns.Add("time", GetType(DateTime))
        dtRainData.Columns.Add("rain", GetType(Double))

        dtWindData.Columns.Add("time", GetType(DateTime))
        dtWindData.Columns.Add("windSpeed", GetType(Double))

        lblStationID.Text = My.Settings.wuStation
    End Sub

    Private Sub AcuRiteSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcuRiteSetupToolStripMenuItem.Click
        Try
            frmSetup.ShowDialog()
        Catch ex As Exception
            If InStr(ex.Message, "pcap") Then
                MsgBox("ERROR: " & ex.Message & vbCrLf & vbCrLf & "Please go to http://www.winpcap.org , download WinPcap, and install it.")
            Else
                MsgBox("ERROR: " & ex.Message)
            End If
        End Try

    End Sub

    Function progressBarValue(ByVal pbarIncrement As Integer) As Integer
        Dim pbarValue As Integer
        If pbarProgressBar1.Value + pbarIncrement <= pbarProgressBar1.Maximum Then
            pbarValue = pbarProgressBar1.Value + pbarIncrement
        Else
            pbarValue = 5
        End If

        Return pbarValue
    End Function

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Kevin's Acu-Link Bridge to Weather Underground Rapid Fire Updater" & vbCrLf & "Build: " & System.IO.File.GetLastWriteTime(System.Reflection.Assembly.GetExecutingAssembly.Location) & _
               vbCrLf & "© 2013  Kevin Key" & vbCrLf & "Comments/suggestions: kevink619@ymail.com")
    End Sub


End Class



Public Class BrowserSession
    Private _isPost As Boolean
    Private _htmlDoc As HtmlDocument

    ''' <summary>
    ''' System.Net.CookieCollection. Provides a collection container for instances of Cookie class 
    ''' </summary>
    Public Property Cookies() As CookieCollection
        Get
            Return m_Cookies
        End Get
        Set(value As CookieCollection)
            m_Cookies = value
        End Set
    End Property
    Private m_Cookies As CookieCollection

    ''' <summary>
    ''' Provide a key-value-pair collection of form elements 
    ''' </summary>
    Public Property FormElements() As FormElementCollection
        Get
            Return m_FormElements
        End Get
        Set(value As FormElementCollection)
            m_FormElements = value
        End Set
    End Property
    Private m_FormElements As FormElementCollection

    ''' <summary>
    ''' Makes a HTTP GET request to the given URL
    ''' </summary>
    Public Function [Get](url As String) As String
        _isPost = False
        CreateWebRequestObject().Load(url)
        Return _htmlDoc.DocumentNode.InnerHtml
    End Function

    ''' <summary>
    ''' Makes a HTTP POST request to the given URL
    ''' </summary>
    Public Function Post(url As String) As String
        _isPost = True
        CreateWebRequestObject().Load(url, "POST")
        Return _htmlDoc.DocumentNode.InnerHtml
    End Function

    ''' <summary>
    ''' Creates the HtmlWeb object and initializes all event handlers. 
    ''' </summary>
    Private Function CreateWebRequestObject() As HtmlWeb
        Dim web As New HtmlWeb()
        web.UseCookies = True
        web.PreRequest = New HtmlWeb.PreRequestHandler(AddressOf OnPreRequest)
        web.PostResponse = New HtmlWeb.PostResponseHandler(AddressOf OnAfterResponse)
        web.PreHandleDocument = New HtmlWeb.PreHandleDocumentHandler(AddressOf OnPreHandleDocument)
        Return web
    End Function

    ''' <summary>
    ''' Event handler for HtmlWeb.PreRequestHandler. Occurs before an HTTP request is executed.
    ''' </summary>
    Protected Function OnPreRequest(request As HttpWebRequest) As Boolean
        AddCookiesTo(request)
        ' Add cookies that were saved from previous requests
        If _isPost Then
            AddPostDataTo(request)
        End If
        ' We only need to add post data on a POST request
        Return True
    End Function

    ''' <summary>
    ''' Event handler for HtmlWeb.PostResponseHandler. Occurs after a HTTP response is received
    ''' </summary>
    Protected Sub OnAfterResponse(request As HttpWebRequest, response As HttpWebResponse)
        SaveCookiesFrom(response)
        ' Save cookies for subsequent requests
    End Sub

    ''' <summary>
    ''' Event handler for HtmlWeb.PreHandleDocumentHandler. Occurs before a HTML document is handled
    ''' </summary>
    Protected Sub OnPreHandleDocument(document As HtmlDocument)
        SaveHtmlDocument(document)
    End Sub

    ''' <summary>
    ''' Assembles the Post data and attaches to the request object
    ''' </summary>
    Private Sub AddPostDataTo(request As HttpWebRequest)
        Dim payload As String = FormElements.AssemblePostPayload()
        Dim buff As Byte() = Encoding.UTF8.GetBytes(payload.ToCharArray())
        request.ContentLength = buff.Length
        request.ContentType = "application/x-www-form-urlencoded"
        Dim reqStream As System.IO.Stream = request.GetRequestStream()
        reqStream.Write(buff, 0, buff.Length)
    End Sub

    ''' <summary>
    ''' Add cookies to the request object
    ''' </summary>
    Private Sub AddCookiesTo(request As HttpWebRequest)
        If Cookies IsNot Nothing AndAlso Cookies.Count > 0 Then
            request.CookieContainer.Add(Cookies)
        End If
    End Sub

    ''' <summary>
    ''' Saves cookies from the response object to the local CookieCollection object
    ''' </summary>
    Private Sub SaveCookiesFrom(response As HttpWebResponse)
        If response.Cookies.Count > 0 Then
            If Cookies Is Nothing Then
                Cookies = New CookieCollection()
            End If
            Cookies.Add(response.Cookies)
        End If
    End Sub

    ''' <summary>
    ''' Saves the form elements collection by parsing the HTML document
    ''' </summary>
    Private Sub SaveHtmlDocument(document As HtmlDocument)
        _htmlDoc = document
        FormElements = New FormElementCollection(_htmlDoc)
    End Sub
End Class

''' <summary>
''' Represents a combined list and collection of Form Elements.
''' </summary>
Public Class FormElementCollection
    Inherits Dictionary(Of String, String)
    ''' <summary>
    ''' Constructor. Parses the HtmlDocument to get all form input elements. 
    ''' </summary>
    Public Sub New(htmlDoc As HtmlDocument)
        Dim inputs = htmlDoc.DocumentNode.Descendants("input")
        For Each element As Object In inputs
            Dim name As String = element.GetAttributeValue("name", "undefined")
            Dim value As String = element.GetAttributeValue("value", "")
            If Not name.Equals("undefined") Then
                Add(name, value)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Assembles all form elements and values to POST. Also html encodes the values.  
    ''' </summary>
    Public Function AssemblePostPayload() As String
        Dim sb As New StringBuilder()
        For Each element As Object In Me
            Dim value As String = System.Web.HttpUtility.UrlEncode(element.Value)
            sb.Append("&" & Convert.ToString(element.Key) & "=" & value)
        Next
        Return sb.ToString().Substring(1)
    End Function
End Class
