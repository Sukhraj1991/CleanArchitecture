using Employee.Core.Repositories;
using Employee.Infrastructure.Data;
using Employee.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repositories
{
    public class DepartmentRepository : Repository<Employee.Core.Entities.Department>, IDepartmentRepository
    {
        public DepartmentRepository(DatabaseContext dbContext) : base(dbContext) { }

        public async Task<IEnumerable<Core.Entities.Department>> GetDepartmentByName(string departmentName)
        {
            return await _dbContext.Departments.Where(m => m.DepartmentName == departmentName).ToListAsync();
        }
    }
}
