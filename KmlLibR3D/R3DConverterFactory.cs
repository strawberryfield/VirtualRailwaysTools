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
    public class R3DConverterFactory : ConverterFactory
    {
        /// <summary>
        /// Returns the text converter of the specified type
        /// </summary>
        /// <param name="type">available codes are: (Empty string)->Text 'LABEL'</param>
        /// <returns>Instance of class with <see cref="T:CasaSoft.vrt.KmlLib.IConverter"/> interface</returns>
        public IConverter GetConverter(string type)
        {
            type = type.ToUpper();

            if (string.IsNullOrWhiteSpace(type))
                return GetConverter();
            else if ("LABEL" == type)
                return new LabelsConverter();
            else
                return null;
        }
    }
}
