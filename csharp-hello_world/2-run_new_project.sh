#!/usr/bin/env bash

# Navigate to (or create) the project folder
mkdir -p 2-new_project
cd 2-new_project

# Initialize a new C# console project
dotnet new console

# Build the project
dotnet build

# Run the project
dotnet run
