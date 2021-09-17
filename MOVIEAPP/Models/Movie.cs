using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Models
{
    public class Movie
    {
        [Required(ErrorMessage = "Kategori seçiniz")] 
        public string  categoryName { get; set; }
        [Required(ErrorMessage = "Movie adı giriniz")] 
     
        public string name { get; set; }
        [Required(ErrorMessage = "Movie yapım yılı giriniz")]
        public int year { get; set; }
        [Required(ErrorMessage = "Yönetmen adı giriniz")]
        public string directorName { get; set; }
        [Required(ErrorMessage = "Filmin konusunu giriniz")]
        public string subject { get; set; }
        [Required(ErrorMessage = "Afiş url giriniz")]
        public string posterUrl { get; set; } 
        public int categoryId { get; set; } 
        public int movieId { get; set; }
    }
}
