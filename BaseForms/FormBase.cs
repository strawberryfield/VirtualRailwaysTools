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
using System.Diagnostics;
using NGettext;

namespace CasaSoft.vrt.forms
{
    public partial class FormBase : Form
    {
        protected ICatalog catalog;
        protected Assembly assembly;
        protected CultureInfo locale;
        protected string prgName;

        #region constructors and init
        public FormBase() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public FormBase(Assembly program, CultureInfo locale)
        {
            // Get infos from assembly
            assembly = program;
            prgName = assembly.GetName().Name;

            // locales management
            this.locale = locale;
            catalog = new Catalog(prgName, "./locale", locale);

            InitializeComponent();
            InitControls();
        }

        /// <summary>
        /// Controls bas init
        /// </summary>
        private void InitControls()
        {
            this.btnSave.Text = catalog.GetString("Save");
        }
        #endregion

        #region save
        private void btnSave_Click(object sender, EventArgs e)
        {
            initSaveDlg();
            saveFileDialog.ShowDialog();
        }

        /// <summary>
        /// Vitual method for custom save dialog
        /// </summary>
        protected virtual void initSaveDlg()
        {
            // nothig to do
        }

        private void saveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string name = saveFileDialog.FileName;
            doSave(name);
        }

        /// <summary>
        /// Virtual method for save dirty work
        /// </summary>
        /// <param name="filename">File to save</param>
        protected virtual void doSave(string filename)
        {
            // nothing to do
        }
        #endregion

        #region program info
        /// <summary>
        /// Show the About Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox box = new AboutBox(assembly, locale);
            box.ShowDialog();
        }

        public string getProgramTitle()
        {
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return string.Format("{0} v.{1}.{2}",
                versionInfo.FileDescription, versionInfo.ProductMajorPart, versionInfo.ProductMinorPart);
        }
        #endregion
    }
}
