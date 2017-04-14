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
    }

}
