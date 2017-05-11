// copyright (c) 2017 Roberto Ceccarelli - CasaSoft
// http://strawberryfield.altervista.org 
// 
// This file is part of CasaSoft Virtual Railways Tools
// 
// CasaSoft Virtual Railways Tools is free software: 
// you can redistribute it and/or modify it
// under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CasaSoft Virtual Railways Tools is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
// See the GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CasaSoft Virtual Railways Tools.  
// If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasaSoft.vrt.forms
{
    public partial class R3Dorigin : UserControl
    {
        protected KmlLib Kml;

        #region constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public R3Dorigin()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Initializes the combobox
        /// </summary>
        /// <param name="kml">instance of <see cref="T:CasaSoft.vrt.KmlLib"/></param>
        public void SetKml(KmlLib kml)
        {
            this.Kml = kml;
            cmbKml.Items.Add("");
            cmbKml.Items.AddRange(kml.PlacemarksNames());
        }
    }
}
