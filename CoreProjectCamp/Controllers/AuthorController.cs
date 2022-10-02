using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreProjectCamp.Controllers
{
    [AllowAnonymous]
    public class AuthorController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthorService _authorService;
        public AuthorController(UserManager<AppUser> userManager,IAuthorService authorService)
        {
            _userManager = userManager;
            _authorService = authorService;
        }        
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AuthorSidebarPartial()
        {
   
            
            return PartialView();
        }
        public PartialViewResult AuthorFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult> AuthorEditProfile()
        {
            var user= await _userManager.FindByNameAsync(User.Identity.Name);
            var author = _authorService.FindByEmail(user.Email);
            var AuthorValues = _authorService.GetById(author.AuthorID);
            return View(AuthorValues);
        }
        [HttpPost]
        public IActionResult AuthorEditProfile(Author p)
        {

            p.AuthorStatus = true;
            AuthorValidator validationRules = new AuthorValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                _authorService.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");

            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        
        //todo 73.video yazar eklemeyi burada tanımlandı

    }
}
