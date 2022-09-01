using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogDal());
        public IActionResult Index()
        {
            var blogs = bm.GetBlogListWithCategory();
            return View(blogs);
        }
        public IActionResult BlogDetails(int id)
        {
            ViewBag.blogID = id;
            var blog = bm.GetById(id);
            return View(blog);
        }
    }
}
