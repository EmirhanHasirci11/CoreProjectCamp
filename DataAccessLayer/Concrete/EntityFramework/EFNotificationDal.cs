using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EFNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        public List<Notification> LatestNotificationsWithCount(int? count)
        {
            using (var c = new Context())
            {
                return count != null ? c.Notifications.OrderByDescending(x => x.NotificationID).Take((int)count).ToList() : c.Notifications.OrderByDescending(x => x.NotificationID).ToList();
            }
        }
    }
}
