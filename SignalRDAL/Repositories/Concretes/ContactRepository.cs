using SignalRDAL.Context;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Concretes
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(MyContext db) : base(db)
        {
        }
    }
}
