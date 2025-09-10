#!/usr/bin/env bash

# Create the project directory
mkdir -p 1-new_project

# Navigate to the project directory
cd 1-new_project

# Create a new console application
dotnet new console

# Build the project
dotnet build 2>&1 | tee build.log
# Check if the build was successful
if grep -q "Build succeeded." build.log; then
    echo "Build succeeded."
else
    echo "Build failed. Check build.log for details."
    exit 1
fi  
# Run the application
dotnet run
  
