using MOVIEAPP.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Data
{
    public class VeritabaniIslemleri
    {
        static string baglantiAdresi = "Server=localhost;Uid=root;Pwd=123456;Database=filmler;";
        static MySqlConnection baglanti;
        static MySqlCommand komut;
        MySqlDataReader dr;


        public  static bool sorguCalistir(string sorgu) {
            try
            {
                baglanti = new MySqlConnection(baglantiAdresi);
                baglanti.Open();
                komut = new MySqlCommand(sorgu, baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
          
        }

        public int kullaniciIdGetir(string sorgu) {
            int kullaniciId=0;
            baglanti = new MySqlConnection(baglantiAdresi);
            baglanti.Open(); 
            komut = new MySqlCommand(sorgu, baglanti); 
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                kullaniciId= dr.GetInt16("kullanici_id");
            }
            return kullaniciId;
        }

        public bool kullaniciGiris(string email,string password ) {
            string sorgu = "SELECT yetki"+
            "FROM filmler.kullanici"+
            "INNER JOIN filmler.login"+
            "ON filmler.kullanici.kullanici_id = filmler.login.kullanici_id"+
            "where kullanici_email = '"+email+"' ";
            baglanti = new MySqlConnection(baglantiAdresi);
            baglanti.Open();
            komut = new MySqlCommand(sorgu, baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                return true;
            } 
            return false;
        }  
    }
    
}
