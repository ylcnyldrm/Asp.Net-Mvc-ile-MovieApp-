using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Models
{
    public class Film
    {
        [Required(ErrorMessage = "Kategori seçiniz")] 
        public string  kategoriAd { get; set; }
        [Required(ErrorMessage = "Film adı giriniz")] 
     
        public string filmAd { get; set; }
        [Required(ErrorMessage = "Film yapım yılı giriniz")]
        public string yapımYılı { get; set; }
        [Required(ErrorMessage = "Yönetmen adı giriniz")]
        public string yonetmenAd { get; set; }
        [Required(ErrorMessage = "Filmin konusunu giriniz")]
        public string konusu { get; set; }
        [Required(ErrorMessage = "Afiş url giriniz")]
        public string afisUrl { get; set; }

        public int kategoriId { get; set; } 
        public int filmId { get; set; }
    }
}
