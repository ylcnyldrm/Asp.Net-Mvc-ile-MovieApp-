using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Data;
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

        public IActionResult Index(int? id) {

            VeritabaniIslemleri veritabaniIslemleri = new VeritabaniIslemleri();

           // veritabaniIslemleri.sorguCalistir("insert into kategoriler (kategori_ad) values ('"+"deneme"+"')");
             
            var movies = MovieRepository.getMovies;
            if (id!=null) {
                movies = movies.Where(i => i.CategoryId == id).ToList();
            }
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.GetCategories;
            //model.Movies = MovieRepository.getMovies; 
            return View(movies); 
        }

        public IActionResult Details(int id) {
            //MovieCategoryModel model = new MovieCategoryModel();
            //model.Categories = CategoryRepository.GetCategories;
            //model.Movie = MovieRepository.GetById(id);
            return View(MovieRepository.GetById(id)); 
        }

    }
}
