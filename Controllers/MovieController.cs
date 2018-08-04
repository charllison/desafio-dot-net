using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjetoDesafioInForma.Models;
using ProjetoDesafioInForma.Helper;
using System.Net.Http;
using Newtonsoft.Json;

namespace ProjetoDesafioInForma.Controllers {

    public class MovieController : Controller {

        [HttpGet]
        public ActionResult Index() {
            return View(new MovieModel());
        }

        [HttpPost]
        public async Task<ActionResult> Index(MovieModel objMovie) {
            // get url to search movie 
            string url = String.Format(Constants.UrlQuery, objMovie.movieResult.title);

            // retrieves movies and convert result (json) in object 
            string jsonResult = await RequestWeb.ApiRequest(url);
            MovieModel movie  = JsonConvert.DeserializeObject<MovieModel>(jsonResult);

            return View(movie);
        }

        [HttpGet]
        public async Task<ActionResult> Details(string id) {
            // get url to search movie detail(by id)
            string urlDetals  = String.Format(Constants.UrlQueryId, id);
            
            // retrieves movie and convert result (json) in object 
            string jsonResult         = await RequestWeb.ApiRequest(urlDetals);
            MovieDetailsModel details = JsonConvert.DeserializeObject<MovieDetailsModel>(jsonResult);

            // configures utr image
            string urlImagem = (details.backdrop_path != null) ? details.backdrop_path : details.poster_path;
            
            // configures viewbag(show of page/view)
            ViewBag.bannerMoviel   = String.Format(Constants.UrlImage, "w185", urlImagem);
            ViewBag.titleMovie     = details.title;
            ViewBag.overviewMoviel = details.overview;

            return View();
        }
    }
}