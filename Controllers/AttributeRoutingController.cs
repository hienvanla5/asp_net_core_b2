using Buoi2.Data;
using Microsoft.AspNetCore.Mvc;

namespace Buoi2.Controllers
{
    [Route("attribute")]
    public class AttributeRoutingController : Controller
    {
        [HttpGet("")]
        public IActionResult Index() => View();

        [HttpGet("movie/{id:int}")]
        public IActionResult Movie(int id)
        {
            ViewData["RequestedId"] = id;
            return View(DemoMovieStore.Find(id));
        }

        [HttpGet("genre/{genre:alpha}")]
        public IActionResult Genre(string genre)
        {
            ViewData["Genre"] = genre;
            return View(DemoMovieStore.Movies
                .Where(m => string.Equals(m.Genre, genre, StringComparison.OrdinalIgnoreCase))
                .ToList());
        }

        [HttpGet("year/{year:int:range(1990,2030)}")]
        public IActionResult Year(int year)
        {
            ViewData["Year"] = year;
            return View(DemoMovieStore.Movies
                .Where(m => m.ReleaseDate.Year == year)
                .ToList());
        }
    }
}
