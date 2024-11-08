using Vogen;

namespace Domain.UserAggregate.ValueObjects;

[ValueObject<string>] 
public partial class LastName
{
    private static Validation Validate(string value)
        => !string.IsNullOrWhiteSpace(value) ? Validation.Ok : Validation.Invalid("Last name cannot be empty.");
}
