using Employee.Application.Commands;
using Employee.Application.Responses;
using Employee.Application.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<EmployeeResponse>> Get()
        {
            return await _employeeService.GetAllEmployee();
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<EmployeeResponse>> CreateEmployee([FromBody] EmployeeRequest command)
        {
            var result = await _employeeService.AddEmployee(command);
            return Ok(result);
        }
    }
}
