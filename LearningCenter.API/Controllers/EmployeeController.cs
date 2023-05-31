using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using LearningCenter.API.Request;
using LearningCenter.API.Response;
using LearningCenter.infraestructura;
using LearningCenter.infraestructura.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase

    {

          private IEmployeeInfraestructure _employeeInfraestructure;
          private IEmployeeDomain _employeeDomain;    

          public EmployeeController(IEmployeeInfraestructure employeeInfraestructure, IEmployeeDomain employeedomain)
          {
            _employeeInfraestructure = employeeInfraestructure;
            _employeeDomain = employeedomain;
          }


        // GET: api/Tutorial
        [HttpGet]
        public List<Employee> Get()
        {
          
            return  _employeeInfraestructure.GetAll();
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "Get")]
        public EmployeeResponse Get(int id)
        {
            Employee employee = _employeeInfraestructure.GetById(id);

            EmployeeResponse employeeResponse = new EmployeeResponse()
            {
                Id = employee.Id,
                Name = employee.Name,
            };
            return employeeResponse;

        }

        // POST: api/Tutorial
        [HttpPost]
        public void Post([FromBody] EmployeeRequest value)
        {
            if(ModelState.IsValid)
            {
                Employee employee = new Employee()
                { 
                    Name = value.Name
                };

                _employeeDomain.save(employee);
            }
            else
            {
                StatusCode(400);
            }
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _employeeDomain.update(id,value);
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeDomain.delete(id);
        }
    }
}
