using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
