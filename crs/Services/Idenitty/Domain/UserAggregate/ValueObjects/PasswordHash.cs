using Vogen;

namespace Domain.UserAggregate.ValueObjects;

[ValueObject<string>] 
public partial class PasswordHash
{
    private static Validation Validate(string value)
        => value.Length >= 8 ? Validation.Ok : Validation.Invalid("Password hash is too short.");
}
