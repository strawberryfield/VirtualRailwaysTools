pushd .
set rar="C:\Program Files\WinRAR\winrar.exe"
set mstsfile=docs\dist\MSTStools
set r3dfile=docs\dist\R3Dtools

cd ..\bin
%rar% a ..\%mstsfile% @..\tools\listafilesmsts.txt
cd ..
%rar% a %mstsfile% LICENSE.txt README.md

cd bin
%rar% a ..\%r3dfile% @..\tools\listafilesr3d.txt
cd ..
%rar% a %r3dfile% LICENSE.txt README.md

popd