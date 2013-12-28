<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbPostToWunderground = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWuPwd = New System.Windows.Forms.TextBox()
        Me.txtWuID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDeviceId = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPressureOffset = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(330, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(227, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbPostToWunderground)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtWuPwd)
        Me.GroupBox1.Controls.Add(Me.txtWuID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 118)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weather Underground"
        '
        'cbPostToWunderground
        '
        Me.cbPostToWunderground.AutoSize = True
        Me.cbPostToWunderground.Location = New System.Drawing.Point(9, 25)
        Me.cbPostToWunderground.Name = "cbPostToWunderground"
        Me.cbPostToWunderground.Size = New System.Drawing.Size(194, 17)
        Me.cbPostToWunderground.TabIndex = 13
        Me.cbPostToWunderground.Text = "Post Data to Weather Underground"
        Me.cbPostToWunderground.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Station ID:"
        '
        'txtWuPwd
        '
        Me.txtWuPwd.Location = New System.Drawing.Point(104, 87)
        Me.txtWuPwd.Name = "txtWuPwd"
        Me.txtWuPwd.Size = New System.Drawing.Size(180, 20)
        Me.txtWuPwd.TabIndex = 6
        Me.txtWuPwd.UseSystemPasswordChar = True
        '
        'txtWuID
        '
        Me.txtWuID.Location = New System.Drawing.Point(104, 52)
        Me.txtWuID.Name = "txtWuID"
        Me.txtWuID.Size = New System.Drawing.Size(180, 20)
        Me.txtWuID.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Station Password:"
        '
        'cmbDeviceId
        '
        Me.cmbDeviceId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDeviceId.FormattingEnabled = True
        Me.cmbDeviceId.Location = New System.Drawing.Point(14, 46)
        Me.cmbDeviceId.Name = "cmbDeviceId"
        Me.cmbDeviceId.Size = New System.Drawing.Size(610, 21)
        Me.cmbDeviceId.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Network Device:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(346, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Pressure Offset:"
        '
        'txtPressureOffset
        '
        Me.txtPressureOffset.Location = New System.Drawing.Point(427, 111)
        Me.txtPressureOffset.MaxLength = 5
        Me.txtPressureOffset.Name = "txtPressureOffset"
        Me.txtPressureOffset.Size = New System.Drawing.Size(41, 20)
        Me.txtPressureOffset.TabIndex = 7
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 254)
        Me.Controls.Add(Me.txtPressureOffset)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDeviceId)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSetup"
        Me.Text = "Setup"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWuPwd As System.Windows.Forms.TextBox
    Friend WithEvents txtWuID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbDeviceId As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPressureOffset As System.Windows.Forms.TextBox
    Friend WithEvents cbPostToWunderground As System.Windows.Forms.CheckBox
End Class
