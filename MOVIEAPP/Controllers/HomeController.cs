using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Data;
using MOVIEAPP.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Data;

namespace MOVIEAPP.Controllers
{
    public class HomeController : Controller
    {
        DatabaseTransactions v = new DatabaseTransactions();
        public IActionResult Contact() {

            return View();
        }
        public IActionResult Popup() {
            return View();
        }
        public IActionResult Index(string name) {
            DatabaseTransactions vt = new DatabaseTransactions();
            CategoryList categoryList = new CategoryList(); 
            categoryList.categories = DatabaseTransactions.kategorileriGetir(); 
            categoryList.movies = new List<Movie>();
            List<Movie> filmler = new List<Movie>();
            Movie film;
            if (name != null)
            {
                DataTable dt = vt.veriGetir("SELECT * " +
                "FROM filmler " +
                "INNER JOIN kategoriler " +
                "ON filmler.kategori_id = kategoriler.kategori_id where kategori_ad='" + name + "'  ");

                foreach (DataRow row in dt.Rows)
                {
                    film = new Movie();
                    film.name = row["film_ad"].ToString();
                    film.directorName = row["yonetmen_ad"].ToString();
                    film.categoryName = row["kategori_ad"].ToString();
                    film.subject = row["konusu"].ToString();
                    film.posterUrl = row["film_afisi"].ToString();
                    film.year = (int)row["yapim_yili"];
                    film.movieId = (int)row["film_id"];
                    filmler.Add(film);
                }
                categoryList.movies = filmler;

                categoryList.categories = categoryList.categories.Where(i => i.Name == name).ToList();
            }
            else {
                DataTable dt = vt.veriGetir("SELECT * " +
               "FROM filmler " +
               "INNER JOIN kategoriler " +
               "ON filmler.kategori_id = kategoriler.kategori_id");

                foreach (DataRow row in dt.Rows)
                {
                    film = new Movie();
                    film.name = row["film_ad"].ToString();
                    film.directorName = row["yonetmen_ad"].ToString();
                    film.categoryName = row["kategori_ad"].ToString();
                    film.subject = row["konusu"].ToString();
                    film.posterUrl = row["film_afisi"].ToString();
                    film.year = (int)row["yapim_yili"];
                    film.movieId = (int)row["film_id"];
                    filmler.Add(film);
                    if (filmler.Count >=10) {
                        break;
                    }
                }
                categoryList.movies = filmler;

                categoryList.categories = categoryList.categories.Where(i => i.Name == name).ToList();
            }
            return View(categoryList); 
        }
      
        public IActionResult Details() {
            Movie film = new Movie();
            string filmId= RouteData.Values["name"].ToString();
            DatabaseTransactions vt = new DatabaseTransactions();
            DataTable dt = vt.veriGetir("SELECT * FROM filmler.filmler where film_id='"+filmId+"' ");
            foreach (DataRow row in dt.Rows)
            {
                film.name = row["film_ad"].ToString();
                film.directorName = row["yonetmen_ad"].ToString();
                film.subject = row["konusu"].ToString();
                film.posterUrl = row["film_afisi"].ToString();
                film.year = (int) row["yapim_yili"];
            }
            return View(film); 
        }
           
        public IActionResult Register (User user)
        { 
            bool kullaniciKayit;
            bool loginKayit;
            user.authority = 1;

            if (user.name != null &&  user.password == user.confirmPassword )
            {
                 try
                {
                    kullaniciKayit = DatabaseTransactions.executeQuery("insert into kullanici" +
                       " (kullanici_ad,kullanici_soyad,kullanici_email,kullanici_sifre)" +
                       " values('" + user.name + "','" + user.surname + "','" + user.Email + "','" + user.password + "')");
                    if (kullaniciKayit)
                    { 
                      
                      int kullaniciId= v.kullaniciIdGetir("select kullanici_id from filmler.kullanici where kullanici_email='"+user.Email+"'");
                        //kullanıcı id çekilip eklenecek
                        loginKayit = DatabaseTransactions.executeQuery("insert into login" +
                      " (email,yetki,kullanici_id)" +
                      " values('" + user.Email + "','" + user.authority + "','"+ kullaniciId + "')");

                        if (loginKayit)
                        { 
                            HttpContext.Session.SetString("nameAndSurname", user.name + " " + user.surname); 
                            
                            return RedirectToAction("Index", "Home");
                        }
                        else { 
                            return View(user);
                        }
                    }
                    else
                    {
                        return View(user);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("CATCH");
                    throw;
                }
                    
            }
            else
            {
                return View();
            }
        }

        public IActionResult Login(User user)
        {
            if (user != null)
            { 
                DatabaseTransactions veritabani = new DatabaseTransactions();
                User userInfo = veritabani.kullaniciGiris(user.Email, user.password);
                if (userInfo != null)
                {
                    switch (userInfo.authority)
                    {
                        case 1:
                            //giriş yapan kullanıcı sessiona eklenecek
                            HttpContext.Session.Clear();  
                            HttpContext.Session.SetString("nameAndSurname",userInfo.name+" "+ userInfo.surname);
                            return RedirectToAction("Index", "Home");
                        case 2:
                            HttpContext.Session.Clear();
                            HttpContext.Session.SetString("nameAndSurnameadmin", userInfo.name + " " + userInfo.surname);
                            return RedirectToAction("Index", "Admin");
                        default: 
                            return View();
                    }

                }
                else { 
                    return View();
                } 
                
            }
            else {
                return View();
            }
          
        }

    }
}
