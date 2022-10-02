using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Author.ViewComponents.AuthorLayout
{
    public class AuthorSidebar:ViewComponent
    {
        AuthorManager arm = new AuthorManager(new EFAuthorDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var author = arm.GetById(1);
            return View(author);
        }
    }
}
