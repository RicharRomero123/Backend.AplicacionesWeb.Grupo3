using LearningCenter.infraestructura.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnignCenter.infraestructura.Context;

public class LearningCenterDBContext: DbContext
{


  public DbSet<Employee> Employees { get; set; }
  public DbSet<Seccion> Seccions { get; set; }
}
