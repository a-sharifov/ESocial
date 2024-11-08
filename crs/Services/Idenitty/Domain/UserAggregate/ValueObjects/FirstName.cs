using Vogen;

namespace Domain.UserAggregate.ValueObjects;

[ValueObject<string>] 
public partial class FirstName
{
    private static Validation Validate(string value)
        => !string.IsNullOrWhiteSpace(value) ? Validation.Ok : Validation.Invalid("First name cannot be empty.");
}
