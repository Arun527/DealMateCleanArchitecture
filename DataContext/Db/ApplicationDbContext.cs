using Authorization.Domain.Aggregates;
using Core.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataContext.Db;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Employee> Employee { get; set; }
    public DbSet<Dealer> Dealer { get; set; }
    public DbSet<Role> Role { get; set; }
    public DbSet<Branch> Branch { get; set; }
    public DbSet<Permission> Permission { get; set; }
    public DbSet<RolePermission> RolePermission { get; set; }
    public DbSet<Vehicle> Vehicle { get; set; }

}
