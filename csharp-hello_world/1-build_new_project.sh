#!/usr/bin/env bash
# This script initializes and builds a new C# console project in folder 1-new_project

# Exit immediately if a command fails
set -e

# Folder name
folder="1-new_project"

# Initialize a new console project
dotnet new console -o $folder

# Build the project
dotnet build $folder

# Print success message and instructions
echo "Initialized and built new C# console project in $folder/"
ls -la $folder
echo "To run the project: cd $folder && dotnet run"
echo "To open the project in VS Code: code $folder"