using Microsoft.AspNetCore.Mvc;

namespace webUi.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}