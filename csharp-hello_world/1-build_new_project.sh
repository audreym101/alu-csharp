#!/usr/bin/env bash

# Create the project directory
mkdir -p 1-new_project

# Navigate to the project directory
cd 1-new_project

# Create a new console application
dotnet new console > /dev/null 2>&1

# Build the project
dotnet build > /dev/null 2>&1