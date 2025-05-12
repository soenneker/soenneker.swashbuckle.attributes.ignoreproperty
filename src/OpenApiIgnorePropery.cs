using System;

namespace Soenneker.Swashbuckle.Attributes.IgnoreProperty;

/// <summary>
/// Hides a property from OpenAPI/Swagger documentation without affecting JSON serialization. Use this when a property should be used at runtime but not exposed in the public API contract.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class OpenApiIgnoreProperty : Attribute
{
}