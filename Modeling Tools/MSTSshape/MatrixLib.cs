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

using Orts.Formats.Msts;

namespace CasaSoft.vrt.Modeling
{
    /// <summary>
    /// Extended <see cref="T:Orts.Formats.Msts.point"/> class
    /// </summary>
    public class PointEx
    {
        /// <summary>
        /// <see cref="T:Orts.Formats.Msts.point"/> instance
        /// </summary>
        protected point Point;

        /// <summary>
        /// X coord
        /// </summary>
        public float X { get { return Point.X; } set { Point.X = X; } }

        /// <summary>
        /// Y coord
        /// </summary>
        public float Y { get { return Point.Y; } set { Point.Y = Y; } }

        /// <summary>
        /// Z coord
        /// </summary>
        public float Z { get { return Point.Z; } set { Point.Z = Z; } }

        /// <summary>
        /// Constructor
        /// </summary>
        public PointEx()
        {
            Point = new point();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="p"></param>
        public PointEx(point p)
        {
            Point = p;
        }

        /// <summary>
        /// Sum a vector
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public point Sum(point p)
        {
            point ret = new point(p.X, p.Y, p.Z);
            ret.X += Point.X;
            ret.Y += Point.Y;
            ret.Z += Point.Z;
            return ret;
        }
    }


    /// <summary>
    /// Extended <see cref="T:Orts.Formats.Msts.matrix"/> class
    /// </summary>
    public class MatrixEx
    {
        /// <summary>
        /// <see cref="T:Orts.Formats.Msts.matrix"/> instance
        /// </summary>
        protected matrix mat;

        /// <summary>
        /// Constructor
        /// </summary>
        public MatrixEx()
        {
            mat = new matrix();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="m"></param>
        public MatrixEx(matrix m)
        {
            mat = m;
        }

        /// <summary>
        /// Tests if the given <see cref="T:Orts.Formats.Msts.matrix"/> is unitary
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public bool isUnity(matrix m)
        {
            return (m.AX == 1 & m.AY == 0 & m.AZ == 0
                & m.BX == 0 & m.BY == 1 & m.BZ == 0
                & m.CX == 0 & m.CY == 0 & m.CZ == 1);
        }

        /// <summary>
        /// Text if this matrix is unitary
        /// </summary>
        /// <returns></returns>
        public bool isUnity()
        {
            return isUnity(mat);
        }

        /// <summary>
        /// multyply this matrix by the given <see cref="T:Orts.Formats.Msts.matrix"/>
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        /// <remarks>Also sums the offset vector</remarks>
        public matrix Mul(matrix m)
        {
            matrix ret;
            if (isUnity())
            {
                ret = m;
            }
            else if (isUnity(m))
            {
                ret = mat;
            }
            else
            {
                ret = new matrix();
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        ret[j, k] = 0;
                        for (int n = 0; n < 3; n++)
                        {
                            ret[j, k] += mat[j, n] * m[n, k];
                        }
                    }
                }
            }
            PointEx pe = new PointEx(new point(m.DX, m.DY, m.DZ));
            point p = pe.Sum(new point(mat.DX, mat.DY, mat.DZ));
            ret.DX = p.X;
            ret.DY = p.Y;
            ret.DZ = p.Z;
            return ret;
        }

        /// <summary>
        /// Multiply the given <see cref="T:Orts.Formats.Msts.point"/> by this matrix
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        /// <remarks>Also sums the offset vector</remarks>
        public point Mul(point p)
        {
            point ret;
            if(isUnity())
            {
                ret = p;
            }
            else
            {
                ret = new point(p.X * mat.AX + p.Y * mat.BX + p.Z * mat.CX,
                    p.X * mat.AY + p.Y * mat.BY + p.Z * mat.CY,
                    p.X * mat.AZ + p.Y * mat.BZ + p.Z * mat.CZ);
            }
            PointEx pe = new PointEx(ret);
            return pe.Sum(new point(mat.DX, mat.DY, mat.DZ));
        }
    }
}
