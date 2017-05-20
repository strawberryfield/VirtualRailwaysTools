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

using System.Collections.Generic;
using System.Xml;

namespace CasaSoft.vrt.KmlLib
{
    public interface IMultiPoint : IKmlItem
    {
        /// <summary>
        /// List of nodes
        /// </summary>
        List<IKmlItem> Nodes { get; set; }

        /// <summary>
        /// Set data from XML fragment and list of coordinates
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        /// <param name="coords">String with coordinate list</param>
        void SetData(XmlNode pmdata, XmlNamespaceManager ns, string coords);

    }
}
