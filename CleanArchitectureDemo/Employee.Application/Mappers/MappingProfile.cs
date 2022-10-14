using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;

namespace Employee.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Employee.Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Employee.Core.Entities.Employee, EmployeeRequest>().ReverseMap();
            CreateMap<Employee.Core.Entities.Department, DepartmentRequest>().ReverseMap();
            CreateMap<Employee.Core.Entities.Department, DepartmentResponse>().ReverseMap();
        }
    }
}
