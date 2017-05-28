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

using System.Xml;

namespace CasaSoft.vrt.KmlLib
{
    /// <summary>
    /// Placemark interface inherited form <see cref="T:CasaSoft.vrt.KmlLib.IKmlItem"/>
    /// </summary>
    public interface IPlacemark : IKmlItem
    {
        /// <summary>
        /// Latitude
        /// </summary>
        double Lat { get; set; }

        /// <summary>
        /// Longitude
        /// </summary>
        double Lon { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        double Height { get; set; }

        /// <summary>
        /// Set data from XML fragment
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        void SetData(XmlNode pmdata, XmlNamespaceManager ns);

        /// <summary>
        /// Set coords data from a triple lon,lat,height
        /// </summary>
        /// <param name="triple">string containing lon,lat,height</param>
        void SetCoord(string triple);
    }
}
