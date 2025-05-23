﻿using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.ManagerServices.Abstracts
{
    public interface IOrderManager:IManager<Order>
    {
        int TotalOrderCount();
        int ActiveTotalOrderCount();
        decimal LastOrderPrice();
        decimal TodayOrderPrice();
    }
}
