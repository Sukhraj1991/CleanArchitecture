using Employee.Application.Commands;
using Employee.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<List<DepartmentResponse>> GetAllDepartments();
        Task<DepartmentResponse> AddDepartment(DepartmentRequest request);
    }
}
