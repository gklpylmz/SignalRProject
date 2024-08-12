﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SignalREntites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Configurations
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class,IEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            
        }

       
    }
}
