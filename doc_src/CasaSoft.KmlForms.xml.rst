Assembly: CasaSoft.KmlForms
***************************

Method: CasaSoft.vrt.forms.KmlBaseForm.#ctor(System.Reflection.Assembly,System.Globalization.CultureInfo)
---------------------------------------------------------------------------------------------------------

 Constructor 

Method: CasaSoft.vrt.forms.KmlBaseForm.InitControls
---------------------------------------------------

 Controls bas init 

Method: CasaSoft.vrt.forms.KmlBaseForm.AfterFileOpenerChanged
-------------------------------------------------------------

 Virtual method for extra inits 

Field: CasaSoft.vrt.forms.KmlBaseForm.components
------------------------------------------------

 Required designer variable. 

Method: CasaSoft.vrt.forms.KmlBaseForm.Dispose(System.Boolean)
--------------------------------------------------------------

 Clean up any resources being used. 

Parameter *disposing*:

true if managed resources should be disposed; otherwise, false.

Method: CasaSoft.vrt.forms.KmlBaseForm.InitializeComponent
----------------------------------------------------------

 Required method for Designer support - do not modify the contents of this method with the code editor. 

Method: CasaSoft.vrt.forms.kmlContentSelector.#ctor
---------------------------------------------------

 Base constructor 

Property: CasaSoft.vrt.forms.kmlContentSelector.PlacemarksSelected
------------------------------------------------------------------

 Return status of Placemarks chechbox 

Property: CasaSoft.vrt.forms.kmlContentSelector.PathsSelected
-------------------------------------------------------------

 Return status of Paths chechbox 

Property: CasaSoft.vrt.forms.kmlContentSelector.PolysSelected
-------------------------------------------------------------

 Return status of Polys chechbox 

Method: CasaSoft.vrt.forms.kmlContentSelector.setLocale(NGettext.ICatalog)
--------------------------------------------------------------------------

 Sets localizable strings 

Parameter *catalog*:



Method: CasaSoft.vrt.forms.kmlContentSelector.resetControls
-----------------------------------------------------------

 Reset checkboxes to defualt values 

Method: CasaSoft.vrt.forms.kmlContentSelector.initFromKml(CasaSoft.vrt.KmlLib.KmlLib)
-------------------------------------------------------------------------------------

 set controls status form kml data 

Parameter *kml*:

kml data objects

Field: CasaSoft.vrt.forms.kmlContentSelector.components
-------------------------------------------------------

 Variabile di progettazione necessaria. 

Method: CasaSoft.vrt.forms.kmlContentSelector.Dispose(System.Boolean)
---------------------------------------------------------------------

 Pulire le risorse in uso. 

Parameter *disposing*:

ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.

Method: CasaSoft.vrt.forms.kmlContentSelector.InitializeComponent
-----------------------------------------------------------------

 Metodo necessario per il supporto della finestra di progettazione. Non modificare il contenuto del metodo con l'editor di codice. 

Method: CasaSoft.vrt.forms.KmlPoint.#ctor
-----------------------------------------

 Constructor 

Method: CasaSoft.vrt.forms.KmlPoint.parse4double(System.String)
---------------------------------------------------------------

 Converts textbox input to double 

Parameter *s*:

string to parse

*Returns*: 

Property: CasaSoft.vrt.forms.KmlPoint.Lat
-----------------------------------------

 Return Latitude 

Property: CasaSoft.vrt.forms.KmlPoint.Lon
-----------------------------------------

 Return Longitude 

Method: CasaSoft.vrt.forms.KmlPoint.setLocale(NGettext.ICatalog)
----------------------------------------------------------------

 Sets localizable strings 

Parameter *catalog*:



Method: CasaSoft.vrt.forms.KmlPoint.SetKml(CasaSoft.vrt.KmlLib.KmlLib)
----------------------------------------------------------------------

 Initializes the combobox 

Parameter *kml*:

instance of [[|T:CasaSoft.vrt.KmlLib.KmlLib]]

Field: CasaSoft.vrt.forms.KmlPoint.components
---------------------------------------------

 Variabile di progettazione necessaria. 

Method: CasaSoft.vrt.forms.KmlPoint.Dispose(System.Boolean)
-----------------------------------------------------------

 Pulire le risorse in uso. 

Parameter *disposing*:

ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.

Method: CasaSoft.vrt.forms.KmlPoint.InitializeComponent
-------------------------------------------------------

 Metodo necessario per il supporto della finestra di progettazione. Non modificare il contenuto del metodo con l'editor di codice. 

Method: CasaSoft.vrt.forms.KmlUtilForm.#ctor(System.Reflection.Assembly,System.Globalization.CultureInfo)
---------------------------------------------------------------------------------------------------------

 Constructor 

Method: CasaSoft.vrt.forms.KmlUtilForm.AfterFileOpenerChanged
-------------------------------------------------------------

 Virtual method for extra inits 

Method: CasaSoft.vrt.forms.KmlUtilForm.GetResult(CasaSoft.vrt.KmlLib.IConverter)
--------------------------------------------------------------------------------

 Result of kml processing 

Parameter *conv*:

Instance of class with [[|T:CasaSoft.vrt.KmlLib.IConverter]] interface

*Returns*: 

Field: CasaSoft.vrt.forms.KmlUtilForm.components
------------------------------------------------

 Required designer variable. 

Method: CasaSoft.vrt.forms.KmlUtilForm.Dispose(System.Boolean)
--------------------------------------------------------------

 Clean up any resources being used. 

Parameter *disposing*:

true if managed resources should be disposed; otherwise, false.

Method: CasaSoft.vrt.forms.KmlUtilForm.InitializeComponent
----------------------------------------------------------

 Required method for Designer support - do not modify the contents of this method with the code editor. 

Type: CasaSoft.vrt.forms.Properties.Resources
=============================================

 Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e cosç via. 

Property: CasaSoft.vrt.forms.Properties.Resources.ResourceManager
-----------------------------------------------------------------

 Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe. 

Property: CasaSoft.vrt.forms.Properties.Resources.Culture
---------------------------------------------------------

 Esegue l'override della proprietÖ CurrentUICulture del thread corrente per tutte le ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata. 


