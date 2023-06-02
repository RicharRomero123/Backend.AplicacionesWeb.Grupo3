using AutoMapper;
using System;
using LearningCenter.infraestructura.Models;
using LearningCenter.API.Response;

namespace LearningCenter.API.Mapper
{
    public class ModelToResponse : Profile
    {
        public ModelToResponse()
        {
            CreateMap<Employee, EmployeeResponse>();
        }
    }
}

