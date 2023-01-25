using Microsoft.AspNetCore.Mvc;

namespace WebAPI_Calls.Controllers
{
    public class ExternalDataController : Controller
    {
      
        public IActionResult PostData()
        {
            return View();
        }

        public IActionResult PhotosData()
        {
            return View();
        }
    }
}
