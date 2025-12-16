using dotNetWedEve;
using Microsoft.EntityFrameworkCore;

public class dotNetWedEveContext : DbContext
{
    public dotNetWedEveContext(
        DbContextOptions options) : base(options)
    {
    }

    public DbSet<dotNetWedEve.Category> Category { get; set; } = default!;
    public DbSet<dotNetWedEve.Transaction> Transaction { get; set; } = default!;

}