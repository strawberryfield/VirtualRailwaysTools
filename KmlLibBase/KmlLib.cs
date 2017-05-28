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
using System.IO;
using System.Xml;
using ICSharpCode.SharpZipLib.Zip;

namespace CasaSoft.vrt.KmlLib
{
    /// <summary>
    /// Base class to handle .kml/.kmz files from Google Earth
    /// </summary>
    public class KmlLib
    {
        #region properties
        /// <summary>
        /// List of single placemarks
        /// </summary>
        public List<IKmlItem> PmList { protected set; get; }
        /// <summary>
        /// List of path placemarks
        /// </summary>
        public List<IKmlItem> PathList { protected set; get; }
        /// <summary>
        /// List of polygon placemarks
        /// </summary>
        public List<IKmlItem> PolyList { protected set; get; }

        #endregion

        #region constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Filename">.kml or .kmz file</param>
        public KmlLib(string Filename)
        {
            Stream kmlStream = null;
            XmlDocument Kml;

            // if .kmz unpack the file
            if (System.IO.Path.GetExtension(Filename).ToUpper() == ".KMZ")
            {
                FileStream kmzFile = File.OpenRead(Filename);
                ZipFile zip = new ZipFile(kmzFile);

                foreach (ZipEntry zipEntry in zip)
                {
                    if (!zipEntry.IsFile)
                    {
                        continue;           // Ignore directories
                    }

                    if (zipEntry.Name.ToUpper() != "DOC.KML")
                    {
                        continue;
                    }

                    kmlStream = zip.GetInputStream(zipEntry);
                    break;
                }
            }
            else
            {
                kmlStream = File.OpenRead(Filename);
            }

            Kml = new XmlDocument();
            Kml.Load(kmlStream);

            // XML parser
            XmlNamespaceManager ns = new XmlNamespaceManager(Kml.NameTable);
            ns.AddNamespace("ns", "http://www.opengis.net/kml/2.2");
            XmlNodeList pmList = Kml.GetElementsByTagName("Placemark");
            PmList = new List<IKmlItem>();
            PathList = new List<IKmlItem>();
            PolyList = new List<IKmlItem>();
            foreach (XmlNode nodo in pmList)
            {
                if (nodo.SelectSingleNode("ns:Point", ns) != null)
                {
                    Placemark pm = new Placemark();
                    pm.SetData(nodo, ns);
                    PmList.Add(pm);
                }
                if (nodo.SelectSingleNode("ns:LineString", ns) != null)
                {
                    Path pa = new Path();
                    pa.SetData(nodo, ns);
                    PathList.Add(pa);
                }
                if (nodo.SelectSingleNode("ns:Polygon", ns) != null)
                {
                    Polygon po = new Polygon();
                    po.SetData(nodo, ns);
                    PolyList.Add(po);
                }
            }
        }
        #endregion

        #region counters
        /// <summary>
        /// Returns number of placemarks in file
        /// </summary>
        /// <returns></returns>
        public int CountPlacemarks()
        {
            return PmList.Count;
        }

        /// <summary>
        /// Returns number of paths in file
        /// </summary>
        /// <returns></returns>
        public int CountPaths()
        {
            return PathList.Count;
        }

        /// <summary>
        /// Returns number of polygons in file
        /// </summary>
        /// <returns></returns>
        public int CountPolys()
        {
            return PolyList.Count;
        }
        #endregion

        #region items lists
        /// <summary>
        /// Lists all names of the given list in object array useful for comboboxes
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        protected object[] ItemsNames(List<IKmlItem> list)
        {
            object[] ret = new object[list.Count];
            int cnt = 0;
            foreach (var p in list)
            {
                ret[cnt] = p.Name;
                cnt++;
            }
            return ret;
        }

        /// <summary>
        /// Lists all names of placemarks in object array useful for comboboxes
        /// </summary>
        /// <returns></returns>
        public object[] PlacemarksNames()
        {
            return ItemsNames(PmList);
        }

        /// <summary>
        /// Lists all names of paths in object array useful for comboboxes
        /// </summary>
        /// <returns></returns>
        public object[] PathsNames()
        {
            return ItemsNames(PathList);
        }

        /// <summary>
        /// Lists all names of polygons in object array useful for comboboxes
        /// </summary>
        /// <returns></returns>
        public object[] PolysNames()
        {
            return ItemsNames(PolyList);
        }
        #endregion

        #region getElementByName
        /// <summary>
        /// Return placemark by its name
        /// </summary>
        /// <param name="name">name of the placemark</param>
        /// <param name="list">list of placemarks where to search</param>
        /// <returns><see cref="T:CasaSoft.vrt.placemark"/> object or null if none found</returns>
        protected IKmlItem GetItemByName(string name, List<IKmlItem> list)
        {
            IKmlItem ret = null;
            foreach (var p in list)
            {
                if (p.Name == name)
                {
                    ret = p;
                    break;
                }
            }
            return ret;
        }

        /// <summary>
        /// Return placemark by its name
        /// </summary>
        /// <param name="name">name of the placemark</param>
        /// <returns><see cref="T:CasaSoft.vrt.placemark"/> object or null if none found</returns>
        public IPlacemark GetPlacemarkByName(string name)
        {
            return (IPlacemark)GetItemByName(name, PmList);
        }

        /// <summary>
        /// Return path by its name
        /// </summary>
        /// <param name="name">name of the path</param>
        /// <returns><see cref="T:CasaSoft.vrt.path"/> object or null if none found</returns>
        public IMultiPoint GetPathByName(string name)
        {
            return (IMultiPoint)GetItemByName(name, PathList);
        }

        /// <summary>
        /// Return polygon by its name
        /// </summary>
        /// <param name="name">name of the polygon</param>
        /// <returns><see cref="T:CasaSoft.vrt.poly"/> object or null if none found</returns>
        public IMultiPoint GetPolyByName(string name)
        {
            return (IMultiPoint)GetItemByName(name, PolyList);
        }
        #endregion

    }
}
