[![](https://img.shields.io/nuget/v/soenneker.swashbuckle.attributes.ignoreproperty.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.swashbuckle.attributes.ignoreproperty/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.swashbuckle.attributes.ignoreproperty.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.swashbuckle.attributes.ignoreproperty/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/actions/workflows/codeql.yml)

# Soenneker.Swashbuckle.Attributes.IgnoreProperty

Provides `OpenApiIgnoreProperty`, a marker for properties that should be omitted from generated OpenAPI schemas without changing runtime serialization.

## Installation

```bash
dotnet add package Soenneker.Swashbuckle.Attributes.IgnoreProperty
```

## Usage

```csharp
using Soenneker.Swashbuckle.Attributes.IgnoreProperty;

public sealed class UserResponse
{
    public required string DisplayName { get; init; }

    [OpenApiIgnoreProperty]
    public string? InternalCorrelationId { get; init; }
}
```

The attribute is metadata only. To make Swashbuckle act on it, install `Soenneker.Swashbuckle.SchemaFilters.IgnoreProperties` and register its filter:

```csharp
using Soenneker.Swashbuckle.SchemaFilters.IgnoreProperties;

builder.Services.AddSwaggerGen(options =>
{
    options.SchemaFilter<IgnorePropertiesSchemaFilter>();
});
```

This affects the generated API contract only. It does not stop ASP.NET Core, System.Text.Json, or Newtonsoft.Json from reading or writing the property. Use the serializer's ignore attribute as well when the value must not appear in runtime JSON.
