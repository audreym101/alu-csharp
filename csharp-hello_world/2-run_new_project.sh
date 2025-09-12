#!/usr/bin/env bash
# Script to build and run an existing C# project

# Build the project in the folder 2-new_project
dotnet build 2-new_project

# Run the project
dotnet run --project 2-new_project
