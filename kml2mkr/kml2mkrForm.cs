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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CasaSoft.vrt.forms
{
    public partial class kml2mkrForm : KmlUtilForm
    {
        public kml2mkrForm()
        {
            InitializeComponent();
            Text = "CasaSoft kml2mkr v.2.0";
        }

        protected override void initSaveDlg()
        {
            base.initSaveDlg();
            if(rdMkr.Checked)
            {
                saveFileDialog.Title = "Create MSTS markes file";
                saveFileDialog.Filter = "Markers file (*.mkr)|*.mkr|All files|*.*";
                saveFileDialog.DefaultExt = ".mkr";
            }
            else if(rdFlyTo.Checked)
            {
                saveFileDialog.Title = "Create FlyTo targets list";
                saveFileDialog.Filter = "FlyTo targets list (*.spt)|*.spt|All files|*.*";
                saveFileDialog.DefaultExt = ".spt";
            }
            else
            {
                saveFileDialog.Title = "Create text list";
                saveFileDialog.Filter = "Text file (*.txt)|*.txt|All files|*.*";
                saveFileDialog.DefaultExt = ".txt";
            }
        }

        protected override void doSave(string filename)
        {
            Converter conv;
            base.doSave(filename);

            if (rdMkr.Checked)
            {
                conv = new Converter(outMode.Markers);
            }
            else if (rdFlyTo.Checked)
            {
                conv = new Converter(outMode.Flyto);
            }
            else
            {
                conv = new Converter(outMode.Text);
            }

            string ret = conv.fileHead();
            ret += conv.fileBody(kml);
            conv.fileOut(ret, filename);
        }
    }
}
