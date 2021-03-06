﻿namespace AcuLink_Bridge_Reader_CSharp
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AcuRiteSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lblWuStationID = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.pbarProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.txtSignal = new System.Windows.Forms.TextBox();
            this.lblBattery = new System.Windows.Forms.Label();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtLastUpdated = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSignalFails = new System.Windows.Forms.TextBox();
            this.lblWbStationID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPwsStationID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAweatherStationID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOwmId = new System.Windows.Forms.Label();
            this.lblCwopId = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click_1);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcuRiteSetupToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.ToolStripMenuItem1.Text = "Edit";
            // 
            // AcuRiteSetupToolStripMenuItem
            // 
            this.AcuRiteSetupToolStripMenuItem.Name = "AcuRiteSetupToolStripMenuItem";
            this.AcuRiteSetupToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.AcuRiteSetupToolStripMenuItem.Text = "Setup";
            this.AcuRiteSetupToolStripMenuItem.Click += new System.EventHandler(this.AcuRiteSetupToolStripMenuItem_Click_1);
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem1,
            this.AboutToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1343, 28);
            this.MenuStrip1.TabIndex = 78;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // lblWuStationID
            // 
            this.lblWuStationID.AutoSize = true;
            this.lblWuStationID.Location = new System.Drawing.Point(168, 49);
            this.lblWuStationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWuStationID.Name = "lblWuStationID";
            this.lblWuStationID.Size = new System.Drawing.Size(0, 17);
            this.lblWuStationID.TabIndex = 77;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(13, 49);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(158, 17);
            this.Label4.TabIndex = 76;
            this.Label4.Text = "Weather Underground: ";
            // 
            // pbarProgressBar1
            // 
            this.pbarProgressBar1.Location = new System.Drawing.Point(440, 498);
            this.pbarProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.pbarProgressBar1.Name = "pbarProgressBar1";
            this.pbarProgressBar1.Size = new System.Drawing.Size(720, 25);
            this.pbarProgressBar1.Step = 1;
            this.pbarProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbarProgressBar1.TabIndex = 75;
            this.pbarProgressBar1.Value = 5;
            this.pbarProgressBar1.Visible = false;
            // 
            // BackgroundWorker1
            // 
            this.BackgroundWorker1.WorkerSupportsCancellation = true;
            this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork_1);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(1240, 497);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(65, 28);
            this.btnStop.TabIndex = 74;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(1165, 497);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(65, 28);
            this.btnStart.TabIndex = 73;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(220, 527);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(47, 17);
            this.Label11.TabIndex = 72;
            this.Label11.Text = "Signal";
            // 
            // txtSignal
            // 
            this.txtSignal.Location = new System.Drawing.Point(224, 498);
            this.txtSignal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignal.Name = "txtSignal";
            this.txtSignal.ReadOnly = true;
            this.txtSignal.Size = new System.Drawing.Size(43, 22);
            this.txtSignal.TabIndex = 71;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(351, 527);
            this.lblBattery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(53, 17);
            this.lblBattery.TabIndex = 70;
            this.lblBattery.Text = "Battery";
            // 
            // txtBattery
            // 
            this.txtBattery.Location = new System.Drawing.Point(355, 498);
            this.txtBattery.Margin = new System.Windows.Forms.Padding(4);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.ReadOnly = true;
            this.txtBattery.Size = new System.Drawing.Size(76, 22);
            this.txtBattery.TabIndex = 69;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(35, 527);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(93, 17);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Last Updated";
            // 
            // txtLastUpdated
            // 
            this.txtLastUpdated.Location = new System.Drawing.Point(35, 498);
            this.txtLastUpdated.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastUpdated.Name = "txtLastUpdated";
            this.txtLastUpdated.ReadOnly = true;
            this.txtLastUpdated.Size = new System.Drawing.Size(180, 22);
            this.txtLastUpdated.TabIndex = 67;
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(0, 84);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(1343, 393);
            this.txtOutput.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 527);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Signal Fails";
            // 
            // txtSignalFails
            // 
            this.txtSignalFails.Location = new System.Drawing.Point(276, 498);
            this.txtSignalFails.Margin = new System.Windows.Forms.Padding(4);
            this.txtSignalFails.Name = "txtSignalFails";
            this.txtSignalFails.ReadOnly = true;
            this.txtSignalFails.Size = new System.Drawing.Size(68, 22);
            this.txtSignalFails.TabIndex = 79;
            // 
            // lblWbStationID
            // 
            this.lblWbStationID.AutoSize = true;
            this.lblWbStationID.Location = new System.Drawing.Point(393, 49);
            this.lblWbStationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWbStationID.Name = "lblWbStationID";
            this.lblWbStationID.Size = new System.Drawing.Size(0, 17);
            this.lblWbStationID.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "WeatherBug:";
            // 
            // lblPwsStationID
            // 
            this.lblPwsStationID.AutoSize = true;
            this.lblPwsStationID.Location = new System.Drawing.Point(511, 49);
            this.lblPwsStationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwsStationID.Name = "lblPwsStationID";
            this.lblPwsStationID.Size = new System.Drawing.Size(0, 17);
            this.lblPwsStationID.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(468, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "PWS: ";
            // 
            // lblAweatherStationID
            // 
            this.lblAweatherStationID.AutoSize = true;
            this.lblAweatherStationID.Location = new System.Drawing.Point(769, 49);
            this.lblAweatherStationID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAweatherStationID.Name = "lblAweatherStationID";
            this.lblAweatherStationID.Size = new System.Drawing.Size(0, 17);
            this.lblAweatherStationID.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 49);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 17);
            this.label6.TabIndex = 85;
            this.label6.Text = "Anything Weather: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 21600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(879, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "OpenWeatherMap:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1180, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 88;
            this.label8.Text = "CWOP:";
            // 
            // lblOwmId
            // 
            this.lblOwmId.AutoSize = true;
            this.lblOwmId.Location = new System.Drawing.Point(1006, 49);
            this.lblOwmId.Name = "lblOwmId";
            this.lblOwmId.Size = new System.Drawing.Size(0, 17);
            this.lblOwmId.TabIndex = 89;
            // 
            // lblCwopId
            // 
            this.lblCwopId.AutoSize = true;
            this.lblCwopId.Location = new System.Drawing.Point(1232, 49);
            this.lblCwopId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCwopId.Name = "lblCwopId";
            this.lblCwopId.Size = new System.Drawing.Size(0, 17);
            this.lblCwopId.TabIndex = 90;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "The weather app will continue to run in the background";
            this.notifyIcon1.BalloonTipTitle = "Kevin\'s Acu-Link Bridge Reader";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Kevin\'s Acu-Link Bridge Reader";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1343, 551);
            this.Controls.Add(this.lblCwopId);
            this.Controls.Add(this.lblOwmId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAweatherStationID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPwsStationID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblWbStationID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSignalFails);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.lblWuStationID);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.pbarProgressBar1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.txtSignal);
            this.Controls.Add(this.lblBattery);
            this.Controls.Add(this.txtBattery);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtLastUpdated);
            this.Controls.Add(this.txtOutput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1330, 598);
            this.Name = "frmMain";
            this.Text = "Kevin\'s Acu-Link Bridge Reader";
            this.Load += new System.EventHandler(this.frmMain_Load_1);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem AcuRiteSetupToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.Label lblWuStationID;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ProgressBar pbarProgressBar1;
        internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
        internal System.Windows.Forms.Button btnStop;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox txtSignal;
        internal System.Windows.Forms.Label lblBattery;
        internal System.Windows.Forms.TextBox txtBattery;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtLastUpdated;
        internal System.Windows.Forms.TextBox txtOutput;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtSignalFails;
        internal System.Windows.Forms.Label lblWbStationID;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label lblPwsStationID;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label lblAweatherStationID;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblOwmId;
        internal System.Windows.Forms.Label lblCwopId;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}