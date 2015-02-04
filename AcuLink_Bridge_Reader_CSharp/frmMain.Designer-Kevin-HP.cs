namespace AcuLink_Bridge_Reader_CSharp
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
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click_1);
            // 
            // ToolStripMenuItem1
            // 
            this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcuRiteSetupToolStripMenuItem});
            this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
            this.ToolStripMenuItem1.Size = new System.Drawing.Size(39, 20);
            this.ToolStripMenuItem1.Text = "Edit";
            // 
            // AcuRiteSetupToolStripMenuItem
            // 
            this.AcuRiteSetupToolStripMenuItem.Name = "AcuRiteSetupToolStripMenuItem";
            this.AcuRiteSetupToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
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
            this.MenuStrip1.Size = new System.Drawing.Size(984, 24);
            this.MenuStrip1.TabIndex = 78;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // lblWuStationID
            // 
            this.lblWuStationID.AutoSize = true;
            this.lblWuStationID.Location = new System.Drawing.Point(179, 40);
            this.lblWuStationID.Name = "lblWuStationID";
            this.lblWuStationID.Size = new System.Drawing.Size(0, 13);
            this.lblWuStationID.TabIndex = 77;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(10, 40);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(169, 13);
            this.Label4.TabIndex = 76;
            this.Label4.Text = "Weather Underground Station ID: ";
            // 
            // pbarProgressBar1
            // 
            this.pbarProgressBar1.Location = new System.Drawing.Point(330, 405);
            this.pbarProgressBar1.Name = "pbarProgressBar1";
            this.pbarProgressBar1.Size = new System.Drawing.Size(540, 20);
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
            this.btnStop.Location = new System.Drawing.Point(930, 404);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(49, 23);
            this.btnStop.TabIndex = 74;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(874, 404);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(49, 23);
            this.btnStart.TabIndex = 73;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(165, 428);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(36, 13);
            this.Label11.TabIndex = 72;
            this.Label11.Text = "Signal";
            // 
            // txtSignal
            // 
            this.txtSignal.Location = new System.Drawing.Point(168, 405);
            this.txtSignal.Name = "txtSignal";
            this.txtSignal.ReadOnly = true;
            this.txtSignal.Size = new System.Drawing.Size(33, 20);
            this.txtSignal.TabIndex = 71;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(263, 428);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(40, 13);
            this.lblBattery.TabIndex = 70;
            this.lblBattery.Text = "Battery";
            // 
            // txtBattery
            // 
            this.txtBattery.Location = new System.Drawing.Point(266, 405);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.ReadOnly = true;
            this.txtBattery.Size = new System.Drawing.Size(58, 20);
            this.txtBattery.TabIndex = 69;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(26, 428);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 68;
            this.Label1.Text = "Last Updated";
            // 
            // txtLastUpdated
            // 
            this.txtLastUpdated.Location = new System.Drawing.Point(26, 405);
            this.txtLastUpdated.Name = "txtLastUpdated";
            this.txtLastUpdated.ReadOnly = true;
            this.txtLastUpdated.Size = new System.Drawing.Size(136, 20);
            this.txtLastUpdated.TabIndex = 67;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(13, 68);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(963, 320);
            this.txtOutput.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Signal Fails";
            // 
            // txtSignalFails
            // 
            this.txtSignalFails.Location = new System.Drawing.Point(207, 405);
            this.txtSignalFails.Name = "txtSignalFails";
            this.txtSignalFails.ReadOnly = true;
            this.txtSignalFails.Size = new System.Drawing.Size(52, 20);
            this.txtSignalFails.TabIndex = 79;
            // 
            // lblWbStationID
            // 
            this.lblWbStationID.AutoSize = true;
            this.lblWbStationID.Location = new System.Drawing.Point(385, 40);
            this.lblWbStationID.Name = "lblWbStationID";
            this.lblWbStationID.Size = new System.Drawing.Size(0, 13);
            this.lblWbStationID.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "WeatherBug Station ID:";
            // 
            // lblPwsStationID
            // 
            this.lblPwsStationID.AutoSize = true;
            this.lblPwsStationID.Location = new System.Drawing.Point(578, 40);
            this.lblPwsStationID.Name = "lblPwsStationID";
            this.lblPwsStationID.Size = new System.Drawing.Size(0, 13);
            this.lblPwsStationID.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 83;
            this.label7.Text = "PWS Station ID: ";
            // 
            // lblAweatherStationID
            // 
            this.lblAweatherStationID.AutoSize = true;
            this.lblAweatherStationID.Location = new System.Drawing.Point(836, 40);
            this.lblAweatherStationID.Name = "lblAweatherStationID";
            this.lblAweatherStationID.Size = new System.Drawing.Size(0, 13);
            this.lblAweatherStationID.TabIndex = 86;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Anything Weather Station ID: ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 448);
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
            this.Name = "frmMain";
            this.Text = "Kevin\'s Acu-Link Bridge to Weather Underground Rapid Fire and More";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
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
    }
}