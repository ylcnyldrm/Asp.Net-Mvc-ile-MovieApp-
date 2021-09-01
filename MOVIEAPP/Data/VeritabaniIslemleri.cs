using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Data
{
    public class VeritabaniIslemleri
    {
        string baglantiAdresi = "Server=localhost;Uid=root;Pwd=123456;Database=filmler;";
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataReader dr;


        public void sorguCalistir(string sorgu) {
            baglanti = new MySqlConnection(baglantiAdresi);
            baglanti.Open();
            komut = new MySqlCommand(sorgu, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

         
         
    }
    
}
