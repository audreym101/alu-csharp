#!/usr/bin/env bash
set -e
folder="1-new_project"

# Remove folder if it exists (clean start)
if [ -d "$folder" ]; then
    rm -rf "$folder"
fi

# Create new console project
dotnet new console -o "$folder"
dotnet restore "$folder"

# Build the project and print the build output
dotnet build "$folder"