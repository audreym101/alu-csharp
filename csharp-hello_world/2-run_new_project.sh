#!/usr/bin/env bash
# Script to initialize, build, and run a new C# project

# Create a new console project in 2-new_project
dotnet new console -o 2-new_project

# Build the project
dotnet build 2-new_project

# Run the project
dotnet run --project 2-new_project
