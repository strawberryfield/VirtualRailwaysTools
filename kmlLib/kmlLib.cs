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


namespace CasaSoft.vrt
{
    public class KmlLib
    {
        #region properties
        /// <summary>
        /// List of single placemarks
        /// </summary>
        protected List<placemark> listaPm;
        /// <summary>
        /// List of path placemarks
        /// </summary>
        protected List<path> listaPath;
        /// <summary>
        /// List of polygon placemarks
        /// </summary>
        protected List<poly> listaPoly;

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
            if (Path.GetExtension(Filename).ToUpper() == ".KMZ")
            {
                FileStream kmzFile = File.OpenRead(Filename);
                ZipFile zip = new ZipFile(kmzFile);

                foreach (ZipEntry zipEntry in zip)
                {
                    if (!zipEntry.IsFile)
                    {
                        continue;           // Ignore directories
                    }

                    if(zipEntry.Name.ToUpper() != "DOC.KML" )
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
            listaPm = new List<placemark>();
            listaPath = new List<path>();
            listaPoly = new List<poly>();
            foreach (XmlNode nodo in pmList)
            {
                if (nodo.SelectSingleNode("ns:Point", ns) != null)
                {
                    placemark pm = new placemark();
                    pm.setData(nodo, ns);
                    listaPm.Add(pm);
                }
                if (nodo.SelectSingleNode("ns:LineString", ns) != null)
                {
                    path pa = new path();
                    pa.setData(nodo, ns);
                    listaPath.Add(pa);
                }
                if (nodo.SelectSingleNode("ns:Polygon", ns) != null)
                {
                    poly po = new poly();
                    po.setData(nodo, ns);
                    listaPoly.Add(po);
                }
            }
        }
        #endregion

        #region textdump
        /// <summary>
        /// Dumps all placemarks data for tabular text
        /// </summary>
        /// <returns></returns>
        public virtual string TextPlacemarks()
        {
            string ret = "";
            foreach (placemark pm in listaPm)
            {
                ret += pm.Text() + "\n";
            }
            return ret;
        }

        /// <summary>
        /// Dumps all path data for tabular text
        /// </summary>
        /// <returns></returns>
        public virtual string TextPaths()
        {
            string ret = "";
            foreach (path pa in listaPath)
            {
                ret += pa.Text() + "\n";
            }
            return ret;
        }

        /// <summary>
        /// Dumps all polygons data for tabular text
        /// </summary>
        /// <returns></returns>
        public virtual string TextPolys()
        {
            string ret = "";
            foreach (poly po in listaPoly)
            {
                ret += po.Text() + "\n";
            }
            return ret;
        }
        #endregion

        #region flytodump
        /// <summary>
        /// Dumps all placemarks data for FlyTo
        /// </summary>
        /// <returns></returns>
        public virtual string FlyToPlacemarks()
        {
            string ret = "";
            foreach (placemark pm in listaPm)
            {
                ret += pm.FlyTo() + "\n";
            }
            return ret;
        }

        /// <summary>
        /// Dumps all path data for FlyTo
        /// </summary>
        /// <returns></returns>
        public virtual string FlyToPaths()
        {
            string ret = "";
            foreach (path pa in listaPath)
            {
                ret += pa.FlyTo();
            }
            return ret;
        }

        /// <summary>
        /// Dumps all polygons data for FlyTo
        /// </summary>
        /// <returns></returns>
        public virtual string FlyToPolys()
        {
            string ret = "";
            foreach (poly po in listaPoly)
            {
                ret += po.FlyTo();
            }
            return ret;
        }
        #endregion

        #region mkrdump
        /// <summary>
        /// Dumps all placemarks data for FlyTo
        /// </summary>
        /// <returns></returns>
        public virtual string MkrPlacemarks()
        {
            string ret = "";
            foreach (placemark pm in listaPm)
            {
                ret += pm.Mkr() + "\n";
            }
            return ret;
        }

        /// <summary>
        /// Dumps all path data for FlyTo
        /// </summary>
        /// <returns></returns>
        public virtual string MkrPaths()
        {
            string ret = "";
            foreach (path pa in listaPath)
            {
                ret += pa.Mkr();
            }
            return ret;
        }

        /// <summary>
        /// Dumps all polygons data for FlyTo
        /// </summary>
        /// <returns></returns>
        public virtual string MkrPolys()
        {
            string ret = "";
            foreach (poly po in listaPoly)
            {
                ret += po.Mkr();
            }
            return ret;
        }
        #endregion

        #region R3D Labels dump
        /// <summary>
        /// Dumps all placemarks data for Rail3D labels
        /// </summary>
        /// <param name="converter">instance of <see cref="T:CasaSoft.vrt.R3dCoordsConverter"/></param>
        /// <returns></returns>
        public virtual string R3DlabelsPlacemarks(R3dCoordsConverter converter)
        {
            string ret = "";
            foreach (placemark pm in listaPm)
            {
                ret += pm.R3Dlabel(converter) + "\n";
            }
            return ret;
        }

        /// <summary>
        /// Dumps all path data for Rail3D labels
        /// </summary>
        /// <param name="converter">instance of <see cref="T:CasaSoft.vrt.R3dCoordsConverter"/></param>
        /// <returns></returns>
        public virtual string R3DlabelsPaths(R3dCoordsConverter converter)
        {
            string ret = "";
            foreach (path pa in listaPath)
            {
                ret += pa.R3Dlabel(converter);
            }
            return ret;
        }

        /// <summary>
        /// Dumps all polygons data for Rail3D labels
        /// </summary>
        /// <param name="converter">instance of <see cref="T:CasaSoft.vrt.R3dCoordsConverter"/></param>
        /// <returns></returns>
        public virtual string R3DlabelsPolys(R3dCoordsConverter converter)
        {
            string ret = "";
            foreach (poly po in listaPoly)
            {
                ret += po.R3Dlabel(converter);
            }
            return ret;
        }
        #endregion

        #region counters
        /// <summary>
        /// Returns number of placemarks in file
        /// </summary>
        /// <returns></returns>
        public int CountPlacemarks()
        {
            return listaPm.Count;
        }

        /// <summary>
        /// Returns number of paths in file
        /// </summary>
        /// <returns></returns>
        public int CountPaths()
        {
            return listaPath.Count;
        }

        /// <summary>
        /// Returns number of polygons in file
        /// </summary>
        /// <returns></returns>
        public int CountPolys()
        {
            return listaPoly.Count;
        }
        #endregion

    }
}
