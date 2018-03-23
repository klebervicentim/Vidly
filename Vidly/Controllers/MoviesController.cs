using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        // Toda a vez que passarmos o parametro /Movies/Random na URL do navegador ele vai chamar o método Random dentro
        // da classe MoviesController de acordo com o parâmetro que a gente passou no RouteConfig
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Origem" };
            return View(movie);
        }
    }
}