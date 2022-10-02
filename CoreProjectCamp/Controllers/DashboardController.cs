using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
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
    public class DashboardController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthorService _authorService;

        public DashboardController(UserManager<AppUser> userManager, IAuthorService authorService)
        {
            _userManager = userManager;
            _authorService = authorService;
        }

        public async Task<IActionResult> Index()
        {
            Context c = new Context();
            //var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var author = _authorService.FindByEmail(user.Email);
            var author = _authorService.GetById(1);
            ViewBag.v1 = c.Blogs.Count();
            ViewBag.v2 = c.Blogs.Where(x=>x.AuthorID==author.AuthorID).Count();
            ViewBag.v3 = c.Categories.Count();
            return View();
        }
    }
}
