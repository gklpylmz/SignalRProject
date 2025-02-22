using SignalRDAL.Context;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using SignalREntites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Concretes
{
    public class NotificationRepository : BaseRepository<Notification>, INotificationRepository
    {
        MyContext _db;
        public NotificationRepository(MyContext db) : base(db)
        {
            _db = db;
        }

        public void ChangeNotificationStatusToFalse(int id)
        {
            var notification = _db.Notifications.Find(id);
            notification.IsActive = false;
            _db.SaveChanges();
        }

        public void ChangeNotificationStatusToTrue(int id)
        {
            var notification = _db.Notifications.Find(id);
            notification.IsActive = true;
            _db.SaveChanges();
        }

        public int GetPassiveNotificationCount()
        {
            return _db.Notifications.Where(x=>x.IsActive == false).Count();
        }
    }
}
