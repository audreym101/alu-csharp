#!/usr/bin/env bash
# Script to initialize and build a C# project in 1-new_project

set -e

folder="1-new_project"

# Remove the folder if it already exists (optional, ensures clean start)
if [ -d "$folder" ]; then
    rm -rf "$folder"
fi

# Create new console project
dotnet new console -o $folder

# Build the project and print output
dotnet build $folder

# Instructions
echo "Initialized and built C# project in $folder/"
echo "To run: cd $folder && dotnet run"
