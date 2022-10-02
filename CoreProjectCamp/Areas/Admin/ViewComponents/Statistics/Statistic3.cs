using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic3 : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new Context();
            ViewBag.totalAuthor = c.Authors.Count();
            ViewBag.totalBlog = c.Blogs.Count();
            return View();
        }
    }
}
