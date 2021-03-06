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
using DotSpatial.Projections;

namespace CasaSoft.vrt.KmlLib
{
    /// <summary>
    /// Contains a couple of longs
    /// </summary>
    public struct LatLon
    {
        /// <summary>
        /// latitude
        /// </summary>
        public double Lat;

        /// <summary>
        /// longitude
        /// </summary>
        public double Lon;
    }

    /// <summary>
    /// Contains a couple of ints
    /// </summary>
    public struct XY
    {
        /// <summary>
        /// x coord
        /// </summary>
        public int X;

        /// <summary>
        /// y coord
        /// </summary>
        public int Y;
    }

    /// <summary>
    /// Converts lat/lon coords to Rail3D layout coords
    /// all data are relative to the starting point (usually 20000, 20000)
    /// </summary>
    public class R3dCoordsConverter
    {
        #region properties
        /// <summary>
        /// <see cref="T:CasaSoft.vrt.KmlLib.LatLon"/> structure with geo coords
        /// </summary>
        protected LatLon GeoCenter;

        /// <summary>
        /// <see cref="T:CasaSoft.vrt.KmlLib.XY"/> structure with geo coords converted to UTM
        /// </summary>
        protected XY UTMcenter;

        /// <summary>
        /// UTM zone for conversion
        /// </summary>
        protected int UTMfuse;

        /// <summary>
        /// Rail3D coords of origin point
        /// </summary>
        protected XY R3Dcenter;

        /// <summary>
        /// id of original coordinate projection
        /// </summary>
        protected ProjectionInfo pOrigin;

        /// <summary>
        /// id of coordinate project to convert into
        /// </summary>
        protected ProjectionInfo pTarget;
        #endregion

        #region constructors and init
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="geo">LatLon structure with geographic coordinates</param>
        /// <param name="r3d">origin point of Rail3D layout</param>
        /// <param name="UTMfuse">zone for UTM conversions</param>
        public R3dCoordsConverter(LatLon geo, XY r3d, int UTMfuse)
        {
            setValues(geo, r3d, UTMfuse);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="geo">LatLon structure with geographic coordinates</param>
        /// <param name="r3d">origin point of Rail3D layout</param>
        public R3dCoordsConverter(LatLon geo, XY r3d)
        {
            setValues(geo, r3d);
        }

        /// <summary>
        /// Common part of constructors
        /// </summary>
        /// <param name="geo">LatLon structure with geographic coordinates</param>
        /// <param name="r3d">origin point of Rail3D layout</param>
        /// <param name="UTMfuse">zone for UTM conversions</param>
        private void setValues(LatLon geo, XY r3d, int UTMfuse)
        {
            this.GeoCenter = geo;
            this.R3Dcenter = r3d;
            this.UTMfuse = UTMfuse;

            this.pOrigin = KnownCoordinateSystems.Geographic.World.WGS1984;
            this.pTarget = ProjectionInfo.FromProj4String(
                string.Format("+proj=utm +zone={0} {1} +ellps=WGS84 +datum=WGS84 +units=m +no_defs ",
                UTMfuse, geo.Lat < 0 ? "+south" : "" ));

            this.UTMcenter = ToUTM(geo);
        }

        /// <summary>
        /// Constructor with automatic zone
        /// </summary>
        /// <param name="geo">LatLon structure with geographic coordinates</param>
        /// <param name="r3d">origin point of Rail3D layout</param>
        private void setValues(LatLon geo, XY r3d)
        {
            setValues(geo, r3d, FindUTMzone(geo.Lon));
        }

        /// <summary>
        /// return UTM zone from longitude
        /// </summary>
        /// <param name="lon">longitude</param>
        /// <returns>UTM zone</returns>
        public int FindUTMzone(double lon)
        {
            return (int)Math.Floor((lon + 180) / 6) + 1;
        }
        #endregion

        #region conversions
        /// <summary>
        /// Wrapper for esier lat/lon to UTM conversion
        /// </summary>
        /// <param name="geo">LatLon structure with geographic coordinates</param>
        /// <returns>XY structure with UTM coordinates</returns>
        protected XY ToUTM(LatLon geo)
        {
            XY ret;

            //Sets up a array to contain the x and y coordinates
            double[] xy = new double[2];
            xy[0] = geo.Lon;
            xy[1] = geo.Lat;
            //An array for the z coordinate
            double[] z = new double[1];
            z[0] = 0;
            Reproject.ReprojectPoints(xy, z, pOrigin, pTarget, 0, 1);

            ret.X = Convert.ToInt32(xy[0]);
            ret.Y = Convert.ToInt32(xy[1]);
            return ret;
        }

        /// <summary>
        /// Converts a lat/lon point to Rail3D layout coords
        /// </summary>
        /// <param name="geo">LatLon structure with geographic coordinates</param>
        /// <returns>XY structure with Rail3D layout coordinates</returns>
        public XY ToRail3D(LatLon geo)
        {
            XY ret = ToUTM(geo);
            ret.X = ret.X - this.UTMcenter.X + this.R3Dcenter.X;
            ret.Y = ret.Y - this.UTMcenter.Y + this.R3Dcenter.Y;
            return ret;
        }
        #endregion
    }
}
