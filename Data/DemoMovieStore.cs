using Buoi2.Models;

namespace Buoi2.Data
{
    public static class DemoMovieStore
    {
        public static IReadOnlyList<Movie> Movies { get; } = new List<Movie>
        {
            new() { Id = 1, Title = "Inception", Genre = "Sci-Fi", ReleaseDate = new DateTime(2010, 7, 16), Price = 12.99m },
            new() { Id = 2, Title = "The Godfather", Genre = "Drama", ReleaseDate = new DateTime(1972, 3, 24), Price = 9.99m },
            new() { Id = 3, Title = "Interstellar", Genre = "Sci-Fi", ReleaseDate = new DateTime(2014, 11, 7), Price = 14.50m },
            new() { Id = 4, Title = "Toy Story", Genre = "Animation", ReleaseDate = new DateTime(1995, 11, 22), Price = 7.99m }
        };

        public static Movie? Find(int id) => Movies.FirstOrDefault(m => m.Id == id);
    }
}
