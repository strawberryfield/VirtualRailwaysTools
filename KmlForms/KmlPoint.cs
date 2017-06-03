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
using System.ComponentModel;
using System.Globalization;
using System.Windows.Forms;
using NGettext;
using CasaSoft.vrt.KmlLib;

namespace CasaSoft.vrt.forms
{
    /// <summary>
    /// User control for select and edit a single point
    /// </summary>
    public partial class KmlPoint : UserControl
    {
        /// <summary>
        /// Instance of <see cref="T:CasaSoft.vrt.KmlLib.KmlLib"/>
        /// </summary>
        protected KmlLib.KmlLib Kml;

        #region constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public KmlPoint()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Converts textbox input to double
        /// </summary>
        /// <param name="s">string to parse</param>
        /// <returns></returns>
        protected double parse4double(string s)
        {
            double ret = 0;
            if (!double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out ret)) ret = 0;
            return ret;
        }

        #region properties
        /// <summary>
        /// Return Latitude
        /// </summary>
        [Description("Latitude"), Category()]
        public double Lat { get { return parse4double(txtLat.Text); } }

        /// <summary>
        /// Return Longitude
        /// </summary>
        [Description("Longitude"), Category()]
        public double Lon { get { return parse4double(txtLon.Text); } }
        #endregion

        #region init methods
        /// <summary>
        /// Sets localizable strings
        /// </summary>
        /// <param name="catalog"></param>
        public void setLocale(ICatalog catalog)
        {
            // Localizable captions
            lblKml.Text = catalog.GetString("Select from kml");
            lblLat.Text = catalog.GetString("Latitude");
            lblLon.Text = catalog.GetString("Longitude");
        }

        /// <summary>
        /// Initializes the combobox
        /// </summary>
        /// <param name="kml">instance of <see cref="T:CasaSoft.vrt.KmlLib.KmlLib"/></param>
        public void SetKml(KmlLib.KmlLib kml)
        {
            this.Kml = kml;
            if (cmbKml.Items.Count > 0)
            {
                cmbKml.Items.Clear();
                cmbKml.Enabled = false;
            }
            if (kml != null)
            {
                cmbKml.Items.Add("");
                cmbKml.Items.AddRange(kml.PlacemarksNames());
                cmbKml.Enabled = true;
            }
        }
        #endregion

        #region events handling
        private void cmbKml_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Object selectedPm = cmbKml.SelectedItem;
            IPlacemark p = Kml.GetPlacemarkByName(selectedPm.ToString());
            if (p != null)
            {
                txtLat.Text = Convert.ToString(p.Lat, CultureInfo.InvariantCulture);
                txtLon.Text = Convert.ToString(p.Lon, CultureInfo.InvariantCulture);
            }

        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & e.KeyChar != (char)Keys.Back & e.KeyChar != '.' & e.KeyChar != '-';
        }
        #endregion

    }
}
