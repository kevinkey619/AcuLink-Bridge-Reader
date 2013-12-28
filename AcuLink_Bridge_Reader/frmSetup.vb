Imports PcapDotNet.Core


Public Class frmSetup
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Retrieve the device list from the local machine
        Dim allDevices As IList(Of LivePacketDevice) = LivePacketDevice.AllLocalMachine
        Dim itemDescription As String

        If allDevices.Count = 0 Then
            cmbDeviceId.Items.Add("No interfaces found! Make sure WinPcap is installed.")
            Return
        End If

        ' Print the list
        Dim i As Integer = 0
        While i <> allDevices.Count
            Dim device As LivePacketDevice = allDevices(i)
            itemDescription = device.Name
            If device.Description IsNot Nothing Then
                itemDescription &= " (" + device.Description.ToString & ")"
            Else
                itemDescription &= " (No description available)"
            End If

            cmbDeviceId.Items.Add(itemDescription)

            i += 1
        End While

        ' Add any initialization after the InitializeComponent() call.
        txtWuID.Text = My.Settings.wuStation
        txtWuPwd.Text = My.Settings.wuPwd
        txtPressureOffset.Text = My.Settings.pressureOffset
        cmbDeviceId.SelectedItem = My.Settings.networkDevice
        cbPostToWunderground.Checked = My.Settings.postToWunderground

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With My.Settings
            .wuStation = txtWuID.Text.ToUpper
            .wuPwd = txtWuPwd.Text
            .pressureOffset = txtPressureOffset.Text
            .networkDevice = cmbDeviceId.SelectedItem
            .postToWunderground = cbPostToWunderground.Checked
        End With

        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub txtPressureOffset_LostFocus(sender As Object, e As EventArgs) Handles txtPressureOffset.LostFocus
        If Not IsNumeric(txtPressureOffset.Text) Then
            MsgBox("Please enter a value between -9.99 and 9.99.")
        ElseIf Not txtPressureOffset.Text >= -9.99 And txtPressureOffset.Text <= 9.99 Then
            MsgBox("Please enter a value between -9.99 and 9.99.")

        End If
    End Sub
End Class

