#!/usr/bin/env bash

# Exit if any command fails
set -e

# Create the new project folder if it doesn't exist
PROJECT_DIR="0-new_project"
if [ ! -d "$PROJECT_DIR" ]; then
    mkdir "$PROJECT_DIR"
fi

# Initialize the C# console project using dotnet
dotnet new console -o "$PROJECT_DIR"

# Optional: Restore dependencies
dotnet restore "$PROJECT_DIR"