using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application.Commands
{
    public class DepartmentRequest
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
