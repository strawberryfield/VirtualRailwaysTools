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
        #region properties
        /// <summary>
        /// Minimum coordinate point
        /// </summary>
        public point MinPoint { get; protected set; }

        /// <summary>
        /// Maximum coordinate point
        /// </summary>
        public point MaxPoint { get; protected set; }
        #endregion

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="block"></param>
        public MstsShape(SBR block) : base(block)
        {
            MaxLod = GetMaxLod();
            MatrixOfPoint = AssociateMatrix();
            PrecalculatedMatrices = PrecalculateMatrices();
            AbsolutePoints = ComputeAbsolutePoints();

            MinPoint = GetMinPoint();
            MaxPoint = GetMaxPoint();
        }

        #region points computing
        /// <summary>
        /// Compute minimum of shape coords
        /// </summary>
        /// <returns></returns>
        protected point GetMinPoint()
        {
            point ret = new point(float.MaxValue, float.MaxValue, float.MaxValue);
            foreach(point p in AbsolutePoints)
            {
                ret.X = (p.X < ret.X ? p.X : ret.X);
                ret.Y = (p.Y < ret.Y ? p.Y : ret.Y);
                ret.Z = (p.Z < ret.Z ? p.Z : ret.Z);
            }
            return ret;
        }

        /// <summary>
        /// Compute minimum of shape coords
        /// </summary>
        /// <returns></returns>
        protected point GetMaxPoint()
        {
            point ret = new point(float.MinValue, float.MinValue, float.MinValue);
            foreach (point p in AbsolutePoints)
            {
                ret.X = (p.X > ret.X ? p.X : ret.X);
                ret.Y = (p.Y > ret.Y ? p.Y : ret.Y);
                ret.Z = (p.Z > ret.Z ? p.Z : ret.Z);
            }
            return ret;
        }
        #endregion

        #region precalculated values
        /// <summary>
        /// Association of point with matrix
        /// </summary>
        protected class PointAndMatrix
        {
            /// <summary>
            /// Index of Point
            /// </summary>
            public int iPoint;

            /// <summary>
            /// Index of matrix
            /// </summary>
            public int iMatrix;
        }

        /// <summary>
        /// Maximum level of detail
        /// </summary>
        protected distance_level MaxLod;

        /// <summary>
        /// Gets the maximum level of detail
        /// </summary>
        /// <returns></returns>
        protected distance_level GetMaxLod()
        {
            // Find the maximum LOD
            distance_level lod = null;
            float max = 9999;
            foreach (var l in lod_controls[0].distance_levels)
            {
                if (l.distance_level_header.dlevel_selection < max)
                    lod = l;
            }
            return lod;
        }
        /// <summary>
        /// List of points with associated matrix
        /// </summary>
        protected List<PointAndMatrix> MatrixOfPoint;

        /// <summary>
        /// Populates <see cref="F:CasaSoft.vrt.Modeling.MstsShape.MatrixOfPoint"/>
        /// </summary>
        protected List<PointAndMatrix> AssociateMatrix()
        {
            List<PointAndMatrix> mop = new List<PointAndMatrix>();

            // scan all subobjects
            foreach(var s in MaxLod.sub_objects)
            {
                for(int j = 0; j < s.vertex_sets.Count; j++)
                {
                    vertex_set vs = s.vertex_sets[j];
                    for(int vj = 0; vj < vs.VtxCount; vj++)
                    {
                        vertex v = s.vertices[vs.StartVtxIdx + vj];
                        mop.Add(new PointAndMatrix() { iPoint = v.ipoint, iMatrix = vtx_states[vs.VtxStateIdx].imatrix });
                    }
                }
            }
            return mop;
        }

        /// <summary>
        /// Precalculated matrices based on hierarchy
        /// </summary>
        protected MatrixEx[] PrecalculatedMatrices;

        /// <summary>
        /// Populates <see cref="F:CasaSoft.vrt.Modeling.MstsShape.PrecalculatedMatrices"/>
        /// </summary>
        protected MatrixEx[] PrecalculateMatrices()
        {
            int n = MaxLod.distance_level_header.hierarchy.Length;
            MatrixEx[] pm = new MatrixEx[n];
            for (int i = 0; i < n; i++)
            {
                int hl = MaxLod.distance_level_header.hierarchy[i];
                if(hl == -1)
                {
                    pm[i] = new MatrixEx(matrices[i]);
                }
                else
                {
                    pm[i] = new MatrixEx(pm[hl].Mul(matrices[i]));
                }
            }
            return pm;
        }

        /// <summary>
        /// List of points with absolute coords
        /// </summary>
        protected List<point> AbsolutePoints;

        /// <summary>
        /// Populate <see cref="F:CasaSoft.vrt.Modeling.MstsShape.AbsolutePoints"/>
        /// </summary>
        /// <returns></returns>
        protected List<point> ComputeAbsolutePoints()
        {
            List<point> ap = new List<point>();
            foreach(var pm in MatrixOfPoint)
            {
                ap.Add(PrecalculatedMatrices[pm.iMatrix].Mul(points[pm.iPoint]));
            }
            return ap;
        }
        #endregion
    }
}
