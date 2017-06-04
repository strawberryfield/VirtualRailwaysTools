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
using System.Reflection;
using System.Globalization;

namespace CasaSoft.vrt.forms
{
    /// <summary>
    /// Base form for kml utilities
    /// </summary>
    public partial class KmlBaseForm : FileOpenerForm
    {
        /// <summary>
        /// Instance of <see cref="T:CasaSoft.vrt.KmlLib.KmlLib"/>
        /// </summary>
        protected KmlLib.KmlLib kml;

        #region constructors and init
        /// <summary>
        /// Constructor (needed only for inheritance)
        /// </summary>
        public KmlBaseForm() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="program">Reference to main program assembly</param>
        /// <param name="locale">loacle for translations</param>
        public KmlBaseForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Controls basic init
        /// </summary>
        private void InitControls()
        {
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

        protected override void doOpenFile()
        {
            string file = fileOpener.FileName;
            kml = null;
            InitControls();
            if (!string.IsNullOrWhiteSpace(file))
            {
                try
                {
                    kml = new KmlLib.KmlLib(file);
                }
                catch (Exception ex)
                {
                    Balloon(catalog.GetString("Error processing file '{0}':\n{1}", file, ex.Message));
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
