namespace SerialHex
{
	partial class SerialPortSettings
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbbPortName = new System.Windows.Forms.ComboBox();
			this.cbbBaudRate = new System.Windows.Forms.ComboBox();
			this.lblDeviceName = new System.Windows.Forms.Label();
			this.btnChange = new System.Windows.Forms.Button();
			this.btnConnection = new System.Windows.Forms.Button();
			this.lblBaud = new System.Windows.Forms.Label();
			this.lblConnection = new System.Windows.Forms.Label();
			this.lblDataBits = new System.Windows.Forms.Label();
			this.cbbDataBits = new System.Windows.Forms.ComboBox();
			this.lblParity = new System.Windows.Forms.Label();
			this.cbbParity = new System.Windows.Forms.ComboBox();
			this.lblStopBits = new System.Windows.Forms.Label();
			this.cbbStopBits = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cbbPortName
			// 
			this.cbbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbPortName.FormattingEnabled = true;
			this.cbbPortName.Location = new System.Drawing.Point(104, 17);
			this.cbbPortName.Name = "cbbPortName";
			this.cbbPortName.Size = new System.Drawing.Size(62, 21);
			this.cbbPortName.TabIndex = 0;
			this.cbbPortName.DropDown += new System.EventHandler(this.cbbPortName_DropDown);
			// 
			// cbbBaudRate
			// 
			this.cbbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbBaudRate.FormattingEnabled = true;
			this.cbbBaudRate.Location = new System.Drawing.Point(172, 17);
			this.cbbBaudRate.Name = "cbbBaudRate";
			this.cbbBaudRate.Size = new System.Drawing.Size(67, 21);
			this.cbbBaudRate.TabIndex = 1;
			// 
			// lblDeviceName
			// 
			this.lblDeviceName.Location = new System.Drawing.Point(-3, 20);
			this.lblDeviceName.Name = "lblDeviceName";
			this.lblDeviceName.Size = new System.Drawing.Size(101, 13);
			this.lblDeviceName.TabIndex = 2;
			this.lblDeviceName.Text = "DeviceName";
			// 
			// btnChange
			// 
			this.btnChange.Location = new System.Drawing.Point(414, 16);
			this.btnChange.Name = "btnChange";
			this.btnChange.Size = new System.Drawing.Size(53, 23);
			this.btnChange.TabIndex = 3;
			this.btnChange.Text = "Change";
			this.btnChange.UseVisualStyleBackColor = true;
			this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
			// 
			// btnConnection
			// 
			this.btnConnection.Location = new System.Drawing.Point(473, 16);
			this.btnConnection.Name = "btnConnection";
			this.btnConnection.Size = new System.Drawing.Size(69, 23);
			this.btnConnection.TabIndex = 3;
			this.btnConnection.Text = "Connect";
			this.btnConnection.UseVisualStyleBackColor = true;
			this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
			// 
			// lblBaud
			// 
			this.lblBaud.Location = new System.Drawing.Point(173, 41);
			this.lblBaud.Name = "lblBaud";
			this.lblBaud.Size = new System.Drawing.Size(66, 13);
			this.lblBaud.TabIndex = 2;
			// 
			// lblConnection
			// 
			this.lblConnection.Location = new System.Drawing.Point(35, 41);
			this.lblConnection.Name = "lblConnection";
			this.lblConnection.Size = new System.Drawing.Size(131, 13);
			this.lblConnection.TabIndex = 2;
			this.lblConnection.Text = "Disconnected";
			// 
			// lblDataBits
			// 
			this.lblDataBits.Location = new System.Drawing.Point(245, 41);
			this.lblDataBits.Name = "lblDataBits";
			this.lblDataBits.Size = new System.Drawing.Size(44, 13);
			this.lblDataBits.TabIndex = 5;
			// 
			// cbbDataBits
			// 
			this.cbbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbDataBits.FormattingEnabled = true;
			this.cbbDataBits.Location = new System.Drawing.Point(245, 17);
			this.cbbDataBits.Name = "cbbDataBits";
			this.cbbDataBits.Size = new System.Drawing.Size(44, 21);
			this.cbbDataBits.TabIndex = 4;
			// 
			// lblParity
			// 
			this.lblParity.Location = new System.Drawing.Point(295, 41);
			this.lblParity.Name = "lblParity";
			this.lblParity.Size = new System.Drawing.Size(62, 13);
			this.lblParity.TabIndex = 7;
			// 
			// cbbParity
			// 
			this.cbbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbParity.FormattingEnabled = true;
			this.cbbParity.Location = new System.Drawing.Point(295, 17);
			this.cbbParity.Name = "cbbParity";
			this.cbbParity.Size = new System.Drawing.Size(62, 21);
			this.cbbParity.TabIndex = 6;
			// 
			// lblStopBits
			// 
			this.lblStopBits.Location = new System.Drawing.Point(363, 41);
			this.lblStopBits.Name = "lblStopBits";
			this.lblStopBits.Size = new System.Drawing.Size(43, 13);
			this.lblStopBits.TabIndex = 9;
			// 
			// cbbStopBits
			// 
			this.cbbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbStopBits.FormattingEnabled = true;
			this.cbbStopBits.Location = new System.Drawing.Point(363, 17);
			this.cbbStopBits.Name = "cbbStopBits";
			this.cbbStopBits.Size = new System.Drawing.Size(45, 21);
			this.cbbStopBits.TabIndex = 8;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(101, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Serial Port";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(169, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Serial Port";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(169, 1);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Baud Rate";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(295, 1);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(33, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Parity";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(360, 1);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(46, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "StopBits";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(242, 1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "DataBits";
			// 
			// SerialPortSettings
			// 
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblStopBits);
			this.Controls.Add(this.cbbStopBits);
			this.Controls.Add(this.lblParity);
			this.Controls.Add(this.cbbParity);
			this.Controls.Add(this.lblDataBits);
			this.Controls.Add(this.cbbDataBits);
			this.Controls.Add(this.btnConnection);
			this.Controls.Add(this.btnChange);
			this.Controls.Add(this.lblConnection);
			this.Controls.Add(this.lblBaud);
			this.Controls.Add(this.lblDeviceName);
			this.Controls.Add(this.cbbBaudRate);
			this.Controls.Add(this.cbbPortName);
			this.Name = "SerialPortSettings";
			this.Size = new System.Drawing.Size(548, 59);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDeviceName;
		public System.Windows.Forms.ComboBox cbbPortName;
		public System.Windows.Forms.ComboBox cbbBaudRate;
		private System.Windows.Forms.Button btnChange;
		private System.Windows.Forms.Button btnConnection;
		private System.Windows.Forms.Label lblConnection;
		public System.Windows.Forms.Label lblBaud;
		public System.Windows.Forms.Label lblDataBits;
		public System.Windows.Forms.ComboBox cbbDataBits;
		public System.Windows.Forms.Label lblParity;
		public System.Windows.Forms.ComboBox cbbParity;
		public System.Windows.Forms.Label lblStopBits;
		public System.Windows.Forms.ComboBox cbbStopBits;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
	}
}
