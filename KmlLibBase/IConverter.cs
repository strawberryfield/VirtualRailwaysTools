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
    public interface IConverter
    {
        string FileFooter();
        string FileHeader();
        string MultiPointBody(IMultiPoint mp);
        string MultiPointBody(List<IKmlItem> list);
        string PathBody();
        string PlacemarkBody();
        string PlacemarkBody(IPlacemark pm);
        string PolyBody();
        void SetKml(KmlLib kmlLib);
        void SetKml(string filename);
    }
}