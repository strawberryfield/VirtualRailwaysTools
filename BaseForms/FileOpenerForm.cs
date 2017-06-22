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

using System;
using System.Globalization;
using System.Reflection;

namespace CasaSoft.vrt.forms
{
    /// <summary>
    /// extends <see cref="T:CasaSoft.vrt.forms.FormBase"/>
    /// with a <see cref="T:CasaSoft.vrt.forms.FileOpener"/>
    /// </summary>
    public partial class FileOpenerForm : FormBase
    {
        #region constructors and init
        /// <summary>
        /// Constructor (needed only for inheritance)
        /// </summary>
        public FileOpenerForm() : base()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public FileOpenerForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }
        #endregion

        private void fileOpener_FileTextChanged(object sender, EventArgs e)
        {
            doOpenFile();
        }

        /// <summary>
        /// Programmatically sets the filename to load
        /// </summary>
        /// <param name="filename">file to load</param>
        public void SetFile(string filename)
        {
            fileOpener.FileName = filename;
            doOpenFile();
        }

        /// <summary>
        /// virtual method for file opening dirty work
        /// </summary>
        protected virtual void doOpenFile()
        {
            btnSave.Enabled = true;
        }


    }
}
