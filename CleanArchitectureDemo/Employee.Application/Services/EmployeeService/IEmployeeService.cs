using Employee.Application.Commands;
using Employee.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<EmployeeResponse>> GetAllEmployee();
        Task<EmployeeResponse> AddEmployee(EmployeeRequest request);
    }
}
