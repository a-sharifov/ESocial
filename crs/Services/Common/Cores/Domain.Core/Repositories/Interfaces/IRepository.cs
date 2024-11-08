using Ardalis.SharedKernel;

namespace Domain.Core.Repositories.Interfaces;

/// <summary>
/// Interface for repository.
/// </summary>
/// <typeparam name="TEntity"> The entity type.</typeparam>
/// <typeparam name="TStrongestId"> The strongest id type.</typeparam>
public interface IRepository<TEntity, TStrongestId>
    where TEntity : EntityBase<TEntity, TStrongestId>
    where TStrongestId : struct, IEquatable<TStrongestId>;
