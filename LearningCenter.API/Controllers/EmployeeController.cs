using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

          public EmployeeController(IEmployeeInfraestructure employeeInfraestructure)
          {
            _employeeInfraestructure = employeeInfraestructure;
          }


        // GET: api/Tutorial
        [HttpGet]
        public List<Employee> Get()
        {
           

            return  _employeeInfraestructure.GetAll();
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Tutorial
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tutorial/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
