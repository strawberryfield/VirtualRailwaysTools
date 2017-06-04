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

namespace CasaSoft.vrt.Modeling
{
    partial class stForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileOpener = new CasaSoft.vrt.forms.FileOpener();
            this.SuspendLayout();
            // 
            // fileOpener
            // 
            this.fileOpener.ButtonText = "Open";
            this.fileOpener.FileDialogFilter = "";
            this.fileOpener.FileDialogTitle = "";
            this.fileOpener.FileName = "";
            this.fileOpener.LabelText = "File name";
            this.fileOpener.Location = new System.Drawing.Point(12, 12);
            this.fileOpener.Name = "fileOpener";
            this.fileOpener.Size = new System.Drawing.Size(567, 38);
            this.fileOpener.TabIndex = 8;
            this.fileOpener.FileTextChanged += new System.EventHandler(this.fileOpener_FileTextChanged);
            // 
            // stForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.fileOpener);
            this.Name = "stForm";
            this.Text = "stForm";
            this.Shown += new System.EventHandler(this.stForm_Shown);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnAbout, 0);
            this.Controls.SetChildIndex(this.fileOpener, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private forms.FileOpener fileOpener;
    }
}