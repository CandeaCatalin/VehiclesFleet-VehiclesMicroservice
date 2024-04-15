using Microsoft.EntityFrameworkCore;
using VehiclesMicroservice.DataAccess.Entities;

namespace VehiclesMicroservice.DataAccess;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    }

    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<VehicleError> VehiclesErrors { get; set; }
}