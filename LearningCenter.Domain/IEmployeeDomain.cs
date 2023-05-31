using LearningCenter.infraestructura.Models;

namespace Domain;

public interface IEmployeeDomain
{
    public bool save(Employee employee);
    public bool update(int id, string name);
    public bool delete(int id);
}
