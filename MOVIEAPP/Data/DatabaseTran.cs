using MOVIEAPP.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Data
{
    public class DatabaseTransactions
    {
        static string connectionString = "Server=localhost;Uid=root;Pwd=123456;Database=filmler;";
        static MySqlConnection connection;
        static MySqlCommand command;
        static MySqlDataReader dataReader;
        DataTable dataTable = new DataTable();
        public  static bool executeQuery(string query) {
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("MYSQLEXCEPTİON"+e.ToString());
                return false;
                
            }
          
        }

        public int kullaniciIdGetir(string sorgu) {
            int kullaniciId=0;
            connection = new MySqlConnection(connectionString);
            connection.Open(); 
            command = new MySqlCommand(sorgu, connection); 
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                kullaniciId= dataReader.GetInt16("kullanici_id");
            }
            connection.Close();
            return kullaniciId;
        }

        public User kullaniciGiris(string email,string password ) {
            User user = new User();
            string sorgu = "SELECT kullanici_ad,kullanici_soyad,kullanici_sifre,yetki" +
                    " FROM filmler.kullanici"+
                    " INNER JOIN filmler.login"+
                    " ON filmler.kullanici.kullanici_id = filmler.login.kullanici_id"+
                    " where kullanici_email = '"+email+"' and kullanici_sifre = '"+password+"' "; 
            connection = new MySqlConnection(connectionString);
            connection.Open();
            command = new MySqlCommand(sorgu, connection);
            dataReader = command.ExecuteReader();
            //Sorgudan dönen veri varsa
            if (dataReader.HasRows) {

                while (dataReader.Read())
                {
                    user.name = dataReader.GetString("kullanici_ad");
                    user.surname = dataReader.GetString("kullanici_soyad");
                    user.authority = dataReader.GetInt16("yetki");
                }
                connection.Close();
                return user;

            } else {
                connection.Close();
                return null;
            }
          
        }

        public static List<Category> kategorileriGetir() {
            List<Category> categories = new List<Category>(); 
            string sorgu = "SELECT kategori_ad FROM filmler.kategoriler";
            connection = new MySqlConnection(connectionString);
            connection.Open();
            command = new MySqlCommand(sorgu, connection); 
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                categories.Add(new Category(dataReader.GetString("kategori_ad"))); 
            }
            connection.Close();
            return categories; 
        }

        public DataTable veriGetir(string sorgu) {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            command = new MySqlCommand(sorgu, connection);  
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            return dataTable;
           

        }
         
    }
    
}
