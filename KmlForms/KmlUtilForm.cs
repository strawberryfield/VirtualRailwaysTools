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

namespace CasaSoft.vrt.forms
{
    public partial class KmlUtilForm : Form
    {
        protected KmlLib kml;

        #region constructors and init
        /// <summary>
        /// Constructor
        /// </summary>
        public KmlUtilForm()
        {
            InitializeComponent();
            InitControls();
        }

        /// <summary>
        /// Controls bas init
        /// </summary>
        protected virtual void InitControls()
        {
            kml = null;

            chkPlacemarks.Text = (string)chkPlacemarks.Tag;
            chkPaths.Text = (string)chkPaths.Tag;
            chkPolys.Text = (string)chkPolys.Tag;

            chkPlacemarks.Enabled = false;
            chkPaths.Enabled = false;
            chkPolys.Enabled = false;
        }
        #endregion

        #region open kml
        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult ret = openFileDialog.ShowDialog();
            if(ret == DialogResult.OK)
            {
                KmlFile.Text = openFileDialog.FileName;
            }
        }


        private void KmlFile_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void KmlFile_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                KmlFile.Text = files[0];
            }
        }

        private void KmlFile_TextChanged(object sender, EventArgs e)
        {
            string file = KmlFile.Text;
            InitControls();
            if(!string.IsNullOrWhiteSpace(file))
            {
                try
                {
                    kml = new KmlLib(file);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error processing file '{0}':\n{1}", file, ex.Message));
                }
                
                if(kml != null)
                {
                    chkPlacemarks.Text = string.Format("{0} ({1})", chkPlacemarks.Tag, kml.CountPlacemarks());
                    if(kml.CountPlacemarks() > 0)
                    {
                        chkPlacemarks.Enabled = true;
                    }
                    chkPaths.Text = string.Format("{0} ({1})", chkPaths.Tag, kml.CountPaths());
                    if (kml.CountPaths() > 0)
                    {
                        chkPaths.Enabled = true;
                    }
                    chkPolys.Text = string.Format("{0} ({1})", chkPolys.Tag, kml.CountPolys());
                    if (kml.CountPolys() > 0)
                    {
                        chkPolys.Enabled = true;
                    }
                }
            }
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
