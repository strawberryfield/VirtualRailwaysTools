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
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using NGettext;

namespace CasaSoft.vrt.forms
{
    public partial class KmlUtilForm : FormBase
    {
        protected KmlLib kml;

        #region constructors and init
        /// <summary>
        /// Constructor
        /// </summary>
        public KmlUtilForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
            InitControls();
        }

        /// <summary>
        /// Controls bas init
        /// </summary>
        private void InitControls()
        {
            kml = null;

            // Localizable captions
            chkPlacemarks.Tag = catalog.GetString("Placemarks");
            chkPaths.Tag = catalog.GetString("Paths");
            chkPolys.Tag = catalog.GetString("Polygons");

            chkPlacemarks.Text = (string)chkPlacemarks.Tag;
            chkPaths.Text = (string)chkPaths.Tag;
            chkPolys.Text = (string)chkPolys.Tag;

            chkPlacemarks.Enabled = false;
            chkPaths.Enabled = false;
            chkPolys.Enabled = false;

            this.labelFile.Text = catalog.GetString("kml / kmz file");
            this.openFileDialog.Filter = catalog.GetString("Placemarks file (*.kml,*.kmz)|*.kml;*.kmz|All files|*.*");
            this.openFileDialog.Title = catalog.GetString("Select placemarks file");

        }
        #endregion

        #region open kml

        protected override void openFile()
        {
            string file = txtFile.Text;
            InitControls();
            if(!string.IsNullOrWhiteSpace(file))
            {
                try
                {
                    kml = new KmlLib(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(catalog.GetString("Error processing file '{0}':\n{1}", file, ex.Message));
                }
                
                if(kml != null)
                {
                    chkPlacemarks.Text = string.Format("{0} ({1})", chkPlacemarks.Tag, kml.CountPlacemarks());
                    if(kml.CountPlacemarks() > 0)
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
            }
        }
        #endregion

    }
}
