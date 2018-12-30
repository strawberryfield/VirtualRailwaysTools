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
    partial class kmlContentSelector
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkPlacemarks = new System.Windows.Forms.CheckBox();
            this.chkPaths = new System.Windows.Forms.CheckBox();
            this.chkPolys = new System.Windows.Forms.CheckBox();
            this.chkTracks = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkPlacemarks
            // 
            this.chkPlacemarks.AutoSize = true;
            this.chkPlacemarks.Location = new System.Drawing.Point(3, 3);
            this.chkPlacemarks.Name = "chkPlacemarks";
            this.chkPlacemarks.Size = new System.Drawing.Size(81, 17);
            this.chkPlacemarks.TabIndex = 0;
            this.chkPlacemarks.Tag = "Placemarks";
            this.chkPlacemarks.Text = "Placemarks";
            this.chkPlacemarks.UseVisualStyleBackColor = true;
            // 
            // chkPaths
            // 
            this.chkPaths.AutoSize = true;
            this.chkPaths.Location = new System.Drawing.Point(3, 26);
            this.chkPaths.Name = "chkPaths";
            this.chkPaths.Size = new System.Drawing.Size(53, 17);
            this.chkPaths.TabIndex = 1;
            this.chkPaths.Tag = "Paths";
            this.chkPaths.Text = "Paths";
            this.chkPaths.UseVisualStyleBackColor = true;
            // 
            // chkPolys
            // 
            this.chkPolys.AutoSize = true;
            this.chkPolys.Location = new System.Drawing.Point(3, 49);
            this.chkPolys.Name = "chkPolys";
            this.chkPolys.Size = new System.Drawing.Size(69, 17);
            this.chkPolys.TabIndex = 2;
            this.chkPolys.Tag = "Polygons";
            this.chkPolys.Text = "Polygons";
            this.chkPolys.UseVisualStyleBackColor = true;
            // 
            // chkTracks
            // 
            this.chkTracks.AutoSize = true;
            this.chkTracks.Location = new System.Drawing.Point(3, 72);
            this.chkTracks.Name = "chkTracks";
            this.chkTracks.Size = new System.Drawing.Size(59, 17);
            this.chkTracks.TabIndex = 3;
            this.chkTracks.Tag = "Tracks";
            this.chkTracks.Text = "Tracks";
            this.chkTracks.UseVisualStyleBackColor = true;
            // 
            // kmlContentSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkTracks);
            this.Controls.Add(this.chkPolys);
            this.Controls.Add(this.chkPaths);
            this.Controls.Add(this.chkPlacemarks);
            this.Name = "kmlContentSelector";
            this.Size = new System.Drawing.Size(150, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPlacemarks;
        private System.Windows.Forms.CheckBox chkPaths;
        private System.Windows.Forms.CheckBox chkPolys;
        private System.Windows.Forms.CheckBox chkTracks;
    }
}
