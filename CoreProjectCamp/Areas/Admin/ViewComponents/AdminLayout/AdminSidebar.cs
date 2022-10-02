using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Admin.ViewComponents.AdminLayout
{
    public class AdminSidebar:ViewComponent
    {
        AuthorManager arm = new(new EFAuthorDal());
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var author = arm.GetById(1);
            return View(author);
        }
    }
}
