using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TriviaBuddy.Data.Models;

namespace TriviaBuddy.Data.EntityConfigurations;

internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // Make sure all columns have correct names
        builder.Property(x => x.CategoryId)
            .HasColumnName("category_id");
        builder.Property(x => x.Name)
            .HasColumnName("name");
        builder.Property(x => x.Description)
            .HasColumnName("description");
        builder.Property(x => x.CreatedOn)
            .HasColumnName("created_on");
        builder.Property(x => x.ModifiedOn)
            .HasColumnName("modified_on");
        
        // Set default values
        builder.Property(x => x.CategoryId)
            .HasDefaultValueSql("uuid_generate_v4()");
        builder.Property(x => x.CreatedOn)
            .HasDefaultValueSql("CURRENT_DATE");
        builder.Property(x => x.ModifiedOn)
            .HasDefaultValueSql("CURRENT_DATE");
    }
}