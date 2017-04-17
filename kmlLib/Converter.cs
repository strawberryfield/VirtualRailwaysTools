﻿// copyright (c) 2017 Roberto Ceccarelli - CasaSoft
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
using System.Text;

namespace CasaSoft.vrt
{
    public enum outMode { Text, Markers, Flyto, R3Dlabels, R3Dpath }

    public class Converter
    {
        protected outMode mode;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="exportMode">set the export type</param>
        public Converter(outMode exportMode)
        {
            mode = exportMode;
        }

        /// <summary>
        /// Returns file header 
        /// </summary>
        /// <returns></returns>
        public string fileHead()
        {
            string ret;
            switch (mode)
            {
                case outMode.Text:
                    ret = string.Empty;
                    break;
                case outMode.Markers:
                    ret = "SIMISA@@@@@@@@@@JINX0I0t______\n\n";
                    break;
                case outMode.Flyto:
                    ret = "\"MSTSFlyTo 2.0\"\n";
                    break;
                case outMode.R3Dlabels:
                    ret = string.Empty;
                    break;
                case outMode.R3Dpath:
                    ret = string.Empty;
                    break;
                default:
                    ret = string.Empty;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Returns file body
        /// </summary>
        /// <param name="filename">kml / kmz file to process</param>
        /// <returns></returns>
        public string fileBody(string filename)
        {
            string ret = "";
            KmlLib kml = new KmlLib(filename);
            switch (mode)
            {
                case outMode.Text:
                    ret += kml.TextPlacemarks();
                    ret += kml.TextPaths();
                    ret += kml.TextPolys();
                    break;
                case outMode.Markers:
                    ret += kml.MkrPlacemarks();
                    ret += kml.MkrPaths();
                    ret += kml.MkrPolys();
                    break;
                case outMode.Flyto:
                    ret += kml.FlyToPlacemarks();
                    break;
                default:
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Prints data to output file
        /// </summary>
        /// <param name="content">Data to include in file</param>
        /// <param name="outputfile">Filename for output. If null or empty outs on stdout</param>
        public void fileOut(string content, string outputfile)
        {
            if (string.IsNullOrEmpty(outputfile))
            {
                Console.WriteLine(content);
            }
            else
            {
                if (mode == outMode.Markers)
                {
                    using (StreamWriter file = new StreamWriter(outputfile, false, Encoding.Unicode))
                    {
                        file.WriteLine(content);
                    }
                }
                else
                {
                    using (StreamWriter file = new StreamWriter(outputfile))
                    {
                        file.WriteLine(content);
                    }
                }
            }

        }
    }
}
