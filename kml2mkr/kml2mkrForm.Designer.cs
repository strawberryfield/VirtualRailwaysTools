// copyright (c) 2017,2019 Roberto Ceccarelli - CasaSoft
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
    partial class kml2mkrForm
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
            this.rdMkr = new System.Windows.Forms.RadioButton();
            this.rdFlyTo = new System.Windows.Forms.RadioButton();
            this.rdText = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(494, 245);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 245);
            // 
            // rdMkr
            // 
            this.rdMkr.AutoSize = true;
            this.rdMkr.Checked = true;
            this.rdMkr.Location = new System.Drawing.Point(12, 160);
            this.rdMkr.Name = "rdMkr";
            this.rdMkr.Size = new System.Drawing.Size(129, 17);
            this.rdMkr.TabIndex = 7;
            this.rdMkr.TabStop = true;
            this.rdMkr.Text = "Markers (MSTS *.mkr)";
            this.rdMkr.UseVisualStyleBackColor = true;
            // 
            // rdFlyTo
            // 
            this.rdFlyTo.AutoSize = true;
            this.rdFlyTo.Location = new System.Drawing.Point(12, 183);
            this.rdFlyTo.Name = "rdFlyTo";
            this.rdFlyTo.Size = new System.Drawing.Size(131, 17);
            this.rdFlyTo.TabIndex = 8;
            this.rdFlyTo.TabStop = true;
            this.rdFlyTo.Text = "FlyTo targets list (*.spt)";
            this.rdFlyTo.UseVisualStyleBackColor = true;
            // 
            // rdText
            // 
            this.rdText.AutoSize = true;
            this.rdText.Location = new System.Drawing.Point(12, 206);
            this.rdText.Name = "rdText";
            this.rdText.Size = new System.Drawing.Size(61, 17);
            this.rdText.TabIndex = 9;
            this.rdText.TabStop = true;
            this.rdText.Text = "Text list";
            this.rdText.UseVisualStyleBackColor = true;
            // 
            // kml2mkrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 277);
            this.Controls.Add(this.rdText);
            this.Controls.Add(this.rdFlyTo);
            this.Controls.Add(this.rdMkr);
            this.Name = "kml2mkrForm";
            this.Text = "kml2mkrForm";
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnAbout, 0);
            this.Controls.SetChildIndex(this.fileOpener, 0);
            this.Controls.SetChildIndex(this.ContentSelector, 0);
            this.Controls.SetChildIndex(this.rdMkr, 0);
            this.Controls.SetChildIndex(this.rdFlyTo, 0);
            this.Controls.SetChildIndex(this.rdText, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdMkr;
        private System.Windows.Forms.RadioButton rdFlyTo;
        private System.Windows.Forms.RadioButton rdText;
    }
}