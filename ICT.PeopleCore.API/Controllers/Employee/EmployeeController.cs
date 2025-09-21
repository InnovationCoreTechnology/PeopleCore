using ICT.PeopleCore.Interface.Employee;
using Microsoft.AspNetCore.Mvc;

namespace ICT.PeopleCore.API.Controllers.Employee
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("get-all")]
        public async Task<IActionResult> GetEmployeesAsync()
        {
            var employeesService = HttpContext.RequestServices.GetService<IEmployee>();
            var result = await employeesService.GetEmployeesAsync();
            return Ok(result);
        }
    }
}
