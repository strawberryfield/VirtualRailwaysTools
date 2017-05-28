cd ..\bin
for %%a in (CasaSoft*.xml) do ..\tools\xml2rst %%a >..\doc_src\%%a.rst