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

namespace CasaSoft.vrt.forms
{
    public partial class kmlContentSelector : UserControl
    {
        #region constructors
        /// <summary>
        /// Base constructor
        /// </summary>
        public kmlContentSelector()
        {
            InitializeComponent();
            chkPlacemarks.Tag = chkPlacemarks.Text;
            chkPaths.Tag = chkPaths.Text;
            chkPolys.Tag = chkPolys.Text;
        }

        /// <summary>
        /// Constructor for localization
        /// </summary>
        /// <param name="catalog">locale strings</param>
        public kmlContentSelector(ICatalog catalog)
        {
            InitializeComponent();

            // Localizable captions
            chkPlacemarks.Tag = catalog.GetString("Placemarks");
            chkPaths.Tag = catalog.GetString("Paths");
            chkPolys.Tag = catalog.GetString("Polygons");

            resetControls();
        }
        #endregion;

        #region properties
        /// <summary>
        /// Return status of Placemarks chechbox
        /// </summary>
        public bool PlacemarksSelected { get { return chkPlacemarks.Checked; } }

        /// <summary>
        /// Return status of Paths chechbox
        /// </summary>
        public bool PathsSelected { get { return chkPaths.Checked; } }

        /// <summary>
        /// Return status of Polys chechbox
        /// </summary>
        public bool PolysSelected { get { return chkPolys.Checked; } }
        #endregion

        #region controls management
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
        }

        /// <summary>
        /// set controls status form kml data
        /// </summary>
        /// <param name="kml">kml data objects</param>
        public void initFromKml(KmlLib kml)
        {
            chkPlacemarks.Text = string.Format("{0} ({1})", chkPlacemarks.Tag, kml.CountPlacemarks());
            if (kml.CountPlacemarks() > 0)
            {
                chkPlacemarks.Enabled = true;
            }
            chkPaths.Text = string.Format("{0} ({1})", chkPaths.Tag, kml.CountPaths());
            if (kml.CountPaths() > 0)
            {
                chkPaths.Enabled = true;
            }
            chkPolys.Text = string.Format("{0} ({1})", chkPolys.Tag, kml.CountPolys());
            if (kml.CountPolys() > 0)
            {
                chkPolys.Enabled = true;
            }
        }
        #endregion

    }
}
