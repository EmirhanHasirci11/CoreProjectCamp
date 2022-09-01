using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EFCommentDal());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult LeaveComment()
        {
          
            return PartialView();
        }
        [HttpPost]
        public IActionResult LeaveComment(Comment c)
        {
            
            
            cm.TAdd(c);

            return Json(true);

        }
        public PartialViewResult CommentsByBlog(int id)
        {
            var comments = cm.GetList(id);
            return PartialView(comments);
        }
    }
}
