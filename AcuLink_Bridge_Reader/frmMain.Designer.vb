<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastUpdated = New System.Windows.Forms.TextBox()
        Me.lblBattery = New System.Windows.Forms.Label()
        Me.txtBattery = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSignal = New System.Windows.Forms.TextBox()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.pbarProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcuRiteSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 61)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(937, 320)
        Me.txtOutput.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Last Updated"
        '
        'txtLastUpdated
        '
        Me.txtLastUpdated.Location = New System.Drawing.Point(26, 398)
        Me.txtLastUpdated.Name = "txtLastUpdated"
        Me.txtLastUpdated.ReadOnly = True
        Me.txtLastUpdated.Size = New System.Drawing.Size(136, 20)
        Me.txtLastUpdated.TabIndex = 33
        '
        'lblBattery
        '
        Me.lblBattery.AutoSize = True
        Me.lblBattery.Location = New System.Drawing.Point(226, 421)
        Me.lblBattery.Name = "lblBattery"
        Me.lblBattery.Size = New System.Drawing.Size(40, 13)
        Me.lblBattery.TabIndex = 55
        Me.lblBattery.Text = "Battery"
        '
        'txtBattery
        '
        Me.txtBattery.Location = New System.Drawing.Point(229, 398)
        Me.txtBattery.Name = "txtBattery"
        Me.txtBattery.ReadOnly = True
        Me.txtBattery.Size = New System.Drawing.Size(55, 20)
        Me.txtBattery.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(165, 421)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Signal"
        '
        'txtSignal
        '
        Me.txtSignal.Location = New System.Drawing.Point(168, 398)
        Me.txtSignal.Name = "txtSignal"
        Me.txtSignal.ReadOnly = True
        Me.txtSignal.Size = New System.Drawing.Size(55, 20)
        Me.txtSignal.TabIndex = 56
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(875, 397)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 61
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(794, 397)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 60
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'pbarProgressBar1
        '
        Me.pbarProgressBar1.Location = New System.Drawing.Point(290, 398)
        Me.pbarProgressBar1.Name = "pbarProgressBar1"
        Me.pbarProgressBar1.Size = New System.Drawing.Size(468, 20)
        Me.pbarProgressBar1.Step = 1
        Me.pbarProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.pbarProgressBar1.TabIndex = 62
        Me.pbarProgressBar1.Value = 5
        Me.pbarProgressBar1.Visible = False
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(179, 33)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(0, 13)
        Me.lblStationID.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Weather Underground Station ID: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(962, 24)
        Me.MenuStrip1.TabIndex = 65
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcuRiteSetupToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(39, 20)
        Me.ToolStripMenuItem1.Text = "Edit"
        '
        'AcuRiteSetupToolStripMenuItem
        '
        Me.AcuRiteSetupToolStripMenuItem.Name = "AcuRiteSetupToolStripMenuItem"
        Me.AcuRiteSetupToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.AcuRiteSetupToolStripMenuItem.Text = "Setup"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 448)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pbarProgressBar1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtSignal)
        Me.Controls.Add(Me.lblBattery)
        Me.Controls.Add(Me.txtBattery)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLastUpdated)
        Me.Controls.Add(Me.txtOutput)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Kevin's Acu-Link Bridge to Weather Underground Rapid Fire Updater"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastUpdated As System.Windows.Forms.TextBox
    Friend WithEvents lblBattery As System.Windows.Forms.Label
    Friend WithEvents txtBattery As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtSignal As System.Windows.Forms.TextBox
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents pbarProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblStationID As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcuRiteSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
