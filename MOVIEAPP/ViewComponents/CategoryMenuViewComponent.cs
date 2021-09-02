using Microsoft.AspNetCore.Mvc;
using MOVIEAPP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP.ViewComponents
{
    public class CategoryMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke () {
            //nula eşit değilse selectedcategoryye aktar
            if (RouteData.Values["action"].ToString()=="Register") 
                ViewBag.SelectedCategory = RouteData?.Values["id"];
                return View(CategoryRepository.GetCategories);
           
         
        }
    }
}
