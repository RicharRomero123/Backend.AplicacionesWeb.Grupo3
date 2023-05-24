using LearnignCenter.infraestructura.Models;
using Microsoft.EntityFrameworkCore;

namespace LearnignCenter.infraestructura.Context;

public class LearnigCenterDBContext: DbContext
{


  public DbSet<Tutorial> Tutorials { get; set; }
  public DbSet<Category> Categories { get; set; }
}
