Assembly: CasaSoft.KmlLib.Base
==============================

Type: CasaSoft.vrt.KmlLib.Converter
-----------------------------------

 Generic placemark converter to another format 

Field: CasaSoft.vrt.KmlLib.Converter.kml
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Instance of `Type: CasaSoft.vrt.KmlLib.KmlLib`_ with data to convert 

Method: CasaSoft.vrt.KmlLib.Converter.SetKml(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Build class by kml/kml file name 

Parameter **filename**\: 

Method: CasaSoft.vrt.KmlLib.Converter.SetKml(CasaSoft.vrt.KmlLib.KmlLib)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Build class by instance of `Type: CasaSoft.vrt.KmlLib.KmlLib`_

Parameter **kmlLib**\: 

Method: CasaSoft.vrt.KmlLib.Converter.FileHeader
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns the file header 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.FileFooter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns the file footer 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark,System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Converts the specified placemark to text using the given title 

Parameter **pm**\: `Type: CasaSoft.vrt.KmlLib.Placemark`_ to convert

Parameter **text**\: Title to use

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Converts the specified placemark to text 

Parameter **pm**\: `Type: CasaSoft.vrt.KmlLib.Placemark`_ to convert

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Decodes all the placemarks in the given list 

Parameter **list**\: List of placemarks to decode

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem},System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Decodes all the placemarks in the given list using the title 

Parameter **list**\: List of placemarks to decode

Parameter **text**\: title to use

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.PlacemarkBody
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Decodes all placemarks to text 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.MultiPointBody(CasaSoft.vrt.KmlLib.IMultiPoint)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Decodes a multi-point item (`Type: CasaSoft.vrt.KmlLib.Path`_ or `Type: CasaSoft.vrt.KmlLib.Polygon`_) to text 

Parameter **mp**\: multipoint (`Type: CasaSoft.vrt.KmlLib.Path`_ or `Type: CasaSoft.vrt.KmlLib.Polygon`_) to decode

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.MultiPointBody(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Decodes a list of multi-point items (`Type: CasaSoft.vrt.KmlLib.Path`_ or `Type: CasaSoft.vrt.KmlLib.Polygon`_) to text 

Parameter **list**\: multipoint items list (`Type: CasaSoft.vrt.KmlLib.Path`_ or `Type: CasaSoft.vrt.KmlLib.Polygon`_) to decode

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.PathBody
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Decodes all Path items 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.PolyBody
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Decodes all Polygon items 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.Converter.FileOut(System.String,System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Prints data to output file 

Parameter **content**\: Data to include in file

Parameter **outputfile**\: Filename for output. If null or empty outs on stdout

Method: CasaSoft.vrt.KmlLib.Converter.FileOut(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Prints data to the console 

Parameter **content**\: Data to include in output

Method: CasaSoft.vrt.KmlLib.Converter.StreamWrite(System.String,System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Prints data to output file 

Parameter **content**\: Data to include in file

Parameter **outputfile**\: Filename for output.

Type: CasaSoft.vrt.KmlLib.ConverterFactory
------------------------------------------

 Creates classes for kml converters 

Method: CasaSoft.vrt.KmlLib.ConverterFactory.GetConverter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns the text converter 

**Returns**\: Instance of `Type: CasaSoft.vrt.KmlLib.Converter`_ class

Type: CasaSoft.vrt.KmlLib.IConverter
------------------------------------

 Common interface for placemarks conversions 

Method: CasaSoft.vrt.KmlLib.IConverter.FileFooter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns the file footer string 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.FileHeader
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns the file header string 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.MultiPointBody(CasaSoft.vrt.KmlLib.IMultiPoint)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns converted data from a path or polygon 

Parameter **mp**\: `Type: CasaSoft.vrt.KmlLib.IMultiPoint`_ to convert

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.MultiPointBody(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns converted data from a list of paths or polygons 

Parameter **list**\: List of `Type: CasaSoft.vrt.KmlLib.IKmlItem`_ to convert

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.PathBody
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns converted data of all paths 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.PlacemarkBody
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns converted data of all placemarks 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Return converted data of a placemark 

Parameter **pm**\: `Type: CasaSoft.vrt.KmlLib.IPlacemark`_ to convert

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.PolyBody
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns converted data of all polygons 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.SetKml(CasaSoft.vrt.KmlLib.KmlLib)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Sets the data to convert from an instance of `Type: CasaSoft.vrt.KmlLib.KmlLib`_

Parameter **kmlLib**\: 

Method: CasaSoft.vrt.KmlLib.IConverter.SetKml(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Sets the data to convert from a .kml/.kmz file 

Parameter **filename**\: name of the file with data to convert

Method: CasaSoft.vrt.KmlLib.IConverter.FileOut(System.String,System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Writes data to a file 

Parameter **content**\: data to write

Parameter **outputfile**\: output file name

Method: CasaSoft.vrt.KmlLib.IConverter.FileOut(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 writes data to standard output 

Parameter **content**\: data to write

Type: CasaSoft.vrt.KmlLib.IKmlItem
----------------------------------

 Root interface for kml items 

Property: CasaSoft.vrt.KmlLib.IKmlItem.Name
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Name of the placemark 

Type: CasaSoft.vrt.KmlLib.IMultiPoint
-------------------------------------

 Inteface for multi-point elements like paths and polygons 

Property: CasaSoft.vrt.KmlLib.IMultiPoint.Nodes
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 List of nodes 

Method: CasaSoft.vrt.KmlLib.IMultiPoint.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager,System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set data from XML fragment and list of coordinates 

Parameter **pmdata**\: Placemark XML fragment

Parameter **ns**\: XML namespace

Parameter **coords**\: String with coordinate list

Type: CasaSoft.vrt.KmlLib.IPlacemark
------------------------------------

 Placemark interface inherited form `Type: CasaSoft.vrt.KmlLib.IKmlItem`_

Property: CasaSoft.vrt.KmlLib.IPlacemark.Lat
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Latitude 

Property: CasaSoft.vrt.KmlLib.IPlacemark.Lon
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Longitude 

Property: CasaSoft.vrt.KmlLib.IPlacemark.Height
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Height 

Method: CasaSoft.vrt.KmlLib.IPlacemark.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set data from XML fragment 

Parameter **pmdata**\: Placemark XML fragment

Parameter **ns**\: XML namespace

Method: CasaSoft.vrt.KmlLib.IPlacemark.SetCoord(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set coords data from a triple lon,lat,height 

Parameter **triple**\: string containing lon,lat,height

Type: CasaSoft.vrt.KmlLib.KmlLib
--------------------------------

 Base class to handle .kml/.kmz files from Google Earth 

Property: CasaSoft.vrt.KmlLib.KmlLib.PmList
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 List of single placemarks 

Property: CasaSoft.vrt.KmlLib.KmlLib.PathList
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 List of path placemarks 

Property: CasaSoft.vrt.KmlLib.KmlLib.PolyList
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 List of polygon placemarks 

Method: CasaSoft.vrt.KmlLib.KmlLib.#ctor(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Parameter **Filename**\: .kml or .kmz file

Method: CasaSoft.vrt.KmlLib.KmlLib.CountPlacemarks
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns number of placemarks in file 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.KmlLib.CountPaths
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns number of paths in file 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.KmlLib.CountPolys
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns number of polygons in file 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.KmlLib.ItemsNames(System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Lists all names of the given list in object array useful for comboboxes 

Parameter **list**\: 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.KmlLib.PlacemarksNames
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Lists all names of placemarks in object array useful for comboboxes 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.KmlLib.PathsNames
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Lists all names of paths in object array useful for comboboxes 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.KmlLib.PolysNames
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Lists all names of polygons in object array useful for comboboxes 

**Returns**\: 

Method: CasaSoft.vrt.KmlLib.KmlLib.GetItemByName(System.String,System.Collections.Generic.List{CasaSoft.vrt.KmlLib.IKmlItem})
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Return placemark by its name 

Parameter **name**\: name of the placemark

Parameter **list**\: list of placemarks where to search

**Returns**\: `Type: CasaSoft.vrt.placemark`_ object or null if none found

Method: CasaSoft.vrt.KmlLib.KmlLib.GetPlacemarkByName(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Return placemark by its name 

Parameter **name**\: name of the placemark

**Returns**\: `Type: CasaSoft.vrt.placemark`_ object or null if none found

Method: CasaSoft.vrt.KmlLib.KmlLib.GetPathByName(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Return path by its name 

Parameter **name**\: name of the path

**Returns**\: `Type: CasaSoft.vrt.path`_ object or null if none found

Method: CasaSoft.vrt.KmlLib.KmlLib.GetPolyByName(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Return polygon by its name 

Parameter **name**\: name of the polygon

**Returns**\: `Type: CasaSoft.vrt.poly`_ object or null if none found

Type: CasaSoft.vrt.KmlLib.MultiPoint
------------------------------------

 Implements the `Type: CasaSoft.vrt.KmlLib.IMultiPoint`_ interface 

Property: CasaSoft.vrt.KmlLib.MultiPoint.Name
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 name of the multipoint placemark 

Property: CasaSoft.vrt.KmlLib.MultiPoint.Nodes
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 List of `Type: CasaSoft.vrt.KmlLib.IKmlItem`_ to contains the coords of the points 

Method: CasaSoft.vrt.KmlLib.MultiPoint.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager,System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set data from XML fragment and list of coordinates 

Parameter **pmdata**\: Placemark XML fragment

Parameter **ns**\: XML namespace

Parameter **coords**\: String with coordinate list



> This method is only used as base for inhertance 

Type: CasaSoft.vrt.KmlLib.Path
------------------------------

 Implements a `Type: CasaSoft.vrt.KmlLib.MultiPoint`_ to contain Path data 

Method: CasaSoft.vrt.KmlLib.Path.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set data from XML fragment 

Parameter **pmdata**\: Placemark XML fragment

Parameter **ns**\: XML namespace

Type: CasaSoft.vrt.KmlLib.Placemark
-----------------------------------

 Implements the `Type: CasaSoft.vrt.KmlLib.IPlacemark`_ interface 

Property: CasaSoft.vrt.KmlLib.Placemark.Name
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Name of the placemark 

Property: CasaSoft.vrt.KmlLib.Placemark.Lat
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Latitude 

Property: CasaSoft.vrt.KmlLib.Placemark.Lon
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Longitude 

Property: CasaSoft.vrt.KmlLib.Placemark.Height
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Height 

Method: CasaSoft.vrt.KmlLib.Placemark.SetCoord(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set coords data from a triple lon,lat,height 

Parameter **triple**\: 

Method: CasaSoft.vrt.KmlLib.Placemark.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set data from XML fragment 

Parameter **pmdata**\: Placemark XML fragment

Parameter **ns**\: XML namespace

Type: CasaSoft.vrt.KmlLib.Polygon
---------------------------------

 Implements a `Type: CasaSoft.vrt.KmlLib.MultiPoint`_ to contain Polygon data 

Method: CasaSoft.vrt.KmlLib.Polygon.SetData(System.Xml.XmlNode,System.Xml.XmlNamespaceManager)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Set data from XML fragment 

Parameter **pmdata**\: Placemark XML fragment

Parameter **ns**\: XML namespace


