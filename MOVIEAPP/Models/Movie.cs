using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string Name { get; set; } 
        public string ShortDescription { get; set; }
        public string Description { get; set; } 
        public string ImageUrl { get; set; }

    }
}
