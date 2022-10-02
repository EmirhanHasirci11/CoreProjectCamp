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
    public class Statistic2:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        public IViewComponentResult Invoke()
        {

            Context c = new Context();
            TempData["LatestBlog"] = bm.LatestBlogsWithCount(1).FirstOrDefault();
            return View();
        }
    }
}
