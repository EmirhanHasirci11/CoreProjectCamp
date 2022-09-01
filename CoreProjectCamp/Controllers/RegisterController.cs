using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreProjectCamp.Models;
using CoreProjectCamp.Models.EntityList;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Controllers
{
    public class RegisterController : Controller
    {
        AuthorManager arm = new AuthorManager(new EFAuthorDal());
        [HttpGet]
        public IActionResult Index()
        {

            List<SelectListItem> values = (from x in CityList.GetCityList()
                                           select new SelectListItem
                                           {
                                               Value = x.CityID.ToString(),
                                               Text = x.CityName
                                           }).ToList();

            TempData["cities"] = values;
           
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Author p)
        {
            AuthorValidator validationRules = new AuthorValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                p.AuthorStatus = true;
                arm.TAdd(p);
                return RedirectToAction("Index", "Blog");

            }
            else
            {
                List<SelectListItem> values = (from x in CityList.GetCityList()
                                               select new SelectListItem
                                               {
                                                   Value = x.CityID.ToString(),
                                                   Text = x.CityName
                                               }).ToList();
                TempData["cities"] = values;
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View(p);

        }
    }
}
