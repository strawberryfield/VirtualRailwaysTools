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

using System.Globalization;
using System.IO;
using System.Text;

namespace CasaSoft.vrt.Modeling
{
    /// <summary>
    /// MSTS extended shape info (.SD) exporter
    /// </summary>
    public class SaveSd
    {
        private string shapeName;
        private int detailLevel;
        private int alternativeTexture;
        private float[] boundingBox;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="ShapeName">.s file name</param>
        /// <param name="DetailLevel">level of detail for visibility options</param>
        /// <param name="AlternativeTexture">Night, snow or saesonal textures present</param>
        /// <param name="BoundingBox">array of six float values</param>
        public SaveSd(string ShapeName, int DetailLevel, int AlternativeTexture, float[] BoundingBox)
        {
            shapeName = ShapeName;
            detailLevel = DetailLevel;
            alternativeTexture = AlternativeTexture;
            boundingBox = BoundingBox;
        }

        /// <summary>
        /// Returns Text content
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ret = @"SIMISA@@@@@@@@@@JINX0t1t______";
            ret += string.Format("\nShape ( {0}\n", shapeName);
            ret += string.Format("\tESD_Detail_Level ( {0} )\n", detailLevel);
            ret += string.Format("\tESD_Alternative_Texture ( {0} )\n", alternativeTexture);
            ret += string.Format(CultureInfo.InvariantCulture, "\tESD_Bounding_Box ( {0} {1} {2} {3} {4} {5} )\n", 
                new object[] { boundingBox[0], boundingBox[1], boundingBox[2], boundingBox[3], boundingBox[4], boundingBox[5] });
            ret += ")";
            return ret;
        }

        /// <summary>
        /// Writes to text file
        /// </summary>
        /// <param name="filename">name of the file</param>
        public void Write(string filename)
        {
            using (StreamWriter file = new StreamWriter(filename, false, Encoding.Unicode))
            {
                file.WriteLine(this.ToString());
            }
        }
    }
}
