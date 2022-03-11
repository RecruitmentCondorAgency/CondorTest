using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Condor_test.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Condor_test.Controllers
{
    public class TestsController : Controller
    {
        private const string index = "~/Views/Tests/Index.cshtml";
        List<MoviesModel> movies = new List<MoviesModel>();

        // GET: /<controller>/

        public IActionResult Index()
        {
           
            movies.Add(new MoviesModel(2, "Ozark", "Usa", "Netflix"));
            movies.Add(new MoviesModel(3, "Hellbound", "Korea", "Netflix"));
            movies.Add(new MoviesModel(4, "The Mandalorian", "Usa", "Disney+"));
            movies.Add(new MoviesModel(5, "Law and Order", "Usa", "Star+"));
            movies.Add(new MoviesModel(6, "The Boys", "Usa", "Amazon Prime"));
            movies.Add(new MoviesModel(7, "The Expanse", "Usa", "Amazon Prime"));


            return View(index, movies);
        }

        public IActionResult Edit(int movieId)
        {
            var Movie = movies.ElementAt(movieId);
            return View(Movie);
        }
        public ActionResult Edit(MoviesModel movie)
        {
            var oldmovie = movies.Where(m => m.Id == movie.Id).First();
            movies.Remove(oldmovie);

            movies.Add(movie);
            return RedirectToAction("Index");
        }

    }
}
