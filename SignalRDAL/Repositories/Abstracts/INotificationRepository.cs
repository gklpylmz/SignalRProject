using SignalRDAL.Repositories.Concretes;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Abstracts
{
    public interface INotificationRepository:IRepository<Notification>
    {
        int GetPassiveNotificationCount();
        void ChangeNotificationStatusToTrue(int id);
        void ChangeNotificationStatusToFalse(int id);
    }
}
