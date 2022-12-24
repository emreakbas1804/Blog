using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace webUi.Controllers
{
    public class CategoryController:Controller
    {
        CategoryManager categoryManager = new CategoryManager(new EFCategoryRepository());

        public IActionResult Index()
        {
            var values = categoryManager.GetList();
            return View(values);
        }


        
    }
}