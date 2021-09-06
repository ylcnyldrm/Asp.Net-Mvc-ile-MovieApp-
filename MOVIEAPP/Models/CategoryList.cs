using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Models
{
    public class CategoryList
    {
        public List<Category> categories { get; set; }
        public Category category { get; set; }

        public Film film { get; set; }
    }
}
