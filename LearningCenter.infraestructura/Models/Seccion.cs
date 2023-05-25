  namespace LearnignCenter.infraestructura.Models;

public class Category
{
  public int Id { get; set; }
  public string Description { get; set; }


  public List<Employee>Tutorials { get; set; }

}
