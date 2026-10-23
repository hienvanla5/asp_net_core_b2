using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Buoi2.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}
