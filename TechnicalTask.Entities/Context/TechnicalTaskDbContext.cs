using Microsoft.EntityFrameworkCore;
using TechnicalTask.Entities.Entities;

namespace TechnicalTask.Entities.Context
{
    public class TechnicalTaskDbContext : DbContext
    {
        public TechnicalTaskDbContext()
        {
        }

        public TechnicalTaskDbContext(DbContextOptions<TechnicalTaskDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=F:\\SQLite\\TechnicalTaskDb.db");
        }

        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Position> Positions { get; set; }

        public virtual DbSet<Project> Projects { get; set; }

        public virtual DbSet<Service> Services { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
            .HasOne(e => e.Position)
            .WithOne(p => p.Employee)
            .HasForeignKey<Position>(p => p.EmployeeId)
            .IsRequired();

            modelBuilder.Entity<Project>()
            .HasIndex(p => new { p.Name, p.Url })
            .IsUnique();

            modelBuilder.Entity<Service>()
            .HasIndex(s => s.Name)
            .IsUnique();

            modelBuilder.Entity<Position>()
            .HasIndex(p => p.Name)
            .IsUnique();
        }
    }
}
