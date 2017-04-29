@echo off

REM script for building website to host on github

set builddir=_build
set site=..\docs
rem set downloads=%site%\bin

call make.bat clean
call make.bat html
xcopy %builddir%\html %site%  /S /Y 

rem call make.bat latexpdf
rem copy /Y %builddir%\latex\*.pdf %downloads%

cd ..
git add .
git commit -m "Automatic site update"
git push origin master
cd doc_src