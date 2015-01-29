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
using System.Text;
using System.IO.Ports;

namespace SerialHex
{
	public class SerialDevice
	{
		protected int[] baudRates;
		protected int defaultBaud;
		protected SerialPort serialPort = new SerialPort();

		public delegate void InformationEventHandler(string message);
		public delegate void ErrorEventHandler(string message);
		public delegate void CommandEventHandler(string command);
		public delegate void ReceiveDataEventHandler(byte[] data);

		public event InformationEventHandler ReportInfo;
		public event ErrorEventHandler ReportError;
		public event CommandEventHandler ReportCommand;
		public event ReceiveDataEventHandler ReceiveData;

		// Configure serial as 8N1 if dataBits, parity, and stopBits are not passed
		public SerialDevice(int[] baudRates, int defaultBaud) : this(baudRates, defaultBaud, 8, Parity.None, StopBits.One)
		{
		}

		public SerialDevice(int[] baudRates, int defaultBaud, int dataBits, Parity parity, StopBits stopBits)
		{
			if (Array.IndexOf(baudRates, defaultBaud) == -1)
			{
				throw new ArgumentException("defaultBaud must be listed in the array of supported baudRates");
			}
			this.baudRates = baudRates;
			this.defaultBaud = defaultBaud;
			this.serialPort.BaudRate = defaultBaud;
			// Configure serial as specified by parameters
			this.serialPort.DataBits = dataBits;
			this.serialPort.Parity = parity;
			this.serialPort.StopBits = stopBits;
			//this.serialPort.ReadTimeout = 100; //***
			this.serialPort.NewLine = "\r\n";
			this.serialPort.Encoding = System.Text.Encoding.ASCII;
            this.serialPort.DataReceived += new SerialDataReceivedEventHandler(this.serialPort_DataReceived);
		}

		public string PortName
		{
			get
			{
				return this.serialPort.PortName;
			}
		}

		public virtual int BaudRate
		{
			get
			{
				return this.serialPort.BaudRate;
			}
			set
			{
				if (Array.IndexOf(baudRates, value) == -1)
				{
					throw new ArgumentException("New baud rate " + value + " is not listed in the array of supported baudRates");
				}
				// if the new value is actually different
				if (this.serialPort.BaudRate != value)
				{
					OnReportInfo("Baud rate changed from " + this.serialPort.BaudRate + " to: " + value);
					this.serialPort.BaudRate = value;
				}
			}
		}

		public int[] BaudRates
		{
			get
			{
				return this.baudRates;
			}
		}

		public int DataBits
		{
			get
			{
				return this.serialPort.DataBits;
			}
			set
			{
				// if the new value is actually different
				if (this.serialPort.DataBits != value)
				{
					OnReportInfo("DataBits changed from " + this.serialPort.DataBits + " to: " + value);
					this.serialPort.DataBits = value;
				}
			}
		}

		public Parity Parity
		{
			get
			{
				return this.serialPort.Parity;
			}
			set
			{
				// if the new value is actually different
				if (this.serialPort.Parity != value)
				{
					OnReportInfo("Parity changed from " + this.serialPort.Parity + " to: " + value);
					this.serialPort.Parity = value;
				}
			}
		}

		public StopBits StopBits
		{
			get
			{
				return this.serialPort.StopBits;
			}
			set
			{
				// if the new value is actually different
				if (this.serialPort.StopBits != value)
				{
					OnReportInfo("StopBits changed from " + this.serialPort.StopBits + " to: " + value);
					this.serialPort.StopBits = value;
				}
			}
		}

		public virtual bool Connect(string portName)
		{
			if (this.serialPort.IsOpen)
			{
				Disconnect();
			}
			try
			{
				this.serialPort.PortName = portName;
				this.serialPort.Open();
				OnReportInfo("Connected to " + portName);
				return true;
			}
			catch (Exception ex)
			{
				OnReportError("Connect(): " + ex.Message);
				return false;
			}
		}

		public virtual bool Disconnect()
		{
			try
			{
				this.serialPort.Close();
				OnReportInfo("Disconnected");
				return true;
			}
			catch (Exception ex)
			{
				OnReportError("Disconnect(): " + ex.Message);
				return false;
			}
		}

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] buffer = new byte[serialPort.BytesToRead];
            serialPort.Read(buffer, 0, serialPort.BytesToRead);
			OnReceiveData(buffer);
        }

		public virtual void serialWrite(string text, string lineEnding)
		{
			OnReportCommand(text + lineEnding.Replace("\r", @"\r").Replace("\n", @"\n"));
			try
			{
				this.serialPort.Write(text + lineEnding);
			}
			catch (Exception ex)
			{
				OnReportError("serialWrite(): " + ex.Message);
			}
		}

		public virtual void serialWrite(byte[] data)
		{
			try
			{
				this.serialPort.Write(data, 0, data.Length);
			}
			catch (Exception ex)
			{
				OnReportError("serialWrite(): " + ex.Message);
			}
		}

		protected virtual void OnReportInfo(string message)
		{
			ReportInfo(message);
		}

		protected virtual void OnReportError(string message)
		{
			ReportError(message);
		}

		protected virtual void OnReceiveData(byte[] data)
		{
			ReceiveData(data);
		}

		protected virtual void OnReportCommand(string command)
		{
			ReportCommand(command);
		}
	}
}
