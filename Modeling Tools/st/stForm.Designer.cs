﻿// copyright (c) 2017 Roberto Ceccarelli - CasaSoft
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSD = new System.Windows.Forms.TabPage();
            this.lblBB = new System.Windows.Forms.Label();
            this.txtBB6 = new System.Windows.Forms.TextBox();
            this.txtBB5 = new System.Windows.Forms.TextBox();
            this.txtBB4 = new System.Windows.Forms.TextBox();
            this.txtBB3 = new System.Windows.Forms.TextBox();
            this.txtBB2 = new System.Windows.Forms.TextBox();
            this.txtBB1 = new System.Windows.Forms.TextBox();
            this.lblSdTexture = new System.Windows.Forms.Label();
            this.cmbSdTexture = new System.Windows.Forms.ComboBox();
            this.lblSdDetail = new System.Windows.Forms.Label();
            this.numSdDetail = new System.Windows.Forms.NumericUpDown();
            this.tabENG = new System.Windows.Forms.TabPage();
            this.tabRef = new System.Windows.Forms.TabPage();
            this.chkRefAppend = new System.Windows.Forms.CheckBox();
            this.lblRefDesc = new System.Windows.Forms.Label();
            this.lblRefClass = new System.Windows.Forms.Label();
            this.txtRefDesc = new System.Windows.Forms.TextBox();
            this.txtRefClass = new System.Windows.Forms.TextBox();
            this.cmbWagType = new System.Windows.Forms.ComboBox();
            this.lblWagType = new System.Windows.Forms.Label();
            this.lblEngType = new System.Windows.Forms.Label();
            this.cmbEngType = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabSD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSdDetail)).BeginInit();
            this.tabENG.SuspendLayout();
            this.tabRef.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileOpener
            // 
            this.fileOpener.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tabControl.Location = new System.Drawing.Point(16, 80);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(756, 198);
            this.tabControl.TabIndex = 9;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabSD
            // 
            this.tabSD.Controls.Add(this.lblBB);
            this.tabSD.Controls.Add(this.txtBB6);
            this.tabSD.Controls.Add(this.txtBB5);
            this.tabSD.Controls.Add(this.txtBB4);
            this.tabSD.Controls.Add(this.txtBB3);
            this.tabSD.Controls.Add(this.txtBB2);
            this.tabSD.Controls.Add(this.txtBB1);
            this.tabSD.Controls.Add(this.lblSdTexture);
            this.tabSD.Controls.Add(this.cmbSdTexture);
            this.tabSD.Controls.Add(this.lblSdDetail);
            this.tabSD.Controls.Add(this.numSdDetail);
            this.tabSD.Location = new System.Drawing.Point(4, 25);
            this.tabSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSD.Name = "tabSD";
            this.tabSD.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabSD.Size = new System.Drawing.Size(748, 169);
            this.tabSD.TabIndex = 0;
            this.tabSD.Text = "SD";
            this.tabSD.UseVisualStyleBackColor = true;
            // 
            // lblBB
            // 
            this.lblBB.AutoSize = true;
            this.lblBB.Location = new System.Drawing.Point(8, 70);
            this.lblBB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBB.Name = "lblBB";
            this.lblBB.Size = new System.Drawing.Size(95, 17);
            this.lblBB.TabIndex = 10;
            this.lblBB.Text = "Bounding Box";
            // 
            // txtBB6
            // 
            this.txtBB6.Location = new System.Drawing.Point(548, 90);
            this.txtBB6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBB6.Name = "txtBB6";
            this.txtBB6.Size = new System.Drawing.Size(99, 22);
            this.txtBB6.TabIndex = 9;
            this.txtBB6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBB6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // txtBB5
            // 
            this.txtBB5.Location = new System.Drawing.Point(440, 90);
            this.txtBB5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBB5.Name = "txtBB5";
            this.txtBB5.Size = new System.Drawing.Size(99, 22);
            this.txtBB5.TabIndex = 8;
            this.txtBB5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBB5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // txtBB4
            // 
            this.txtBB4.Location = new System.Drawing.Point(332, 90);
            this.txtBB4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBB4.Name = "txtBB4";
            this.txtBB4.Size = new System.Drawing.Size(99, 22);
            this.txtBB4.TabIndex = 7;
            this.txtBB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // txtBB3
            // 
            this.txtBB3.Location = new System.Drawing.Point(224, 90);
            this.txtBB3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBB3.Name = "txtBB3";
            this.txtBB3.Size = new System.Drawing.Size(99, 22);
            this.txtBB3.TabIndex = 6;
            this.txtBB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // txtBB2
            // 
            this.txtBB2.Location = new System.Drawing.Point(116, 90);
            this.txtBB2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBB2.Name = "txtBB2";
            this.txtBB2.Size = new System.Drawing.Size(99, 22);
            this.txtBB2.TabIndex = 5;
            this.txtBB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // txtBB1
            // 
            this.txtBB1.Location = new System.Drawing.Point(8, 90);
            this.txtBB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBB1.Name = "txtBB1";
            this.txtBB1.Size = new System.Drawing.Size(99, 22);
            this.txtBB1.TabIndex = 4;
            this.txtBB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeric_KeyPress);
            // 
            // lblSdTexture
            // 
            this.lblSdTexture.AutoSize = true;
            this.lblSdTexture.Location = new System.Drawing.Point(117, 10);
            this.lblSdTexture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSdTexture.Name = "lblSdTexture";
            this.lblSdTexture.Size = new System.Drawing.Size(127, 17);
            this.lblSdTexture.TabIndex = 3;
            this.lblSdTexture.Text = "Alternative Texture";
            // 
            // cmbSdTexture
            // 
            this.cmbSdTexture.FormattingEnabled = true;
            this.cmbSdTexture.Location = new System.Drawing.Point(121, 30);
            this.cmbSdTexture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbSdTexture.Name = "cmbSdTexture";
            this.cmbSdTexture.Size = new System.Drawing.Size(232, 24);
            this.cmbSdTexture.TabIndex = 2;
            // 
            // lblSdDetail
            // 
            this.lblSdDetail.AutoSize = true;
            this.lblSdDetail.Location = new System.Drawing.Point(4, 10);
            this.lblSdDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSdDetail.Name = "lblSdDetail";
            this.lblSdDetail.Size = new System.Drawing.Size(82, 17);
            this.lblSdDetail.TabIndex = 1;
            this.lblSdDetail.Text = "Detail Level";
            // 
            // numSdDetail
            // 
            this.numSdDetail.Location = new System.Drawing.Point(8, 30);
            this.numSdDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numSdDetail.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numSdDetail.Name = "numSdDetail";
            this.numSdDetail.Size = new System.Drawing.Size(80, 22);
            this.numSdDetail.TabIndex = 0;
            this.numSdDetail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabENG
            // 
            this.tabENG.Controls.Add(this.lblEngType);
            this.tabENG.Controls.Add(this.cmbEngType);
            this.tabENG.Controls.Add(this.lblWagType);
            this.tabENG.Controls.Add(this.cmbWagType);
            this.tabENG.Location = new System.Drawing.Point(4, 25);
            this.tabENG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabENG.Name = "tabENG";
            this.tabENG.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabENG.Size = new System.Drawing.Size(748, 169);
            this.tabENG.TabIndex = 1;
            this.tabENG.Text = "Eng / Wag";
            this.tabENG.UseVisualStyleBackColor = true;
            // 
            // tabRef
            // 
            this.tabRef.Controls.Add(this.chkRefAppend);
            this.tabRef.Controls.Add(this.lblRefDesc);
            this.tabRef.Controls.Add(this.lblRefClass);
            this.tabRef.Controls.Add(this.txtRefDesc);
            this.tabRef.Controls.Add(this.txtRefClass);
            this.tabRef.Location = new System.Drawing.Point(4, 25);
            this.tabRef.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRef.Name = "tabRef";
            this.tabRef.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabRef.Size = new System.Drawing.Size(748, 169);
            this.tabRef.TabIndex = 2;
            this.tabRef.Text = "Ref";
            this.tabRef.UseVisualStyleBackColor = true;
            // 
            // chkRefAppend
            // 
            this.chkRefAppend.AutoSize = true;
            this.chkRefAppend.Checked = true;
            this.chkRefAppend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRefAppend.Location = new System.Drawing.Point(8, 138);
            this.chkRefAppend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRefAppend.Name = "chkRefAppend";
            this.chkRefAppend.Size = new System.Drawing.Size(168, 21);
            this.chkRefAppend.TabIndex = 4;
            this.chkRefAppend.Text = "Append to existing file";
            this.chkRefAppend.UseVisualStyleBackColor = true;
            this.chkRefAppend.CheckedChanged += new System.EventHandler(this.chkRefAppend_CheckedChanged);
            // 
            // lblRefDesc
            // 
            this.lblRefDesc.AutoSize = true;
            this.lblRefDesc.Location = new System.Drawing.Point(8, 70);
            this.lblRefDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefDesc.Name = "lblRefDesc";
            this.lblRefDesc.Size = new System.Drawing.Size(79, 17);
            this.lblRefDesc.TabIndex = 3;
            this.lblRefDesc.Text = "Description";
            // 
            // lblRefClass
            // 
            this.lblRefClass.AutoSize = true;
            this.lblRefClass.Location = new System.Drawing.Point(8, 10);
            this.lblRefClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRefClass.Name = "lblRefClass";
            this.lblRefClass.Size = new System.Drawing.Size(42, 17);
            this.lblRefClass.TabIndex = 2;
            this.lblRefClass.Text = "Class";
            // 
            // txtRefDesc
            // 
            this.txtRefDesc.Location = new System.Drawing.Point(8, 90);
            this.txtRefDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRefDesc.Name = "txtRefDesc";
            this.txtRefDesc.Size = new System.Drawing.Size(521, 22);
            this.txtRefDesc.TabIndex = 1;
            // 
            // txtRefClass
            // 
            this.txtRefClass.Location = new System.Drawing.Point(8, 30);
            this.txtRefClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRefClass.Name = "txtRefClass";
            this.txtRefClass.Size = new System.Drawing.Size(211, 22);
            this.txtRefClass.TabIndex = 0;
            // 
            // cmbWagType
            // 
            this.cmbWagType.FormattingEnabled = true;
            this.cmbWagType.Location = new System.Drawing.Point(8, 30);
            this.cmbWagType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbWagType.Name = "cmbWagType";
            this.cmbWagType.Size = new System.Drawing.Size(173, 24);
            this.cmbWagType.TabIndex = 3;
            // 
            // lblWagType
            // 
            this.lblWagType.AutoSize = true;
            this.lblWagType.Location = new System.Drawing.Point(5, 9);
            this.lblWagType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWagType.Name = "lblWagType";
            this.lblWagType.Size = new System.Drawing.Size(73, 17);
            this.lblWagType.TabIndex = 4;
            this.lblWagType.Text = "Wag Type";
            // 
            // lblEngType
            // 
            this.lblEngType.AutoSize = true;
            this.lblEngType.Location = new System.Drawing.Point(199, 9);
            this.lblEngType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEngType.Name = "lblEngType";
            this.lblEngType.Size = new System.Drawing.Size(69, 17);
            this.lblEngType.TabIndex = 6;
            this.lblEngType.Text = "Eng Type";
            // 
            // cmbEngType
            // 
            this.cmbEngType.FormattingEnabled = true;
            this.cmbEngType.Location = new System.Drawing.Point(202, 30);
            this.cmbEngType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEngType.Name = "cmbEngType";
            this.cmbEngType.Size = new System.Drawing.Size(173, 24);
            this.cmbEngType.TabIndex = 5;
            // 
            // stForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 321);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "stForm";
            this.Text = "stForm";
            this.Shown += new System.EventHandler(this.stForm_Shown);
            this.Controls.SetChildIndex(this.fileOpener, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.btnAbout, 0);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.tabControl.ResumeLayout(false);
            this.tabSD.ResumeLayout(false);
            this.tabSD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSdDetail)).EndInit();
            this.tabENG.ResumeLayout(false);
            this.tabENG.PerformLayout();
            this.tabRef.ResumeLayout(false);
            this.tabRef.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSD;
        private System.Windows.Forms.TabPage tabENG;
        private System.Windows.Forms.Label lblSdTexture;
        private System.Windows.Forms.ComboBox cmbSdTexture;
        private System.Windows.Forms.Label lblSdDetail;
        private System.Windows.Forms.NumericUpDown numSdDetail;
        private System.Windows.Forms.TabPage tabRef;
        private System.Windows.Forms.Label lblBB;
        private System.Windows.Forms.TextBox txtBB6;
        private System.Windows.Forms.TextBox txtBB5;
        private System.Windows.Forms.TextBox txtBB4;
        private System.Windows.Forms.TextBox txtBB3;
        private System.Windows.Forms.TextBox txtBB2;
        private System.Windows.Forms.TextBox txtBB1;
        private System.Windows.Forms.Label lblRefDesc;
        private System.Windows.Forms.Label lblRefClass;
        private System.Windows.Forms.TextBox txtRefDesc;
        private System.Windows.Forms.TextBox txtRefClass;
        private System.Windows.Forms.CheckBox chkRefAppend;
        private System.Windows.Forms.Label lblEngType;
        private System.Windows.Forms.ComboBox cmbEngType;
        private System.Windows.Forms.Label lblWagType;
        private System.Windows.Forms.ComboBox cmbWagType;
    }
}