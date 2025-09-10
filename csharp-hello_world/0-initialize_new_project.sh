#!/usr/bin/env bash
folder="0-new_project"

# Create the project folder
mkdir -p $folder
cd $folder

# Initialize a new console project in the current folder
dotnet new console -n $folder

cd ..
echo "Initialized new C# console project in $folder/"
ls -la $folder
echo "To run the project, navigate to $folder and execute 'dotnet run'"
echo "To build the project, navigate to $folder and execute 'dotnet build'"
