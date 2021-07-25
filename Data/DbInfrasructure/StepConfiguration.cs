﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe_Api.Data.Entities;


namespace Recipe_Api.Data.DbInfrasructure
{
    public class StepConfiguration : IEntityTypeConfiguration<Step>
    {
        public void Configure(EntityTypeBuilder<Step> builder)
        {
            builder.ToTable("Steps")
                .HasKey(item => item.StepId);
            builder.Property(item => item.StepId)
                .HasColumnName("StepId");
        }
    }
}