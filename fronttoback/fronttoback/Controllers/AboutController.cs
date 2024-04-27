using Microsoft.AspNetCore.Mvc;

namespace fronttoback.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
