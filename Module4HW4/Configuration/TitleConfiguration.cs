﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entity;

namespace Module4HW4.Configuration
{
    public class TitleConfiguration : IEntityTypeConfiguration<TitleEntity>
    {
        public void Configure(EntityTypeBuilder<TitleEntity> builder)
        {
            builder.ToTable("Title").HasKey(p => p.TitleId);
            builder.Property(p => p.TitleId).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
        }
    }
}
