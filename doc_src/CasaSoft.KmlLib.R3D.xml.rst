Assembly: CasaSoft.KmlLib.R3D
=============================

Type: CasaSoft.vrt.KmlLib.IR3DConverter
---------------------------------------

 specialized cref="T:CasaSoft.vrt.KmlLib.IConverter"/> for Rail3D 

Property: CasaSoft.vrt.KmlLib.IR3DConverter.R3dConverter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Instance of cref="T:CasaSoft.vrt.R3dCoordsConverter"/> 

Type: CasaSoft.vrt.KmlLib.LabelsConverter
-----------------------------------------

 Converter for Rail3D labels 

Property: CasaSoft.vrt.KmlLib.LabelsConverter.R3dConverter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Base point for UTM transforms 

Method: CasaSoft.vrt.KmlLib.LabelsConverter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark,System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Converts the specified placemark to text using the given title 

Parameter **pm**\: `Type: CasaSoft.vrt.KmlLib.Placemark`_ to convert

Parameter **text**\: Title to use

**Returns**\: 

Type: CasaSoft.vrt.KmlLib.R3DConverterFactory
---------------------------------------------

 specialized `Type: CasaSoft.vrt.KmlLib.ConverterFactory`_ for Rail3D 

Method: CasaSoft.vrt.KmlLib.R3DConverterFactory.GetConverter(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns the text converter of the specified type 

Parameter **type**\: available codes are: 'LABEL'

**Returns**\: Instance of class with `Type: CasaSoft.vrt.KmlLib.IR3DConverter`_ interface


