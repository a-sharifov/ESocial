using Contracts.Enumurations;
using Ardalis.SharedKernel;
using Domain.UserAggregate.Ids;
using Domain.UserAggregate.ValueObjects;

namespace Domain.UserAggregate;

public sealed class User : EntityBase<User, UserId>, IAggregateRoot
{
    public Email Email { get; private set; }
    public FirstName? FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public PasswordHash PasswordHash { get; private set; }
    public PasswordSalt PasswordSalt { get; private set; }
    public RefreshToken? RefreshToken { get; private set; }
    public EmailConfirmationToken? EmailConfirmationToken { get; private set; }
    public IsEmailConfirmed IsEmailConfirmed { get; private set; }
    public Role Role { get; private set; }
    public Gender Gender { get; private set; }

    public User(
        Email email,
        FirstName firstName,
        LastName lastName,
        PasswordHash passwordHash,
        PasswordSalt passwordSalt,
        RefreshToken? refreshToken,
        EmailConfirmationToken? emailConfirmationToken,
        Role role,
        Gender gender)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
        RefreshToken = refreshToken;
        EmailConfirmationToken = emailConfirmationToken;
        Role = role;
        Gender = gender;
        IsEmailConfirmed = IsEmailConfirmed.From(false);
    }

    public User(
        Email email,
        FirstName firstName,
        LastName lastName,
        PasswordHash passwordHash,
        PasswordSalt passwordSalt,
        RefreshToken? refreshToken,
        Role role,
        Gender gender)
    {
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
        RefreshToken = refreshToken;
        Role = role;
        Gender = gender;
        IsEmailConfirmed = IsEmailConfirmed.From(false);
    }
}