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
    partial class R3Dorigin
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
            this.lblZone = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbKml
            // 
            this.cmbKml.Enabled = false;
            this.cmbKml.FormattingEnabled = true;
            this.cmbKml.Location = new System.Drawing.Point(3, 19);
            this.cmbKml.Name = "cmbKml";
            this.cmbKml.Size = new System.Drawing.Size(303, 21);
            this.cmbKml.TabIndex = 0;
            this.cmbKml.Validated += new System.EventHandler(this.cmbKml_Validated);
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
            this.txtLon.Location = new System.Drawing.Point(3, 66);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(113, 20);
            this.txtLon.TabIndex = 1;
            this.txtLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Location = new System.Drawing.Point(242, 50);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(57, 13);
            this.lblZone.TabIndex = 7;
            this.lblZone.Text = "UTM zone";
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(241, 66);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(65, 20);
            this.txtZone.TabIndex = 3;
            this.txtZone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtZone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(4, 98);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(72, 13);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "Rail3D X start";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(3, 114);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(113, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "20000";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(124, 98);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(72, 13);
            this.lblY.TabIndex = 9;
            this.lblY.Text = "Rail3D Y start";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(123, 114);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(113, 20);
            this.txtY.TabIndex = 5;
            this.txtY.Text = "20000";
            this.txtY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // R3Dorigin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.txtZone);
            this.Controls.Add(this.lblLon);
            this.Controls.Add(this.txtLon);
            this.Controls.Add(this.lblLat);
            this.Controls.Add(this.txtLat);
            this.Controls.Add(this.lblKml);
            this.Controls.Add(this.cmbKml);
            this.Name = "R3Dorigin";
            this.Size = new System.Drawing.Size(310, 139);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKml;
        private System.Windows.Forms.Label lblKml;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.Label lblLat;
        private System.Windows.Forms.Label lblLon;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
    }
}
