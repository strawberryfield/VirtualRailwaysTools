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
using System.Threading;

namespace CasaSoft.vrt.forms
{
    /// <summary>
    /// Base class for all forms
    /// </summary>
    public partial class FormBase : Form
    {
        /// <summary>
        /// catalog of translations
        /// </summary>
        protected ICatalog catalog;

        /// <summary>
        /// Reference to main program assembly
        /// </summary>
        protected Assembly assembly;

        /// <summary>
        /// Locale to use for translations
        /// </summary>
        protected CultureInfo locale;

        /// <summary>
        /// name of the calling program
        /// </summary>
        protected string prgName;

        #region constructors and init
        /// <summary>
        /// Constructor (needed only for inheritance)
        /// </summary>
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

        /// <summary>
        /// Returns the main program description
        /// </summary>
        /// <returns></returns>
        public string getProgramTitle()
        {
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            return string.Format("{0} v.{1}.{2}",
                versionInfo.FileDescription, versionInfo.ProductMajorPart, versionInfo.ProductMinorPart);
        }
        #endregion

        #region balloons
        /// <summary>
        /// displays a notification in a popup balloon
        /// </summary>
        /// <param name="body"></param>
        public void Balloon(string body)
        {
            NotifyIcon notification = new NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipIcon = ToolTipIcon.Info,
                BalloonTipTitle = prgName,
                BalloonTipText = body,
            };

            // Display for 5 seconds.
            notification.ShowBalloonTip(5);

            Thread.Sleep(10000);
            notification.Dispose();
        }
        #endregion
    }
}
