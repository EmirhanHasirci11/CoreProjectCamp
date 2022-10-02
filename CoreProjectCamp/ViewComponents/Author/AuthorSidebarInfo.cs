using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreProjectCamp.ViewComponents.Author
{
    public class AuthorSidebarInfo:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public AuthorSidebarInfo(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        AuthorManager arm = new AuthorManager(new EFAuthorDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
          //  var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var author = arm.FindByEmail(user.Email);
            var author = arm.GetById(1);
            var values = arm.GetById(author.AuthorID);
            return View(values);
        }
    }
}
