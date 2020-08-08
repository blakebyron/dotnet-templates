# Base Templates

This repository contains templates for creating applications with a predefined structure and some basic functionality.

Created using the [Template Engine](https://github.com/dotnet/templating/), these custom templates can be used with the `dotnet new` command to create projects quickly and consistently.

## Installation

### Prerequisites

Installation of .Net Core SDK. Suggested version is 3.1 or higher.(https://dotnet.microsoft.com/download/dotnet-core/3.1)

### Install with

```bash
dotnet new -i .\
```

<p>If you need to set back your dotnet new list to "factory defaults", use this command:</p>

```bash
dotnet new --debug:reinit
```

## Useage

### dotnet new baseapi

```bash
dotnet new baseapi --name Property.Api -o Property.Api
```

The example demonstrates use of the `baseapi` project template to create a project with the name `Property.Api`. The `-o` parameter defines the directory in which the project will be created

### dotnet new featurefolder

```bash
dotnet new featurefolder --name Property --namespace Property.Api
```

This second example makes use of the `featurefolder` item template, adds a folder called `property` sets the namespace to `Property.Api`. The command should be run in the the `features` directory of the application.

The namespace defined is case sensitive and should match that of the receving application which requires references to the MediatR library.

## Roadmap

- Consider adding behaviour as an example of a logging implementation
- Change logging settings to be defined in appsettings.json

# Related Projects

These projects are related and might provide a source of useful information

- Template Engine
  (https://github.com/dotnet/templating/)
- Template Samples
  (https://github.com/dotnet/dotnet-template-samples)
- ASP.Net Core Project Templates
  (https://github.com/dotnet/aspnetcore/tree/master/src/ProjectTemplates)
