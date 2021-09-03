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
        static MySqlDataReader dr;
         
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
            baglanti.Close();
            return kullaniciId;
        }

        public User kullaniciGiris(string email,string password ) {
            User user = new User();
            string sorgu = "SELECT kullanici_ad,kullanici_soyad,kullanici_sifre,yetki" +
                    " FROM filmler.kullanici"+
                    " INNER JOIN filmler.login"+
                    " ON filmler.kullanici.kullanici_id = filmler.login.kullanici_id"+
                    " where kullanici_email = '"+email+"' and kullanici_sifre = '"+password+"' "; 
            baglanti = new MySqlConnection(baglantiAdresi);
            baglanti.Open();
            komut = new MySqlCommand(sorgu, baglanti);
            dr = komut.ExecuteReader();
            //Sorgudan dönen veri varsa
            if (dr.HasRows) {

                while (dr.Read())
                {
                    user.Name = dr.GetString("kullanici_ad");
                    user.Surname = dr.GetString("kullanici_soyad");
                    user.Yetki = dr.GetInt16("yetki");
                }
                return user;

            } else {
                baglanti.Close();
                return null;
            }
          
        }

        public static List<Category> kategorileriGetir() {
            List<Category> categories = new List<Category>(); 
            string sorgu = "SELECT kategori_ad FROM filmler.kategoriler";
            baglanti = new MySqlConnection(baglantiAdresi);
            baglanti.Open();
            komut = new MySqlCommand(sorgu, baglanti);
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                categories.Add(new Category(dr.GetString("kategori_ad"))); 
            }
            return categories; 
        }
    }
    
}
