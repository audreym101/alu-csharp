#!/usr/bin/env bash

# Create the folder if it doesn't exist
mkdir -p 2-new_project
cd 2-new_project

# Only create a new console project if Program.cs does not exist
if [ ! -f Program.cs ]; then
    dotnet new console
fi

# Build the project
dotnet build

# Run the project
dotnet run
# --- IGNORE ---