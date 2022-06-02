using Microsoft.AspNetCore.Mvc;

namespace DBProject.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
