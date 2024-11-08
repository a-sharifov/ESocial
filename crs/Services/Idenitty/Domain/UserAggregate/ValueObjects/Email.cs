using Domain.UserAggregate.Regexes;
using Vogen;

namespace Domain.UserAggregate.ValueObjects;

[ValueObject<string>] 
public partial class Email
{
    private static Validation Validate(string value)
        => EmailRegex.Regex().IsMatch(value) 
        ? Validation.Ok : Validation.Invalid("Email is invalid.");
}
