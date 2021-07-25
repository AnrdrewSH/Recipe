using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe_Api.Data.Entities;


namespace Recipe_Api.Data.DbInfrasructure
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags")
                .HasKey(item => item.TagId);
            builder.Property(item => item.TagId)
                .HasColumnName("TagId");
        }
    }
}
