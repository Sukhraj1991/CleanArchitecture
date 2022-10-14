using Employee.Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Core.Repositories
{
    public interface IDepartmentRepository : IRepository<Employee.Core.Entities.Department>
    {
        //custom operations here
        Task<IEnumerable<Employee.Core.Entities.Department>> GetDepartmentByName(string departmentName);
    }
}
