using Microsoft.EntityFrameworkCore;
using Module4HW4.Configuration;
using Module4HW4.Entity;

namespace Module4HW4
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<EmployeeEntity> Employee { get; set; }
        public DbSet<EmployeeProjectEntity> EmployeeProject { get; set; }
        public DbSet<OfficeEntity> Office { get; set; }
        public DbSet<ProjectEntity> Project { get; set; }
        public DbSet<TitleEntity> Title { get; set; }
        public DbSet<ClientEntity> Client { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectConfiguration());
            modelBuilder.ApplyConfiguration(new TitleConfiguration());
        }
    }
}
