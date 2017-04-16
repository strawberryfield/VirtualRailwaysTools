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
using System.Xml;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CasaSoft.vrt
{
    /// <summary>
    /// Class to contain placemarks data
    /// </summary>
    public class placemark
    {
        /// <summary>
        /// Placemarks name
        /// </summary>
        public String name = "";
        /// <summary>
        /// Latitude
        /// </summary>
        public Double lat = 0;
        /// <summary>
        /// Longitude
        /// </summary>
        public Double lon = 0;
        /// <summary>
        /// Height
        /// </summary>
        public Double height = 0;

        /// <summary>
        /// Set data from XML fragment
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        public void setData(XmlNode pmdata, XmlNamespaceManager ns)
        {
            name = pmdata.SelectSingleNode("ns:name", ns).InnerText;
            setCoord(pmdata.SelectSingleNode("ns:Point", ns).SelectSingleNode("ns:coordinates", ns).InnerText);
        }

        private System.Globalization.NumberFormatInfo provider;
        /// <summary>
        /// Set coords data from a triple lon,lat,height
        /// </summary>
        /// <param name="triple"></param>
        public void setCoord(String triple)
        {
            // Create a NumberFormatInfo object
            provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";
            provider.NumberGroupSeparator = ",";

            String re = @"\,";
            string[] result = Regex.Split(triple, re);
            lon = Convert.ToDouble(result[0], provider);
            lat = Convert.ToDouble(result[1], provider);
            height = Convert.ToDouble(result[2], provider);
        }

        /// <summary>
        /// Format data for tabubular text output with placemark name
        /// </summary>
        /// <returns></returns>
        public virtual string Text()
        {
            return Text(name);
        }
        /// <summary>
        /// Format data for tabubular text output
        /// </summary>
        /// <param name="text">Text label for target</param>
        /// <returns></returns>
        public virtual string Text(string text)
        {
            return string.Format(CultureInfo.InvariantCulture, "Lat: {0}\tLon: {1}\tH: {2}\t\"{3}\"", new object[] { lat, lon, height, text });
        }

        /// <summary>
        /// Format data for FlyTo output with placemark name
        /// </summary>
        /// <returns></returns>
        public virtual string FlyTo()
        {
            return FlyTo(name);
        }

        /// <summary>
        /// Format data for FlyTo with specified text
        /// </summary>
        /// <param name="text">Text label for target</param>
        /// <returns></returns>
        public virtual string FlyTo(string text)
        {
            return string.Format(CultureInfo.InvariantCulture, "\"{0}\",{1},{2}", new object[] { text, lon, lat });
        }

        /// <summary>
        /// Format data for Markers output with placemark name
        /// </summary>
        /// <returns></returns>
        public virtual string Mkr()
        {
            return Mkr(name);
        }

        /// <summary>
        /// Format data for Markers with specified text
        /// </summary>
        /// <param name="text">Text label for target</param>
        /// <returns></returns>
        public virtual string Mkr(string text)
        {
            return string.Format(CultureInfo.InvariantCulture, "Marker ( {1} {2} {0} 2 )", 
                new object[] { text.Replace(' ', '_'), lon, lat });
        }
    }

    /// <summary>
    /// Class to contain a placemark with multiple points (lines and polygons)
    /// </summary>
    public class multipoint
    {
        /// <summary>
        /// Name of the placemark
        /// </summary>
        public String name { get; set; }
        /// <summary>
        /// List of nodes
        /// </summary>
        public List<placemark> nodi = null;

        /// <summary>
        /// Set data from XML fragment and list of coordinates
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        /// <param name="coords">String with coordinate list</param>
        /// <remarks>
        /// This method is only used as base for inhertance
        /// </remarks>
        public void setData(XmlNode pmdata, XmlNamespaceManager ns, String coords)
        {
            nodi = new List<placemark>();
            name = pmdata.SelectSingleNode("ns:name", ns).InnerText;
            String re = @" ";
            string[] result = Regex.Split(coords, re);
            foreach (String item in result)
            {
                String triple = item.Trim();
                if (triple != "")
                {
                    placemark nodo = new placemark();
                    nodo.setCoord(triple);
                    nodi.Add(nodo);
                }
            }
        }

        /// <summary>
        /// Dumps all placemarks data for tabular text
        /// </summary>
        /// <param name="mode">'Path' or 'Polygon'</param>
        /// <returns></returns>
        public virtual string Text(string mode)
        {
            string ret = string.Format("{1}: {0}\n", name, mode);
            foreach (placemark pm in nodi)
            {
                ret += pm.Text() + "\n";
            }
            return ret;
        }

        /// <summary>
        /// Dumps alla placemarks data for FlyTo
        /// </summary>
        /// <returns></returns>
        public virtual string FlyTo()
        {
            string ret = "";
            int counter = 0;
            foreach (placemark pm in nodi)
            {
                counter++;
                ret += pm.FlyTo(string.Format("{0}_{1}", name, counter)) + "\n";
            }
            return ret;
        }

        /// <summary>
        /// Dumps alla placemarks data for Markers
        /// </summary>
        /// <returns></returns>
        public virtual string Mkr()
        {
            string ret = "";
            int counter = 0;
            foreach (placemark pm in nodi)
            {
                counter++;
                ret += pm.Mkr(string.Format("{0}_{1}", name, counter)) + "\n";
            }
            return ret;
        }

    }

    /// <summary>
    /// Multipoint inherited class for paths
    /// </summary>
    public class path : multipoint
    {
        /// <summary>
        /// Set data from XML fragment
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        public void setData(XmlNode pmdata, XmlNamespaceManager ns)
        {
            String coords = pmdata.SelectSingleNode("ns:LineString", ns).SelectSingleNode("ns:coordinates", ns).InnerText;
            base.setData(pmdata, ns, coords);
        }

        /// <summary>
        /// Dump all points of the path
        /// </summary>
        /// <returns></returns>
        public virtual string Text()
        {
            return base.Text("Path");
        }
    }

    /// <summary>
    /// Multipoint inherited class for polygons
    /// </summary>
    public class poly : multipoint
    {
        /// <summary>
        /// Set data from XML fragment
        /// </summary>
        /// <param name="pmdata">Placemark XML fragment</param>
        /// <param name="ns">XML namespace</param>
        public void setData(XmlNode pmdata, XmlNamespaceManager ns)
        {
            String coords = pmdata.SelectSingleNode("ns:Polygon", ns).
                SelectSingleNode("ns:outerBoundaryIs", ns).
                SelectSingleNode("ns:LinearRing", ns).
                SelectSingleNode("ns:coordinates", ns).InnerText;
            base.setData(pmdata, ns, coords);
        }

        /// <summary>
        /// Dump all points of the poly
        /// </summary>
        /// <returns></returns>
        public virtual string Text()
        {
            return base.Text("Polygon");
        }

    }

}
