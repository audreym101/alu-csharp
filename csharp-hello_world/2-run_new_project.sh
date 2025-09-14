#!/usr/bin/env bash
# Initialize, build, and run a new C# project in 2-new_project
set -e

DIR="2-new_project"

# Ensure a clean setup
if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi

# Initialize the console project
dotnet new console -o "$DIR"

# Restore, build, and run the project
dotnet restore "$DIR/$DIR.csproj"
dotnet build "$DIR/$DIR.csproj"
dotnet run --project "$DIR/$DIR.csproj"
