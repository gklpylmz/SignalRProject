﻿using SignalRDAL.Context;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Concretes
{
    public class SocialMediaRepository : BaseRepository<SocialMedia>, ISocialMediaRepository
    {
        public SocialMediaRepository(MyContext db) : base(db)
        {
        }
    }
}
