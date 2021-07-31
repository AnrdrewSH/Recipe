//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Recipe_Api.Data.Entities;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Recipe_Api.Data.DbInfrasructure
//{
//    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
//    {
//        public void Configure(EntityTypeBuilder<Recipe> builder)
//        {
//            builder.ToTable("Recipes")
//                .HasKey(item => item.Id);
//            builder.Property(item => item.Id)
//                .HasColumnName("Id");
//        }
//    }
//}
