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
            this.KmlFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chkPlacemarks = new System.Windows.Forms.CheckBox();
            this.chkPaths = new System.Windows.Forms.CheckBox();
            this.chkPolys = new System.Windows.Forms.CheckBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KmlFile
            // 
            this.KmlFile.AllowDrop = true;
            this.KmlFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KmlFile.Location = new System.Drawing.Point(12, 31);
            this.KmlFile.Name = "KmlFile";
            this.KmlFile.Size = new System.Drawing.Size(476, 20);
            this.KmlFile.TabIndex = 0;
            this.KmlFile.TextChanged += new System.EventHandler(this.KmlFile_TextChanged);
            this.KmlFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.KmlFile_DragDrop);
            this.KmlFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.KmlFile_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "kml / kmz file";
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(494, 31);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(85, 20);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "kml";
            this.openFileDialog.Filter = "Placemarks file (*.kml,*.kmz)|*.kml;*.kmz|All files|*.*";
            this.openFileDialog.Title = "Select placemarks file";
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
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(494, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 20);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // KmlUtilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chkPolys);
            this.Controls.Add(this.chkPaths);
            this.Controls.Add(this.chkPlacemarks);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KmlFile);
            this.Name = "KmlUtilForm";
            this.Text = "kml2mkr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox KmlFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        protected System.Windows.Forms.CheckBox chkPlacemarks;
        protected System.Windows.Forms.CheckBox chkPaths;
        protected System.Windows.Forms.CheckBox chkPolys;
        protected System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnSave;
    }
}