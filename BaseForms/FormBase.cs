﻿// copyright (c) 2017 Roberto Ceccarelli - CasaSoft
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
    public partial class FormBase : Form
    {
        protected ICatalog catalog;
        protected Assembly assembly;
        protected string prgName;

        #region constructors and init
        /// <summary>
        /// Constructor
        /// </summary>
        public FormBase(Assembly program, CultureInfo locale)
        {
            // Get infos from assembly
            assembly = program;
            prgName = assembly.GetName().Name;

            // locales management
            catalog = new Catalog(prgName, "./locale", locale);

            InitializeComponent();
            InitControls();
        }

        /// <summary>
        /// Controls bas init
        /// </summary>
        private void InitControls()
        {
            this.labelFile.Text = catalog.GetString("File name");
            this.btnOpen.Text = catalog.GetString("Open");
            this.openFileDialog.Filter = catalog.GetString("File|*.*");
            this.openFileDialog.Title = catalog.GetString("Select file");
            this.btnSave.Text = catalog.GetString("Save");
        }
        #endregion

        #region open kml
        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog.ShowDialog();
            if (ret == DialogResult.OK)
            {
                txtFile.Text = openFileDialog.FileName;
            }
        }


        private void txtFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void txtFile_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                txtFile.Text = files[0];
            }
        }

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            openFile();
        }

        /// <summary>
        /// Virtual method for file opening
        /// </summary>
        protected virtual void openFile()
        {
            // Nothing to do
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

    }
}