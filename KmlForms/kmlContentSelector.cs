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

using NGettext;
using System.Windows.Forms;
using System.ComponentModel;

namespace CasaSoft.vrt.forms
{
    public partial class kmlContentSelector : UserControl
    {
        #region constructors
        /// <summary>
        /// Base constructor
        /// </summary>
        public kmlContentSelector() : base()
        {
            InitializeComponent();
        }
        #endregion;

        #region properties
        /// <summary>
        /// Return status of Placemarks chechbox
        /// </summary>
        [Description("status of Placemarks chechbox"), Category()]
        public bool PlacemarksSelected { get { return chkPlacemarks.Checked; } }

        /// <summary>
        /// Return status of Paths chechbox
        /// </summary>
        [Description("status of Paths chechbox"), Category()]
        public bool PathsSelected { get { return chkPaths.Checked; } }

        /// <summary>
        /// Return status of Polys chechbox
        /// </summary>
        [Description("status of Polys chechbox"), Category()]
        public bool PolysSelected { get { return chkPolys.Checked; } }
        #endregion

        #region controls management
        /// <summary>
        /// Sets localizable strings
        /// </summary>
        /// <param name="catalog"></param>
        public void setLocale(ICatalog catalog)
        {
            // Localizable captions
            chkPlacemarks.Tag = catalog.GetString("Placemarks");
            chkPaths.Tag = catalog.GetString("Paths");
            chkPolys.Tag = catalog.GetString("Polygons");

            resetControls();
        }

        /// <summary>
        /// Reset checkboxes to defualt values
        /// </summary>
        public void resetControls()
        {
            chkPlacemarks.Text = (string)chkPlacemarks.Tag;
            chkPaths.Text = (string)chkPaths.Tag;
            chkPolys.Text = (string)chkPolys.Tag;

            chkPlacemarks.Enabled = false;
            chkPaths.Enabled = false;
            chkPolys.Enabled = false;

            chkPlacemarks.Checked = false;
            chkPaths.Checked = false;
            chkPolys.Checked = false;
        }

        /// <summary>
        /// set controls status form kml data
        /// </summary>
        /// <param name="kml">kml data objects</param>
        public void initFromKml(KmlLib.KmlLib kml)
        {
            chkPlacemarks.Text = string.Format("{0} ({1})", chkPlacemarks.Tag, kml.CountPlacemarks());
            if (kml.CountPlacemarks() > 0)
            {
                chkPlacemarks.Enabled = true;
                chkPlacemarks.Checked = true;
            }
            chkPaths.Text = string.Format("{0} ({1})", chkPaths.Tag, kml.CountPaths());
            if (kml.CountPaths() > 0)
            {
                chkPaths.Enabled = true;
                chkPaths.Checked = true;
            }
            chkPolys.Text = string.Format("{0} ({1})", chkPolys.Tag, kml.CountPolys());
            if (kml.CountPolys() > 0)
            {
                chkPolys.Enabled = true;
                chkPolys.Checked = true;
            }
        }
        #endregion

    }
}
