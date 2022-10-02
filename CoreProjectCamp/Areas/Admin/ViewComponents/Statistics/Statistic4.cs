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
    public class Statistic4:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context c = new();
            AuthorManager arm = new(new EFAuthorDal());
            AdminManager adm = new(new EFAdminDal());
            var values = adm.GetById(1);
            ViewBag.allNotification = c.Notifications.Count();
            int mostCreativeAuthorId = c.Blogs.GroupBy(x => x.AuthorID).OrderByDescending(x=>x.Key).Select(x => x.Key).FirstOrDefault();
            var topAuthor = arm.GetById(mostCreativeAuthorId);
            


            return View(values);
        }
    }
}
