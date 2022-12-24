using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Entity.Concrete;
using System;

namespace webUi.Controllers
{
    public class CommentController:Controller
    {
        CommentManager commentManager = new CommentManager(new EFCommentRepository());
        public IActionResult Index()
        {            
            return View();
        }
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = commentManager.GetList(id);
            return PartialView(values);
        }
   

    }
}