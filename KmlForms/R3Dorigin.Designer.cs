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
            this.lblZone = new System.Windows.Forms.Label();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.txtX.Location = new System.Drawing.Point(0, 114);
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
            this.Name = "R3Dorigin";
            this.Size = new System.Drawing.Size(310, 139);
            this.Controls.SetChildIndex(this.txtZone, 0);
            this.Controls.SetChildIndex(this.lblZone, 0);
            this.Controls.SetChildIndex(this.txtY, 0);
            this.Controls.SetChildIndex(this.lblY, 0);
            this.Controls.SetChildIndex(this.txtX, 0);
            this.Controls.SetChildIndex(this.lblX, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox txtY;
    }
}
