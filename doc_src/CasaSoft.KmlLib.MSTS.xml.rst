Assembly: CasaSoft.KmlLib.MSTS
******************************

Method: CasaSoft.vrt.KmlLib.FlyToConverter.FileHeader
-----------------------------------------------------

 Returns the file header 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.FlyToConverter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark,System.String)
------------------------------------------------------------------------------------------------------

 Converts the specified placemark to text using the given title 

Parameter *pm*:

[[|T:CasaSoft.vrt.KmlLib.Placemark]] to convert

Parameter *text*:

Title to use

*Returns*: 

Method: CasaSoft.vrt.KmlLib.MkrConverter.FileHeader
---------------------------------------------------

 Returns the file header 

*Returns*: 

Method: CasaSoft.vrt.KmlLib.MkrConverter.PlacemarkBody(CasaSoft.vrt.KmlLib.IPlacemark,System.String)
----------------------------------------------------------------------------------------------------

 Converts the specified placemark to text using the given title 

Parameter *pm*:

[[|T:CasaSoft.vrt.KmlLib.Placemark]] to convert

Parameter *text*:

Title to use

*Returns*: 

Method: CasaSoft.vrt.KmlLib.MkrConverter.StreamWrite(System.String,System.String)
---------------------------------------------------------------------------------

 Prints data to output file using 16 bit unicode encoding 

Parameter *content*:

Data to include in file

Parameter *outputfile*:

Filename for output.

Type: CasaSoft.vrt.KmlLib.MSTSConverterFactory
==============================================

 Creates classes for kml converters to MSTS/OR formats 

Method: CasaSoft.vrt.KmlLib.MSTSConverterFactory.GetConverter(System.String)
----------------------------------------------------------------------------

 Returns the text converter of the specified type 

Parameter *type*:

available codes are: (Empty string)->Text 'MKR', 'FLYTO'

*Returns*: Instance of class with [[|T:CasaSoft.vrt.KmlLib.IConverter]] interface


