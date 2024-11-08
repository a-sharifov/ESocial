using Vogen;

namespace Domain.UserAggregate.ValueObjects;

[ValueObject<string>] 
public partial class PasswordSalt
{
    private static Validation Validate(string value)
        => value.Length >= 8 ? Validation.Ok : Validation.Invalid("Password salt is too short.");
}
