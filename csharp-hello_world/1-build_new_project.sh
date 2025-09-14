#!/usr/bin/env bash
# Initialize and build a new C# project inside 1-new_project
set -e

DIR="1-new_project"

# Ensure a clean setup
if [ -d "$DIR" ]; then
  rm -rf "$DIR"
fi

# Initialize the console project
# Suppress template creation logs to keep output minimal
dotnet new console -o "$DIR" >/dev/null

# Build the project and print only the summary lines
if ! build_output=$(dotnet build "$DIR/$DIR.csproj" 2>&1); then
  echo "$build_output" >&2
  exit 1
fi
# Extract exactly the three expected lines
printf "%s\n" "$build_output" | awk '/^Build succeeded\./{print; getline; print; getline; print; exit}'