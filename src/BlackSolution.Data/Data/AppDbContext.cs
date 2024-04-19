using BlackSolution.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlackSolution.Data.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Blog> blogs { get; set; }
}
