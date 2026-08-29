$ErrorActionPreference = "Stop"

Write-Host ""
Write-Host "Socratic C# Learning Environment"
Write-Host "================================"
Write-Host ""

if (-not (Get-Command dotnet -ErrorAction SilentlyContinue)) {
    Write-Host "The .NET SDK is not installed or is not on PATH."
    Write-Host ""
    Write-Host "Install the current .NET SDK, restart VS Code, and run this script again."
    exit 1
}

$version = dotnet --version
Write-Host ".NET SDK detected: $version"
Write-Host ""

if (Test-Path "SocraticStore.sln") {
    Write-Host "SocraticStore.sln already exists."
    Write-Host "Setup will not overwrite the learner's project."
    exit 0
}

New-Item -ItemType Directory -Force -Path "src" | Out-Null
New-Item -ItemType Directory -Force -Path "tests" | Out-Null

dotnet new sln -n SocraticStore

dotnet new console -n Store.Console -o src/Store.Console
dotnet new webapi -n Store.Api -o src/Store.Api

dotnet new xunit -n Store.Console.Tests -o tests/Store.Console.Tests
dotnet new xunit -n Store.Api.Tests -o tests/Store.Api.Tests

dotnet sln SocraticStore.sln add src/Store.Console/Store.Console.csproj
dotnet sln SocraticStore.sln add src/Store.Api/Store.Api.csproj
dotnet sln SocraticStore.sln add tests/Store.Console.Tests/Store.Console.Tests.csproj
dotnet sln SocraticStore.sln add tests/Store.Api.Tests/Store.Api.Tests.csproj

dotnet add tests/Store.Console.Tests/Store.Console.Tests.csproj reference src/Store.Console/Store.Console.csproj
dotnet add tests/Store.Api.Tests/Store.Api.Tests.csproj reference src/Store.Api/Store.Api.csproj

Write-Host ""
Write-Host "Starter solution created."
Write-Host ""
Write-Host "Next:"
Write-Host "  1. Select the Workshop Guide agent in Copilot Chat."
Write-Host "  2. Tell it: 'I am ready to begin.'"
Write-Host ""
Write-Host "Do not worry about understanding everything this script created yet."
Write-Host "That is what the learning agents are for."
