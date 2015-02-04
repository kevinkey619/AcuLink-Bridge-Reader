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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAwPwd = new System.Windows.Forms.TextBox();
            this.txtAwID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbPostToAWeather = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtSensorIdRain = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cmbSensorTypeRain = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtSensorIdWind = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbSensorTypeWind = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSensorIdHumidity = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbSensorTypeHumidity = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSensorIdTemperature = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbSensorTypeTemperature = new System.Windows.Forms.ComboBox();
            this.txtCsvFilePath = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(804, 400);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(804, 356);
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
            this.txtPressureOffset.Location = new System.Drawing.Point(407, 301);
            this.txtPressureOffset.MaxLength = 5;
            this.txtPressureOffset.Name = "txtPressureOffset";
            this.txtPressureOffset.Size = new System.Drawing.Size(41, 20);
            this.txtPressureOffset.TabIndex = 1;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(326, 304);
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
            this.cbWriteToCSV.Location = new System.Drawing.Point(467, 303);
            this.cbWriteToCSV.Name = "cbWriteToCSV";
            this.cbWriteToCSV.Size = new System.Drawing.Size(106, 17);
            this.cbWriteToCSV.TabIndex = 3;
            this.cbWriteToCSV.Text = "Write to CSV File";
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
            this.txtFilterOnSensorId.Location = new System.Drawing.Point(665, 274);
            this.txtFilterOnSensorId.MaxLength = 5;
            this.txtFilterOnSensorId.Name = "txtFilterOnSensorId";
            this.txtFilterOnSensorId.Size = new System.Drawing.Size(49, 20);
            this.txtFilterOnSensorId.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(347, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Global Filter On Sensor ID (leave blank unless you have more than one):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(321, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Global Filter on Sensor Type:";
            // 
            // cmbSensorType
            // 
            this.cmbSensorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorType.FormattingEnabled = true;
            this.cmbSensorType.Location = new System.Drawing.Point(467, 250);
            this.cmbSensorType.Name = "cmbSensorType";
            this.cmbSensorType.Size = new System.Drawing.Size(81, 21);
            this.cmbSensorType.TabIndex = 25;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtAwPwd);
            this.groupBox4.Controls.Add(this.txtAwID);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cbPostToAWeather);
            this.groupBox4.Location = new System.Drawing.Point(15, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 117);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Anything Weather";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Station ID:";
            // 
            // txtAwPwd
            // 
            this.txtAwPwd.Location = new System.Drawing.Point(103, 81);
            this.txtAwPwd.Name = "txtAwPwd";
            this.txtAwPwd.Size = new System.Drawing.Size(180, 20);
            this.txtAwPwd.TabIndex = 6;
            this.txtAwPwd.UseSystemPasswordChar = true;
            // 
            // txtAwID
            // 
            this.txtAwID.Location = new System.Drawing.Point(103, 46);
            this.txtAwID.Name = "txtAwID";
            this.txtAwID.Size = new System.Drawing.Size(180, 20);
            this.txtAwID.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Station Password:";
            // 
            // cbPostToAWeather
            // 
            this.cbPostToAWeather.AutoSize = true;
            this.cbPostToAWeather.Location = new System.Drawing.Point(8, 19);
            this.cbPostToAWeather.Name = "cbPostToAWeather";
            this.cbPostToAWeather.Size = new System.Drawing.Size(173, 17);
            this.cbPostToAWeather.TabIndex = 3;
            this.cbPostToAWeather.Text = "Post Data to Anything Weather";
            this.cbPostToAWeather.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label23);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.txtSensorIdRain);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.cmbSensorTypeRain);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.txtSensorIdWind);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Controls.Add(this.cmbSensorTypeWind);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.txtSensorIdHumidity);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.cmbSensorTypeHumidity);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.txtSensorIdTemperature);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.cmbSensorTypeTemperature);
            this.groupBox5.Location = new System.Drawing.Point(13, 336);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(724, 102);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Multi Sensors (Advanced Settings)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(585, 47);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Type:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(585, 74);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 44;
            this.label24.Text = "ID (optional):";
            // 
            // txtSensorIdRain
            // 
            this.txtSensorIdRain.Location = new System.Drawing.Point(658, 71);
            this.txtSensorIdRain.MaxLength = 5;
            this.txtSensorIdRain.Name = "txtSensorIdRain";
            this.txtSensorIdRain.Size = new System.Drawing.Size(49, 20);
            this.txtSensorIdRain.TabIndex = 43;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(585, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 13);
            this.label25.TabIndex = 42;
            this.label25.Text = "Rain";
            // 
            // cmbSensorTypeRain
            // 
            this.cmbSensorTypeRain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorTypeRain.FormattingEnabled = true;
            this.cmbSensorTypeRain.Location = new System.Drawing.Point(626, 44);
            this.cmbSensorTypeRain.Name = "cmbSensorTypeRain";
            this.cmbSensorTypeRain.Size = new System.Drawing.Size(81, 21);
            this.cmbSensorTypeRain.TabIndex = 41;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(391, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 40;
            this.label20.Text = "Type:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(391, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "ID (optional):";
            // 
            // txtSensorIdWind
            // 
            this.txtSensorIdWind.Location = new System.Drawing.Point(464, 71);
            this.txtSensorIdWind.MaxLength = 5;
            this.txtSensorIdWind.Name = "txtSensorIdWind";
            this.txtSensorIdWind.Size = new System.Drawing.Size(49, 20);
            this.txtSensorIdWind.TabIndex = 38;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(391, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(32, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Wind";
            // 
            // cmbSensorTypeWind
            // 
            this.cmbSensorTypeWind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorTypeWind.FormattingEnabled = true;
            this.cmbSensorTypeWind.Location = new System.Drawing.Point(432, 44);
            this.cmbSensorTypeWind.Name = "cmbSensorTypeWind";
            this.cmbSensorTypeWind.Size = new System.Drawing.Size(81, 21);
            this.cmbSensorTypeWind.TabIndex = 36;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(203, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Type:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(203, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "ID (optional):";
            // 
            // txtSensorIdHumidity
            // 
            this.txtSensorIdHumidity.Location = new System.Drawing.Point(276, 71);
            this.txtSensorIdHumidity.MaxLength = 5;
            this.txtSensorIdHumidity.Name = "txtSensorIdHumidity";
            this.txtSensorIdHumidity.Size = new System.Drawing.Size(49, 20);
            this.txtSensorIdHumidity.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(203, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(47, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "Humidity";
            // 
            // cmbSensorTypeHumidity
            // 
            this.cmbSensorTypeHumidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorTypeHumidity.FormattingEnabled = true;
            this.cmbSensorTypeHumidity.Location = new System.Drawing.Point(244, 44);
            this.cmbSensorTypeHumidity.Name = "cmbSensorTypeHumidity";
            this.cmbSensorTypeHumidity.Size = new System.Drawing.Size(81, 21);
            this.cmbSensorTypeHumidity.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 30;
            this.label16.Text = "Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "ID (optional):";
            // 
            // txtSensorIdTemperature
            // 
            this.txtSensorIdTemperature.Location = new System.Drawing.Point(83, 71);
            this.txtSensorIdTemperature.MaxLength = 5;
            this.txtSensorIdTemperature.Name = "txtSensorIdTemperature";
            this.txtSensorIdTemperature.Size = new System.Drawing.Size(49, 20);
            this.txtSensorIdTemperature.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Temperature";
            // 
            // cmbSensorTypeTemperature
            // 
            this.cmbSensorTypeTemperature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensorTypeTemperature.FormattingEnabled = true;
            this.cmbSensorTypeTemperature.Location = new System.Drawing.Point(51, 44);
            this.cmbSensorTypeTemperature.Name = "cmbSensorTypeTemperature";
            this.cmbSensorTypeTemperature.Size = new System.Drawing.Size(81, 21);
            this.cmbSensorTypeTemperature.TabIndex = 26;
            // 
            // txtCsvFilePath
            // 
            this.txtCsvFilePath.Location = new System.Drawing.Point(688, 301);
            this.txtCsvFilePath.Name = "txtCsvFilePath";
            this.txtCsvFilePath.Size = new System.Drawing.Size(221, 20);
            this.txtCsvFilePath.TabIndex = 28;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(585, 304);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 13);
            this.label26.TabIndex = 29;
            this.label26.Text = "File path and name:";
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 445);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.txtCsvFilePath);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox4;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.TextBox txtAwPwd;
        internal System.Windows.Forms.TextBox txtAwID;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.CheckBox cbPostToAWeather;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        internal System.Windows.Forms.TextBox txtSensorIdRain;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox cmbSensorTypeRain;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        internal System.Windows.Forms.TextBox txtSensorIdWind;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbSensorTypeWind;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        internal System.Windows.Forms.TextBox txtSensorIdHumidity;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbSensorTypeHumidity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtSensorIdTemperature;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbSensorTypeTemperature;
        private System.Windows.Forms.TextBox txtCsvFilePath;
        private System.Windows.Forms.Label label26;
    }
}