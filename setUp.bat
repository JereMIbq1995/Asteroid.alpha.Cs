@ECHO OFF
dotnet new console
dotnet restore
copyFile main.txt Program.cs