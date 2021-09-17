using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Data;
using MOVIEAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke () {

            List<Category> categories = DatabaseTransactions.kategorileriGetir();
            //nula eşit değilse selectedcategoryye aktar
            //RouteData ile o anki actionu al  
            if (RouteData.Values["action"].ToString() == "Index") { 
                ViewBag.SelectedCategory = RouteData?.Values["name"]; 
            }   
            return View(categories);
               
        }
    }
}
