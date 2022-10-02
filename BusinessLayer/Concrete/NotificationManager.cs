using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public Notification GetById(int id)
        {
            return _notificationDal.GetById(x => x.NotificationID == id);
        }

        public List<Notification> GetList()
        {
            return _notificationDal.GetList();
        }

        public List<Notification> LatestNotificationsWithCount(int? count)
        {
            return count != null ? _notificationDal.LatestNotificationsWithCount((int)count) : _notificationDal.LatestNotificationsWithCount(null);
        }

        public void TAdd(Notification t)
        {
            _notificationDal.TAdd(t);
        }

        public void TDelete(Notification t)
        {
            _notificationDal.TDelete(t);
        }

        public void TUpdate(Notification t)
        {
            _notificationDal.TUpdate(t);
        }
    }
}
