using Microsoft.AspNetCore.Mvc;

namespace fronttoback.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
