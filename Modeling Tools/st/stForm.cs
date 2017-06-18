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

using CasaSoft.vrt.forms;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace CasaSoft.vrt.Modeling
{
    public partial class stForm : FileOpenerForm
    {
        private MstsShape s;
        private string name;

        private class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }

        #region constructor and inits
        public stForm()
        {
            InitializeComponent();
        }

        public stForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
            Text = getProgramTitle();
        }

        /// <summary>
        /// Controls bas init
        /// </summary>
        private void InitControls()
        {
            fileOpener.LabelText = catalog.GetString(".s file");
            fileOpener.ButtonText = catalog.GetString("Open");
            fileOpener.FileDialogFilter = catalog.GetString("MSTS shape file (*.s)|*.s|All files|*.*");
            fileOpener.FileDialogTitle = catalog.GetString("Select shape");

            lblSdDetail.Text = catalog.GetString("Detail level");
            lblSdTexture.Text = catalog.GetString("Alternative texture");
            lblBB.Text = catalog.GetString("Bounding Box");

            cmbSdTexture.Items.Add(new ComboboxItem { Value = 0, Text = catalog.GetString("Base only") });
            cmbSdTexture.Items.Add(new ComboboxItem { Value = 1, Text = catalog.GetString("Base and snow") });
            cmbSdTexture.Items.Add(new ComboboxItem { Value = 256, Text = catalog.GetString("Base and night") });
            cmbSdTexture.Items.Add(new ComboboxItem { Value = 257, Text = catalog.GetString("Base, night and snow") });
            cmbSdTexture.Items.Add(new ComboboxItem { Value = 252, Text = catalog.GetString("All seasons") });
            cmbSdTexture.SelectedIndex = 0;

            lblRefClass.Text = catalog.GetString("Class");
            lblRefDesc.Text = catalog.GetString("Description");
            chkRefAppend.Text = catalog.GetString("Append to existing file");

            btnSave.Enabled = false;
        }

        private void stForm_Shown(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                InitControls();
            }
        }

        private void txtNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) & e.KeyChar != (char)Keys.Back & e.KeyChar != '.' & e.KeyChar != '-';
        }
        #endregion

        private void fileOpener_FileTextChanged(object sender, EventArgs e)
        {
            MstsShapeFile sf = new MstsShapeFile(fileOpener.FileName);
            s = sf.shape;
            name = Path.GetFileNameWithoutExtension(fileOpener.FileName);

            txtBB1.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MinPoint.X);
            txtBB2.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MinPoint.Y);
            txtBB3.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MinPoint.Z);
            txtBB4.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MaxPoint.X);
            txtBB5.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MaxPoint.Y);
            txtBB6.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MaxPoint.Z);

            txtRefDesc.Text = name;

            setSaveButton(tabControl.SelectedIndex);
        }

        #region save
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSaveButton(((TabControl)sender).SelectedIndex);
        }

        private void setSaveButton(int mode)
        {
            switch (mode)
            {
                case 0:
                    saveFileDialog.Title = catalog.GetString("Create SD file");
                    saveFileDialog.Filter = catalog.GetString("SD file (*.sd)|*.sd|All files|*.*");
                    saveFileDialog.DefaultExt = ".sd";
                    saveFileDialog.CheckFileExists = false;
                    saveFileDialog.OverwritePrompt = true;
                    btnSave.Enabled = true;
                    break;

                case 1:
                    btnSave.Enabled = false;
                    break;

                case 2:
                    setSaveDialog4ref();
                    btnSave.Enabled = true;
                    break;

                default:
                    btnSave.Enabled = false;
                    break;
            }
        }

        private void setSaveDialog4ref()
        {
            saveFileDialog.DefaultExt = ".ref";
            if(chkRefAppend.Checked)
            {
                saveFileDialog.Title = catalog.GetString("Append to REF file");
                saveFileDialog.Filter = catalog.GetString("REF file (*.ref)|*.ref|All files|*.*");
                saveFileDialog.CheckFileExists = true;
                saveFileDialog.OverwritePrompt = false;
            }
            else
            {
                saveFileDialog.Title = catalog.GetString("Create REF snippet");
                saveFileDialog.Filter = catalog.GetString("REF snippet (*.ref)|*.ref|All files|*.*");
                saveFileDialog.CheckFileExists = false;
                saveFileDialog.OverwritePrompt = true;
            }
        }

        /// <summary>
        /// Converts textbox input to float
        /// </summary>
        /// <param name="s">string to parse</param>
        /// <returns></returns>
        private float parse4float(string s)
        {
            float ret = 0;
            if (!float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out ret)) ret = 0;
            return ret;
        }

        protected override void doSave(string filename)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    SaveSd saveSd = new SaveSd(string.Format("{0}.s", name), 
                        Convert.ToInt16(numSdDetail.Value),
                        Convert.ToInt16(((ComboboxItem)cmbSdTexture.SelectedItem).Value),
                        new float[6] {
                            parse4float(txtBB1.Text),
                            parse4float(txtBB2.Text),
                            parse4float(txtBB3.Text),
                            parse4float(txtBB4.Text),
                            parse4float(txtBB5.Text),
                            parse4float(txtBB6.Text)
                        });
                    saveSd.Write(filename);
                    break;

                case 1:
                    break;

                case 2:
                    SaveRef saveRef = new SaveRef(name, txtRefClass.Text, txtRefDesc.Text);
                    if(chkRefAppend.Checked)
                    {
                        saveRef.Append(filename);
                    }
                    else
                    {
                        saveRef.Write(filename);
                    }
                    break;

                default:
                    break;
            }
        }
        #endregion

        private void chkRefAppend_CheckedChanged(object sender, EventArgs e)
        {
            setSaveDialog4ref();
        }
    }
}
