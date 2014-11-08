cd %~dp0

MSBuild.exe ..\..\src\MvcAccount\MvcAccount.csproj /p:Configuration=Release
MSBuild.exe MvcAccount.shfbproj
MSBuild.exe sandcastle-md\sandcastle-md.sln
rd /s /q ..\..\docs\api
sandcastle-md\src\sandcastle-md\bin\Debug\sandcastle-md.exe output ..\..\docs\api
