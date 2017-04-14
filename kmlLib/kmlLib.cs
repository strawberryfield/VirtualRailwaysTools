using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;


namespace CasaSoft.vrt
{
    public class kmlLib
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
        public kmlLib(string Filename)
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
    }
}
