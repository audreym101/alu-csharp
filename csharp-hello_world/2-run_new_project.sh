#!/usr/bin/env bash
# 2-run_new_project.sh

# Exit immediately if a command fails
set -e

# Create a new console project in 2-new_project folder
dotnet new console -o 2-new_project

# Navigate into the project folder
cd 2-new_project

# Restore dependencies
dotnet restore

# Build the project
dotnet build

# Run the project
dotnet run
