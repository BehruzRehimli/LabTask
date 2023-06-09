using Microsoft.AspNetCore.Mvc;

namespace LabTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
