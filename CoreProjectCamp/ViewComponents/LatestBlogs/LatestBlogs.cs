using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.ViewComponents.LatestBlogs
{
    public class LatestBlogs:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogDal());

        public IViewComponentResult Invoke()
        {
            var blogs= bm.LatestBlogsWithCount(3);
            return View(blogs);
        }
    }
}
