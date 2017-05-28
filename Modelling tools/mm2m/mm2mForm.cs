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

using CasaSoft.vrt.forms;
using System;
using System.Globalization;
using System.Reflection;
using System.IO;

namespace CasaSoft.vrt.Modelling
{
    public partial class mm2mForm : FormBase
    {
        private string converted;

        #region constructors and init
        public mm2mForm()
        {
            InitializeComponent();
        }

        public mm2mForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
            Text = getProgramTitle();
        }

        /// <summary>
        /// Controls bas init
        /// </summary>
        private void InitControls()
        {
            this.fileOpener.LabelText = catalog.GetString("stc file");
            this.fileOpener.ButtonText = catalog.GetString("Open");
            this.fileOpener.FileDialogFilter = catalog.GetString("Rail3D Model (*.stc)|*.stc|All files|*.*");
            this.fileOpener.FileDialogTitle = catalog.GetString("Select model");
        }

        private void mm2mForm_Shown(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                InitControls();
            }
        }
        #endregion

        #region save
        /// <summary>
        /// Save dialog init
        /// </summary>
        protected override void initSaveDlg()
        {
            base.initSaveDlg();
            saveFileDialog.Title = catalog.GetString("Save converted model");
            saveFileDialog.Filter = catalog.GetString("Rail3D Model (*.stc)|*.stc|All files|*.*");
            saveFileDialog.DefaultExt = ".stc";

        }

        /// <summary>
        /// Save dirty work
        /// </summary>
        /// <param name="filename">File to save on</param>
        protected override void doSave(string filename)
        {
            base.doSave(filename);
            using (StreamWriter file = new StreamWriter(filename))
            {
                file.WriteLine(converted);
            }
        }
        #endregion

        private void fileOpener_FileTextChanged(object sender, EventArgs e)
        {
            mm2mConverter conv = new mm2mConverter();
            converted = conv.Metric(fileOpener.FileName);
        }
    }
}
