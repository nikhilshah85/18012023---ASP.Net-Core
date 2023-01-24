using Microsoft.AspNetCore.Mvc;
using DI_and_DataAnnotation_Demo.Models;
namespace DI_and_DataAnnotation_Demo.Controllers
{
    public class EmployeeController : Controller
    {

        //this is a crime, else please write a code to destroy the object
        //Employee empObj = new Employee(); 

        Employee _empObj;

        public EmployeeController(Employee empObjREF)//this is the reference variable to object created by runtime, and that object is passed to our variable
        {
            _empObj = empObjREF;
        }

        public IActionResult AllEmployees()
        {

            ViewBag.empDetails = _empObj.GetAllEmployees();
            return View();
        }
    }
}
