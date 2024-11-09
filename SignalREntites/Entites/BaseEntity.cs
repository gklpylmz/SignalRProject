using SignalREntites.Enums;
using SignalREntites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREntites.Entites
{
    public class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set ; }
        public DateTime? ModifiedDate { get ; set ; }
        public DateTime? DeletedDate { get; set ; }
        public DataStatus Status { get ; set; }
    }
}
