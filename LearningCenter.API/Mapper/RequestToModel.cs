using System;
using AutoMapper;
using LearningCenter.API.Request;
using LearningCenter.infraestructura.Models;

namespace LearningCenter.API.Mapper
{
    public class RequestToModel : Profile
    {
        public RequestToModel()
        {
            CreateMap<EmployeeRequest, Employee>();
        }
    }
}

