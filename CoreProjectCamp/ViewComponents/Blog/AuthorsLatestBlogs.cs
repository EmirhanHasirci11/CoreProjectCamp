using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.ViewComponents.Blog
{
    public class AuthorsLatestBlogs:ViewComponent
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = bm.AuthorsLatestBlogs(id);
            return View(values);
        }

    }
}
