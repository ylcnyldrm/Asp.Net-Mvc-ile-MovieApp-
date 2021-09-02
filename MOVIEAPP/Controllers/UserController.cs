using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Controllers
{
    public class UserController:Controller
    {
        public IActionResult Register(string Name,string Surname,string Email,string Password,string ConfirmPassword) {
            Console.WriteLine("TIKLANILDI");
            User user = new User();
            user.Name = Name;
            user.Surname = Surname;
            user.Email = Email;
            user.Password = Password; 
            user.ConfirmPassword = ConfirmPassword;
            if (user.Name != null)
            { 
                if (user.Password != user.ConfirmPassword)
                {
                    return View(user);
                }
                else
                {
                    return RedirectToAction("Register", "Home");
                }
            }
            else
            {
                return View();
            }
        }
        public IActionResult Login () {
            return View();
        }
        

    }
}
