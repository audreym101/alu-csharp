#!/bin/bash
# Navigate to the folder where the project will be created
mkdir -p 2-new_project
cd 2-new_project

# Initialize a new C# console project
dotnet new console

# Build the project
dotnet build

# Run the project
dotnet run
# The output should be "Hello, World!" if everything is set up correctly.