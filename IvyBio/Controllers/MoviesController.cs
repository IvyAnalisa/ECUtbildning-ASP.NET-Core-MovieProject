using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IvyBio.Data;

namespace IvyASPMovies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: MoviesController
        public MoviesController(IvyBioContext context)
        {
            Context = context;
        }

        public IvyBioContext Context { get; }

        // GET: MoviesController/Details/titanic
        [Route("Movies/{urlSlug}")]
        public ActionResult Details(string urlSlug)
        {
            var movie = Context.Movie.FirstOrDefault(x => x.UrlSlug == urlSlug);

            return View(movie);
        }

        // GET: MoivesController/Create

    }

}

