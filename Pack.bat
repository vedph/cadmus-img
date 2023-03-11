@echo off
echo BUILD
del .\Cadmus.Img.Parts\bin\Debug\*.nupkg
del .\Cadmus.Img.Parts\bin\Debug\*.snupkg
del .\Cadmus.Seed.Img.Parts\bin\Debug\*.nupkg
del .\Cadmus.Seed.Img.Parts\bin\Debug\*.snupkg

cd .\Cadmus.Img.Parts
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

cd .\Cadmus.Seed.Img.Parts
dotnet pack -c Debug -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
cd..

pause
