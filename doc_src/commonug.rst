.. copyright (c) 2017 Roberto Ceccarelli - CasaSoft
   http://strawberryfield.altervista.org 
   
   This file is part of CasaSoft Virtual Railways Tools
   
   CasaSoft Virtual Railways Tools is free software: 
   you can redistribute it and/or modify it
   under the terms of the GNU General Public License as published by
   the Free Software Foundation, either version 3 of the License, or
   (at your option) any later version.
   
   CasaSoft Virtual Railways Tools is distributed in the hope that it will be useful,
   but WITHOUT ANY WARRANTY; without even the implied warranty of
   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  
   See the GNU General Public License for more details.
   
   You should have received a copy of the GNU General Public License
   along with CasaSoft Virtual Railways Tools.  
   If not, see <http://www.gnu.org/licenses/>.

.. _commonug:

Common informations
*******************

In this section are described common informations about setup and localization
for all the included programs

Setup
=====

These programs don't need special setup procedure: simply unpack all the files in a folder 
of your choice (please maintain the subfolders hierarchy) and run.

Localization
============

The programs can be localized in any language.

Currently only english and italian languages are available; the programs use the machine locale
and if it is not available default to english.

You can force any program to a specific locale modifying the *programname*.config file that appear like this::

    <?xml version="1.0" encoding="utf-8"?>
    <configuration>
      <startup>
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.0"/>
      </startup>
      <appSettings>
        <add key="locale" value=""/>
      </appSettings>
    </configuration>

The code of the requested locale can be specified in the value property of the line 
``<add key="locale" value=""/>``.

For example to force using english the line must be::

      <appSettings>
        <add key="locale" value="en"/>
      </appSettings>

To create a new locale please refer to the developers' documentation.