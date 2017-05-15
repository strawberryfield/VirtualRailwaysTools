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
    public partial class KmlBaseForm : FormBase
    {
        protected KmlLib kml;

        #region constructors and init
        public KmlBaseForm() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public KmlBaseForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controls bas init
        /// </summary>
        private void InitControls()
        {
            kml = null;

            this.fileOpener.LabelText = catalog.GetString("kml / kmz file");
            this.fileOpener.ButtonText = catalog.GetString("Open");
            this.fileOpener.FileDialogFilter = catalog.GetString("Placemarks file (*.kml,*.kmz)|*.kml;*.kmz|All files|*.*");
            this.fileOpener.FileDialogTitle = catalog.GetString("Select placemarks file");
        }

        private void KmlUtilForm_Shown(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                InitControls();
            }
        }
        #endregion

        #region open kml
        private void fileOpener_FileTextChanged(object sender, EventArgs e)
        {
            string file = fileOpener.FileName;
            InitControls();
            if (!string.IsNullOrWhiteSpace(file))
            {
                try
                {
                    kml = new KmlLib(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(catalog.GetString("Error processing file '{0}':\n{1}", file, ex.Message));
                }

                if (kml != null)
                {
                    AfterFileOpenerChanged();
                }
            }

        }

        /// <summary>
        /// Virtual method for extra inits
        /// </summary>
        protected virtual void AfterFileOpenerChanged()
        {
            // virtual;
        }
        #endregion

    }
}
