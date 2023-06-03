using LearningCenter.infraestructura.Models;

namespace LearningCenter.infraestructura;

public interface IEmployeeInfraestructure
{
    //List<Employee> GetAll();
    Employee GetById(int id);
    public Task<bool> SaveAsync(Employee employee);
    public bool update(int id, string name);
    public bool delete(int id);
    Task<List<Employee>> GetAllAsync();
}
