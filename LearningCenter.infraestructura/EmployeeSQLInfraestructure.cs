﻿using LearningCenter.infraestructura.Context;

using LearningCenter.infraestructura.Models;

namespace LearningCenter.infraestructura;

public class EmployeeSQLInfraestructure : IEmployeeInfraestructure
{
    private LearningCenterDBContext _learningCenterDBContext;

    public EmployeeSQLInfraestructure(LearningCenterDBContext learningCenterDBContext)
    {
        _learningCenterDBContext = learningCenterDBContext;
    }


    public List<Employee> GetAll()
    {
        

        return _learningCenterDBContext.Employees.Where(employee => employee.IsActive).ToList();

    }

    public bool save(Employee employee)
    {
        

        _learningCenterDBContext.Employees.Add(employee);

        _learningCenterDBContext.SaveChanges();

        return true;
    }

    public bool update(int id, string name)
    {
        Employee employee = _learningCenterDBContext.Employees.Find(id);
        employee.Name = name;

        _learningCenterDBContext.Employees.Update(employee);

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

