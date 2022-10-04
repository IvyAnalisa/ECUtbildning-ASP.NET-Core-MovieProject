using IvyBio.Models.Domain;

namespace IvyBio.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Movie> TopMovies { get; set; } = new List<Movie>();
    }
}
