using Konyvek.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Konyvek.Database;

internal sealed class KonyvekContext : DbContext, IKonyvekContext
{
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    public KonyvekContext()
    {
        Database.Migrate();
    }

    public string DbFile
        => Path.Combine(AppContext.BaseDirectory, "database.sqlite");

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite($"Data Source={DbFile}");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(KonyvekContext).Assembly);
    }
}
