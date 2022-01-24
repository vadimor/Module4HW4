using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Module4HW4.Entity;
using System;

namespace Module4HW4.Configuration
{
    public class ProjectConfiguration : IEntityTypeConfiguration<ProjectEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectEntity> builder)
        {
            builder.ToTable("Project").HasKey(p => p.ProjectId);
            builder.Property(p => p.ProjectId).ValueGeneratedOnAdd();
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Budget).HasColumnType("money").IsRequired();
            builder.Property(p => p.StartedDate).HasMaxLength(7).IsRequired();
            builder.Property(p => p.ClientId).IsRequired();
            builder.HasOne(p => p.Client)
                .WithMany(p => p.Projects)
                .HasForeignKey(p => p.ClientId);
            builder.HasData(
                new ProjectEntity() { ProjectId = 1, Name = "Pockemon GO", Budget = 100000,  StartedDate = new DateTime(2017,12,31), ClientId = 1},
                new ProjectEntity() { ProjectId = 2, Name = "Project F", Budget = 100000,  StartedDate = new DateTime(2018,3,1), ClientId = 2},
                new ProjectEntity() { ProjectId = 3, Name = "Diya", Budget = 1000,  StartedDate = new DateTime(2016,12,1), ClientId = 4},
                new ProjectEntity() { ProjectId = 4, Name = "Pockemon Unite", Budget = 1000000,  StartedDate = new DateTime(2017,1,31), ClientId = 5},
                new ProjectEntity() { ProjectId = 5, Name = "Medical Mathematic Project", Budget = 20,  StartedDate = new DateTime(2022,1,24), ClientId = 3}
                );
        }
    }
}
