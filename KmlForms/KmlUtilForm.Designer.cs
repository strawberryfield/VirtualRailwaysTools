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

namespace CasaSoft.vrt.forms
{
    partial class KmlUtilForm
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
            this.ContentSelector = new CasaSoft.vrt.forms.kmlContentSelector();
            this.fileOpener = new CasaSoft.vrt.forms.FileOpener();
            this.SuspendLayout();
            // 
            // ContentSelector
            // 
            this.ContentSelector.Location = new System.Drawing.Point(12, 57);
            this.ContentSelector.Name = "ContentSelector";
            this.ContentSelector.Size = new System.Drawing.Size(147, 67);
            this.ContentSelector.TabIndex = 8;
            // 
            // fileOpener
            // 
            this.fileOpener.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileOpener.ButtonText = "Open";
            this.fileOpener.FileDialogFilter = "";
            this.fileOpener.FileDialogTitle = "";
            this.fileOpener.FileName = "";
            this.fileOpener.LabelText = "File name";
            this.fileOpener.Location = new System.Drawing.Point(12, 13);
            this.fileOpener.Name = "fileOpener";
            this.fileOpener.Size = new System.Drawing.Size(567, 38);
            this.fileOpener.TabIndex = 9;
            this.fileOpener.FileTextChanged += new System.EventHandler(this.fileOpener_FileTextChanged);
            // 
            // KmlUtilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 271);
            this.Controls.Add(this.fileOpener);
            this.Controls.Add(this.ContentSelector);
            this.Name = "KmlUtilForm";
            this.Text = "KmlUtilForm";
            this.Shown += new System.EventHandler(this.KmlUtilForm_Shown);
            this.Controls.SetChildIndex(this.ContentSelector, 0);
            this.Controls.SetChildIndex(this.fileOpener, 0);
            this.ResumeLayout(false);

        }

        #endregion

        protected kmlContentSelector ContentSelector;
        private FileOpener fileOpener;
    }
}