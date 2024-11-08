using Ardalis.SharedKernel;
using Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Command.DbContexts;

internal class IdentityDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public IdentityDbContext() { }

    public IdentityDbContext(DbContextOptions<IdentityDbContext> options) 
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
     modelBuilder
     .Ignore<IList<DomainEventBase>>()
     .ApplyConfigurationsFromAssembly(AssemblyReference.Assembly);

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder..UsePostgreSql();
}

