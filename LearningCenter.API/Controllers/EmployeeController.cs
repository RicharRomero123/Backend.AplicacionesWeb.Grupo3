using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
        private IMapper _mapper;

        public EmployeeController(IEmployeeInfraestructure employeeInfraestructure, IEmployeeDomain employeedomain, IMapper mapper)
        {
            _employeeInfraestructure = employeeInfraestructure;
            _employeeDomain = employeedomain;
            _mapper = mapper;
        }


        // GET: api/Tutorial
        [HttpGet]
        public async Task<List<EmployeeResponse>> GetAsync()
        {

            var employees = await _employeeInfraestructure.GetAllAsync();

            return _mapper.Map<List<Employee>, List<EmployeeResponse>>(employees);
        }

        // GET: api/Tutorial/5
        [HttpGet("{id}", Name = "Get")]
        public EmployeeResponse Get(int id)
        {
            Employee employee = _employeeInfraestructure.GetById(id);

            //EmployeeResponse employeeResponse = new EmployeeResponse()
            //{
            //    Id = employee.Id,
            //    Name = employee.Name,
            //};

            var employeeResponse = _mapper.Map<Employee, EmployeeResponse>(employee);

            return employeeResponse;

        }

        // POST: api/Tutorial
        [HttpPost]
        public void Post([FromBody] EmployeeRequest value)
        {
            if (ModelState.IsValid)
            {
                //Employee employee = new Employee()
                //{
                //    Name = value.Name
                //};

                var employee = _mapper.Map<EmployeeRequest, Employee>(value);

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
            _employeeDomain.update(id, value);
        }

        // DELETE: api/Tutorial/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employeeDomain.delete(id);
        }
    }
}
