using Buoi2.Data;
using Microsoft.AspNetCore.Mvc;

namespace Buoi2.Controllers
{
    public class RoutingController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Details(int id)
        {
            ViewData["RequestedId"] = id;
            return View(DemoMovieStore.Find(id));
        }

        public IActionResult About() => View();
    }
}
