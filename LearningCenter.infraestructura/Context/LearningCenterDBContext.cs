using LearningCenter.infraestructura.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.infraestructura.Context;

public class LearningCenterDBContext: DbContext
{
    public LearningCenterDBContext()
    {

    }

    public LearningCenterDBContext(DbContextOptions<LearningCenterDBContext> options) : base(options) { }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Seccion> Seccions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            var serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            optionsBuilder.UseMySql("Server=localhost,3306;Uid=root;Pwd=12345678;Database=EmployeeCenterDB;", serverVersion);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Seccion>().ToTable("Seccions");
        modelBuilder.Entity<Seccion>().HasKey(p=>p.Id);
        modelBuilder.Entity<Seccion>().Property(p=>p.Id).IsRequired().ValueGeneratedOnAdd();
        modelBuilder.Entity<Seccion>().Property(p => p.Description).IsRequired().HasMaxLength(70);

        modelBuilder.Entity<Employee>().ToTable("Employees");
        modelBuilder.Entity<Employee>().HasKey(p => p.Id);
        modelBuilder.Entity<Employee>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
    }
}
