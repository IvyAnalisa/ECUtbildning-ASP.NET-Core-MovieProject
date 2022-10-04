using IvyBio.Models;
using IvyBio.Data;
using IvyBio.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IvyBio.Controllers
{
    public class HomeController : Controller
    {
        public IvyBioContext Context { get; }

        public HomeController(IvyBioContext context)
        {
            Context = context;
        }
        /* private readonly ILogger<HomeController> _logger;

         public HomeController(ILogger<HomeController> logger)
         {
             _logger = logger;
         }*/

        public IActionResult Index()
        {
            var movies = Context.Movie.ToList();
            //mappa movies
            var movieViewModel = movies.Select(movie => new MovieViewModel
            {
                Title = movie.Title,
                Year = movie.Year,
                Rate = movie.Rate,

            });




            var viewModel = new HomeIndexViewModel
            {
                //Dipslay Top Pick Movie in Index page
                TopMovies = movies
            };
            return View(viewModel);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}