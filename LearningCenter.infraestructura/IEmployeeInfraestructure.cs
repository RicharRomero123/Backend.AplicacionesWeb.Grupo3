using LearningCenter.infraestructura.Models;

namespace LearningCenter.infraestructura;

public interface IEmployeeInfraestructure
{
    List<Employee> GetAll();

    public bool save(string name);
    public bool update(int id, string name);
    public bool delete(int id);

}
