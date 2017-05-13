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
        }

        protected override void AfterFileOpenerChanged()
        {
            base.AfterFileOpenerChanged();
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
            base.doSave(filename);
            Converter conv = new Converter(outMode.R3Dlabels);

            string ret = conv.fileHead();
            ret += conv.fileBody(kml);
            conv.fileOut(ret, filename);
        }
        #endregion
    }
}
