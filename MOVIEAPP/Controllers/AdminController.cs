using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Forms() {
            return View();
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
