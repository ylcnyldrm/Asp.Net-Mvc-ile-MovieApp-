using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOVIEAPP.Data;
using System.Data;

namespace MOVIEAPP.Controllers
{
    public class AdminController:Controller
    {
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        
        public IActionResult Index() {

            return View();
        }


        [HttpGet]

        public IActionResult Forms() {
            DataTable dt = vt.veriGetir("SELECT kategori_ad FROM filmler.kategoriler");
            CategoryList categoryList = new CategoryList();
            categoryList.categories = new List<Category>();
            
            foreach (DataRow row in dt.Rows)
            {
                categoryList.category = new Category();
                categoryList.category.Name= row["kategori_ad"].ToString();
                categoryList.categories.Add(categoryList.category);
                Console.WriteLine("kategori ad = " + row["kategori_ad"].ToString()); 
            }
            return View(categoryList);
        }
        [HttpPost]
        public IActionResult Forms(Film film)
        { 
                if (this.ModelState.IsValid==true)
                {

                    DataTable dt = vt.veriGetir("SELECT kategori_id FROM filmler.kategoriler where kategori_ad='" + film.kategoriAd + "'");
                    int kategoriId = (int)dt.Rows[0]["kategori_id"];
                    bool b = VeritabaniIslemleri.sorguCalistir("insert into filmler.filmler " +
                        "(kategori_id,film_ad,yonetmen_ad,konusu,film_afisi,yapim_yili)" +
                        "values('"+kategoriId+"','"+film.filmAd+"','"+film.yonetmenAd+"','"+(film.konusu)+"','"+film.afisUrl+"','"+film.yapımYılı+"')  ");
                  
                return Forms();  
                }
                else {
                    return View(film);
                } 
        }
         
        [HttpGet] 
        public IActionResult Tables() {
            FilmList filmList = new FilmList();
            filmList.films = new List<Film>(); 
            DataTable dt = vt.veriGetir("SELECT film_id,film_ad,yonetmen_ad,konusu,yapim_yili,filmler.kategori_id FROM filmler.filmler "+
            " INNER JOIN filmler.kategoriler"+
            " ON filmler.kategori_id = kategoriler.kategori_id ");
            
            foreach (DataRow row in dt.Rows)
            {
                filmList.film =new Film();
                filmList.film.filmAd = row["film_Ad"].ToString();
                filmList.film.konusu = row["konusu"].ToString();
                filmList.film.yonetmenAd = row["yonetmen_ad"].ToString();
                filmList.film.yapımYılı = row["yapim_yili"].ToString();
                filmList.film.kategoriId = (int) row["kategori_id"];
                filmList.film.filmId =  (int) row["film_id"];
                filmList.films.Add(filmList.film);   
            } 
            return View(filmList);
        }

        [HttpGet("{filmId}")] 
        public IActionResult Tables(int filmId, string name ) {
            switch (name)
            {
                case "sil":
                    VeritabaniIslemleri.sorguCalistir("delete from filmler where film_id='"+filmId+"' ");
                    return Tables();
                case "güncelle": 
                    return Forms();
                case "düzenle":
                    return Content("düzenle id  = " + filmId.ToString());
                default:
                    return Content("hiçbiri değil id  = " + filmId.ToString()); 
            }
           
        }
        
        public IActionResult Ui() {
            return View();
        }
        public IActionResult Login() {
            return View();
         }
        public IActionResult Register() {
            return View();
         }
        public IActionResult Modals() {
            return View();
         } 
        public IActionResult Buttons() {
            return View();
         }
    }
}
