using Microsoft.AspNetCore.Mvc;
using TechnicalTask.Domain.Employee;
using TechnicalTask.Services.Interfaces;

namespace TechnicalTask.WEBAPI.Controllers
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

        [HttpGet("GetEmployees")]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await _employeeService.GetAllAsync();

            return Ok(employees);
        }

        [HttpPost("AddEmployee")]
        public async Task<IActionResult> AddEmployee(AddEmployeeViewModel addEmployeeViewModel)
        {
            var result = await _employeeService.AddAsync(addEmployeeViewModel);

            return Ok(result);
        }
    }
}
