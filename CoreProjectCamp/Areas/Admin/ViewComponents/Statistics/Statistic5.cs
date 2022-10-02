using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic5:ViewComponent
    {
        Context c = new();
        AuthorManager arm = new(new EFAuthorDal());
        public IViewComponentResult Invoke()
        {

            int mostCreativeAuthorId = c.Blogs.GroupBy(x => x.AuthorID).Select(x => x.Key).FirstOrDefault();
            TempData["topAuthor"] = arm.GetById(mostCreativeAuthorId);

            return View();
        }
    }
}
