using Buoi2.Data;
using Microsoft.AspNetCore.Mvc;

namespace Buoi2.ViewComponents
{
    public class MovieSummaryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string heading = "Tổng quan phim")
        {
            var movies = DemoMovieStore.Movies;

            var model = new MovieSummaryModel
            {
                Heading = heading,
                MovieCount = movies.Count,
                GenreCount = movies.Select(m => m.Genre).Distinct().Count(),
                TotalPrice = movies.Sum(m => m.Price)
            };

            return View(model);
        }
    }

    public class MovieSummaryModel
    {
        public string Heading { get; set; } = "";
        public int MovieCount { get; set; }
        public int GenreCount { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
