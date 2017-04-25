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
            this.chkPlacemarks = new System.Windows.Forms.CheckBox();
            this.chkPaths = new System.Windows.Forms.CheckBox();
            this.chkPolys = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkPlacemarks
            // 
            this.chkPlacemarks.AutoSize = true;
            this.chkPlacemarks.Location = new System.Drawing.Point(12, 67);
            this.chkPlacemarks.Name = "chkPlacemarks";
            this.chkPlacemarks.Size = new System.Drawing.Size(81, 17);
            this.chkPlacemarks.TabIndex = 3;
            this.chkPlacemarks.Tag = "Placemarks";
            this.chkPlacemarks.Text = "Placemarks";
            this.chkPlacemarks.UseVisualStyleBackColor = true;
            // 
            // chkPaths
            // 
            this.chkPaths.AutoSize = true;
            this.chkPaths.Location = new System.Drawing.Point(12, 90);
            this.chkPaths.Name = "chkPaths";
            this.chkPaths.Size = new System.Drawing.Size(53, 17);
            this.chkPaths.TabIndex = 4;
            this.chkPaths.Tag = "Paths";
            this.chkPaths.Text = "Paths";
            this.chkPaths.UseVisualStyleBackColor = true;
            // 
            // chkPolys
            // 
            this.chkPolys.AutoSize = true;
            this.chkPolys.Location = new System.Drawing.Point(12, 113);
            this.chkPolys.Name = "chkPolys";
            this.chkPolys.Size = new System.Drawing.Size(69, 17);
            this.chkPolys.TabIndex = 5;
            this.chkPolys.Tag = "Polygons";
            this.chkPolys.Text = "Polygons";
            this.chkPolys.UseVisualStyleBackColor = true;
            // 
            // KmlUtilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.chkPolys);
            this.Controls.Add(this.chkPaths);
            this.Controls.Add(this.chkPlacemarks);
            this.Name = "KmlUtilForm";
            this.Text = "KmlUtilForm";
            this.Controls.SetChildIndex(this.chkPlacemarks, 0);
            this.Controls.SetChildIndex(this.chkPaths, 0);
            this.Controls.SetChildIndex(this.chkPolys, 0);
            this.Controls.SetChildIndex(this.txtFile, 0);
            this.Controls.SetChildIndex(this.labelFile, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.CheckBox chkPlacemarks;
        protected System.Windows.Forms.CheckBox chkPaths;
        protected System.Windows.Forms.CheckBox chkPolys;
    }
}