using Buoi2.Data;
using Microsoft.AspNetCore.Mvc;

namespace Buoi2.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult PartialViewDemo() => View(DemoMovieStore.Movies);

        public IActionResult ViewComponentDemo() => View();
    }
}
