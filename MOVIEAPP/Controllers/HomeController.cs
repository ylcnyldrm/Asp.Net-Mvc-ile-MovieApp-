﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index() {
            return View(); 
        }

    }
}