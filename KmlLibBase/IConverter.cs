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

namespace CasaSoft.vrt.KmlLib
{
    /// <summary>
    /// Common interface for placemarks conversions
    /// </summary>
    public interface IConverter
    {
        /// <summary>
        /// Returns the file footer string
        /// </summary>
        /// <returns></returns>
        string FileFooter();

        /// <summary>
        /// Returns the file header string
        /// </summary>
        /// <returns></returns>
        string FileHeader();

        /// <summary>
        /// Returns converted data from a path or polygon
        /// </summary>
        /// <param name="mp"><see cref="T:CasaSoft.vrt.KmlLib.IMultiPoint"/> to convert</param>
        /// <returns></returns>
        string MultiPointBody(IMultiPoint mp);

        /// <summary>
        /// Returns converted data from a list of paths or polygons
        /// </summary>
        /// <param name="list">List of <see cref="T:CasaSoft.vrt.KmlLib.IKmlItem"/> to convert</param>
        /// <returns></returns>
        string MultiPointBody(List<IKmlItem> list);

        /// <summary>
        /// Returns converted data of all paths
        /// </summary>
        /// <returns></returns>
        string PathBody();

        /// <summary>
        /// Returns converted data of all placemarks
        /// </summary>
        /// <returns></returns>
        string PlacemarkBody();

        /// <summary>
        /// Return converted data of a placemark
        /// </summary>
        /// <param name="pm"><see cref="T:CasaSoft.vrt.KmlLib.IPlacemark"/> to convert</param>
        /// <returns></returns>
        string PlacemarkBody(IPlacemark pm);

        /// <summary>
        /// Returns converted data of all polygons
        /// </summary>
        /// <returns></returns>
        string PolyBody();

        /// <summary>
        /// Returns converted data of all polygons
        /// </summary>
        /// <returns></returns>
        string TrackBody();

        /// <summary>
        /// Sets the data to convert from an instance of <see cref="T:CasaSoft.vrt.KmlLib.KmlLib"/> 
        /// </summary>
        /// <param name="kmlLib"></param>
        void SetKml(KmlLib kmlLib);

        /// <summary>
        /// Sets the data to convert from a .kml/.kmz file
        /// </summary>
        /// <param name="filename">name of the file with data to convert</param>
        void SetKml(string filename);

        /// <summary>
        /// Writes data to a file
        /// </summary>
        /// <param name="content">data to write</param>
        /// <param name="outputfile">output file name</param>
        void FileOut(string content, string outputfile);

        /// <summary>
        /// writes data to standard output
        /// </summary>
        /// <param name="content">data to write</param>
        void FileOut(string content);
    }
}