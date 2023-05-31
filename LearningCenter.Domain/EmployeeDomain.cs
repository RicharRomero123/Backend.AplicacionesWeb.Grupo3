

using LearningCenter.infraestructura;
using LearningCenter.infraestructura.Models;

namespace Domain;

public class EmployeeDomain : IEmployeeDomain
{
    public IEmployeeInfraestructure _employeeInfraestructure;

    public EmployeeDomain(IEmployeeInfraestructure employeeInfraestructure)
    {
        _employeeInfraestructure = employeeInfraestructure;
    }
    public bool save(Employee employee)
    {
        //if (!this.IsValidData(employee)) throw new Exception("The length of your name is invalid");

        return _employeeInfraestructure.save(employee);
    }

    public bool update(int id, string name)
    {
        if (!this.IsValidData(name)) throw new Exception("The length of your name is invalid");
        return _employeeInfraestructure.update(id, name);
    }

    public bool delete(int id)
    {
        return _employeeInfraestructure.delete(id);
    }


    private bool IsValidData(string name)
    {
        if (name.Length < 3 || name.Length >30) return false;
        return true;

    }
}
