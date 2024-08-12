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
    public class ContactManager:BaseManager<Contact>,IContactManager
    {
        IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository):base(contactRepository) 
        {
            _contactRepository = contactRepository;
        }
    }
}
