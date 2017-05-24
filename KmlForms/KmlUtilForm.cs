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
using System.Windows.Forms;
using System.Reflection;
using System.Globalization;
using CasaSoft.vrt.KmlLib;

namespace CasaSoft.vrt.forms
{
    public partial class KmlUtilForm : KmlBaseForm
    {
        #region constructors and init
        public KmlUtilForm() : base()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Constructor
        /// </summary>
        public KmlUtilForm(Assembly program, CultureInfo locale) : base(program, locale)
        {
            InitializeComponent();
        }

        private void KmlUtilForm_Shown(object sender, EventArgs e)
        {
            if(!this.DesignMode)
            {
                ContentSelector.setLocale(catalog);
            }
        }
        #endregion

        #region open kml
        /// <summary>
        /// Virtual method for extra inits
        /// </summary>
        protected override void AfterFileOpenerChanged()
        {
            ContentSelector.initFromKml(kml);
        }
        #endregion

        #region save utils
        /// <summary>
        /// Result of kml processing
        /// </summary>
        /// <param name="conv">Instance of class with <see cref="T:CasaSoft.vrt.KmlLib.IConverter"/> interface</param>
        /// <returns></returns>
        protected virtual string GetResult(IConverter conv)
        {
            string ret = conv.FileHeader();
            conv.SetKml(kml);
            if (ContentSelector.PlacemarksSelected)
                ret += conv.PlacemarkBody();
            if (ContentSelector.PathsSelected)
                ret += conv.PathBody();
            if (ContentSelector.PolysSelected)
                ret += conv.PolyBody();
            return ret;
        }
        #endregion
    }
}
