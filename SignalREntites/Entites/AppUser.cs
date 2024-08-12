using Microsoft.AspNetCore.Identity;
using SignalREntites.Enums;
using SignalREntites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREntites.Entites
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? ModifiedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DeletedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DataStatus Status { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //Relational Prop
        public virtual AppUserProfile Profile { get; set; }
    }
}
