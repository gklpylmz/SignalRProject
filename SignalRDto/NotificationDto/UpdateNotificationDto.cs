using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDto.NotificationDto
{
    public class UpdateNotificationDto
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}
