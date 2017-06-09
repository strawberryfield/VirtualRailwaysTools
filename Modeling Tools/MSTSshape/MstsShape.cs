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
using Orts.Formats.Msts;

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
    public class MstsShape : shape
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="block"></param>
        public MstsShape(SBR block) : base(block)
        {
        }

        /// <summary>
        /// Compute minimum of shape coords
        /// </summary>
        /// <returns></returns>
        public point MinPoint()
        {
            point ret = new point() { X = float.MaxValue, Y = float.MaxValue, Z = float.MaxValue };
            foreach(point p in points)
            {
                ret.X = (p.X < ret.X ? p.X : ret.X);
                ret.Y = (p.Y < ret.Y ? p.Y : ret.Y);
                ret.Z = (p.Z < ret.Z ? p.Z : ret.Z);
            }
            return ret;
        }

        protected int[] MatrixOfPoint;

        protected void AssociateMatrix()
        {
            MatrixOfPoint = new int[points.Count];

            // Find the minimum LOD
            distance_level lod = null;
            float max = 9999;
            foreach(var l in lod_controls[0].distance_levels)
            {
                if (l.distance_level_header.dlevel_selection < max)
                    lod = l;
            }

            // scan all subobjects
            foreach(var s in lod.sub_objects)
            {
                for(int j = 0; j < s.vertex_sets.Count; j++)
                {
                    vertex_set vs = s.vertex_sets[j];
                    for(int vj = 0; vj < vs.VtxCount; vj++)
                    {
                        vertex v = s.vertices[vs.StartVtxIdx + vj];
                        MatrixOfPoint[v.ipoint] = vtx_states[j].imatrix;
                    }
                }
            }
        }

        protected matrix[] PrecalculatedMatrices;

        protected void PrecalculateMatrices()
        {
            // todo
        }
    }
}
