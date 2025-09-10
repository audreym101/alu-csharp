#!/usr/bin/env bash
folder="0-new_project"
dotnet new console -o $folder
echo "Initialized new C# console project in $folder/"
ls -la $folder
echo "To run the project: cd $folder && dotnet run"
