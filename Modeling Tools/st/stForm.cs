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
using System.Reflection;

namespace CasaSoft.vrt.Modeling
{
    public partial class stForm : FormBase
    {
        private MstsShape s;

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
            this.fileOpener.LabelText = catalog.GetString(".s file");
            this.fileOpener.ButtonText = catalog.GetString("Open");
            this.fileOpener.FileDialogFilter = catalog.GetString("MSTS shape file (*.s)|*.s|All files|*.*");
            this.fileOpener.FileDialogTitle = catalog.GetString("Select shape");
        }

        private void stForm_Shown(object sender, EventArgs e)
        {
            if (!this.DesignMode)
            {
                InitControls();
            }
        }

        #endregion

        private void fileOpener_FileTextChanged(object sender, EventArgs e)
        {
            MstsShapeFile sf = new MstsShapeFile(fileOpener.FileName);
            s = sf.shape;
        }
    }
}
