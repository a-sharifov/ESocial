using Vogen;

namespace Domain.UserAggregate.ValueObjects;

[ValueObject<string>] 
public partial class RefreshToken
{
    private static Validation Validate(string value)
        => value == null || value.Length >= 20 ? Validation.Ok : Validation.Invalid("Refresh token must be at least 20 characters long.");
}
