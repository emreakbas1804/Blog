using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Entity.Concrete;
using System;

namespace webUi.Controllers
{
    public class BlogController:Controller
    {
        
        BlogManager blogManager = new BlogManager(new EFBlogRepository());

        public IActionResult Index()
        {
            var values = blogManager.GetBlogListWithCategory();
            return View(values);
        }
        public IActionResult BlogRead(int id)
        {
            var values = blogManager.GetBlogById(id);
            return View(values);
        }


    }
}