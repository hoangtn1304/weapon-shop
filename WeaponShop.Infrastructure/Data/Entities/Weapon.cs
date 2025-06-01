using Microsoft.EntityFrameworkCore;

namespace WeaponShop.Infrastructure.Data.Entities;

public class Weapon
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Type { get; set; } = default!;
    public int Damage { get; set; }
    
    [Precision(18, 2)]
    public decimal Price { get; set; }
}