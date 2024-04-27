using Microsoft.AspNetCore.Mvc;

namespace fronttoback.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
