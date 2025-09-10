#!/usr/bin/env bash
set -e

# Create the new project folder and initialize a console application
dotnet new console -o 1-new_project

# Restore dependencies
dotnet restore 1-new_project

# Build the project
dotnet build 1-new_project