using Microsoft.AspNetCore.Mvc;

namespace shoppingAPPMVC.Controllers
{
    public class shoppingController : Controller
    {

        public IActionResult Products()
        {
            //collect data from model, pass it in a Bag - viewbag            
            return View();
        }

        public IActionResult Client()
        {
            return View();
        }

        public IActionResult Orders()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

      
    }
}
