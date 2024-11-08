using Vogen;

namespace Domain.UserAggregate.ValueObjects;

[ValueObject<string>] 
public partial class EmailConfirmationToken
{
    private static Validation Validate(string value)
        => value.Length >= 20 ? Validation.Ok : Validation.Invalid("Email confirmation token is invalid.");
}
