using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Configurations
{
    public class NotificationConfiguration : BaseConfiguration<Notification>
    {
        public override void Configure(EntityTypeBuilder<Notification> builder)
        {
            base.Configure(builder);

        }
    }
}
