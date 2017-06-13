Assembly: CasaSoft.vrt.BaseForms
================================

Type: CasaSoft.vrt.forms.AboutBox
---------------------------------

 About box dialog 

Method: CasaSoft.vrt.forms.AboutBox.#ctor(System.Reflection.Assembly,System.Globalization.CultureInfo)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Parameter **program**\: 

Parameter **locale**\: 

Field: CasaSoft.vrt.forms.AboutBox.components
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Required designer variable. 

Method: CasaSoft.vrt.forms.AboutBox.Dispose(System.Boolean)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Clean up any resources being used. 

Parameter **disposing**\: true if managed resources should be disposed; otherwise, false.

Method: CasaSoft.vrt.forms.AboutBox.InitializeComponent
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Required method for Designer support - do not modify the contents of this method with the code editor. 

Type: CasaSoft.vrt.forms.FileOpener
-----------------------------------

 User control with textbox and button for file selection 

Method: CasaSoft.vrt.forms.FileOpener.#ctor
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Property: CasaSoft.vrt.forms.FileOpener.ButtonText
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Text displayed on the button 

Property: CasaSoft.vrt.forms.FileOpener.LabelText
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Text displayed on the label 

Property: CasaSoft.vrt.forms.FileOpener.FileDialogFilter
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Filter for file dialog 

Property: CasaSoft.vrt.forms.FileOpener.FileDialogTitle
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Title for file dialog 

Property: CasaSoft.vrt.forms.FileOpener.FileName
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 File name 

Event: CasaSoft.vrt.forms.FileOpener.FileTextChanged
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Fired on TextChanged in the textbox 

Field: CasaSoft.vrt.forms.FileOpener.components
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Variabile di progettazione necessaria. 

Method: CasaSoft.vrt.forms.FileOpener.Dispose(System.Boolean)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Pulire le risorse in uso. 

Parameter **disposing**\: ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.

Method: CasaSoft.vrt.forms.FileOpener.InitializeComponent
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Metodo necessario per il supporto della finestra di progettazione. Non modificare il contenuto del metodo con l'editor di codice. 

Type: CasaSoft.vrt.forms.FileOpenerForm
---------------------------------------

 extends `Type: CasaSoft.vrt.forms.FormBase`_ with a `Type: CasaSoft.vrt.forms.FileOpener`_

Method: CasaSoft.vrt.forms.FileOpenerForm.#ctor
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor (needed only for inheritance) 

Method: CasaSoft.vrt.forms.FileOpenerForm.#ctor(System.Reflection.Assembly,System.Globalization.CultureInfo)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Method: CasaSoft.vrt.forms.FileOpenerForm.SetFile(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Programmatically sets the filename to load 

Parameter **filename**\: file to load

Method: CasaSoft.vrt.forms.FileOpenerForm.doOpenFile
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 virtual method for file opening dirty work 

Field: CasaSoft.vrt.forms.FileOpenerForm.components
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Required designer variable. 

Method: CasaSoft.vrt.forms.FileOpenerForm.Dispose(System.Boolean)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Clean up any resources being used. 

Parameter **disposing**\: true if managed resources should be disposed; otherwise, false.

Method: CasaSoft.vrt.forms.FileOpenerForm.InitializeComponent
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Required method for Designer support - do not modify the contents of this method with the code editor. 

Field: CasaSoft.vrt.forms.FileOpenerForm.fileOpener
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

`Type: CasaSoft.vrt.forms.FileOpener`_ instance 

Type: CasaSoft.vrt.forms.FormBase
---------------------------------

 Base class for all forms 

Field: CasaSoft.vrt.forms.FormBase.catalog
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 catalog of translations 

Field: CasaSoft.vrt.forms.FormBase.assembly
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Reference to main program assembly 

Field: CasaSoft.vrt.forms.FormBase.locale
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Locale to use for translations 

Field: CasaSoft.vrt.forms.FormBase.prgName
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 name of the calling program 

Method: CasaSoft.vrt.forms.FormBase.#ctor
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor (needed only for inheritance) 

Method: CasaSoft.vrt.forms.FormBase.#ctor(System.Reflection.Assembly,System.Globalization.CultureInfo)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Constructor 

Method: CasaSoft.vrt.forms.FormBase.InitControls
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Controls bas init 

Method: CasaSoft.vrt.forms.FormBase.initSaveDlg
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Vitual method for custom save dialog 

Method: CasaSoft.vrt.forms.FormBase.doSave(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Virtual method for save dirty work 

Parameter **filename**\: File to save

Method: CasaSoft.vrt.forms.FormBase.btnAbout_Click(System.Object,System.EventArgs)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Show the About Box 

Parameter **sender**\: 

Parameter **e**\: 

Method: CasaSoft.vrt.forms.FormBase.getProgramTitle
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Returns the main program description 

**Returns**\: 

Method: CasaSoft.vrt.forms.FormBase.Balloon(System.String)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 displays a notification in a popup balloon 

Parameter **body**\: 

Field: CasaSoft.vrt.forms.FormBase.components
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Required designer variable. 

Method: CasaSoft.vrt.forms.FormBase.Dispose(System.Boolean)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Clean up any resources being used. 

Parameter **disposing**\: true if managed resources should be disposed; otherwise, false.

Method: CasaSoft.vrt.forms.FormBase.InitializeComponent
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Required method for Designer support - do not modify the contents of this method with the code editor. 

Field: CasaSoft.vrt.forms.FormBase.saveFileDialog
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Save file dialog component 

Field: CasaSoft.vrt.forms.FormBase.btnSave
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 save button component 

Field: CasaSoft.vrt.forms.FormBase.btnAbout
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 about button component 

Type: CasaSoft.vrt.forms.Properties.Resources
---------------------------------------------

 Classe di risorse fortemente tipizzata per la ricerca di stringhe localizzate e cosç via. 

Property: CasaSoft.vrt.forms.Properties.Resources.ResourceManager
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Restituisce l'istanza di ResourceManager nella cache utilizzata da questa classe. 

Property: CasaSoft.vrt.forms.Properties.Resources.Culture
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Esegue l'override della proprietÖ CurrentUICulture del thread corrente per tutte le ricerche di risorse eseguite utilizzando questa classe di risorse fortemente tipizzata. 

Property: CasaSoft.vrt.forms.Properties.Resources.LICENSE
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

 Cerca una stringa localizzata simile a GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007 Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/> Everyone is permitted to copy and distribute verbatim copies of this license document, but changing it is not allowed. Preamble The GNU General Public License is a free, copyleft license for software and other kinds of works. The licenses for most software and other practical works are designed to [stringa troncata]";. 


