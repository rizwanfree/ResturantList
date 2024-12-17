using Microsoft.AspNetCore.Mvc;

namespace ResturantList.Controllers
{
    public class ResturantList : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Random() 
        {
            return Content("Hello Asp.Net");
        }
    }
}
