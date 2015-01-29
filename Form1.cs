/*
SerialHex - A tool for reading and writing serial port data
Copyright (C) 2007  Patrick J. McCarty

This file is part of SerialHex. SerialHex is free software;
you can redistribute it and/or modify it under the terms of the 
GNU General Public License as published by the Free Software Foundation;
either version 2 of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along
with this program; if not, write to the Free Software Foundation, Inc.,
51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SerialHex
{
	public partial class Form1 : Form
	{
		private SerialDevice serial;
		private delegate void LogDelegate(string text);
		private delegate void ShowDataDelegate(byte[] data);
		private int packetBytesReceived = 0;
		private int packetSize;
		private byte packetChecksum;
		private int packetCount = 0;
		private string hexPrefix = ""; //gets changed to "0x" if user enables the prefix option
		private string delimiter = " "; //default is space, can be changed by user
		private string lineEnding;
		private StringBuilder immediateASCIIhistory = new StringBuilder(100); // twice as big as it needs to be, to allow some leeway?

		public Form1()
		{
			InitializeComponent();
			int[] baudRates = { 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 76800, 115200, 230400, 250000, 500000, 1000000 };
			serial = new SerialDevice(baudRates, 38400);
			serialPortSettings1.Initialize(serial);
			serial.ReportInfo += new SerialDevice.InformationEventHandler(LogD);
			serial.ReportError += new SerialDevice.ErrorEventHandler(LogErrorD);
			serial.ReportCommand += new SerialDevice.CommandEventHandler(LogCommand);
			serial.ReceiveData += new SerialDevice.ReceiveDataEventHandler(ShowDataD);
		}

		void serial_ReceiveData(string command)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Setup Line Ending options and default to \r\n
			cbbLineEnding.Items.Add(new ComboItem(@"\r\n - <CR><LF>","\r\n"));
			cbbLineEnding.Items.Add(new ComboItem(@"\r - <CR>","\r"));
			cbbLineEnding.Items.Add(new ComboItem(@"\n - <LF>","\n"));
			cbbLineEnding.Items.Add(new ComboItem(@"none", ""));
			cbbLineEnding.SelectedIndex = 0;

			// connect automatically when the form starts up
			if (serialPortSettings1.PortName != "none")
			{
				serialPortSettings1.btnConnection_Click(sender, e);
			}
		}

		public void Log(string text)
		{
			txtLog.SelectionStart = txtLog.TextLength;
			txtLog.SelectionColor = Color.Black;
			txtLog.AppendText(text + "\r\n");
			txtLog.ScrollToCaret();
		}

		public void LogError(string text)
		{
			txtLog.SelectionStart = txtLog.TextLength;
			txtLog.SelectionColor = Color.Red;
			txtLog.AppendText(text + "\r\n");
			txtLog.ScrollToCaret();
		}

		public void LogCommand(string text)
		{
			txtLog.SelectionStart = txtLog.TextLength;
			txtLog.SelectionColor = Color.Green;
			txtLog.AppendText(text + "\r\n");
			txtLog.ScrollToCaret();
		}

		public void LogCommandChar(char character)
		{
			txtLog.SelectionStart = txtLog.TextLength;
			txtLog.SelectionColor = Color.Green;
			txtLog.AppendText(character.ToString());
			//txtLog.ScrollToCaret();
		}

		public void LogD(string text)
		{
			txtLog.Invoke(new LogDelegate(Log), new object[] { text });
		}

		public void LogErrorD(string text)
		{
			txtLog.Invoke(new LogDelegate(LogError), new object[] { text });
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtLog.Clear();
		}

		public void ShowDataD(byte[] data)
		{
			this.Invoke(new ShowDataDelegate(ShowData), new object[] { data });
		}

		private void ShowData(byte[] data)
		{
			this.txtHex.SuspendLayout();
			this.txtBinary.SuspendLayout();
			this.txtASCII.SuspendLayout();
			this.txtSignedDecimal.SuspendLayout();
			this.txtUnsignedDecimal.SuspendLayout();
			foreach (byte b in data)
			{
				// Display the byte in various formats
				this.txtHex.AppendText(String.Format("{0}{1:X2}{2}", hexPrefix, b, delimiter));
				this.txtBinary.AppendText(Convert.ToString(b, 2).PadLeft(8, '0') + delimiter);
				this.txtASCII.AppendText(((char)b).ToString());
				this.txtSignedDecimal.AppendText(String.Format("{0}{1}", (sbyte)b, delimiter));
				this.txtUnsignedDecimal.AppendText(String.Format("{0}{1}", b, delimiter));

				if (chkEnablePacketParsing.Checked)
				{
					// increment bytes received
					packetBytesReceived++;

					if (packetBytesReceived == 1)
					{
						// This is the first byte of a packet, the code
						packetChecksum = b;
					}
					else if (packetBytesReceived == 2)
					{
						// This is the second byte of a packet, the size
						packetSize = b;
						packetChecksum += b;
					}
					else if (packetSize > 0)
					{
						// If we still have data bytes left
						packetChecksum += b;
						packetSize--;
					}
					else if (packetSize == 0)
					{
						// This is the checksum byte
						if (packetChecksum != b)
						{
							LogError(String.Format("Invalid Checksum {0:X2} (should be {1:X2})", b, packetChecksum));
						}
						// End of packet, so append a newline
						this.txtHex.AppendText("\r\n");
						this.txtBinary.AppendText("\r\n");
						this.txtASCII.AppendText("\r\n");
						this.txtSignedDecimal.AppendText("\r\n");
						this.txtUnsignedDecimal.AppendText("\r\n");
						// Count the total number of packets received and update GUI
						packetCount++;
						this.lblPacketsReceived.Text = packetCount.ToString();
						// Reset packetBytesReceived, so the parser interprets the next byte as a new packet
						packetBytesReceived = 0;
					}
					else
					{
						LogError("Fell through packet parser, not sure what to do!");
					}
				}
			}
			this.txtHex.ResumeLayout();
			this.txtBinary.ResumeLayout();
			this.txtASCII.ResumeLayout();
			this.txtSignedDecimal.ResumeLayout();
			this.txtUnsignedDecimal.ResumeLayout();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			packetCount = 0;
			this.lblPacketsReceived.Text = packetCount.ToString();
			this.txtHex.Clear();
			this.txtBinary.Clear();
			this.txtASCII.Clear();
			this.txtSignedDecimal.Clear();
			this.txtUnsignedDecimal.Clear();
			Log("Reset Outputs");
		}

		private void btnTestParser_Click(object sender, EventArgs e)
		{
			Log("Parser Test");
			chkEnablePacketParsing.Checked = true;
			packetBytesReceived = 0;
			packetCount = 0;
			ShowData(new byte[] { 20, 5, 1, 2, 3, 4, 5, 0x28, 21, 4, 11, 22, 33, 44, 0x87, 0x50, 0x61, 0x74, 0x72, 0x69, 0x63, 0x6B });
		}

		private void chkShow0x_CheckedChanged(object sender, EventArgs e)
		{
			if (chkShow0x.Checked)
			{
				hexPrefix = "0x";
			}
			else
			{
				hexPrefix = "";
			}
		}

		private void btnApplyOptions_Click(object sender, EventArgs e)
		{
			if (txtDelimiter.Text != delimiter)
			{
				if (MessageBox.Show("Do you want to change existing output text to reflect this new setting?", "Change existing output?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
				{
					txtHex.Text = txtHex.Text.Replace(delimiter, txtDelimiter.Text);
					txtBinary.Text = txtBinary.Text.Replace(delimiter, txtDelimiter.Text);
					txtSignedDecimal.Text = txtSignedDecimal.Text.Replace(delimiter, txtDelimiter.Text);
					txtUnsignedDecimal.Text = txtUnsignedDecimal.Text.Replace(delimiter, txtDelimiter.Text);
				}
				delimiter = txtDelimiter.Text;
			}
		}

		private void btnExamplesHex_Click(object sender, EventArgs e)
		{
			string exampleText = @"All of the following are equivalent:
0xDE,0xAD,0xBE,0xEF
0xDE 0xAD 0xBE 0xEF
0xDEAD,0xBEEF
0xDEADBEEF

DE    ,AD,  BE  ,  EF
DE,AD,BE,EF
DE AD BE EF
DEAD,BEEF
DEADBEEF";
			Examples examples = new Examples("Hex Examples", exampleText);
			examples.ShowDialog();
		}

		private void txtTransmitHex_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnSendHex_Click(sender, e);
				e.Handled = true;
			}
			else if (e.KeyChar == (char)(Keys.Escape))
			{
				txtTransmitHex.Clear();
				e.Handled = true;
			}
		}

		private void btnSendHex_Click(object sender, EventArgs e)
		{
			// strip the input of all delimiter characters and the optional 0x prefix
			string data = txtTransmitHex.Text.Replace("0x", "").Replace(@"\n", "0A").Replace(@"\r", "0D").Replace(delimiter, "").Replace(",", "").Replace(" ", "").ToUpper();

			// check for invalid characters
			string invalidChars = "";
			for (int i = 0; i < data.Length; i++)
			{
				if (!Char.IsDigit(data[i]) && !(data[i] >= 'A' && data[i] <= 'F'))
				{
					if (invalidChars.IndexOf(data[i]) == -1)
					{
						invalidChars += data[i];
					}
				}
			}
			// report any invalid characters
			if (invalidChars != "")
			{
				LogError("Invalid characters detected (non-Hex, non-delimiter characters): " + invalidChars);
				return;
			}
			// require an even number of hex characters
			if (data.Length % 2 != 0)
			{
				LogError("Must have an even number of hex characters. You supplied " + data.Length + " characters.");
				return;
			}

			// convert the hex characters to a byte array
			byte[] buffer = new byte[data.Length / 2 + lineEnding.Length];
			for (int i = 0; i < data.Length; i+=2)
			{
				buffer[i / 2] = byte.Parse(data.Substring(i, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
			}

			// add the configured line ending to the end of the buffer
			for (int i = 0; i < lineEnding.Length; i++)
			{
				buffer[data.Length / 2 + i] = (byte)lineEnding[i];
			}

			// Convert to displayable hex format, with 0x prefix if enabled, and the configured delimiter
			StringBuilder command = new StringBuilder(buffer.Length * (hexPrefix.Length + 2 + delimiter.Length));
			foreach (byte b in buffer)
			{
				if (b == '\r')
				{
					command.Append(@"\r");
					command.Append(delimiter);
				}
				else if (b == '\n')
				{
					command.Append(@"\n");
					command.Append(delimiter);
				}
				else
				{
					command.Append(String.Format("{0}{1:X2}{2}", hexPrefix, b, delimiter));
				}
			}

			// Log the command and write it out to the serial port
			LogCommand(command.ToString());
			serial.serialWrite(buffer);	

			// Clear the transmit textbox if option is checked
			if (chkClearTransmitAfterSend.Checked)
			{
				txtTransmitHex.Clear();
			}
		}

		private void txtTransmitASCII_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\r')
			{
				btnSendASCII_Click(sender, e);
				e.Handled = true;
			}
			else if (e.KeyChar == (char)(Keys.Escape))
			{
				txtTransmitASCII.Clear();
				e.Handled = true;
			}
		}

		private void btnSendASCII_Click(object sender, EventArgs e)
		{
			// write the command out to the serial port, which also logs it
			serial.serialWrite(txtTransmitASCII.Text, lineEnding);

			// Clear the transmit textbox if option is checked
			if (chkClearTransmitAfterSend.Checked)
			{
				txtTransmitASCII.Clear();
			}
		}

		private void txtImmediateASCII_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (immediateASCIIhistory.Length >= 50)
			{
				// keep only the last 49 characters
				immediateASCIIhistory.Remove(0, immediateASCIIhistory.Length - 49);
			}
			immediateASCIIhistory.Append(e.KeyChar);
			txtLast50ASCIIChars.Text = immediateASCIIhistory.ToString();

			// Enter key gets special handling to make it send the chosen Line Ending instead of just \r
			if (e.KeyChar == '\r')
			{
				serial.serialWrite("", lineEnding);
			}
			else
			{
				serial.serialWrite(new byte[] { (byte)e.KeyChar });
				LogCommandChar(e.KeyChar);
			}
			e.Handled = true;
		}

		private void cbbLineEnding_SelectedIndexChanged(object sender, EventArgs e)
		{
			// update the lineEnding variable with the new choice
			lineEnding = ((ComboItem)cbbLineEnding.SelectedItem).Value;
		}

		private void chkEnablePacketParsing_CheckedChanged(object sender, EventArgs e)
		{
			packetBytesReceived = 0;
			if (chkEnablePacketParsing.Checked)
			{
				Log("Enabled Packet Parsing");
			}
			else
			{
				Log("Disabled Packet Parsing");
			}
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			About about = new About();
			about.ShowDialog();
		}
	}
}