using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Models
{
    public class Film
    {
 
       public string  kategoriAd { get; set; }
       public string filmAd { get; set; }
       public string yapımYılı { get; set; }
       public string yonetmenAd { get; set; }
       public string konusu { get; set; } 
       public string afisUrl { get; set; } 
    }
}
