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
        VeritabaniIslemleri v = new VeritabaniIslemleri();
        public IActionResult Contact() {

            return View();
        }
        public IActionResult Popup() {
            return View();
        }
        public IActionResult Index(string name) {
            VeritabaniIslemleri vt = new VeritabaniIslemleri();
            CategoryList categoryList = new CategoryList(); 
            categoryList.categories = VeritabaniIslemleri.kategorileriGetir(); 
            categoryList.filmler = new List<Film>();
            List<Film> filmler = new List<Film>();
            Film film;
            if (name != null)
            {
                DataTable dt = vt.veriGetir("SELECT * " +
                "FROM filmler " +
                "INNER JOIN kategoriler " +
                "ON filmler.kategori_id = kategoriler.kategori_id where kategori_ad='" + name + "'  ");

                foreach (DataRow row in dt.Rows)
                {
                    film = new Film();
                    film.filmAd = row["film_ad"].ToString();
                    film.yonetmenAd = row["yonetmen_ad"].ToString();
                    film.kategoriAd = row["kategori_ad"].ToString();
                    film.yonetmenAd = row["konusu"].ToString();
                    film.afisUrl = row["film_afisi"].ToString();
                    film.yapimYili = (int)row["yapim_yili"];
                    film.filmId = (int)row["film_id"];
                    filmler.Add(film);
                }
                categoryList.filmler = filmler;

                categoryList.categories = categoryList.categories.Where(i => i.Name == name).ToList();
            }
            else {
                DataTable dt = vt.veriGetir("SELECT * " +
               "FROM filmler " +
               "INNER JOIN kategoriler " +
               "ON filmler.kategori_id = kategoriler.kategori_id");

                foreach (DataRow row in dt.Rows)
                {
                    film = new Film();
                    film.filmAd = row["film_ad"].ToString();
                    film.yonetmenAd = row["yonetmen_ad"].ToString();
                    film.kategoriAd = row["kategori_ad"].ToString();
                    film.yonetmenAd = row["konusu"].ToString();
                    film.afisUrl = row["film_afisi"].ToString();
                    film.yapimYili = (int)row["yapim_yili"];
                    film.filmId = (int)row["film_id"];
                    filmler.Add(film);
                    if (filmler.Count >=10) {
                        break;
                    }
                }
                categoryList.filmler = filmler;

                categoryList.categories = categoryList.categories.Where(i => i.Name == name).ToList();
            }
            return View(categoryList); 
        }
      
        public IActionResult Details() {
            Film film = new Film();
            string filmId= RouteData.Values["name"].ToString();
            VeritabaniIslemleri vt = new VeritabaniIslemleri();
            DataTable dt = vt.veriGetir("SELECT * FROM filmler.filmler where film_id='"+filmId+"' ");
            foreach (DataRow row in dt.Rows)
            {
                film.filmAd = row["film_ad"].ToString();
                film.yonetmenAd = row["yonetmen_ad"].ToString();
                film.konusu = row["konusu"].ToString();
                film.afisUrl = row["film_afisi"].ToString();
                film.yapimYili = (int) row["yapim_yili"];
            }
            return View(film); 
        }
           
        public IActionResult Register (User user)
        { 
            bool kullaniciKayit;
            bool loginKayit;
            user.Yetki = 1;

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
                      " values('" + user.Email + "','" + user.Yetki + "','"+ kullaniciId + "')");

                        if (loginKayit)
                        { 
                            HttpContext.Session.SetString("nameAndSurname", user.Name + " " + user.Surname); 
                            
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
                VeritabaniIslemleri veritabani = new VeritabaniIslemleri();
                User userInfo = veritabani.kullaniciGiris(user.Email, user.Password);
                if (userInfo != null)
                {
                    switch (userInfo.Yetki)
                    {
                        case 1:
                            //giriş yapan kullanıcı sessiona eklenecek
                            HttpContext.Session.Clear();  
                            HttpContext.Session.SetString("nameAndSurname",userInfo.Name+" "+ userInfo.Surname);
                            return RedirectToAction("Index", "Home");
                        case 2:
                            HttpContext.Session.Clear();
                            HttpContext.Session.SetString("nameAndSurnameadmin", userInfo.Name + " " + userInfo.Surname);
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
