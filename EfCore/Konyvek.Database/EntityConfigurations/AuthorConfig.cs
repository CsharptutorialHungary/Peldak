using Konyvek.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Konyvek.Database.EntityConfigurations;

internal sealed class AuthorConfig : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.HasKey(author => author.Id);
        builder.Property(author => author.FirstName).IsRequired();
        builder.Property(author => author.LastName).IsRequired();
        builder.HasIndex(author => author.FirstName).IsUnique(false);
        builder.HasIndex(author => author.LastName).IsUnique(false);
    }
}
