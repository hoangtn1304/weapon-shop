using Microsoft.EntityFrameworkCore;
using WeaponShop.Infrastructure.Data.Entities;

namespace WeaponShop.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

    public DbSet<Weapon> Weapons => Set<Weapon>();
}