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
using System.Reflection;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using CasaSoft.vrt.forms;

namespace CasaSoft.vrt
{
    static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] argv)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // locales management
            string localeName = ConfigurationManager.AppSettings["locale"];
            CultureInfo locale;

            if (string.IsNullOrWhiteSpace(localeName))
                locale = CultureInfo.CurrentCulture;
            else
                locale = new CultureInfo(localeName);

            var form = new forms.kml2labelForm(Assembly.GetExecutingAssembly(), locale);
            if (argv.Length > 0)
            {
                form.SetFile(argv[0]);
            }
            Application.Run(form);
        }
    }
}
