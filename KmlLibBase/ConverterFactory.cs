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

namespace CasaSoft.vrt.KmlLib
{
    /// <summary>
    /// Creates classes for kml converters
    /// </summary>
    public class ConverterFactory
    {
        /// <summary>
        /// Returns the text converter
        /// </summary>
        /// <returns>Instance of <see cref="T:CasaSoft.vrt.KmlLib.Converter"/> class</returns>
        public IConverter GetConverter()
        {
            return new Converter();
        }
    }
}
