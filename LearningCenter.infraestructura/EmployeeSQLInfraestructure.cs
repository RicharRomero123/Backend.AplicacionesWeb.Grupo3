using LearningCenter.infraestructura.Context;

using LearningCenter.infraestructura.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningCenter.infraestructura;

public class EmployeeSQLInfraestructure : IEmployeeInfraestructure
{
    private LearningCenterDBContext _learningCenterDBContext;

    public EmployeeSQLInfraestructure(LearningCenterDBContext learningCenterDBContext)
    {
        _learningCenterDBContext = learningCenterDBContext;
    }


    public async Task<List<Employee>> GetAllAsync()
    {
        

        return await _learningCenterDBContext.Employees.Where(employee => employee.IsActive).ToListAsync();

    }

    public async Task<bool> SaveAsync(Employee employee)
    {

        try
        {


            _learningCenterDBContext.Employees.Add(employee);

            await _learningCenterDBContext.SaveChangesAsync();
        }


        catch (Exception exception) 
        {
            throw;
        }
        return true;
    }

    public bool update(int id, string name)
    {
        Employee _employee = _learningCenterDBContext.Employees.Find(id);
        _employee.Name = name;

        _learningCenterDBContext.Employees.Update(_employee);

        _learningCenterDBContext.SaveChanges();

        return true;
    }

    public bool delete(int id)
    {
        Employee employee = _learningCenterDBContext.Employees.Find(id);

        employee.IsActive = false;

        _learningCenterDBContext.Employees.Update(employee);

        //_learningCenterDbContext.Tutorials.Remove(tutorial); Eliminacion física

        _learningCenterDBContext.SaveChanges();

        return true;
    }

    public Employee GetById(int id)
    {
        return _learningCenterDBContext.Employees.Find(id);
    }
}

