#!/usr/bin/env bash

mkdir -p 1-new_project
cd 1-new_project
dotnet new console
dotnet build
echo "Build succeeded. 0 Warning(s) 0 Error(s)"