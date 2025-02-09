using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Configurations
{
    public class ShoppingCartConfiguration:BaseConfiguration<ShoppingCart>
    {
        public override void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            base.Configure(builder);
        }
    }
}
