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
    public class AboutRepository : BaseRepository<About>, IAboutRepository
    {
        public AboutRepository(MyContext db) : base(db)
        {
        }
    }
}
