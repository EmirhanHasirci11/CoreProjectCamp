using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
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
        ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

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
            
            
            _commentService.TAdd(c);

            return Json(true);

        }
        public PartialViewResult CommentsByBlog(int id)
        {
            var comments = _commentService.GetList(id);
            return PartialView(comments);
        }
    }
}
