using fronttoback.Data;
using Microsoft.AspNetCore.Mvc;

namespace fronttoback.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()

        {
            //ViewData["name"] = "Meryem";
            //ViewBag.Title = "Home";
            //TempData["name"] = "Meryem";
            //return RedirectToAction(nameof(Detail));
            //var datas = GetSliders();
            var sliders = _context.sliders.ToList();
            return View(sliders);
        }

        //private List<Slider> GetSliders()
        //{
        //    return new List<Slider>
        //    {
        //        new Slider()
        //        {
        //            Title = "Home",
        //            Description = "Television",
        //        },
        //         new Slider()
        //        {
        //            Title = "Course",
        //            Description = "Programming",
        //        },
        //          new Slider()
        //        {
        //            Title = "SHop",
        //            Description = "Food",
        //        },
        //           new Slider()
        //        {
        //            Title = "Village",
        //            Description = "Forest",
        //        },
        //    };
        //}
        //public IActionResult Detail()
        //{
        //    //ViewData["name"] = "Meryem";
        //    //ViewBag.Title = "Home";              
        //    return View();
        //}


    }
}
