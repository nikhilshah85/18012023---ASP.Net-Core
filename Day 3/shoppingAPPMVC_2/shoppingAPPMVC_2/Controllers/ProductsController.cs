using Microsoft.AspNetCore.Mvc;
using shoppingAPPMVC_2.Models;
namespace shoppingAPPMVC_2.Controllers
{
    public class ProductsController : Controller
    {
     


        public IActionResult ProductsHome()
        {
            //collect data from Model

            //this data would come from Model, model will get it from somewhere
            ViewBag.totalProducts = 50;
            ViewBag.developer = "Nikhil Shah";
            ViewBag.isProjectLive = false;

            List<string> topSellingProducts = new List<string>()
            {
                "IPhone","Superdry","Puma","Nike","Pepsi","Maggie","Macbook Air"
            };

            ViewBag.topProducts = topSellingProducts;


            return View();
        }


        ProductDetailsModel pObj = new ProductDetailsModel();
        public IActionResult ProductDetails()
        {
            ViewBag.pList = pObj.GetAllProducts();
            return View();
        }


    }
}
