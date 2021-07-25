using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe_Api.Data.Entities;

namespace Recipe_Api.Data.DbInfrasructure
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products")
                .HasKey(item => item.ProductId);
            builder.Property(item => item.ProductId)
                .HasColumnName("ProductId");
        }
    }
}
