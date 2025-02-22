using SignalRBLL.ManagerServices.Abstracts;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.ManagerServices.Concretes
{
    public class NotificationManager:BaseManager<Notification>,INotificationManager
    {
        INotificationRepository _notificationRepository;

        public NotificationManager(INotificationRepository notificationRepository):base(notificationRepository)
        {
            _notificationRepository = notificationRepository;
        }

        public void ChangeNotificationStatusToFalse(int id)
        {
            
            _notificationRepository.ChangeNotificationStatusToFalse(id);
        }

        public void ChangeNotificationStatusToTrue(int id)
        {
            _notificationRepository.ChangeNotificationStatusToTrue(id);
        }

        public int GetPassiveNotificationCount()
        {
            return _notificationRepository.GetPassiveNotificationCount();
        }

        public List<Notification> GetPassiveNotifications()
        {
            var values = _notificationRepository.GetAll();
            return values.Where(x => x.IsActive == false).ToList();
        }
    }
}
