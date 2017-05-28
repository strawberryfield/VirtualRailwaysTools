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

using System.ComponentModel;
using System.Windows.Forms;
using NGettext;

namespace CasaSoft.vrt.forms
{
    /// <summary>
    /// Component to manage Rail3D origin point of layouts
    /// </summary>
    public partial class R3Dorigin : KmlPoint
    {

        #region constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public R3Dorigin() : base()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Converts textbox input to int
        /// </summary>
        /// <param name="s">string to parse</param>
        /// <returns></returns>
        protected int parse4int(string s)
        {
            int ret = 0;
            if (!int.TryParse(s, out ret)) ret = 0;
            return ret;
        }

        #region properties
        /// <summary>
        /// Return UTM zone
        /// </summary>
        [Description("UTM zone"), Category()]
        public int UTMzone { get { return parse4int(txtZone.Text); } }

        /// <summary>
        /// Return Rail3D X of origin
        /// </summary>
        [Description("Rail3D X of origin"), Category()]
        public int X { get { return parse4int(txtX.Text); } }

        /// <summary>
        /// Return Rail3D Y of origin
        /// </summary>
        [Description("Rail3D Y of origin"), Category()]
        public int Y { get { return parse4int(txtY.Text); } }
        #endregion

        /// <summary>
        /// Returns an instance of <see cref="T:CasaSoft.vrt.R3dCoordsConverter"/>
        /// initialized with control's data
        /// </summary>
        /// <returns></returns>
        public R3dCoordsConverter CoordsConverter()
        {
            R3dCoordsConverter ret = null;
            if (!string.IsNullOrWhiteSpace(txtLat.Text)
                & !string.IsNullOrWhiteSpace(txtLon.Text)
                & !string.IsNullOrWhiteSpace(txtX.Text)
                & !string.IsNullOrWhiteSpace(txtY.Text))
            {
                LatLon ll = new LatLon() { Lat = this.Lat, Lon = this.Lon };
                XY xy = new XY() { X = this.X, Y = this.Y };

                if (!string.IsNullOrWhiteSpace(txtZone.Text))
                {
                    ret = new R3dCoordsConverter(ll, xy, this.UTMzone);
                }
                else
                {
                    ret = new R3dCoordsConverter(ll, xy);
                }
            }
            return ret;
        }

        #region init methods
        /// <summary>
        /// Sets localizable strings
        /// </summary>
        /// <param name="catalog"></param>
        public new void setLocale(ICatalog catalog)
        {
            // Localizable captions
            base.setLocale(catalog);
            lblZone.Text = catalog.GetString("UTM Zone");
            lblX.Text = catalog.GetString("Rail3D X start");
            lblY.Text = catalog.GetString("Rail3D Y start");
        }
        #endregion

        #region events handling
        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & e.KeyChar != (char)Keys.Back & e.KeyChar != '.' & e.KeyChar != '-';
        }
        #endregion
    }
}
