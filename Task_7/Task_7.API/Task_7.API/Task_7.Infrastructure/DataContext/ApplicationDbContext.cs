using Microsoft.EntityFrameworkCore;
using Task_7.API.Task_7.Domain;

namespace Task_7.API.Task_7.Infrastructure.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext) : base(dbContext)
        {
        }
        public DbSet<Pupil> Pupils { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Teacher>()
                .HasMany(i => i.Pupils)
                .WithMany(i => i.Teachers);
        }
    }
}
