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

namespace SerialHex
{
	public partial class About : Form
	{
		public About()
		{
			InitializeComponent();
		}

		private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(linkGitHub.Text);
		}

		private void btnViewLicense_Click(object sender, EventArgs e)
		{
			Examples examples = new Examples("GNU General Public License", SerialHex.Properties.Resources.GPL2);
			examples.Width = 550;
			examples.Height = 500;
			examples.txtExamples.WordWrap = false;
			examples.FormBorderStyle = FormBorderStyle.Sizable;
			examples.ShowDialog();
        }
	}
}