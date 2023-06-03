using LearningCenter.infraestructura.Models;

namespace Domain;

public interface IEmployeeDomain
{
    public Task<bool> SaveAsync(Employee employee);
    public bool update(int id, string name);
    public bool delete(int id);
}
