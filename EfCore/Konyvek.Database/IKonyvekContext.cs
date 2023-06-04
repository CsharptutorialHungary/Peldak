using Konyvek.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Konyvek.Database
{
    internal interface IKonyvekContext
    {
        DbSet<Author> Authors { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<Publisher> Publishers { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}