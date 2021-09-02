using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Data;
using MOVIEAPP.Models; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
namespace MOVIEAPP.Controllers
{
    public class HomeController:Controller
    {
        VeritabaniIslemleri v = new VeritabaniIslemleri();
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
           
        public IActionResult Register (User user)
        {
            
            bool kullaniciKayit;
            bool loginKayit;
              
            if (user.Name != null &&  user.Password == user.ConfirmPassword )
            {
                 try
                {
                    kullaniciKayit = VeritabaniIslemleri.sorguCalistir("insert into kullanici" +
                       " (kullanici_ad,kullanici_soyad,kullanici_email,kullanici_sifre)" +
                       " values('" + user.Name + "','" + user.Surname + "','" + user.Email + "','" + user.Password + "')");
                    if (kullaniciKayit)
                    { 
                      
                      int kullaniciId= v.kullaniciIdGetir("select kullanici_id from filmler.kullanici where kullanici_email='"+user.Email+"'");
                        //kullanıcı id çekilip eklenecek
                        loginKayit = VeritabaniIslemleri.sorguCalistir("insert into login" +
                      " (email,yetki,kullanici_id)" +
                      " values('" + user.Email + "','" + 1 + "','"+ kullaniciId + "')");

                        if (loginKayit)
                        { 
                            HttpContext.Session.SetString("nameAndSurname", user.Name + " " + user.Surname); 
                            //    TempData["nameAndSurname"] = user.Name+" "+user.Surname;
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
            VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
          
            return View();
        }

    }
}
