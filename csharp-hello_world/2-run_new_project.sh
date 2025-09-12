#!/usr/bin/env bash
# Script to initialize, build, and run a new C# project

# Folder name
DIR="2-new_project"

# Remove the folder if it already exists
if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi

# Create a new console project
dotnet new console -o "$DIR"

# Build the project
dotnet build "$DIR"

# Run the project
dotnet run --project "$DIR"
