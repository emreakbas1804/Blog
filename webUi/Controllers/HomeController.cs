using System;
using Business.Concrete;
using Business.ValidationRules;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace webUi.Controllers
{
    public class HomeController : Controller
    {
        WriterManager writerManager = new WriterManager(new EFWriterRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Writer model)
        {
            WriterValidator validationRulesValue = new WriterValidator();
            ValidationResult result = validationRulesValue.Validate(model);
            if (result.IsValid)
            {
                Writer newWriter = new Writer
                {
                    WriterName = model.WriterName,
                    WriterMail = model.WriterMail,
                    WriterPassword = model.WriterPassword
                };
                writerManager.WriterAdd(newWriter);              
            }
            else{
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    return View(model);
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Writer model)
        {
            return View();
        }


    }
}