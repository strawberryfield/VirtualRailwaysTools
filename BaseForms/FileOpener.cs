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
using System.ComponentModel;
using System.Windows.Forms;

namespace CasaSoft.vrt.forms
{
    public partial class FileOpener : UserControl
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FileOpener()
        {
            InitializeComponent();
        }

        #region properties
        /// <summary>
        /// Text displayed on the button
        /// </summary>
        [Description("Text displayed on the button"), Category()]
        public string ButtonText
        {
            get { return button.Text; }
            set { button.Text = value; }
        }

        /// <summary>
        /// Text displayed on the label
        /// </summary>
        [Description("Text displayed on the label"), Category()]
        public string LabelText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        /// <summary>
        /// Filter for file dialog
        /// </summary>
        [Description("Filter for file dialog"), Category()]
        public string FileDialogFilter
        {
            get { return openFileDialog.Filter; }
            set { openFileDialog.Filter = value; }
        }

        /// <summary>
        /// Title for file dialog
        /// </summary>
        [Description("Title for file dialog"), Category()]
        public string FileDialogTitle
        {
            get { return openFileDialog.Title; }
            set { openFileDialog.Title = value; }
        }

        /// <summary>
        /// File name
        /// </summary>
        [Description("File name"), Category()]
        public string FileName
        {
            get { return txtFile.Text; }
            set { txtFile.Text = value; }
        }
        #endregion

        #region events
        /// <summary>
        /// Fired on TextChanged in the textbox
        /// </summary>
        [Description("Fired on TextChanged in the textbox"), Category()]
        public event EventHandler FileTextChanged;

        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            if (this.FileTextChanged != null)
                this.FileTextChanged(this, e);
        }
        #endregion

        #region file management
        private void button_Click(object sender, EventArgs e)
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
        #endregion

    }
}
