Assembly: CasaSoft.R3D.Coords
*****************************

Type: CasaSoft.vrt.LatLon
=========================

 Contains a couple of longs 

Type: CasaSoft.vrt.XY
=====================

 Contains a couple of ints 

Type: CasaSoft.vrt.R3dCoordsConverter
=====================================

 Converts lat/lon coords to Rail3D layout coords all data are relative to the starting point (usually 20000, 20000) 

Method: CasaSoft.vrt.R3dCoordsConverter.#ctor(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY,System.Int32)
-----------------------------------------------------------------------------------------------

 Constructor 

Parameter *geo*:

LatLon structure with geographic coordinates

Parameter *r3d*:

origin point of Rail3D layout

Parameter *UTMfuse*:

zone for UTM conversions

Method: CasaSoft.vrt.R3dCoordsConverter.#ctor(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY)
----------------------------------------------------------------------------------

 Constructor 

Parameter *geo*:

LatLon structure with geographic coordinates

Parameter *r3d*:

origin point of Rail3D layout

Method: CasaSoft.vrt.R3dCoordsConverter.setValues(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY,System.Int32)
---------------------------------------------------------------------------------------------------

 Common part of constructors 

Parameter *geo*:

LatLon structure with geographic coordinates

Parameter *r3d*:

origin point of Rail3D layout

Parameter *UTMfuse*:

zone for UTM conversions

Method: CasaSoft.vrt.R3dCoordsConverter.setValues(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY)
--------------------------------------------------------------------------------------

 Constructor with automatic zone 

Parameter *geo*:

LatLon structure with geographic coordinates

Parameter *r3d*:

origin point of Rail3D layout

Method: CasaSoft.vrt.R3dCoordsConverter.FindUTMzone(System.Double)
------------------------------------------------------------------

 return UTM zone from longitude 

Parameter *lon*:

longitude

*Returns*: UTM zone

Method: CasaSoft.vrt.R3dCoordsConverter.ToUTM(CasaSoft.vrt.LatLon)
------------------------------------------------------------------

 Wrapper for esier lat/lon to UTM conversion 

Parameter *geo*:

LatLon structure with geographic coordinates

*Returns*: XY structure with UTM coordinates

Method: CasaSoft.vrt.R3dCoordsConverter.ToRail3D(CasaSoft.vrt.LatLon)
---------------------------------------------------------------------

 Converts a lat/lon point to Rail3D layout coords 

Parameter *geo*:

LatLon structure with geographic coordinates

*Returns*: XY structure with Rail3D layout coordinates


