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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Orts.Parsers.Msts;

namespace CasaSoft.vrt.Modeling
{
    /// <summary>
    /// Simple class to read shape from file
    /// </summary>
    public class MstsShapeFile
    {
        /// <summary>
        /// shape data
        /// </summary>
        public MstsShape shape;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="filename">file to read and parse</param>
        public MstsShapeFile(string filename)
        {
            var file = SBR.Open(filename);
            shape = new MstsShape(file.ReadSubBlock());
            file.VerifyEndOfBlock();
        }
    }

    /// <summary>
    /// Extends ORTS class for MSTS shape 
    /// </summary>
    public class MstsShape : Orts.Formats.Msts.shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="block"></param>
        public MstsShape(SBR block) : base(block)
        {
        }

    }
}
