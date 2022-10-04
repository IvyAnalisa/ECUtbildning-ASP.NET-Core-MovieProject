using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IvyBio.Data;

namespace IvyASPMovies.Controllers
{
    public class SearchMoviesController : Controller
    {
        public SearchMoviesController(IvyBioContext context)
        {
            Context = context;
        }

        public IvyBioContext Context { get; }
        //search movie/Index
        [Route("/search")]
        //lägga attribute string q för att göra Request till backend
        public IActionResult Index([FromQuery] string q)
        {
            var movies = Context.Movie.Where(x => x.Title.Contains(q)).ToList();
            return View(movies);
        }
    }
}
