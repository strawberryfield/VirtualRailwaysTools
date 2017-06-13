Assembly: CasaSoft.R3D.Coords
=============================

Type: CasaSoft.vrt.KmlLib.LatLon
--------------------------------

 Contains a couple of longs 

Field: CasaSoft.vrt.KmlLib.LatLon.Lat
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 latitude 

Field: CasaSoft.vrt.KmlLib.LatLon.Lon
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 longitude 

Type: CasaSoft.vrt.KmlLib.XY
----------------------------

 Contains a couple of ints 

Field: CasaSoft.vrt.KmlLib.XY.X
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 x coord 

Field: CasaSoft.vrt.KmlLib.XY.Y
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 y coord 

Type: CasaSoft.vrt.KmlLib.R3dCoordsConverter
--------------------------------------------

 Converts lat/lon coords to Rail3D layout coords all data are relative to the starting point (usually 20000, 20000) 

Field: CasaSoft.vrt.KmlLib.R3dCoordsConverter.GeoCenter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

`Type: CasaSoft.vrt.KmlLib.LatLon`_ structure with geo coords 

Field: CasaSoft.vrt.KmlLib.R3dCoordsConverter.UTMcenter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

`Type: CasaSoft.vrt.KmlLib.XY`_ structure with geo coords converted to UTM 

Field: CasaSoft.vrt.KmlLib.R3dCoordsConverter.UTMfuse
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 UTM zone for conversion 

Field: CasaSoft.vrt.KmlLib.R3dCoordsConverter.R3Dcenter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Rail3D coords of origin point 

Field: CasaSoft.vrt.KmlLib.R3dCoordsConverter.pOrigin
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 id of original coordinate projection 

Field: CasaSoft.vrt.KmlLib.R3dCoordsConverter.pTarget
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 id of coordinate project to convert into 

Method: CasaSoft.vrt.KmlLib.R3dCoordsConverter.#ctor(CasaSoft.vrt.KmlLib.LatLon,CasaSoft.vrt.KmlLib.XY,System.Int32)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Parameter **UTMfuse**\: zone for UTM conversions

Method: CasaSoft.vrt.KmlLib.R3dCoordsConverter.#ctor(CasaSoft.vrt.KmlLib.LatLon,CasaSoft.vrt.KmlLib.XY)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Method: CasaSoft.vrt.KmlLib.R3dCoordsConverter.setValues(CasaSoft.vrt.KmlLib.LatLon,CasaSoft.vrt.KmlLib.XY,System.Int32)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Common part of constructors 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Parameter **UTMfuse**\: zone for UTM conversions

Method: CasaSoft.vrt.KmlLib.R3dCoordsConverter.setValues(CasaSoft.vrt.KmlLib.LatLon,CasaSoft.vrt.KmlLib.XY)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor with automatic zone 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Method: CasaSoft.vrt.KmlLib.R3dCoordsConverter.FindUTMzone(System.Double)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 return UTM zone from longitude 

Parameter **lon**\: longitude

**Returns**\: UTM zone

Method: CasaSoft.vrt.KmlLib.R3dCoordsConverter.ToUTM(CasaSoft.vrt.KmlLib.LatLon)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Wrapper for esier lat/lon to UTM conversion 

Parameter **geo**\: LatLon structure with geographic coordinates

**Returns**\: XY structure with UTM coordinates

Method: CasaSoft.vrt.KmlLib.R3dCoordsConverter.ToRail3D(CasaSoft.vrt.KmlLib.LatLon)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Converts a lat/lon point to Rail3D layout coords 

Parameter **geo**\: LatLon structure with geographic coordinates

**Returns**\: XY structure with Rail3D layout coordinates


