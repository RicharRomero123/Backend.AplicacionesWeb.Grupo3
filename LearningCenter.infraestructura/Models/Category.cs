  namespace LearnignCenter.infraestructura.Models;

public class Category
{
  public int Id { get; set; }
  public string Description { get; set; }


  public List<Tutorial>Tutorials { get; set; }

}
