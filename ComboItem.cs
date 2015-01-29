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

namespace SerialHex
{
    class ComboItem
    {
        protected string _Text;
        protected string _Value;

        public ComboItem(string Text)
        {
            this._Text = Text;
            this._Value = Text;
        }

        public ComboItem(string Text, string Value)
        {
            this._Text = Text;
            this._Value = Value;
        }

        public string Value
        {
            get
            {
                return _Value;
            }
            set
            {
                this._Value = value;
            }
        }

        public string Text
        {
            get
            {
                return _Text;
            }
            set
            {
                this._Text = value;
            }
        }

        public override string ToString()
        {
            return _Text;
        }
    }
}
