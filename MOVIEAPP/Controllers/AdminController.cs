using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MOVIEAPP.Data;
using System.Data;
using MySql.Data.MySqlClient;

namespace MOVIEAPP.Controllers
{
    public class AdminController : Controller
    {
        VeritabaniIslemleri vt = new VeritabaniIslemleri();
        int filmId = 0;
        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Forms()
        {
            Console.WriteLine("FORM GET");
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


        [HttpPost]
        public IActionResult Forms(CategoryList categoryList)
        {
            Console.WriteLine("FORM POST ");
            string kategoriAd = categoryList.film.kategoriAd;
            string filmAd = categoryList.film.filmAd;
            string yonetmenAd = categoryList.film.yonetmenAd;
            string konu = categoryList.film.konusu;
            string afisUrl = categoryList.film.afisUrl;
            int yapimYili = categoryList.film.yapimYili;

            categoryList.film = new CategoryList().film;
            if (this.ModelState.IsValid == true)
            {
                DataTable dt = vt.veriGetir("SELECT kategori_id FROM filmler.kategoriler where kategori_ad='" + kategoriAd + "'");
                int kategoriId = (int)dt.Rows[0]["kategori_id"];
                Console.WriteLine("kategori id = " + kategoriId.ToString());
                bool b = VeritabaniIslemleri.sorguCalistir("insert into filmler.filmler " +
                    "(kategori_id,film_ad,yonetmen_ad,konusu,film_afisi,yapim_yili)" +
                    "values('" + kategoriId + "','" + filmAd + "','" + yonetmenAd + "','" + konu + "','" + afisUrl + "','" + yapimYili + "')  ");


                return View();
            }
            else
            {
                return View(categoryList);
            }
        }


        [HttpGet]
        public IActionResult Tables()
        {
            Console.WriteLine("TABLES boş ");
            FilmList filmList = new FilmList();
            filmList.films = new List<Film>();
            DataTable dt = vt.veriGetir("SELECT film_id,film_ad,yonetmen_ad,konusu,yapim_yili,filmler.kategori_id FROM filmler.filmler " +
            " INNER JOIN filmler.kategoriler" +
            " ON filmler.kategori_id = kategoriler.kategori_id ");

            foreach (DataRow row in dt.Rows)
            {
                filmList.film = new Film();
                filmList.film.filmAd = row["film_Ad"].ToString();
                filmList.film.konusu = row["konusu"].ToString();
                filmList.film.yonetmenAd = row["yonetmen_ad"].ToString();
                filmList.film.yapimYili = (int)row["yapim_yili"];
                filmList.film.kategoriId = (int)row["kategori_id"];
                filmList.film.filmId = (int)row["film_id"];
                filmList.films.Add(filmList.film);
            }
            return View(filmList);
        }

        [HttpGet("{TablesFilmId},{sil}")]
        public IActionResult Tables(int TablesFilmId)
        {
            VeritabaniIslemleri.sorguCalistir("delete from filmler where film_id='" + TablesFilmId + "' ");
            return Tables();

        }

        public IActionResult Ui()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Modals()
        {
            return View();
        }
        public IActionResult Buttons()
        {
            return View();
        }


        public IActionResult Guncelle(int formsFilmId)
        {
            if (formsFilmId != 0)
            {
                filmId = 0;
                filmId = formsFilmId;
                VeritabaniIslemleri vt = new VeritabaniIslemleri();
                CategoryList categoryList = new CategoryList();
                categoryList.categories = new List<Category>();
                categoryList.film = new Film();
                List<Category> kategoriler = VeritabaniIslemleri.kategorileriGetir();

                DataTable dt = vt.veriGetir("select * from filmler.filmler where film_id='" + formsFilmId + "'  ");

                foreach (DataRow row in dt.Rows)
                {
                    categoryList.film.yonetmenAd = row["yonetmen_ad"].ToString();
                    categoryList.film.konusu = row["konusu"].ToString();
                    categoryList.film.filmAd = row["film_ad"].ToString();
                    categoryList.film.afisUrl = row["film_afisi"].ToString();
                    categoryList.film.yapimYili = (int)row["yapim_yili"];
                    categoryList.film.kategoriId = (int)row["kategori_id"];
                    categoryList.film.filmId = (int)row["film_id"];
                } 

                categoryList.categories = kategoriler;

                return View(categoryList);
            }
            else { return Content(" Bir Sorun Oluştu "); }
        }
        [HttpPost]
        public IActionResult Guncelle(CategoryList categoryList)
        {  
            int filmId = categoryList.film.filmId = categoryList.film.filmId;
            string filmAd = categoryList.film.filmAd;
            string yonetmenAd = categoryList.film.yonetmenAd;
            int yapimYili = categoryList.film.yapimYili;
            string konusu = categoryList.film.konusu;
            string afisUrl = categoryList.film.afisUrl;
            int kategoriId = categoryList.film.kategoriId; 

            if (filmAd != null && yonetmenAd != null && yapimYili != 0 && konusu != null && afisUrl != null & kategoriId != 0)
            {
                bool b = VeritabaniIslemleri.sorguCalistir("update filmler.filmler set film_ad='" + filmAd + "'," +
                    "yonetmen_ad='" + yonetmenAd + "',yapim_yili='" + yapimYili + "',konusu='" + konusu + "',film_afisi='" + afisUrl + "'," +
                    "kategori_id='" + kategoriId + "' where filmler.film_id='"+filmId+"' ");
                if (b)
                {
                    return View();
                }
                return Content("Güncelleme Başarısız");
            }
            else
            {
            }
            return Content("Güncelleme Başarısız");
        }




    }
}
