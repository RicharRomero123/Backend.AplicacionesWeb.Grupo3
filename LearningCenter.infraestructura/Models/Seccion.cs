namespace LearningCenter.infraestructura.Models;

public class Seccion
{
  public int Id { get; set; }
  public string Description { get; set; }


  public List<Employee>Employees { get; set; }

}
