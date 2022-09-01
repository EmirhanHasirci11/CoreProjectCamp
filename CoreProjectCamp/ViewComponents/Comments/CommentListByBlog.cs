using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.ViewComponents.Comments
{
    public class CommentListByBlog: ViewComponent
    {
        CommentManager cm = new CommentManager(new EFCommentDal());

        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}
