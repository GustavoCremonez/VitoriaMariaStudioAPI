using Microsoft.EntityFrameworkCore;
using VitoriaMariaStudio.Domain.Entities;
using VitoriaMariaStudio.Repository.Seeders;

namespace VitoriaMariaStudio.Repository.Context
{
    public class StudioDbContext : DbContext
    {
        public StudioDbContext(DbContextOptions<StudioDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }

        public DbSet<Scheduling> Schedulings { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<Professional> Professionals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Person

            modelBuilder.Entity<Person>()
                .HasIndex(person => person.Email)
                .IsUnique(true);

            modelBuilder.Entity<Person>()
                .Property(person => person.Name)
                .HasMaxLength(125)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Person>()
                .Property(person => person.Email)
                .HasMaxLength(125)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Person>()
                .Property(person => person.Phone)
                .HasMaxLength(25)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Person>()
                .Property(person => person.Address)
                .HasMaxLength(125)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            #endregion Person

            #region Professional

            modelBuilder.Entity<Professional>()
                .HasOne(professional => professional.Role)
                .WithMany()
                .HasForeignKey(professional => professional.RoleId);

            modelBuilder.Entity<Professional>()
                .HasIndex(professional => professional.Email)
                .IsUnique(true);

            modelBuilder.Entity<Professional>()
                .Property(professional => professional.Name)
                .HasMaxLength(125)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Professional>()
                .Property(professional => professional.Email)
                .HasMaxLength(125)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Professional>()
                .Property(professional => professional.Phone)
                .HasMaxLength(25)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Professional>()
                .Property(professional => professional.Address)
                .HasMaxLength(125)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            #endregion Professional

            #region Scheduling

            modelBuilder.Entity<Scheduling>()
                .HasOne(scheduling => scheduling.Client)
                .WithMany()
                .HasForeignKey(scheduling => scheduling.ClientId);

            modelBuilder.Entity<Scheduling>()
                .HasOne(scheduling => scheduling.Professional)
                .WithMany()
                .HasForeignKey(scheduling => scheduling.ProfessionalId);

            modelBuilder.Entity<Scheduling>()
                .HasMany(scheduling => scheduling.Jobs)
                .WithMany(jobs => jobs.Schedulings)
                .UsingEntity(table => table.ToTable("SchedulingJob"));

            modelBuilder.Entity<Scheduling>()
                .Property(x => x.Date)
                .IsRequired()
                .HasColumnType("datetime");

            #endregion Scheduling

            #region Job

            modelBuilder.Entity<Job>()
                .HasOne(job => job.Category)
                .WithMany()
                .HasForeignKey(job => job.CategoryId);

            modelBuilder.Entity<Job>()
                .Property(job => job.Name)
                .HasMaxLength(125)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Job>()
                .Property(job => job.Description)
                .HasMaxLength(300)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            modelBuilder.Entity<Job>()
                .Property(job => job.Price)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Job>()
                .Property(job => job.ExpectedTime)
                .IsRequired();

            #endregion Job

            #region Category

            modelBuilder.Entity<Category>()
                .Property(category => category.Name)
                .HasMaxLength(100)
                .IsRequired()
                .IsUnicode(false)
                .HasColumnType("varchar");

            #endregion Category

            #region Role

            modelBuilder.Entity<Role>()
               .Property(role => role.Name)
               .HasMaxLength(100)
               .IsRequired()
               .IsUnicode(false)
               .HasColumnType("varchar");

            #endregion Role
        }
    }
}