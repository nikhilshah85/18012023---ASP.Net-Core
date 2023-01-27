using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using demo_webAPIService_MVC.Models;

namespace demo_webAPIService_MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //worst thing to do 
        Employee empObj = new Employee();

        [HttpGet]
        [Route("employees")]
        public IActionResult GetAllEmployees()
        {

            return Ok(empObj.GetAllEmployees());
        }
        [HttpGet]
        [Route("employees/{id}")]
        public IActionResult GetEmployeeById(int id)
        {
            try
            {
                return Ok(empObj.GetEmployeeById(id));
            }
            catch(Exception es)
            {
                return NotFound(es.Message);
            }
        }
    }
}
