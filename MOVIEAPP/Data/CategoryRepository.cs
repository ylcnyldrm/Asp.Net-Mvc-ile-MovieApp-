using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.Data

{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;
        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
               new Category(){ Id=1,Name="Macera"},
               new Category(){ Id=2,Name="Romantik"},
               new Category(){ Id=4,Name="Savaş"},
               new Category(){ Id=3,Name="Komedi"},
               new Category(){ Id=5,Name="Bilim Kurgu"},
            };

        }

        public static List<Category> GetCategories
        {
            get { return _categories; }
        }
        public static void AddCategories(Category entity)
        {
            _categories.Add(entity);
        }

        public static Category GetById(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}
