using Konyvek.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Konyvek.Database.EntityConfigurations;

internal sealed class PublisherConfig : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.HasKey(publisher => publisher.Id);
        builder.Property(publisher => publisher.Name).IsRequired();
        builder.Property(publisher => publisher.Adress).IsRequired();
        builder.HasIndex(publisher => publisher.Name).IsUnique(false);
    }
}
