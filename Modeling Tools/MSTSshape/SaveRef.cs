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

using System.IO;
using System.Text;

namespace CasaSoft.vrt.Modeling
{
    /// <summary>
    /// Save the .ref snippet
    /// </summary>
    public class SaveRef
    {
        private string name;
        private string clas;
        private string desc;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="Name">Name of the object</param>
        /// <param name="Clas">Class of the object</param>
        /// <param name="Desc">Description</param>
        public SaveRef(string Name, string Clas, string Desc)
        {
            name = Name;
            clas = Clas;
            desc = Desc;
        }

        /// <summary>
        /// Returns Text content
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Static (\n\t Class( {0} )\n\tFilename ( {1}.s )\n\tAlign ( None )\n\tDescription ( {2} )\n)\n",
                clas, name, desc);
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

        /// <summary>
        /// Appends to text file
        /// </summary>
        /// <param name="filename">name of the file</param>
        public void Append(string filename)
        {
            using (StreamWriter file = new StreamWriter(filename, true, Encoding.Unicode))
            {
                file.WriteLine(this.ToString());
            }
        }

    }
}
