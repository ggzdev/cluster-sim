:: cluster-sim -- an open-source, highly customizable instrument cluster simulator
:: Copyright (c) 2024 Kian Schmalzl. All rights reserved. Licensed under MIT-License
:: make-file Version 0.1-stable [last update: 12.03.2024]
:: https://www.github.com/ggzdev/cluster-sim

@echo off

echo cluster-sim project compiler (make) Version 0.1-stable

echo
echo compile: Building from source (win-x86_64 scc)
dotnet publish -c Release -r win-x64 --self-contained
dotnet publish -c Release -r win-x86 --self-contained

echo internal: finishing project structure...
xcopy ".\bin\Release\net8.0\win-x64" ".\out\win-x64" /E /I /H /Y
xcopy ".\bin\Release\net8.0\win-x86" ".\out\win-x86" /E /I /H /Y

echo internal: batch building process finished with code 0.
exit /b 0