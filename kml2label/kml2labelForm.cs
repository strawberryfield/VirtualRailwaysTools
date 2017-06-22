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

using System.Reflection;
using System.Globalization;
using CasaSoft.vrt.KmlLib;
using System.Windows.Forms;

namespace CasaSoft.vrt.forms
{
    public partial class kml2labelForm : KmlUtilForm
    {
        public kml2labelForm()
        {
            InitializeComponent();
        }

        public kml2labelForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
            Text = getProgramTitle();
            btnClip.Text = catalog.GetString("Clipboard");
            btnClip.Enabled = false;
        }

        protected override void AfterFileOpenerChanged()
        {
            base.AfterFileOpenerChanged();
            btnClip.Enabled = true;
            R3Dorigin.SetKml(kml);
        }

        private void kml2labelForm_Shown(object sender, System.EventArgs e)
        {
            if (!this.DesignMode)
            {
                R3Dorigin.setLocale(catalog);
            }

        }

        #region save
        /// <summary>
        /// Save dialog init
        /// </summary>
        protected override void initSaveDlg()
        {
            base.initSaveDlg();
            saveFileDialog.Title = catalog.GetString("Create Rail3D labels file");
            saveFileDialog.Filter = catalog.GetString("Text file (*.txt)|*.txt|All files|*.*");
            saveFileDialog.DefaultExt = ".txt";

        }

        /// <summary>
        /// Save dirty work
        /// </summary>
        /// <param name="filename">File to save on</param>
        protected override void doSave(string filename)
        {
            R3dCoordsConverter R3Dconv = R3Dorigin.CoordsConverter();
            if(R3Dconv != null)
            {
                base.doSave(filename);
                IR3DConverter conv = getConv(R3Dconv);
                conv.FileOut(GetResult(conv), filename);
            }
        }

        private void btnClip_Click(object sender, System.EventArgs e)
        {
            R3dCoordsConverter R3Dconv = R3Dorigin.CoordsConverter();
            if (R3Dconv != null)
            {
                Clipboard.SetDataObject(GetResult(getConv(R3Dconv)));
                Balloon(catalog.GetString("Data copied to Clipboard."));
            }
        }

        private IR3DConverter getConv(R3dCoordsConverter R3Dconv)
        {
            R3DConverterFactory factory = new R3DConverterFactory();
            IR3DConverter conv = factory.GetConverter("LABEL");
            conv.SetKml(kml);
            conv.R3dConverter = R3Dconv;
            return conv;
        }
        #endregion
    }
}
