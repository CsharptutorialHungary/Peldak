using Konyvek.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Konyvek.Database.EntityConfigurations;

internal sealed class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasKey(book => book.ISBN);
        builder.Property(book => book.Title).IsRequired();
        builder.Property(book => book.PublishYear).IsRequired();
        builder.HasIndex(book => book.Title).IsUnique(false);

        builder
            .HasOne(book => book.Author)
            .WithMany(author => author.Books);

        builder
            .HasOne(book => book.Publisher)
            .WithMany(publisher => publisher.Books);

    }
}
