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
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialHex
{
	public partial class SerialPortSettings : UserControl
	{
		private SerialDevice serialDevice;

		public SerialPortSettings()
		{
			InitializeComponent();

			// populate the dataBits options
			this.cbbDataBits.Items.Add(5);
			this.cbbDataBits.Items.Add(6);
			this.cbbDataBits.Items.Add(7);
			this.cbbDataBits.Items.Add(8);

			// populate the parity options
			foreach (Parity par in System.Enum.GetValues(typeof(Parity)))
			{
				this.cbbParity.Items.Add(new ComboItem(System.Enum.GetName(typeof(System.IO.Ports.Parity), par)));
			}

			// populate the stopBits
			this.cbbStopBits.Items.Add(new ComboItem("1", "One"));
			this.cbbStopBits.Items.Add(new ComboItem("1.5", "OnePointFive"));
			this.cbbStopBits.Items.Add(new ComboItem("2", "Two"));
		}

		public string DeviceName
		{
			get
			{
				return this.lblDeviceName.Text;
			}
			set
			{
				this.lblDeviceName.Text = value;
			}
		}

		public string PortName
		{
			get
			{
				return this.cbbPortName.Text;
			}
			set
			{
				this.cbbPortName.Text = value;
			}
		}

		public string BaudRate
		{
			get
			{
				return this.cbbBaudRate.Text;
			}
			set
			{
				this.cbbBaudRate.Text = value;
			}
		}

		public string DataBits
		{
			get
			{
				return this.cbbDataBits.Text;
			}
			set
			{
				this.cbbDataBits.SelectedValue = value;
			}
		}

		public string Parity
		{
			get
			{
				return this.cbbParity.Text;
			}
			set
			{
				this.cbbParity.SelectedItem = value;
			}
		}

		public string StopBits
		{
			get
			{
				return this.cbbStopBits.Text;
			}
			set
			{
				this.cbbParity.SelectedItem = value;
			}
		}

		public void Initialize(SerialDevice serialDevice)
		{
			this.serialDevice = serialDevice;

			// copy the BaudRates from serialDevice into the dropdownlist
			int itemindex;
			foreach (int baud in serialDevice.BaudRates)
			{
				itemindex = this.cbbBaudRate.Items.Add(baud);
				if (baud == serialDevice.BaudRate)
				{
					this.cbbBaudRate.SelectedIndex = itemindex;
					this.lblBaud.Text = baud.ToString();
				}
			}

			// show this computer's COM ports in the dropdownlist
			refreshPortChoices();
			// select the last port
			if (this.cbbPortName.Items.Count > 0)
			{
				this.cbbPortName.SelectedIndex = this.cbbPortName.Items.Count - 1;
			}

			// select the DataBits option already configured on the serialDevice
			this.cbbDataBits.SelectedIndex = this.cbbDataBits.Items.IndexOf(serialDevice.DataBits);

			// select the Parity option already configured on the serialDevice
			string setting = Enum.GetName(typeof(System.IO.Ports.Parity), serialDevice.Parity);
			for (itemindex = 0; itemindex < this.cbbParity.Items.Count; itemindex++)
			{
				if (((ComboItem)this.cbbParity.Items[itemindex]).Value == setting)
				{
					this.cbbParity.SelectedIndex = itemindex;
					break;
				}
			}

			// select the StopBits option already configured on the serialDevice
			setting = Enum.GetName(typeof(System.IO.Ports.StopBits), serialDevice.StopBits);
			for (itemindex = 0; itemindex < this.cbbStopBits.Items.Count; itemindex++)
			{
				if (((ComboItem)this.cbbStopBits.Items[itemindex]).Value == setting)
				{
					this.cbbStopBits.SelectedIndex = itemindex;
					break;
				}
			}

			//foreach (ComboItem item in this.cbbDataBits.Items)
			//{
			//    if (item.Value == serialDevice.DataBits.ToString())
			//    {
			//        this.cbbDataBits.SelectedIndex = this.cbbDataBits.Items..IndexOf(
			//}
			//this.cbbDataBits.SelectedIndex = this.cbbDataBits.Items..IndexOf(serialDevice.DataBits.ToString());
			//this.cbbParity.SelectedIndex = this.cbbParity.Items.IndexOf(Enum.GetName(typeof(System.IO.Ports.Parity), serialDevice.Parity));
			//this.cbbStopBits.SelectedIndex = this.cbbStopBits.Items.IndexOf(Enum.GetName(typeof(System.IO.Ports.StopBits), serialDevice.StopBits));
		}

		public void ChangeSettings()
		{
			serialDevice.BaudRate = (int)this.cbbBaudRate.SelectedItem;
			this.lblBaud.Text = serialDevice.BaudRate.ToString();
			serialDevice.DataBits = (int)this.cbbDataBits.SelectedItem;
			this.lblDataBits.Text = serialDevice.DataBits.ToString();
			serialDevice.Parity = (Parity)Enum.Parse(typeof(System.IO.Ports.Parity), this.cbbParity.Text);
			this.lblParity.Text = this.cbbParity.Text;
			serialDevice.StopBits = (StopBits)Enum.Parse(typeof(System.IO.Ports.StopBits), ((ComboItem)this.cbbStopBits.SelectedItem).Value);
			this.lblStopBits.Text = this.cbbStopBits.Text;
		}

		public void btnConnection_Click(object sender, EventArgs e)
		{
			if (this.btnConnection.Text.Equals("Connect"))
			{
				ChangeSettings();
				if (serialDevice.Connect(this.cbbPortName.Items[this.cbbPortName.SelectedIndex].ToString()))
				{
					this.cbbPortName.Enabled = false;
					this.btnConnection.Text = "Disconnect";
					this.lblConnection.Text = "Connected on " + serialDevice.PortName;
				}
			}
			else
			{
				if (serialDevice.Disconnect())
				{
					this.cbbPortName.Enabled = true;
					this.btnConnection.Text = "Connect";
					this.lblConnection.Text = "Disconnected";
				}
			}
		}

		private void btnChange_Click(object sender, EventArgs e)
		{
			ChangeSettings();
		}

		private void cbbPortName_DropDown(object sender, EventArgs e)
		{
			refreshPortChoices();
		}

		private void refreshPortChoices()
		{
			int selectedPortIndex = this.cbbPortName.SelectedIndex;
			this.cbbPortName.Items.Clear();
			string[] portNames = SerialPort.GetPortNames();
			Array.Sort(portNames);
			this.cbbPortName.Items.AddRange(portNames);
			if (selectedPortIndex < this.cbbPortName.Items.Count)
			{
				this.cbbPortName.SelectedIndex = selectedPortIndex;
			}
			if (this.cbbPortName.Items.Count == 0)
			{
				this.cbbPortName.Items.Add("none");
				this.btnConnection.Enabled = false;
			}
			else
			{
				this.btnConnection.Enabled = true;
			}
		}
	}
}
