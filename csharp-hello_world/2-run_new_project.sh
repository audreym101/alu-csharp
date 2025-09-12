#!/usr/bin/env bash
# Script to initialize, build, and run a new C# project

# Folder name
DIR="2-new_project"

# Remove the folder if it already exists
if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi

# Create a new console project
dotnet new console -o "$DIR"

# Ensure Program.cs contains the Hello World line
echo 'using System;
class Program {
    static void Main(string[] args) {
        Console.WriteLine("Hello World!");
    }
}' > "$DIR/Program.cs"

# Build the project
dotnet build "$DIR"

# Run the project
dotnet run --project "$DIR"
