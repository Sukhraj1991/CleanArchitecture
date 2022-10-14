using Employee.Application.Commands;
using Employee.Application.Mappers;
using Employee.Application.Responses;
using Employee.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepo = employeeRepository;

        }
        public async Task<EmployeeResponse> AddEmployee(EmployeeRequest request)
        {
            var employeeEntitiy = ClassMapper.Mapper.Map<Employee.Core.Entities.Employee>(request);
            if (employeeEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newEmployee = await _employeeRepo.AddAsync(employeeEntitiy);
            var employeeResponse = ClassMapper.Mapper.Map<EmployeeResponse>(newEmployee);
            return employeeResponse;
        }

        public async Task<List<EmployeeResponse>> GetAllEmployee()
        {
            var employeesList = await _employeeRepo.GetAllAsync();
            List<EmployeeResponse> list = new List<EmployeeResponse>();
            foreach (var employee in employeesList)
            {
                list.Add(ClassMapper.Mapper.Map<EmployeeResponse>(employee));

            }
            return list;
        }
    }
}
