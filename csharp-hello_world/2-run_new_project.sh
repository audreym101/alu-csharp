#!/usr/bin/env bash
# Initialize, build, and run a new C# project in 2-new_project
set -e

DIR="2-new_project"

# Initialize the console project only if it doesn't exist
if [ ! -d "$DIR" ]; then
  dotnet new console -o "$DIR"
fi

# Restore, build, and run the project
dotnet restore "$DIR/$DIR.csproj"
dotnet build "$DIR/$DIR.csproj"
dotnet run --project "$DIR/$DIR.csproj"
