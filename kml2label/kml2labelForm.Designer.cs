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
    partial class kml2labelForm
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
            this.R3Dorigin = new CasaSoft.vrt.forms.R3Dorigin();
            this.btnClip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(494, 291);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 291);
            // 
            // R3Dorigin
            // 
            this.R3Dorigin.Location = new System.Drawing.Point(12, 130);
            this.R3Dorigin.Name = "R3Dorigin";
            this.R3Dorigin.Size = new System.Drawing.Size(312, 152);
            this.R3Dorigin.TabIndex = 10;
            // 
            // btnClip
            // 
            this.btnClip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClip.Location = new System.Drawing.Point(403, 291);
            this.btnClip.Name = "btnClip";
            this.btnClip.Size = new System.Drawing.Size(85, 20);
            this.btnClip.TabIndex = 11;
            this.btnClip.Text = "Clipboard";
            this.btnClip.UseVisualStyleBackColor = true;
            this.btnClip.Click += new System.EventHandler(this.btnClip_Click);
            // 
            // kml2labelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 323);
            this.Controls.Add(this.btnClip);
            this.Controls.Add(this.R3Dorigin);
            this.Name = "kml2labelForm";
            this.Text = "kml2labelForm";
            this.Shown += new System.EventHandler(this.kml2labelForm_Shown);
            this.Controls.SetChildIndex(this.fileOpener, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnAbout, 0);
            this.Controls.SetChildIndex(this.ContentSelector, 0);
            this.Controls.SetChildIndex(this.R3Dorigin, 0);
            this.Controls.SetChildIndex(this.btnClip, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private R3Dorigin R3Dorigin;
        private System.Windows.Forms.Button btnClip;
    }
}