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
using System.Globalization;

namespace CasaSoft.vrt.KmlLib
{
    public class Converter : IConverter
    {
        protected KmlLib kml;

        #region inits
        public void SetKml(string filename)
        {
            SetKml(new KmlLib(filename));
        }

        public void SetKml(KmlLib kmlLib)
        {
            kml = kmlLib;
        }
        #endregion

        #region header & footer
        /// <summary>
        /// Returns the file header 
        /// </summary>
        /// <returns></returns>
        public virtual string FileHeader()
        {
            return "";
        }

        /// <summary>
        /// Returns the file footer 
        /// </summary>
        /// <returns></returns>
        public virtual string FileFooter()
        {
            return "";
        }
        #endregion

        #region placemark body items
        /// <summary>
        /// Converts the specified placemark to text using the given title
        /// </summary>
        /// <param name="pm"><see cref="T:CasaSoft.vrt.KmlLib.Placemark"/> to convert</param>
        /// <param name="text">Title to use</param>
        /// <returns></returns>
        protected virtual string PlacemarkBody(IPlacemark pm, string text)
        {
            return string.Format(CultureInfo.InvariantCulture, "Lat: {0}\tLon: {1}\tH: {2}\t\"{3}\"", new object[] { pm.Lat, pm.Lon, pm.Height, text });
        }

        /// <summary>
        /// Converts the specified placemark to text
        /// </summary>
        /// <param name="pm"><see cref="T:CasaSoft.vrt.KmlLib.Placemark"/> to convert</param>
        /// <returns></returns>
        public virtual string PlacemarkBody(IPlacemark pm)
        {
            return PlacemarkBody(pm, pm.Name);
        }

        /// <summary>
        /// Decodes all the placemarks in the given list
        /// </summary>
        /// <param name="list">List of placemarks to decode</param>
        /// <returns></returns>
        protected virtual string PlacemarkBody(List<IKmlItem> list)
        {
            string ret = "";
            foreach(var p in list)
            {
                ret += PlacemarkBody((IPlacemark)p);
                ret += "\n";
            }
            return ret;
        }

        /// <summary>
        /// Decodes all the placemarks in the given list using the title
        /// </summary>
        /// <param name="list">List of placemarks to decode</param>
        /// <param name="text">title to use</param>
        /// <returns></returns>
        protected virtual string PlacemarkBody(List<IKmlItem> list, string text)
        {
            string ret = "";
            int counter = 0;
            foreach (var p in list)
            {
                counter++;
                ret += PlacemarkBody((IPlacemark)p, string.Format("{0}_{1}", text, counter));
                ret += "\n";
            }
            return ret;
        }

        /// <summary>
        /// Decodes all placemarks to text
        /// </summary>
        /// <returns></returns>
        public virtual string PlacemarkBody()
        {
            return PlacemarkBody(kml.PmList);
        }
        #endregion

        #region Multipoint body items
        /// <summary>
        /// Decodes a multi-point item 
        /// (<see cref="T:CasaSoft.vrt.KmlLib.Path"/> or <see cref="T:CasaSoft.vrt.KmlLib.Polygon"/>)
        /// to text
        /// </summary>
        /// <param name="mp">multipoint 
        /// (<see cref="T:CasaSoft.vrt.KmlLib.Path"/> or <see cref="T:CasaSoft.vrt.KmlLib.Polygon"/>)
        /// to decode</param>
        /// <returns></returns>
        public virtual string MultiPointBody(IMultiPoint mp)
        {
            return PlacemarkBody(mp.Nodes, mp.Name);
        }

        /// <summary>
        /// Decodes a list of multi-point items 
        /// (<see cref="T:CasaSoft.vrt.KmlLib.Path"/> or <see cref="T:CasaSoft.vrt.KmlLib.Polygon"/>)
        /// to text
        /// </summary>
        /// <param name="list">multipoint items list
        /// (<see cref="T:CasaSoft.vrt.KmlLib.Path"/> or <see cref="T:CasaSoft.vrt.KmlLib.Polygon"/>)
        /// to decode</param>
        /// <returns></returns>
        public virtual string MultiPointBody(List<IKmlItem> list)
        {
            string ret = "";
            foreach (var p in list)
            {
                ret += MultiPointBody((IMultiPoint)p);
            }
            return ret;
        }

        /// <summary>
        /// Decodes all Path items
        /// </summary>
        /// <returns></returns>
        public virtual string PathBody()
        {
            return MultiPointBody(kml.PathList);
        }

        /// <summary>
        /// Decodes all Polygon items
        /// </summary>
        /// <returns></returns>
        public virtual string PolyBody()
        {
            return MultiPointBody(kml.PolyList);
        }
        #endregion
    }
}
