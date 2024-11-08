using Ardalis.SharedKernel;
using Domain.SharedKernel.Repositories;
using Domain.UserAggregate.Ids;
using Domain.UserAggregate.ValueObjects;
namespace Domain.UserAggregate.Repositories;

public interface IUserRepository<TEntity, TStrongestId> 
    : IBaseRepository<TEntity, TStrongestId>
    where TEntity : EntityBase<TEntity, TStrongestId>
    where TStrongestId : struct, IEquatable<TStrongestId>
{
    Task<User> GetAsync(Email email, CancellationToken cancellationToken = default);
    Task<bool> IsEmailUniqueAsync(Email email, CancellationToken cancellationToken = default);
    Task<bool> IsEmailConfirmedAsync(UserId userId, CancellationToken cancellationToken = default);
    Task<bool> IsExistAsync(Email email, CancellationToken cancellationToken = default);
}
