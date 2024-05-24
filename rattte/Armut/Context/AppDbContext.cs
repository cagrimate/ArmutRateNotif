using Armut.Entities;
using Microsoft.EntityFrameworkCore;

namespace Armut.Context
{
  public class AppDbContext : DbContext
  {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      base.OnConfiguring(optionsBuilder);
      optionsBuilder.UseSqlServer("Server=; Database=;uid=;pwd=;TrustServerCertificate=true"); //please use your own conf.
    }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Company> companies { get; set; }
  }
}
