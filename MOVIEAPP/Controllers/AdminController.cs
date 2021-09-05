using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Controllers
{
    public class AdminController:Controller
    {
        public IActionResult Index() {

            return View();
        }
        [HttpGet]
        public IActionResult Forms() {
            Console.WriteLine("  GET ÇALIŞTI");
            return View();
        }
        [HttpPost]
        public IActionResult Forms(Film film)
        {
            if (film != null)
            {
                Console.WriteLine("  POST ÇALIŞTI" + film.filmAd);
                Console.WriteLine("  POST ÇALIŞTI" + film.afisUrl);
                Console.WriteLine("  POST ÇALIŞTI" + film.kategoriAd);
                Console.WriteLine("  POST ÇALIŞTI" + film.konusu);
                Console.WriteLine("  POST ÇALIŞTI" + film.yapımYılı);
                Console.WriteLine("  POST ÇALIŞTI" + film.yonetmenAd);
                Console.WriteLine("değil");
                return View();
            }
            else {
                Console.WriteLine("null");
                return Content("null");
            }
             
        }
        public IActionResult Tables() {
            return View();
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
