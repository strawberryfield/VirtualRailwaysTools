# VirtualRailwaysTools
## Tools for Trains e Railways simulators

### Intro

You can read online documentation here: https://strawberryfield.github.io/VirtualRailwaysTools/

### Build binaries and documentation

#### Programs

Source code is written in C# and targeted to .NET 4.0 so it can run on Windows XP and above
and under Mono (only for the command-line versions; there is no working implementation of Windows Forms for Mono)

Sorurce code is developed and tested with Visual Studio 2017 Community Edition, it could not 
work with 'Express' editions

#### Documentation

Documentation is written in ReStructuredText and can be build with Sphinx-Build

You need to install Python and Sphinx, as described in 
http://www.sphinx-doc.org/en/stable/install.html

If you want to create PDF files also install MikTex as described in 
http://miktex.org/howto/install-miktex

The following two build targets are configured and can be used:

make.bat html
make.bat latexpdf

Targeting latexpdf will build the documentation first to LaTex format, then 
using MikTex will be converted to pdf. Please take care, that some object 
types (tables being one of them) are built differently to html, using 
different in-document configuration options. To ensure proper result, a test 
latexpdf build should be performed at inserting such objects. 

Please be aware that MikTex will download additional modules from internet 
at first run, please make sure to allow that.

You can also read this interesting introduction to ReStructuredText by Peter Gulyas: 
https://gist.github.com/pzgulyas/b5068c7c2cc801dc36e7

Or my guide (in italian language): https://strawberryfield.github.io/guide_guide/index.html 

### Acknowledgments

### Legal

#### Warranty

NO WARRANTIES: The author disclaims any warranty, at all, for its Software.
This software and any related tools, or documentation is provided
"as is" without warranty of any kind, either express or implied, including
suitability for use. You, as the user of this software, acknowledge the
entire risk from its use. See the license for more details.

#### Properties Acknowledgment

Casasoft, The Strawberry Field and associated graphical representations are the
property of Roberto Ceccarelli. All other third party brands, products, service
names, trademarks, or registered service marks are the property of and used
to identify the products or services of their respective owners.

#### Copyright Acknowledgment and License

copyright (c) 2017 Roberto Ceccarelli - The Strawberry Field.

This document is part of CasaSoft Virtual Railways Tools.
CasaSoft Virtual Railways Tools is free software: you can redistribute it and/or modify it under
the terms of the GNU General Public License as published by the Free
Software Foundation, either version 3 of the License, or any later version.

You should have received a copy of the GNU General Public License as part
of the Open Rails distribution in ``/LICENSE.txt``.
If not, see http://www.gnu.org/licenses/ .
