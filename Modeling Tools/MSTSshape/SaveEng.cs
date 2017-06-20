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
using System.Globalization;
using System.IO;
using System.Text;

namespace CasaSoft.vrt.Modeling
{
    /// <summary>
    /// MSTS Eng/Wag exporter
    /// </summary>
    public class SaveEng
    {
        private string WagType;
        private string EngType;
        private float[] Size;
        private string SizeString;
        private string Name;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="wagType">WAG Type : "Engine", "Carriage", "Freight", "Tender"</param>
        /// <param name="engType">Eng Type : "Electric", "Diesel", "Steam"</param>
        /// <param name="name">shape and eng/wag name</param>
        /// <param name="size">x,y,Z dims in meters</param>
        public SaveEng(string wagType, string engType, string name, float[] size)
        {
            WagType = wagType;
            EngType = engType;
            Name = name;
            Size = size;
            SizeString = string.Format(CultureInfo.InvariantCulture, "( {0}m {1}m {2}m )",
                new object[] { Math.Round(size[0], 1), Math.Round(size[1], 1), Math.Round(size[2], 1) });
        }

        /// <summary>
        /// Returns Text content
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string ret = @"SIMISA@@@@@@@@@@JINX0D0t______";

            ret += string.Format("\n\nWagon ( {0}\n", Name);
            ret += "\tComment ( Created with CasaSoft Virtual Railways Tools )\n";
            ret += "\tComment ( copyright 2017 Roberto Ceccarelli )\n\n";
            ret += string.Format("\tType ( {0} )\n", WagType);
            ret += string.Format("\tName ( {0} )\n", Name);
            ret += string.Format("\tWagonShape ( {0}.s )\n", Name);
            ret += "\n";
            ret += string.Format("\tSize {0}\n", SizeString);
            ret += string.Format("\tInertiaTensor ( Box {0} )\n", SizeString);
            ret += ")";

            if (WagType == "Engine")
            {
                ret += string.Format("\n\nEngine ( {0}\n", Name);
                ret += string.Format("\tWagon ( {0} )\n", Name);
                ret += string.Format("\tType ( {0} )\n", EngType);
                ret += string.Format("\tName ( \"{0}\" )\n", Name);
                ret += ")";
            }
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
