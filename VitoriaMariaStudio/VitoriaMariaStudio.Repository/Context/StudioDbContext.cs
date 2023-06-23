using Microsoft.EntityFrameworkCore;

namespace VitoriaMariaStudio.Repository.Context
{
    public class StudioDbContext : DbContext
    {
        public StudioDbContext(DbContextOptions<StudioDbContext> options) : base(options)
        {
        }

        //public DbSet<entity> table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // map of entitys here
        }
    }
}