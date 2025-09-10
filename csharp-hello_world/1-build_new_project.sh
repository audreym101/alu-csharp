#!/usr/bin/env bash

# Create a new console application in 1-new_project directory
dotnet new console -o 1-new_project > /dev/null 2>&1

# Build the project
dotnet build 1-new_project