@ECHO OFF

@REM First, if Program.cs exists, copy it to a cache file, then remove it!
echo Removing Program.cs...
cp Program.cs Program.cache
rm Program.cs

@REM Remove the csharp project file (if that doesn't exist, it will just give an error and move on)
echo Removing *.csproj...
rm *.csproj

@REM Remove the binary and object folders of the project (if these don't exist, it will just give an error and move on)
echo Removing binary and object folders...
rmdir /s /q bin
rmdir /s /q obj

@REM Once the old files are created, create a brand new project using dotnet
echo Old files cleaned! Creating new project...
dotnet new console
dotnet restore

@REM If there's a cache file for Program.cs, copy the content to the Program.cs just created
cp Program.cache Program.cs

@REM Remove the cache file
@REM rm Program.cache