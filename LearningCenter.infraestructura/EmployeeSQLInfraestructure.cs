using LearnignCenter.infraestructura.Context;
using LearnignCenter.infraestructura.Models;

namespace LearnignCenter.infraestructura;

public class TutorialSQLInfraestructure : iTutorialInfraestructure
{
  public List<string> GetAll()
  {
    List<string> list = new List<string>();
    list.Add("Tutorial SQL 1");
    list.Add("Tutorial SQL 2");
    list.Add("Tutorial SQL 3");
    list.Add("Tutorial SQL 4");


    LearnigCenterDBContext learnigCenterDbContext = new LearnigCenterDBContext();
    learnigCenterDbContext.Tutorials.Add(new Tutorial()
    {
      Name = "Tutorial SQL 1"

    });
    learnigCenterDbContext.Tutorials.Update (new Tutorial()
    {
      Id = 1,
      Name = "Tutorial SQL 1"

    });
    learnigCenterDbContext.Tutorials.Remove(new Tutorial()
    {
      Id = 1,
      Name = "Tutorial SQL 1"

    });
    learnigCenterDbContext.Categories.ToList();

    learnigCenterDbContext.SaveChanges();

    return list;
  }
}

