namespace SerialHex
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabsOutput = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExamplesHex = new System.Windows.Forms.Button();
            this.txtTransmitHex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSendHex = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtBinary = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLast50ASCIIChars = new System.Windows.Forms.TextBox();
            this.txtImmediateASCII = new System.Windows.Forms.TextBox();
            this.txtTransmitASCII = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSendASCII = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtSignedDecimal = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.txtUnsignedDecimal = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkEnablePacketParsing = new System.Windows.Forms.CheckBox();
            this.btnTestParser = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPacketsReceived = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnApplyOptions = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDelimiter = new System.Windows.Forms.TextBox();
            this.chkShow0x = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbLineEnding = new System.Windows.Forms.ComboBox();
            this.chkClearTransmitAfterSend = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.serialPortSettings1 = new SerialHex.SerialPortSettings();
            this.groupBox1.SuspendLayout();
            this.tabsOutput.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.serialPortSettings1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 77);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port";
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(0, 34);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(673, 177);
            this.txtLog.TabIndex = 5;
            this.txtLog.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Event Log";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(62, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Log";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tabsOutput
            // 
            this.tabsOutput.Controls.Add(this.tabPage1);
            this.tabsOutput.Controls.Add(this.tabPage2);
            this.tabsOutput.Controls.Add(this.tabPage3);
            this.tabsOutput.Controls.Add(this.tabPage4);
            this.tabsOutput.Controls.Add(this.tabPage5);
            this.tabsOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsOutput.Location = new System.Drawing.Point(0, 0);
            this.tabsOutput.Name = "tabsOutput";
            this.tabsOutput.SelectedIndex = 0;
            this.tabsOutput.Size = new System.Drawing.Size(673, 322);
            this.tabsOutput.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(665, 296);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Hex";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtHex);
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(665, 204);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Receive";
            // 
            // txtHex
            // 
            this.txtHex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHex.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex.Location = new System.Drawing.Point(3, 16);
            this.txtHex.Multiline = true;
            this.txtHex.Name = "txtHex";
            this.txtHex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHex.Size = new System.Drawing.Size(659, 185);
            this.txtHex.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnExamplesHex);
            this.groupBox3.Controls.Add(this.txtTransmitHex);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnSendHex);
            this.groupBox3.Location = new System.Drawing.Point(0, 210);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 86);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transmit";
            // 
            // btnExamplesHex
            // 
            this.btnExamplesHex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamplesHex.Location = new System.Drawing.Point(506, 58);
            this.btnExamplesHex.Name = "btnExamplesHex";
            this.btnExamplesHex.Size = new System.Drawing.Size(64, 23);
            this.btnExamplesHex.TabIndex = 5;
            this.btnExamplesHex.Text = "Examples";
            this.btnExamplesHex.UseVisualStyleBackColor = true;
            this.btnExamplesHex.Click += new System.EventHandler(this.btnExamplesHex_Click);
            // 
            // txtTransmitHex
            // 
            this.txtTransmitHex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransmitHex.Location = new System.Drawing.Point(6, 19);
            this.txtTransmitHex.Name = "txtTransmitHex";
            this.txtTransmitHex.Size = new System.Drawing.Size(601, 20);
            this.txtTransmitHex.TabIndex = 0;
            this.txtTransmitHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransmitHex_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "The 0x prefix is optional (ignored). Numbers without 0x are still treated as hex," +
    " not decimals!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(494, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Several hex formats are supported. Only requirement is that an even number of cha" +
    "racters are provided.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Enter to send command, Esc to clear textbox.";
            // 
            // btnSendHex
            // 
            this.btnSendHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendHex.Location = new System.Drawing.Point(613, 17);
            this.btnSendHex.Name = "btnSendHex";
            this.btnSendHex.Size = new System.Drawing.Size(49, 23);
            this.btnSendHex.TabIndex = 1;
            this.btnSendHex.Text = "Send";
            this.btnSendHex.UseVisualStyleBackColor = true;
            this.btnSendHex.Click += new System.EventHandler(this.btnSendHex_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtBinary);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(665, 296);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Binary";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtBinary
            // 
            this.txtBinary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBinary.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBinary.Location = new System.Drawing.Point(0, 0);
            this.txtBinary.Multiline = true;
            this.txtBinary.Name = "txtBinary";
            this.txtBinary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBinary.Size = new System.Drawing.Size(665, 296);
            this.txtBinary.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(665, 296);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ASCII";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.txtASCII);
            this.groupBox7.Location = new System.Drawing.Point(0, 0);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(665, 204);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Receive";
            // 
            // txtASCII
            // 
            this.txtASCII.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtASCII.Location = new System.Drawing.Point(3, 16);
            this.txtASCII.Multiline = true;
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtASCII.Size = new System.Drawing.Size(659, 185);
            this.txtASCII.TabIndex = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtLast50ASCIIChars);
            this.groupBox6.Controls.Add(this.txtImmediateASCII);
            this.groupBox6.Controls.Add(this.txtTransmitASCII);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.btnSendASCII);
            this.groupBox6.Location = new System.Drawing.Point(0, 210);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(665, 86);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transmit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(233, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Last 50 characters typed:";
            // 
            // txtLast50ASCIIChars
            // 
            this.txtLast50ASCIIChars.Location = new System.Drawing.Point(366, 57);
            this.txtLast50ASCIIChars.Name = "txtLast50ASCIIChars";
            this.txtLast50ASCIIChars.ReadOnly = true;
            this.txtLast50ASCIIChars.Size = new System.Drawing.Size(222, 20);
            this.txtLast50ASCIIChars.TabIndex = 5;
            // 
            // txtImmediateASCII
            // 
            this.txtImmediateASCII.AcceptsReturn = true;
            this.txtImmediateASCII.AcceptsTab = true;
            this.txtImmediateASCII.Location = new System.Drawing.Point(157, 57);
            this.txtImmediateASCII.Name = "txtImmediateASCII";
            this.txtImmediateASCII.Size = new System.Drawing.Size(70, 20);
            this.txtImmediateASCII.TabIndex = 5;
            this.txtImmediateASCII.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImmediateASCII_KeyPress);
            // 
            // txtTransmitASCII
            // 
            this.txtTransmitASCII.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTransmitASCII.Location = new System.Drawing.Point(6, 19);
            this.txtTransmitASCII.Name = "txtTransmitASCII";
            this.txtTransmitASCII.Size = new System.Drawing.Size(601, 20);
            this.txtTransmitASCII.TabIndex = 0;
            this.txtTransmitASCII.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransmitASCII_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Immediate character transmit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Enter to send command, Esc to clear textbox.";
            // 
            // btnSendASCII
            // 
            this.btnSendASCII.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendASCII.Location = new System.Drawing.Point(613, 17);
            this.btnSendASCII.Name = "btnSendASCII";
            this.btnSendASCII.Size = new System.Drawing.Size(49, 23);
            this.btnSendASCII.TabIndex = 1;
            this.btnSendASCII.Text = "Send";
            this.btnSendASCII.UseVisualStyleBackColor = true;
            this.btnSendASCII.Click += new System.EventHandler(this.btnSendASCII_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtSignedDecimal);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(665, 296);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Signed Decimal";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtSignedDecimal
            // 
            this.txtSignedDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSignedDecimal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignedDecimal.Location = new System.Drawing.Point(0, 0);
            this.txtSignedDecimal.Multiline = true;
            this.txtSignedDecimal.Name = "txtSignedDecimal";
            this.txtSignedDecimal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSignedDecimal.Size = new System.Drawing.Size(665, 296);
            this.txtSignedDecimal.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.txtUnsignedDecimal);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(665, 296);
            this.tabPage5.TabIndex = 6;
            this.tabPage5.Text = "Unsigned Decimal";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // txtUnsignedDecimal
            // 
            this.txtUnsignedDecimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUnsignedDecimal.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnsignedDecimal.Location = new System.Drawing.Point(0, 0);
            this.txtUnsignedDecimal.Multiline = true;
            this.txtUnsignedDecimal.Name = "txtUnsignedDecimal";
            this.txtUnsignedDecimal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUnsignedDecimal.Size = new System.Drawing.Size(665, 296);
            this.txtUnsignedDecimal.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 146);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabsOutput);
            this.splitContainer1.Panel1MinSize = 175;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chkEnablePacketParsing);
            this.splitContainer1.Panel2.Controls.Add(this.btnTestParser);
            this.splitContainer1.Panel2.Controls.Add(this.btnReset);
            this.splitContainer1.Panel2.Controls.Add(this.lblPacketsReceived);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.txtLog);
            this.splitContainer1.Panel2MinSize = 85;
            this.splitContainer1.Size = new System.Drawing.Size(673, 537);
            this.splitContainer1.SplitterDistance = 322;
            this.splitContainer1.TabIndex = 11;
            // 
            // chkEnablePacketParsing
            // 
            this.chkEnablePacketParsing.AutoSize = true;
            this.chkEnablePacketParsing.Location = new System.Drawing.Point(266, 9);
            this.chkEnablePacketParsing.Name = "chkEnablePacketParsing";
            this.chkEnablePacketParsing.Size = new System.Drawing.Size(134, 17);
            this.chkEnablePacketParsing.TabIndex = 13;
            this.chkEnablePacketParsing.Text = "Enable Packet Parsing";
            this.chkEnablePacketParsing.UseVisualStyleBackColor = true;
            this.chkEnablePacketParsing.CheckedChanged += new System.EventHandler(this.chkEnablePacketParsing_CheckedChanged);
            // 
            // btnTestParser
            // 
            this.btnTestParser.Location = new System.Drawing.Point(568, 5);
            this.btnTestParser.Name = "btnTestParser";
            this.btnTestParser.Size = new System.Drawing.Size(75, 23);
            this.btnTestParser.TabIndex = 12;
            this.btnTestParser.Text = "Test Parser";
            this.btnTestParser.UseVisualStyleBackColor = true;
            this.btnTestParser.Click += new System.EventHandler(this.btnTestParser_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(145, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 23);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset Outputs";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPacketsReceived
            // 
            this.lblPacketsReceived.AutoSize = true;
            this.lblPacketsReceived.Location = new System.Drawing.Point(499, 11);
            this.lblPacketsReceived.Name = "lblPacketsReceived";
            this.lblPacketsReceived.Size = new System.Drawing.Size(13, 13);
            this.lblPacketsReceived.TabIndex = 10;
            this.lblPacketsReceived.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Packets Received:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnApplyOptions);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtDelimiter);
            this.groupBox2.Controls.Add(this.chkShow0x);
            this.groupBox2.Location = new System.Drawing.Point(12, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 45);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output Options";
            // 
            // btnApplyOptions
            // 
            this.btnApplyOptions.Location = new System.Drawing.Point(220, 17);
            this.btnApplyOptions.Name = "btnApplyOptions";
            this.btnApplyOptions.Size = new System.Drawing.Size(46, 23);
            this.btnApplyOptions.TabIndex = 5;
            this.btnApplyOptions.Text = "Apply";
            this.btnApplyOptions.UseVisualStyleBackColor = true;
            this.btnApplyOptions.Click += new System.EventHandler(this.btnApplyOptions_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Delimiter:";
            // 
            // txtDelimiter
            // 
            this.txtDelimiter.Location = new System.Drawing.Point(175, 18);
            this.txtDelimiter.Name = "txtDelimiter";
            this.txtDelimiter.Size = new System.Drawing.Size(39, 20);
            this.txtDelimiter.TabIndex = 3;
            this.txtDelimiter.Text = " ";
            // 
            // chkShow0x
            // 
            this.chkShow0x.AutoSize = true;
            this.chkShow0x.Location = new System.Drawing.Point(6, 19);
            this.chkShow0x.Name = "chkShow0x";
            this.chkShow0x.Size = new System.Drawing.Size(107, 17);
            this.chkShow0x.TabIndex = 2;
            this.chkShow0x.Text = "Display 0x in Hex";
            this.chkShow0x.UseVisualStyleBackColor = true;
            this.chkShow0x.CheckedChanged += new System.EventHandler(this.chkShow0x_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Line Ending:";
            // 
            // cbbLineEnding
            // 
            this.cbbLineEnding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLineEnding.FormattingEnabled = true;
            this.cbbLineEnding.Location = new System.Drawing.Point(76, 15);
            this.cbbLineEnding.Name = "cbbLineEnding";
            this.cbbLineEnding.Size = new System.Drawing.Size(104, 21);
            this.cbbLineEnding.TabIndex = 0;
            this.cbbLineEnding.SelectedIndexChanged += new System.EventHandler(this.cbbLineEnding_SelectedIndexChanged);
            // 
            // chkClearTransmitAfterSend
            // 
            this.chkClearTransmitAfterSend.AutoSize = true;
            this.chkClearTransmitAfterSend.Location = new System.Drawing.Point(186, 19);
            this.chkClearTransmitAfterSend.Name = "chkClearTransmitAfterSend";
            this.chkClearTransmitAfterSend.Size = new System.Drawing.Size(177, 17);
            this.chkClearTransmitAfterSend.TabIndex = 2;
            this.chkClearTransmitAfterSend.Text = "Clear Transmit text after sending";
            this.chkClearTransmitAfterSend.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkClearTransmitAfterSend);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cbbLineEnding);
            this.groupBox4.Location = new System.Drawing.Point(292, 95);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 45);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transmit Options";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(9, 30);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(95, 23);
            this.btnAbout.TabIndex = 1;
            this.btnAbout.Text = "About SerialHex";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox8.Controls.Add(this.btnAbout);
            this.groupBox8.Location = new System.Drawing.Point(573, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(112, 77);
            this.groupBox8.TabIndex = 14;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "SerialHex";
            // 
            // serialPortSettings1
            // 
            this.serialPortSettings1.BaudRate = "";
            this.serialPortSettings1.DataBits = "";
            this.serialPortSettings1.DeviceName = "Device Parameters";
            this.serialPortSettings1.Location = new System.Drawing.Point(6, 15);
            this.serialPortSettings1.Name = "serialPortSettings1";
            this.serialPortSettings1.Parity = "";
            this.serialPortSettings1.PortName = "";
            this.serialPortSettings1.Size = new System.Drawing.Size(544, 56);
            this.serialPortSettings1.StopBits = "";
            this.serialPortSettings1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 695);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(682, 440);
            this.Name = "Form1";
            this.Text = "Serial Hex";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabsOutput.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private SerialPortSettings serialPortSettings1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TabControl tabsOutput;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TextBox txtASCII;
		private System.Windows.Forms.TextBox txtSignedDecimal;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox txtHex;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox txtBinary;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblPacketsReceived;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TextBox txtUnsignedDecimal;
		private System.Windows.Forms.Button btnTestParser;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTransmitHex;
		private System.Windows.Forms.Button btnSendHex;
		private System.Windows.Forms.ComboBox cbbLineEnding;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox chkShow0x;
		private System.Windows.Forms.Button btnApplyOptions;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDelimiter;
		private System.Windows.Forms.CheckBox chkClearTransmitAfterSend;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnExamplesHex;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtTransmitASCII;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnSendASCII;
		private System.Windows.Forms.TextBox txtImmediateASCII;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtLast50ASCIIChars;
		private System.Windows.Forms.CheckBox chkEnablePacketParsing;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.GroupBox groupBox8;
	}
}

