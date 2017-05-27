Assembly: CasaSoft.KmlLib.Base
******************************

Type: CasaSoft.vrt.KmlLib.Converter
===================================

 Generic placemark converter to another format 

Field: CasaSoft.vrt.KmlLib.Converter.kml
----------------------------------------

 Instance of [[|T:CasaSoft.vrt.KmlLib.KmlLib]] with data to convert 

Method: CasaSoft.vrt.KmlLib.Converter.SetKml(System.String)
-----------------------------------------------------------

 Build class by kml/kml file name 

Parameter *filename*:



Method: CasaSoft.vrt.KmlLib.Converter.SetKml(CasaSoft.vrt.KmlLib.KmlLib)
------------------------------------------------------------------------

 Build class by instance of [[|T:CasaSoft.vrt.KmlLib.KmlLib]]

Parameter *kmlLib*:



Method: CasaSoft.vrt.KmlLib.Converter.FileHeader
------------------------------------------------

 Returns the file header 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.FileFooter
------------------------------------------------

 Returns the file footer 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark,System.String)
-------------------------------------------------------------------------------------------------

 Converts the specified placemark to text using the given title 

Parameter *pm*:

[[|T:CasaSoft.vrt.KmlLib.Placemark]] to convert

Parameter *text*:

Title to use

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark)
-----------------------------------------------------------------------------------

 Converts the specified placemark to text 

Parameter *pm*:

[[|T:CasaSoft.vrt.KmlLib.Placemark]] to convert

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
------------------------------------------------------------------------------------------------------------------

 Decodes all the placemarks in the given list 

Parameter *list*:

List of placemarks to decode

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem},System.String)
--------------------------------------------------------------------------------------------------------------------------------

 Decodes all the placemarks in the given list using the title 

Parameter *list*:

List of placemarks to decode

Parameter *text*:

title to use

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody
---------------------------------------------------

 Decodes all placemarks to text 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.MultiPointBody(CasaSoft.vrt.KmlLib.IMultiPoint)
-------------------------------------------------------------------------------------

 Decodes a multi-point item ([[|T:CasaSoft.vrt.KmlLib.Path]] or [[|T:CasaSoft.vrt.KmlLib.Polygon]]) to text 

Parameter *mp*:

multipoint ([[|T:CasaSoft.vrt.KmlLib.Path]] or [[|T:CasaSoft.vrt.KmlLib.Polygon]]) to decode

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.MultiPointBody(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
-------------------------------------------------------------------------------------------------------------------

 Decodes a list of multi-point items ([[|T:CasaSoft.vrt.KmlLib.Path]] or [[|T:CasaSoft.vrt.KmlLib.Polygon]]) to text 

Parameter *list*:

multipoint items list ([[|T:CasaSoft.vrt.KmlLib.Path]] or [[|T:CasaSoft.vrt.KmlLib.Polygon]]) to decode

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.PathBody
----------------------------------------------

 Decodes all Path items 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.PolyBody
----------------------------------------------

 Decodes all Polygon items 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.Converter.FileOut(System.String,System.String)
--------------------------------------------------------------------------

 Prints data to output file 

Parameter *content*:

Data to include in file

Parameter *outputfile*:

Filename for output. If null or empty outs on stdout

Method: CasaSoft.vrt.KmlLib.Converter.FileOut(System.String)
------------------------------------------------------------

 Prints data to the console 

Parameter *content*:

Data to include in output

Method: CasaSoft.vrt.KmlLib.Converter.StreamWrite(System.String,System.String)
------------------------------------------------------------------------------

 Prints data to output file 

Parameter *content*:

Data to include in file

Parameter *outputfile*:

Filename for output.

Type: CasaSoft.vrt.KmlLib.ConverterFactory
==========================================

 Creates classes for kml converters 

Method: CasaSoft.vrt.KmlLib.ConverterFactory.GetConverter
---------------------------------------------------------

 Returns the text converter 

*Returns*: Instance of [[|T:CasaSoft.vrt.KmlLib.Converter]] class

Property: CasaSoft.vrt.KmlLib.IKmlItem.Name
-------------------------------------------

 Name of the placemark 

Property: CasaSoft.vrt.KmlLib.IMultiPoint.Nodes
-----------------------------------------------

 List of nodes 

Method: CasaSoft.vrt.KmlLib.IMultiPoint.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager,System.String)
----------------------------------------------------------------------------------------------------------------

 Set data from XML fragment and list of coordinates 

Parameter *pmdata*:

Placemark XML fragment

Parameter *ns*:

XML namespace

Parameter *coords*:

String with coordinate list

Property: CasaSoft.vrt.KmlLib.IPlacemark.Lat
--------------------------------------------

 Latitude 

Property: CasaSoft.vrt.KmlLib.IPlacemark.Lon
--------------------------------------------

 Longitude 

Property: CasaSoft.vrt.KmlLib.IPlacemark.Height
-----------------------------------------------

 Height 

Method: CasaSoft.vrt.KmlLib.IPlacemark.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
-------------------------------------------------------------------------------------------------

 Set data from XML fragment 

Parameter *pmdata*:

Placemark XML fragment

Parameter *ns*:

XML namespace

Method: CasaSoft.vrt.KmlLib.IPlacemark.SetCoord(System.String)
--------------------------------------------------------------

 Set coords data from a triple lon,lat,height 

Parameter *triple*:



Property: CasaSoft.vrt.KmlLib.KmlLib.PmList
-------------------------------------------

 List of single placemarks 

Property: CasaSoft.vrt.KmlLib.KmlLib.PathList
---------------------------------------------

 List of path placemarks 

Property: CasaSoft.vrt.KmlLib.KmlLib.PolyList
---------------------------------------------

 List of polygon placemarks 

Method: CasaSoft.vrt.KmlLib.KmlLib.#ctor(System.String)
-------------------------------------------------------

 Constructor 

Parameter *Filename*:

.kml or .kmz file

Method: CasaSoft.vrt.KmlLib.KmlLib.CountPlacemarks
--------------------------------------------------

 Returns number of placemarks in file 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.KmlLib.CountPaths
---------------------------------------------

 Returns number of paths in file 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.KmlLib.CountPolys
---------------------------------------------

 Returns number of polygons in file 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.KmlLib.ItemsNames(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
------------------------------------------------------------------------------------------------------------

 Lists all names of the given list in object array useful for comboboxes 

Parameter *list*:



*Returns*: 

Method: CasaSoft.vrt.KmlLib.KmlLib.PlacemarksNames
--------------------------------------------------

 Lists all names of placemarks in object array useful for comboboxes 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.KmlLib.PathsNames
---------------------------------------------

 Lists all names of paths in object array useful for comboboxes 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.KmlLib.PolysNames
---------------------------------------------

 Lists all names of polygons in object array useful for comboboxes 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.KmlLib.GetItemByName(System.String,System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
-----------------------------------------------------------------------------------------------------------------------------

 Return placemark by its name 

Parameter *name*:

name of the placemark

*Returns*: [[|T:CasaSoft.vrt.placemark]] object or null if none found

Method: CasaSoft.vrt.KmlLib.KmlLib.GetPlacemarkByName(System.String)
--------------------------------------------------------------------

 Return placemark by its name 

Parameter *name*:

name of the placemark

*Returns*: [[|T:CasaSoft.vrt.placemark]] object or null if none found

Method: CasaSoft.vrt.KmlLib.KmlLib.GetPathByName(System.String)
---------------------------------------------------------------

 Return path by its name 

Parameter *name*:

name of the path

*Returns*: [[|T:CasaSoft.vrt.path]] object or null if none found

Method: CasaSoft.vrt.KmlLib.KmlLib.GetPolyByName(System.String)
---------------------------------------------------------------

 Return polygon by its name 

Parameter *name*:

name of the polygon

*Returns*: [[|T:CasaSoft.vrt.poly]] object or null if none found

Method: CasaSoft.vrt.KmlLib.MultiPoint.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager,System.String)
---------------------------------------------------------------------------------------------------------------

 Set data from XML fragment and list of coordinates 

Parameter *pmdata*:

Placemark XML fragment

Parameter *ns*:

XML namespace

Parameter *coords*:

String with coordinate list



> This method is only used as base for inhertance 

Method: CasaSoft.vrt.KmlLib.Path.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
-------------------------------------------------------------------------------------------

 Set data from XML fragment 

Parameter *pmdata*:

Placemark XML fragment

Parameter *ns*:

XML namespace

Method: CasaSoft.vrt.KmlLib.Placemark.SetCoord(System.String)
-------------------------------------------------------------

 Set coords data from a triple lon,lat,height 

Parameter *triple*:



Method: CasaSoft.vrt.KmlLib.Placemark.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
------------------------------------------------------------------------------------------------

 Set data from XML fragment 

Parameter *pmdata*:

Placemark XML fragment

Parameter *ns*:

XML namespace

Method: CasaSoft.vrt.KmlLib.Polygon.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
----------------------------------------------------------------------------------------------

 Set data from XML fragment 

Parameter *pmdata*:

Placemark XML fragment

Parameter *ns*:

XML namespace


