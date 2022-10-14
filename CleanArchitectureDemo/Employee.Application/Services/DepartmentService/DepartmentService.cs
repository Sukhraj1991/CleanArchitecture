using Employee.Application.Commands;
using Employee.Application.Mappers;
using Employee.Application.Responses;
using Employee.Application.Services.DepartmentService;
using Employee.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Services.DepartmentService
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepo;
        public DepartmentService(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }
        public async Task<DepartmentResponse> AddDepartment(DepartmentRequest request)
        {
           var department= ClassMapper.Mapper.Map<Employee.Core.Entities.Department>(request);
            if (department is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newDepartment = await _departmentRepo.AddAsync(department);
            var response=ClassMapper.Mapper.Map<DepartmentResponse>(newDepartment);
            return response;
        }

        public Task<List<DepartmentResponse>> GetAllDepartments()
        {
            throw new NotImplementedException();
        }
    }
}
