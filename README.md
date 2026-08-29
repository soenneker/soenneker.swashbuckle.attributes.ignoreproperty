[![](https://img.shields.io/nuget/v/soenneker.swashbuckle.attributes.ignoreproperty.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.swashbuckle.attributes.ignoreproperty/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.swashbuckle.attributes.ignoreproperty.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.swashbuckle.attributes.ignoreproperty/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.swashbuckle.attributes.ignoreproperty/actions/workflows/codeql.yml)

# Soenneker.Swashbuckle.Attributes.IgnoreProperty

Hides a property from OpenAPI/Swagger documentation without affecting JSON serialization. Use this when a property should be used at runtime but not exposed in the public API contract.

## Install

```bash
dotnet add package Soenneker.Swashbuckle.Attributes.IgnoreProperty
```

## What you get

- `OpenApiIgnoreProperty` — Hides a property from OpenAPI/Swagger documentation without affecting JSON serialization. Use this when a property should be used at runtime but not exposed in the public API contract.
