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
    partial class KmlPoint
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
            this.cmbKml = new System.Windows.Forms.ComboBox();
            this.lblKml = new System.Windows.Forms.Label();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.lblLat = new System.Windows.Forms.Label();
            this.lblLon = new System.Windows.Forms.Label();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbKml
            // 
            this.cmbKml.Enabled = false;
            this.cmbKml.FormattingEnabled = true;
            this.cmbKml.Location = new System.Drawing.Point(0, 19);
            this.cmbKml.Name = "cmbKml";
            this.cmbKml.Size = new System.Drawing.Size(236, 21);
            this.cmbKml.TabIndex = 0;
            this.cmbKml.SelectionChangeCommitted += new System.EventHandler(this.cmbKml_SelectionChangeCommitted);
            // 
            // lblKml
            // 
            this.lblKml.AutoSize = true;
            this.lblKml.Location = new System.Drawing.Point(4, 3);
            this.lblKml.Name = "lblKml";
            this.lblKml.Size = new System.Drawing.Size(79, 13);
            this.lblKml.TabIndex = 1;
            this.lblKml.Text = "Select from kml";
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(123, 66);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(113, 20);
            this.txtLat.TabIndex = 2;
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // lblLat
            // 
            this.lblLat.AutoSize = true;
            this.lblLat.Location = new System.Drawing.Point(124, 50);
            this.lblLat.Name = "lblLat";
            this.lblLat.Size = new System.Drawing.Size(45, 13);
            this.lblLat.TabIndex = 3;
            this.lblLat.Text = "Latitude";
            // 
            // lblLon
            // 
            this.lblLon.AutoSize = true;
            this.lblLon.Location = new System.Drawing.Point(4, 50);
            this.lblLon.Name = "lblLon";
            this.lblLon.Size = new System.Drawing.Size(54, 13);
            this.lblLon.TabIndex = 5;
            this.lblLon.Text = "Longitude";
            // 
            // txtLon
            // 
            this.txtLon.Location = new System.Drawing.Point(0, 66);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(113, 20);
            this.txtLon.TabIndex = 1;
            this.txtLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // KmlPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLon);
            this.Controls.Add(this.txtLon);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.lblKml);
            this.Controls.Add(this.cmbKml);
            this.Name = "KmlPoint";
            this.Size = new System.Drawing.Size(238, 88);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ComboBox cmbKml;
        protected System.Windows.Forms.TextBox txtLat;
        protected System.Windows.Forms.TextBox txtLon;
        protected System.Windows.Forms.Label lblKml;
        protected System.Windows.Forms.Label lblLat;
        protected System.Windows.Forms.Label lblLon;
    }
}
