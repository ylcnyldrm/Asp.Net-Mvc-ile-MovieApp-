using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOVIEAPP.Data;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Http;
namespace MOVIEAPP.Controllers
{
    public class AdminController : Controller
    {
        DatabaseTransactions vt = new DatabaseTransactions();
        public IActionResult Index()
        {
            if (erisimKontrol()==true)
            {
                return View();
            }
            return RedirectToAction("Login","Home");
        }

        [HttpGet]
        public IActionResult Forms()
        {
            if (erisimKontrol())
            {
                DataTable dt = vt.veriGetir("SELECT * FROM filmler.kategoriler");
                CategoryList categoryList = new CategoryList();
                categoryList.categories = new List<Category>();
                foreach (DataRow row in dt.Rows)
                {
                    categoryList.category = new Category();
                    categoryList.category.Name = row["kategori_ad"].ToString();
                    categoryList.categories.Add(categoryList.category);
                }
                return View(categoryList);
            }
            return RedirectToAction("Login", "Home");
             
        }


        [HttpPost]
        public IActionResult Forms(CategoryList categoryList)
        {
            if (erisimKontrol() == true)
            {

                string kategoriAd = categoryList.movie.categoryName;
                string filmAd = categoryList.movie.name;
                string yonetmenAd = categoryList.movie.directorName;
                string konu = categoryList.movie.subject;
                string afisUrl = categoryList.movie.posterUrl;
                int yapimYili = categoryList.movie.year;

                categoryList.movie = new CategoryList().movie;
                if (this.ModelState.IsValid == true)
                {
                    DataTable dt = vt.veriGetir("SELECT kategori_id FROM filmler.kategoriler where kategori_ad='" + kategoriAd + "'");
                    int kategoriId = (int)dt.Rows[0]["kategori_id"];
                    Console.WriteLine("kategori id = " + kategoriId.ToString());
                    bool b = DatabaseTransactions.executeQuery("insert into filmler.filmler " +
                        "(kategori_id,film_ad,yonetmen_ad,konusu,film_afisi,yapim_yili)" +
                        "values('" + kategoriId + "','" + filmAd + "','" + yonetmenAd + "','" + konu + "','" + afisUrl + "','" + yapimYili + "')  ");


                    return View();
                }
                else
                {
                    return View(categoryList);
                }
            }
            return RedirectToAction("Login", "Home");

        }


        [HttpGet]
        public IActionResult Tables()
        {
            if (erisimKontrol() == true)
            {

                FilmList filmList = new FilmList();
                filmList.movies = new List<Movie>();
                DataTable dt = vt.veriGetir("SELECT film_id,film_ad,yonetmen_ad,konusu,yapim_yili,filmler.kategori_id FROM filmler.filmler " +
                " INNER JOIN filmler.kategoriler" +
                " ON filmler.kategori_id = kategoriler.kategori_id ");

                foreach (DataRow row in dt.Rows)
                {
                    filmList.movie = new Movie();
                    filmList.movie.name = row["film_Ad"].ToString();
                    filmList.movie.subject = row["konusu"].ToString();
                    filmList.movie.directorName = row["yonetmen_ad"].ToString();
                    filmList.movie.year = (int)row["yapim_yili"];
                    filmList.movie.categoryId = (int)row["kategori_id"];
                    filmList.movie.movieId = (int)row["film_id"];
                    filmList.movies.Add(filmList.movie);
                }
                return View(filmList);
            }
            return RedirectToAction("Login", "Home");


        }

        [HttpGet("{TablesFilmId},{sil}")]
        public IActionResult Tables(int TablesFilmId)
        {
            if (erisimKontrol() == true)
            {
                DatabaseTransactions.executeQuery("delete from filmler where film_id='" + TablesFilmId + "' ");
                return Tables();
            }
            return RedirectToAction("Login", "Home");

            

        }

        public IActionResult Ui()
        {
            if (erisimKontrol() == true)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
         
        }
        public IActionResult Login()
        {
            if (erisimKontrol() == true)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
         
        }
        public IActionResult Register()
        {
            if (erisimKontrol() == true)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
           
        }
        public IActionResult Modals()
        {
            if (erisimKontrol() == true)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
            
        }
        public IActionResult Buttons()
        {
            if (erisimKontrol() == true)
            {
                return View();
            }
            return RedirectToAction("Login", "Home");
          
        }


        public IActionResult Guncelle(int formsFilmId)
        {
            if (erisimKontrol() == true)
            {
                if (formsFilmId != 0)
                {
                    DatabaseTransactions vt = new DatabaseTransactions();
                    CategoryList categoryList = new CategoryList();
                    categoryList.categories = new List<Category>();
                    categoryList.movie = new Movie();
                    List<Category> kategoriler = DatabaseTransactions.kategorileriGetir();

                    DataTable dt = vt.veriGetir("select * from filmler.filmler where film_id='" + formsFilmId + "'  ");

                    foreach (DataRow row in dt.Rows)
                    {
                        categoryList.movie.directorName = row["yonetmen_ad"].ToString();
                        categoryList.movie.subject = row["konusu"].ToString();
                        categoryList.movie.name = row["film_ad"].ToString();
                        categoryList.movie.posterUrl = row["film_afisi"].ToString();
                        categoryList.movie.year = (int)row["yapim_yili"];
                        categoryList.movie.categoryId = (int)row["kategori_id"];
                        categoryList.movie.movieId = (int)row["film_id"];
                    }

                    categoryList.categories = kategoriler;

                    return View(categoryList);
                }
                else { return Content(" Bir Sorun Oluştu "); }
            }
            return RedirectToAction("Login", "Home");


        
        }
        [HttpPost]
        public IActionResult Guncelle(CategoryList categoryList)
        {
            if (erisimKontrol() == true)
            {
                int filmId = categoryList.movie.movieId = categoryList.movie.movieId;
                string filmAd = categoryList.movie.name;
                string yonetmenAd = categoryList.movie.directorName;
                int yapimYili = categoryList.movie.year;
                string konusu = categoryList.movie.subject;
                string afisUrl = categoryList.movie.posterUrl;
                int kategoriId = categoryList.movie.categoryId;

                if (filmAd != null && yonetmenAd != null && yapimYili != 0 && konusu != null && afisUrl != null & kategoriId != 0)
                {
                    bool b = DatabaseTransactions.executeQuery("update filmler.filmler set film_ad='" + filmAd + "'," +
                        "yonetmen_ad='" + yonetmenAd + "',yapim_yili='" + yapimYili + "',konusu='" + konusu + "',film_afisi='" + afisUrl + "'," +
                        "kategori_id='" + kategoriId + "' where filmler.film_id='" + filmId + "' ");
                    if (b)
                    {
                        FilmList filmList = new FilmList();
                        filmList.movies = new List<Movie>();
                        DataTable dt = vt.veriGetir("SELECT film_id,film_ad,yonetmen_ad,konusu,yapim_yili,filmler.kategori_id FROM filmler.filmler " +
                        " INNER JOIN filmler.kategoriler" +
                        " ON filmler.kategori_id = kategoriler.kategori_id ");

                        foreach (DataRow row in dt.Rows)
                        {
                            filmList.movie = new Movie();
                            filmList.movie.name = row["film_Ad"].ToString();
                            filmList.movie.subject = row["konusu"].ToString();
                            filmList.movie.directorName = row["yonetmen_ad"].ToString();
                            filmList.movie.year = (int)row["yapim_yili"];
                            filmList.movie.categoryId = (int)row["kategori_id"];
                            filmList.movie.movieId = (int)row["film_id"];
                            filmList.movies.Add(filmList.movie);
                        }
                        return View("Tables", filmList);
                    }
                    return Content("Güncelleme Başarısız");
                }
                else
                {
                }
                return Content("Güncelleme Başarısız");
            }
            return RedirectToAction("Login", "Home");
           
        }

        [NonAction]
        public bool erisimKontrol() {
           string session = HttpContext.Session.GetString("nameAndSurnameadmin");
            if (session !=null)
            {
                return true;
            }
            return false;
        }
    }
}
