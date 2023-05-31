using LearningCenter.infraestructura.Models;

namespace LearningCenter.infraestructura;

public interface IEmployeeInfraestructure
{
    List<Employee> GetAll();
    Employee GetById(int id);
    public bool save(Employee employee);
    public bool update(int id, string name);
    public bool delete(int id);

}
