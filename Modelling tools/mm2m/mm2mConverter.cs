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
using System.IO;
using System.Text.RegularExpressions;

namespace CasaSoft.vrt.Modelling
{
    public class mm2mConverter
    {
        public string Converted { get; protected set; }

        private static string banner = @"## Converted to 'Metric' using CasaSoft mm2m v 2.0
## copyright (c) 2011,2017 Roberto Ceccarelli - CasaSoft
## see https://github.com/strawberryfield/VirtualRailwaysTools
";

        public mm2mConverter()
        {
            Converted = banner;
        }

        public void ReadFile(string filename)
        {
            Converted = banner;
            bool isVertexSection = false;

            string[] readText = File.ReadAllLines(filename);
            foreach (string s in readText)
            {
                Regex re = new Regex("Millimetric");
                string ret = re.Replace(s, "Metric");

                re = new Regex(@"^\s*Length\s*(\d+)", RegexOptions.IgnoreCase);
                ret = re.Replace(ret, delegate (Match match)
                {
                    decimal v = Convert.ToDecimal(match.Groups[1].ToString());
                    return string.Format("Length {0}", Math.Floor(v / 10));
                });

                if(!isVertexSection)
                {
                    isVertexSection = ret.Contains("<VertexBuffer>");
                }
                else
                {
                    if(ret.Contains("<VertexBuffer>"))
                    {
                        isVertexSection = false;
                    }
                    else
                    {

                    }
                }

                Converted += ret + "\n";
            }
        }

        public void WriteFile(string filename)
        {
            using (StreamWriter file = new StreamWriter(filename))
            {
                file.WriteLine(Converted);
            }
        }
    }
}
