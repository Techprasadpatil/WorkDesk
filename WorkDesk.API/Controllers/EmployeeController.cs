using Microsoft.AspNetCore.Mvc;
using WorkDesk.API.Models;
using WorkDesk.API.Services;

namespace WorkDesk.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // GET: api/Employee
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employees = _employeeService.GetEmployees();

            return Ok(employees);
        }

        // GET: api/Employee/{id}
        [HttpGet("{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            var employee = _employeeService.GetEmployeeById(id);

            if (employee == null)
            {
                return NotFound(new
                {
                    message = "Employee not found"
                });
            }

            return Ok(employee);
        }

        // POST: api/Employee
        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);

            return Ok(new
            {
                message = "Employee added successfully"
            });
        }

        // PUT: api/Employee/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, Employee employee)
        {
            employee.Id = id;

            _employeeService.UpdateEmployee(employee);

            return Ok(new
            {
                message = "Employee updated successfully"
            });
        }

        // DELETE: api/Employee/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            _employeeService.DeleteEmployee(id);

            return Ok(new
            {
                message = "Employee deleted successfully"
            });
        }
    }
}