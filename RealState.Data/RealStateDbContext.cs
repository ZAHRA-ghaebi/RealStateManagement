using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using RealState.Data.Entities;
namespace RealState.Data;
public class RealStateDbcontext:DbContext
{
    private string _ConnectionString;
    public RealStateDbcontext(string connectionString)
    {
        _ConnectionString = connectionString;
    }
    public DbSet<Customer> Customers =>Set<Customer>();
    public DbSet<Seller> sellers => Set<Seller>();
    public DbSet<Property> Properties =>Set<Property>();  
    public DbSet<Contract> Contracts =>Set<Contract>();
    public DbSet <Payment> Payments =>Set<Payment>();
    public DbSet<User> Users =>Set<User>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseSqlServer(_ConnectionString);
        base.OnConfiguring(optionsBuilder);
    }
}
