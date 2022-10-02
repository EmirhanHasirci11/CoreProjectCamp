using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.ViewComponents.AuthorNotifications
{
    public class AuthorNotifications:ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EFNotificationDal());
        public IViewComponentResult Invoke()
        {
            var notifications = nm.LatestNotificationsWithCount(3);
            return View(notifications);
        }
    }
}
