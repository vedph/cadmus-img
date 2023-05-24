@echo off
echo PRESS ANY KEY TO INSTALL TO LOCAL NUGET FEED
echo Remember to generate the up-to-date package.
c:\exe\nuget add .\Cadmus.Img.Parts\bin\Debug\Cadmus.Img.Parts.1.0.0.nupkg -source C:\Projects\_NuGet
c:\exe\nuget add .\Cadmus.Seed.Img.Parts\bin\Debug\Cadmus.Seed.Img.Parts.1.0.0.nupkg -source C:\Projects\_NuGet
pause
