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
using System.IO;
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using System.Diagnostics;
using NGettext;

namespace CasaSoft.vrt.forms
{
    /// <summary>
    /// About box dialog
    /// </summary>
    public partial class AboutBox : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="program"></param>
        /// <param name="locale"></param>
        public AboutBox(Assembly program, CultureInfo locale)
        {
            InitializeComponent();

            string prgName = program.GetName().Name;
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(program.Location);
            ICatalog catalog = new Catalog(prgName, "./locale", locale);

            Text = catalog.GetString("About {0}", versionInfo.FileDescription);
            labelProgramName.Text = versionInfo.FileDescription;
            labelCopyright.Text = versionInfo.LegalCopyright;
            labelVersion.Text = catalog.GetString("version {0}.{1}", versionInfo.ProductMajorPart, versionInfo.ProductMinorPart);
            labelLicense.Text = catalog.GetString("License info");
            labelDesc.Text = versionInfo.Comments;
            labelProduct.Text = versionInfo.ProductName;

            // get license text
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "CasaSoft.vrt.forms.Resources.LICENSE.txt";
            //string[] risorse = assembly.GetManifestResourceNames();

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                txtLicense.Text = reader.ReadToEnd();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
