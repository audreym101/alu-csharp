#!/usr/bin/env bash
# Initialize and build a C# project in 1-new_project

set -e

folder="1-new_project"

# Remove folder if it exists (clean start)
if [ -d "$folder" ]; then
    rm -rf "$folder"
fi

# Create new console project
dotnet new console -o $folder

# Build the project and print the build output
dotnet build $folder | tee /dev/tty

# Instructions
echo "Initialized and built C# project in $folder/"
echo "To run: cd $folder && dotnet run"
ls -la $folder
