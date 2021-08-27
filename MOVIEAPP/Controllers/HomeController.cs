using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Contact() {
             
            return View();
        }

        public IActionResult Index() {
            List<Movie> movies = Repository.getMovies; 
            return View(movies); 
        }

        public IActionResult Details(int id) {
            return View(Repository.GetById(id));
        }

    }
}
