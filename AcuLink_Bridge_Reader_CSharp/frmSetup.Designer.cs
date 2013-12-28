namespace AcuLink_Bridge_Reader_CSharp
{
    partial class frmSetup
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPostToWunderground = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtWuPwd = new System.Windows.Forms.TextBox();
            this.txtWuID = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtPressureOffset = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.cmbDeviceId = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtWbStationNum = new System.Windows.Forms.TextBox();
            this.cbPostToWeatherbug = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWbPassword = new System.Windows.Forms.TextBox();
            this.txtWbPubID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbWriteToCSV = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPostToPWS = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPwsPassword = new System.Windows.Forms.TextBox();
            this.txtPwsStationId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilterOnSensorId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSensorType = new System.Windows.Forms.ComboBox();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(739, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(636, 265);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.cbPostToWunderground);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.txtWuPwd);
            this.GroupBox1.Controls.Add(this.txtWuID);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(14, 79);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(290, 118);
            this.GroupBox1.TabIndex = 16;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Weather Underground";
            // 
            // cbPostToWunderground
            // 
            this.cbPostToWunderground.AutoSize = true;
            this.cbPostToWunderground.Location = new System.Drawing.Point(9, 25);
            this.cbPostToWunderground.Name = "cbPostToWunderground";
            this.cbPostToWunderground.Size = new System.Drawing.Size(194, 17);
            this.cbPostToWunderground.TabIndex = 0;
            this.cbPostToWunderground.Text = "Post Data to Weather Underground";
            this.cbPostToWunderground.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(57, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Station ID:";
            // 
            // txtWuPwd
            // 
            this.txtWuPwd.Location = new System.Drawing.Point(104, 87);
            this.txtWuPwd.Name = "txtWuPwd";
            this.txtWuPwd.Size = new System.Drawing.Size(180, 20);
            this.txtWuPwd.TabIndex = 2;
            this.txtWuPwd.UseSystemPasswordChar = true;
            // 
            // txtWuID
            // 
            this.txtWuID.Location = new System.Drawing.Point(104, 52);
            this.txtWuID.Name = "txtWuID";
            this.txtWuID.Size = new System.Drawing.Size(180, 20);
            this.txtWuID.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 13);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Station Password:";
            // 
            // txtPressureOffset
            // 
            this.txtPressureOffset.Location = new System.Drawing.Point(97, 211);
            this.txtPressureOffset.MaxLength = 5;
            this.txtPressureOffset.Name = "txtPressureOffset";
            this.txtPressureOffset.Size = new System.Drawing.Size(41, 20);
            this.txtPressureOffset.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(16, 214);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(82, 13);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Pressure Offset:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(12, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(87, 13);
            this.Label3.TabIndex = 15;
            this.Label3.Text = "Network Device:";
            // 
            // cmbDeviceId
            // 
            this.cmbDeviceId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeviceId.FormattingEnabled = true;
            this.cmbDeviceId.Location = new System.Drawing.Point(14, 37);
            this.cmbDeviceId.Name = "cmbDeviceId";
            this.cmbDeviceId.Size = new System.Drawing.Size(762, 21);
            this.cmbDeviceId.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtWbStationNum);
            this.groupBox2.Controls.Add(this.cbPostToWeatherbug);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtWbPassword);
            this.groupBox2.Controls.Add(this.txtWbPubID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(319, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(290, 152);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Weatherbug";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Station #:";
            // 
            // txtWbStationNum
            // 
            this.txtWbStationNum.Location = new System.Drawing.Point(104, 87);
            this.txtWbStationNum.Name = "txtWbStationNum";
            this.txtWbStationNum.Size = new System.Drawing.Size(180, 20);
            this.txtWbStationNum.TabIndex = 2;
            // 
            // cbPostToWeatherbug
            // 
            this.cbPostToWeatherbug.AutoSize = true;
            this.cbPostToWeatherbug.Location = new System.Drawing.Point(9, 25);
            this.cbPostToWeatherbug.Name = "cbPostToWeatherbug";
            this.cbPostToWeatherbug.Size = new System.Drawing.Size(147, 17);
            this.cbPostToWeatherbug.TabIndex = 0;
            this.cbPostToWeatherbug.Text = "Post Data to Weatherbug";
            this.cbPostToWeatherbug.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Publisher ID:";
            // 
            // txtWbPassword
            // 
            this.txtWbPassword.Location = new System.Drawing.Point(104, 120);
            this.txtWbPassword.Name = "txtWbPassword";
            this.txtWbPassword.Size = new System.Drawing.Size(180, 20);
            this.txtWbPassword.TabIndex = 3;
            this.txtWbPassword.UseSystemPasswordChar = true;
            // 
            // txtWbPubID
            // 
            this.txtWbPubID.Location = new System.Drawing.Point(104, 52);
            this.txtWbPubID.Name = "txtWbPubID";
            this.txtWbPubID.Size = new System.Drawing.Size(180, 20);
            this.txtWbPubID.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Station Password:";
            // 
            // cbWriteToCSV
            // 
            this.cbWriteToCSV.AutoSize = true;
            this.cbWriteToCSV.Location = new System.Drawing.Point(19, 271);
            this.cbWriteToCSV.Name = "cbWriteToCSV";
            this.cbWriteToCSV.Size = new System.Drawing.Size(132, 17);
            this.cbWriteToCSV.TabIndex = 3;
            this.cbWriteToCSV.Text = "Write Data to CSV File";
            this.cbWriteToCSV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPostToPWS);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPwsPassword);
            this.groupBox3.Controls.Add(this.txtPwsStationId);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(625, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(290, 118);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PWSweather";
            // 
            // cbPostToPWS
            // 
            this.cbPostToPWS.AutoSize = true;
            this.cbPostToPWS.Location = new System.Drawing.Point(9, 25);
            this.cbPostToPWS.Name = "cbPostToPWS";
            this.cbPostToPWS.Size = new System.Drawing.Size(151, 17);
            this.cbPostToPWS.TabIndex = 0;
            this.cbPostToPWS.Text = "Post Data to PWSweather";
            this.cbPostToPWS.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Station ID:";
            // 
            // txtPwsPassword
            // 
            this.txtPwsPassword.Location = new System.Drawing.Point(104, 87);
            this.txtPwsPassword.Name = "txtPwsPassword";
            this.txtPwsPassword.Size = new System.Drawing.Size(180, 20);
            this.txtPwsPassword.TabIndex = 2;
            this.txtPwsPassword.UseSystemPasswordChar = true;
            // 
            // txtPwsStationId
            // 
            this.txtPwsStationId.Location = new System.Drawing.Point(104, 52);
            this.txtPwsStationId.Name = "txtPwsStationId";
            this.txtPwsStationId.Size = new System.Drawing.Size(180, 20);
            this.txtPwsStationId.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Station Password:";
            // 
            // txtFilterOnSensorId
            // 
            this.txtFilterOnSensorId.Location = new System.Drawing.Point(517, 241);
            this.txtFilterOnSensorId.MaxLength = 5;
            this.txtFilterOnSensorId.Name = "txtFilterOnSensorId";
            this.txtFilterOnSensorId.Size = new System.Drawing.Size(49, 20);
            this.txtFilterOnSensorId.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(314, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Filter On Sensor ID (leave blank unless you have more than one):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Sensor Type:";
            // 
            // cmbSensorType
            // 
            this.cmbSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorType.FormattingEnabled = true;
            this.cmbSensorType.Location = new System.Drawing.Point(97, 239);
            this.cmbSensorType.Name = "cmbSensorType";
            this.cmbSensorType.Size = new System.Drawing.Size(81, 21);
            this.cmbSensorType.TabIndex = 25;
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 312);
            this.Controls.Add(this.cmbSensorType);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFilterOnSensorId);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbWriteToCSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.txtPressureOffset);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.cmbDeviceId);
            this.Name = "frmSetup";
            this.Text = "Setup";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.CheckBox cbPostToWunderground;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtWuPwd;
        internal System.Windows.Forms.TextBox txtWuID;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtPressureOffset;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.ComboBox cmbDeviceId;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtWbStationNum;
        internal System.Windows.Forms.CheckBox cbPostToWeatherbug;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtWbPassword;
        internal System.Windows.Forms.TextBox txtWbPubID;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.CheckBox cbWriteToCSV;
        internal System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.CheckBox cbPostToPWS;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtPwsPassword;
        internal System.Windows.Forms.TextBox txtPwsStationId;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtFilterOnSensorId;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSensorType;
    }
}