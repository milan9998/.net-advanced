using System.Reflection;
using Demo.Application.Common.Interfaces;
using Demo.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Demo.Infrastructure.Contexts; 


public class ConnDbcontext : 
    IdentityDbContext<
    ApplicationUser,
    ApplicationRole,
    string,
    IdentityUserClaim<string>,
    ApplicationUserRole,
    IdentityUserLogin<string>,
    IdentityRoleClaim<string>,
    IdentityUserToken<string>>, 
    IDemoDbContext
 /*
  public ConnDbcontext(DbContextOptions<ConnDbcontext> options) : base(options)
    {
    }
  */
{
    public ConnDbcontext(DbContextOptions<ConnDbcontext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=123");

    public DbSet<Product> Products => Set<Product>();
    public DbSet<Company> Companies => Set<Company>();

    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        var result = await base.SaveChangesAsync(cancellationToken);
        return result;
    }
}