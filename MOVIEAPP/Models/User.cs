﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations; 

namespace MOVIEAPP.Models
{
    public class User
    { 
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int Yetki { get; set; }
            

    }
}
