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

namespace CasaSoft.vrt.forms
{
    public partial class kml2mkrForm : KmlUtilForm
    {
        public kml2mkrForm() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public kml2mkrForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
            Text = getProgramTitle();
            InitControls();
        }

        /// <summary>
        /// Components initialization
        /// </summary>
        private void InitControls()
        {
            // localizable strings
            this.rdMkr.Text = catalog.GetString("Markers (MSTS *.mkr)");
            this.rdFlyTo.Text = catalog.GetString("FlyTo targets list (*.spt)");
            this.rdText.Text = catalog.GetString("Text list");
        }

        /// <summary>
        /// Save dialog init
        /// </summary>
        protected override void initSaveDlg()
        {
            base.initSaveDlg();
            if(rdMkr.Checked)
            {
                saveFileDialog.Title = catalog.GetString("Create MSTS markes file");
                saveFileDialog.Filter = catalog.GetString("Markers file (*.mkr)|*.mkr|All files|*.*");
                saveFileDialog.DefaultExt = ".mkr";
            }
            else if(rdFlyTo.Checked)
            {
                saveFileDialog.Title = catalog.GetString("Create FlyTo targets list");
                saveFileDialog.Filter = catalog.GetString("FlyTo targets list (*.spt)|*.spt|All files|*.*");
                saveFileDialog.DefaultExt = ".spt";
            }
            else
            {
                saveFileDialog.Title = catalog.GetString("Create text list");
                saveFileDialog.Filter = catalog.GetString("Text file (*.txt)|*.txt|All files|*.*");
                saveFileDialog.DefaultExt = ".txt";
            }
        }

        /// <summary>
        /// Save dirty work
        /// </summary>
        /// <param name="filename">File to save on</param>
        protected override void doSave(string filename)
        {
            base.doSave(filename);
            string mode = "";
            if (rdMkr.Checked)
            {
                mode = "MKR";
            }
            else if (rdFlyTo.Checked)
            {
                mode = "FLYTO";
            }

            MSTSConverterFactory factory = new MSTSConverterFactory();
            IConverter conv = factory.GetConverter(mode);

            string ret = conv.FileHeader();
            conv.SetKml(kml);
            ret += conv.PlacemarkBody();
            ret += conv.PathBody();
            ret += conv.PolyBody();
            conv.FileOut(ret, filename);
        }

    }
}
