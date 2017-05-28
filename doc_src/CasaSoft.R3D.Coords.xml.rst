Assembly: CasaSoft.R3D.Coords
=============================

Type: CasaSoft.vrt.LatLon
-------------------------

 Contains a couple of longs 

Field: CasaSoft.vrt.LatLon.Lat
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 latitude 

Field: CasaSoft.vrt.LatLon.Lon
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 longitude 

Type: CasaSoft.vrt.XY
---------------------

 Contains a couple of ints 

Field: CasaSoft.vrt.XY.X
~~~~~~~~~~~~~~~~~~~~~~~~

 x coord 

Field: CasaSoft.vrt.XY.Y
~~~~~~~~~~~~~~~~~~~~~~~~

 y coord 

Type: CasaSoft.vrt.R3dCoordsConverter
-------------------------------------

 Converts lat/lon coords to Rail3D layout coords all data are relative to the starting point (usually 20000, 20000) 

Field: CasaSoft.vrt.R3dCoordsConverter.GeoCenter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

`Type: CasaSoft.vrt.KmlLib.LatLon`_ structure with geo coords 

Field: CasaSoft.vrt.R3dCoordsConverter.UTMcenter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

`Type: CasaSoft.vrt.KmlLib.XY`_ structure with geo coords converted to UTM 

Field: CasaSoft.vrt.R3dCoordsConverter.UTMfuse
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 UTM zone for conversion 

Field: CasaSoft.vrt.R3dCoordsConverter.R3Dcenter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Rail3D coords of origin point 

Field: CasaSoft.vrt.R3dCoordsConverter.pOrigin
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 id of original coordinate projection 

Field: CasaSoft.vrt.R3dCoordsConverter.pTarget
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 id of coordinate project to convert into 

Method: CasaSoft.vrt.R3dCoordsConverter.#ctor(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY,System.Int32)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Parameter **UTMfuse**\: zone for UTM conversions

Method: CasaSoft.vrt.R3dCoordsConverter.#ctor(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Method: CasaSoft.vrt.R3dCoordsConverter.setValues(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY,System.Int32)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Common part of constructors 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Parameter **UTMfuse**\: zone for UTM conversions

Method: CasaSoft.vrt.R3dCoordsConverter.setValues(CasaSoft.vrt.LatLon,CasaSoft.vrt.XY)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor with automatic zone 

Parameter **geo**\: LatLon structure with geographic coordinates

Parameter **r3d**\: origin point of Rail3D layout

Method: CasaSoft.vrt.R3dCoordsConverter.FindUTMzone(System.Double)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 return UTM zone from longitude 

Parameter **lon**\: longitude

**Returns**\: UTM zone

Method: CasaSoft.vrt.R3dCoordsConverter.ToUTM(CasaSoft.vrt.LatLon)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Wrapper for esier lat/lon to UTM conversion 

Parameter **geo**\: LatLon structure with geographic coordinates

**Returns**\: XY structure with UTM coordinates

Method: CasaSoft.vrt.R3dCoordsConverter.ToRail3D(CasaSoft.vrt.LatLon)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Converts a lat/lon point to Rail3D layout coords 

Parameter **geo**\: LatLon structure with geographic coordinates

**Returns**\: XY structure with Rail3D layout coordinates


