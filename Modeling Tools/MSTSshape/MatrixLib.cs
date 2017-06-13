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

using Orts.Parsers.Msts;
using Orts.Formats.Msts;

namespace CasaSoft.vrt.Modeling
{
    public class PointEx
    {
        protected point Point;

        public float X { get { return Point.X; } set { Point.X = X; } }
        public float Y { get { return Point.Y; } set { Point.Y = Y; } }
        public float Z { get { return Point.Z; } set { Point.Z = Z; } }

        public PointEx()
        {
            Point = new point();
        }

        public PointEx(point p)
        {
            Point = p;
        }

        public point Sum(point p)
        {
            point ret = new point(p.X, p.Y, p.Z);
            ret.X += Point.X;
            ret.Y += Point.Y;
            ret.Z += Point.Z;
            return ret;
        }
    }


    public class MatrixEx
    {
        protected matrix mat;

        public MatrixEx()
        {
            mat = new matrix();
        }

        public MatrixEx(matrix m)
        {
            mat = m;
        }

        public bool isUnity(matrix m)
        {
            return (m.AX == 1 & m.AY == 0 & m.AZ == 0
                & m.BX == 0 & m.BY == 1 & m.BZ == 0
                & m.CX == 0 & m.CY == 0 & m.CZ == 1);
        }

        public bool isUnity()
        {
            return isUnity(mat);
        }

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
            return ret;
        }

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
            return ret;
        }
    }
}
