using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Configurations
{
    public class SocialMediaConfiguration:BaseConfiguration<SocialMedia>
    {
        public override void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            base.Configure(builder);
        }
    }
}
