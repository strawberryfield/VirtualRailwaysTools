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

            cmbWagType.Items.Add(new ComboboxItem { Value = "Engine", Text = catalog.GetString("Engine") });
            cmbWagType.Items.Add(new ComboboxItem { Value = "Carriage", Text = catalog.GetString("Carriage") });
            cmbWagType.Items.Add(new ComboboxItem { Value = "Freight", Text = catalog.GetString("Freight") });
            cmbWagType.Items.Add(new ComboboxItem { Value = "Tender", Text = catalog.GetString("Tender") });
            cmbWagType.SelectedIndex = 0;

            cmbEngType.Items.Add(new ComboboxItem { Value = "Electric", Text = catalog.GetString("Electric") });
            cmbEngType.Items.Add(new ComboboxItem { Value = "Diesel", Text = catalog.GetString("Diesel") });
            cmbEngType.Items.Add(new ComboboxItem { Value = "Steam", Text = catalog.GetString("Steam") });
            cmbEngType.SelectedIndex = 0;

            lblEngType.Text = "Eng Type";
            lblWagType.Text = "Wag Type";

            tabControl.Enabled = false;
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
        
        #region save
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
                    break;

                case 1:
                    setSaveDialog4eng();
                    break;

                case 2:
                    setSaveDialog4ref();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Save dialog settings for .ref file
        /// </summary>
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
        /// Save dialog settings for Eng/Wag
        /// </summary>
        private void setSaveDialog4eng()
        {
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.OverwritePrompt = true;
            if (((ComboboxItem)cmbWagType.SelectedItem).Value.ToString() == "Engine")
            {
                saveFileDialog.Title = catalog.GetString("Create Eng file");
                saveFileDialog.Filter = catalog.GetString("Eng file (*.eng)|*.eng|All files|*.*");
                saveFileDialog.DefaultExt = ".eng";
            }
            else
            {
                saveFileDialog.Title = catalog.GetString("Create Wag file");
                saveFileDialog.Filter = catalog.GetString("Wag file (*.wag)|*.wag|All files|*.*");
                saveFileDialog.DefaultExt = ".wag";
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
                    SaveSd saveSd = new SaveSd(string.Format("{0}.s", this.name), 
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
                    SaveEng saveEng = new SaveEng(((ComboboxItem)cmbWagType.SelectedItem).Value.ToString(),
                        ((ComboboxItem)cmbEngType.SelectedItem).Value.ToString(),
                        this.name,
                        new float[3] {
                            parse4float(txtEngSize1.Text),
                            parse4float(txtEngSize2.Text),
                            parse4float(txtEngSize3.Text)
                        });
                    saveEng.Write(filename);
                    break;

                case 2:
                    SaveRef saveRef = new SaveRef(this.name, txtRefClass.Text, txtRefDesc.Text);
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

        #region Event handlers
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSaveButton(((TabControl)sender).SelectedIndex);
        }

        /// <summary>
        /// Open file dirty work
        /// </summary>
        protected override void doOpenFile()
        {
            string file = fileOpener.FileName;
            MstsShapeFile sf = null;

            if (!string.IsNullOrWhiteSpace(file))
            {
                try
                {
                    sf = new MstsShapeFile(fileOpener.FileName);
                }
                catch (Exception ex)
                {
                    Balloon(catalog.GetString("Error processing file '{0}':\n{1}", file, ex.Message));
                }

                if (sf != null)
                {
                    s = sf.shape;
                    name = Path.GetFileNameWithoutExtension(file);

                    txtBB1.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MinPoint.X);
                    txtBB2.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MinPoint.Y);
                    txtBB3.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MinPoint.Z);
                    txtBB4.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MaxPoint.X);
                    txtBB5.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MaxPoint.Y);
                    txtBB6.Text = string.Format(CultureInfo.InvariantCulture, "{0}", s.MaxPoint.Z);

                    txtEngSize1.Text = string.Format(CultureInfo.InvariantCulture, "{0}", Math.Abs(s.MaxPoint.X - s.MinPoint.X));
                    txtEngSize2.Text = string.Format(CultureInfo.InvariantCulture, "{0}", Math.Abs(s.MaxPoint.Y - s.MinPoint.Y));
                    txtEngSize3.Text = string.Format(CultureInfo.InvariantCulture, "{0}", Math.Abs(s.MaxPoint.Z - s.MinPoint.Z));

                    txtRefDesc.Text = name;

                    tabControl.Enabled = true;
                    setSaveButton(tabControl.SelectedIndex);
                    base.doOpenFile();
                }
            }
        }

        private void chkRefAppend_CheckedChanged(object sender, EventArgs e)
        {
            setSaveDialog4ref();
        }

        private void cmbWagType_SelectedValueChanged(object sender, EventArgs e)
        {
            setSaveDialog4eng();
            if (((ComboboxItem)cmbWagType.SelectedItem).Value.ToString() == "Engine")
            {
                cmbEngType.Enabled = true;
            }
            else
            {
                cmbEngType.Enabled = false;
            }
        }
        #endregion

    }
}
