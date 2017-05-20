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
using System.Text.RegularExpressions;
using System.Xml;

namespace CasaSoft.vrt.KmlLib
{
    class Placemark : IPlacemark
    {
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Height { get; set; }

        private NumberFormatInfo provider;

        /// <summary>
        /// Set coords data from a triple lon,lat,height
        /// </summary>
        /// <param name="triple"></param>
        public void SetCoord(string triple)
        {
            // Create a NumberFormatInfo object
            provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";

            String re = @"\,";
            string[] result = Regex.Split(triple, re);
            Lon = Convert.ToDouble(result[0], provider);
            Lat = Convert.ToDouble(result[1], provider);
            Height = Convert.ToDouble(result[2], provider);
        }

        /// <summary>
        /// Set data from XML fragment
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        public void SetData(XmlNode pmdata, XmlNamespaceManager ns)
        {
            Name = pmdata.SelectSingleNode("ns:name", ns).InnerText;
            SetCoord(pmdata.SelectSingleNode("ns:Point", ns).SelectSingleNode("ns:coordinates", ns).InnerText);
        }
    }
}
