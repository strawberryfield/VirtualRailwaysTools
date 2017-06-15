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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSD = new System.Windows.Forms.TabPage();
            this.tabENG = new System.Windows.Forms.TabPage();
            this.numSdDetail = new System.Windows.Forms.NumericUpDown();
            this.lblSdDetail = new System.Windows.Forms.Label();
            this.cmbSdTexture = new System.Windows.Forms.ComboBox();
            this.lblSdTexture = new System.Windows.Forms.Label();
            this.tabRef = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.tabSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSdDetail)).BeginInit();
            this.SuspendLayout();
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
            this.fileOpener.Location = new System.Drawing.Point(12, 12);
            this.fileOpener.Name = "fileOpener";
            this.fileOpener.Size = new System.Drawing.Size(567, 38);
            this.fileOpener.TabIndex = 8;
            this.fileOpener.FileTextChanged += new System.EventHandler(this.fileOpener_FileTextChanged);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSD);
            this.tabControl.Controls.Add(this.tabENG);
            this.tabControl.Controls.Add(this.tabRef);
            this.tabControl.Location = new System.Drawing.Point(12, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(567, 161);
            this.tabControl.TabIndex = 9;
            // 
            // tabSD
            // 
            this.tabSD.Controls.Add(this.lblSdTexture);
            this.tabSD.Controls.Add(this.cmbSdTexture);
            this.tabSD.Controls.Add(this.lblSdDetail);
            this.tabSD.Controls.Add(this.numSdDetail);
            this.tabSD.Location = new System.Drawing.Point(4, 22);
            this.tabSD.Name = "tabSD";
            this.tabSD.Padding = new System.Windows.Forms.Padding(3);
            this.tabSD.Size = new System.Drawing.Size(559, 135);
            this.tabSD.TabIndex = 0;
            this.tabSD.Text = "SD";
            this.tabSD.UseVisualStyleBackColor = true;
            // 
            // tabENG
            // 
            this.tabENG.Location = new System.Drawing.Point(4, 22);
            this.tabENG.Name = "tabENG";
            this.tabENG.Padding = new System.Windows.Forms.Padding(3);
            this.tabENG.Size = new System.Drawing.Size(559, 135);
            this.tabENG.TabIndex = 1;
            this.tabENG.Text = "Eng / Wag";
            this.tabENG.UseVisualStyleBackColor = true;
            // 
            // numSdDetail
            // 
            this.numSdDetail.Location = new System.Drawing.Point(6, 24);
            this.numSdDetail.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numSdDetail.Name = "numSdDetail";
            this.numSdDetail.Size = new System.Drawing.Size(60, 20);
            this.numSdDetail.TabIndex = 0;
            this.numSdDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSdDetail
            // 
            this.lblSdDetail.AutoSize = true;
            this.lblSdDetail.Location = new System.Drawing.Point(3, 8);
            this.lblSdDetail.Name = "lblSdDetail";
            this.lblSdDetail.Size = new System.Drawing.Size(63, 13);
            this.lblSdDetail.TabIndex = 1;
            this.lblSdDetail.Text = "Detail Level";
            // 
            // cmbSdTexture
            // 
            this.cmbSdTexture.FormattingEnabled = true;
            this.cmbSdTexture.Location = new System.Drawing.Point(91, 24);
            this.cmbSdTexture.Name = "cmbSdTexture";
            this.cmbSdTexture.Size = new System.Drawing.Size(175, 21);
            this.cmbSdTexture.TabIndex = 2;
            // 
            // lblSdTexture
            // 
            this.lblSdTexture.AutoSize = true;
            this.lblSdTexture.Location = new System.Drawing.Point(88, 8);
            this.lblSdTexture.Name = "lblSdTexture";
            this.lblSdTexture.Size = new System.Drawing.Size(96, 13);
            this.lblSdTexture.TabIndex = 3;
            this.lblSdTexture.Text = "Alternative Texture";
            // 
            // tabRef
            // 
            this.tabRef.Location = new System.Drawing.Point(4, 22);
            this.tabRef.Name = "tabRef";
            this.tabRef.Padding = new System.Windows.Forms.Padding(3);
            this.tabRef.Size = new System.Drawing.Size(559, 135);
            this.tabRef.TabIndex = 2;
            this.tabRef.Text = "Ref";
            this.tabRef.UseVisualStyleBackColor = true;
            // 
            // stForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 261);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.fileOpener);
            this.Name = "stForm";
            this.Text = "stForm";
            this.Shown += new System.EventHandler(this.stForm_Shown);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnAbout, 0);
            this.Controls.SetChildIndex(this.fileOpener, 0);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.tabControl.ResumeLayout(false);
            this.tabSD.ResumeLayout(false);
            this.tabSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSdDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private forms.FileOpener fileOpener;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSD;
        private System.Windows.Forms.TabPage tabENG;
        private System.Windows.Forms.Label lblSdTexture;
        private System.Windows.Forms.ComboBox cmbSdTexture;
        private System.Windows.Forms.Label lblSdDetail;
        private System.Windows.Forms.NumericUpDown numSdDetail;
        private System.Windows.Forms.TabPage tabRef;
    }
}