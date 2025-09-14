#!/usr/bin/env bash
# Initialize and build a new C# project inside 1-new_project
set -e

DIR="1-new_project"

# Ensure a clean setup
if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi

# Initialize the console project
dotnet new console -o "$DIR"

# Build the project
dotnet build "$DIR/$DIR.csproj"