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

using System.Globalization;

namespace CasaSoft.vrt.KmlLib
{
    public class MkrConverter : Converter
    {
        /// <summary>
        /// Returns the file header 
        /// </summary>
        /// <returns></returns>
        public override string FileHeader()
        {
            return "SIMISA@@@@@@@@@@JINX0I0t______\n\n";
        }

        /// <summary>
        /// Converts the specified placemark to text using the given title
        /// </summary>
        /// <param name="pm"><see cref="T:CasaSoft.vrt.KmlLib.Placemark"/> to convert</param>
        /// <param name="text">Title to use</param>
        /// <returns></returns>
        protected override string PlacemarkBody(IPlacemark pm, string text)
        {
            return string.Format(CultureInfo.InvariantCulture, "Marker ( {1} {2} {0} 2 )",
                new object[] { text.Replace(' ', '_'), pm.Lon, pm.Lat });
        }

    }
}
