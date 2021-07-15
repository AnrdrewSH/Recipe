using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeApi.Entities;

namespace RecipeApi.Dbinfrastructure
{
    public class RecipeEntityConfiguration : IEntityTypeConfiguration<RecipeEntity>
    {
        public void Configure(EntityTypeBuilder<RecipeEntity> builder)
        {
            builder.ToTable("ToDoList")
                .HasKey(item => item.Id);
            builder.Property(item => item.Id)
                .HasColumnName("ToDoId");
        }
    }
}
