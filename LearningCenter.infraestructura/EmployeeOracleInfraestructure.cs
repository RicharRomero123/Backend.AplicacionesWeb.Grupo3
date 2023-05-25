using LearningCenter.infraestructura.Context;

using LearningCenter.infraestructura.Models;

namespace LearningCenter.infraestructura;

public class EmployeeOracleInfraestructure:IEmployeeInfraestructure
{
    public List<Employee> GetAll()
    {
        //Conecta BBDD
        List<string> list = new List<string>();
        list.Add("Value Oracle 1");
        list.Add("Value Oracle 2");
        list.Add("Value Oracle 3");
        //LearningCenterDBContext;
        //SecurityDB;


        LearningCenterDBContext learningCenterDbContext = new LearningCenterDBContext();
        learningCenterDbContext.Employees.Add(new Employee()
        {
            Name = "Test1"
        });

        learningCenterDbContext.Employees.Update(new Employee()
        {
            Id = 1,
            Name = "Test1"
        });


        learningCenterDbContext.Employees.Remove(new Employee()
        {
            Id = 1,
            Name = "Test1"
        });


        learningCenterDbContext.Seccions.ToList();

        learningCenterDbContext.SaveChanges();

        return null;

    }

    public bool save(string name)
    {
        throw new NotImplementedException();
    }

    public bool update(int id, string name)
    {
        throw new NotImplementedException();
    }

    public bool delete(int id)
    {
        throw new NotImplementedException();
    }
}


