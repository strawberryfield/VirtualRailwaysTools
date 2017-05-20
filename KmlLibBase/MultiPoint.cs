﻿// copyright (c) 2017 Roberto Ceccarelli - CasaSoft
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
using System.Text.RegularExpressions;
using System.Xml;

namespace CasaSoft.vrt.KmlLib
{
    class MultiPoint : IMultiPoint
    {
        public string Name { get; set; }
        public List<IKmlItem> Nodes { get; set; }

        /// <summary>
        /// Set data from XML fragment and list of coordinates
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        /// <param name="coords">String with coordinate list</param>
        /// <remarks>
        /// This method is only used as base for inhertance
        /// </remarks>
        public void SetData(XmlNode pmdata, XmlNamespaceManager ns, string coords)
        {
            Nodes = new List<IKmlItem>();
            Name = pmdata.SelectSingleNode("ns:name", ns).InnerText;
            String re = @" ";
            string[] result = Regex.Split(coords, re);
            foreach (String item in result)
            {
                String triple = item.Trim();
                if (triple != "")
                {
                    Placemark node = new Placemark();
                    node.SetCoord(triple);
                    Nodes.Add(node);
                }
            }
        }
    }
}
