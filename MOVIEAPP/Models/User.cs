using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using System.ComponentModel.DataAnnotations; 

namespace MOVIEAPP.Models
{
    public class User
    { 
        public string name { get; set; }
        public string surname { get; set; }
        public string Email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public int authority { get; set; }
            

    }
}
