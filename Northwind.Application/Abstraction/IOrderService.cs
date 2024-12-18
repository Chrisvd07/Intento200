﻿using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Northwind.Application.Abstraction
{
    public interface IOrderService
    {
        int CreateOrder(Order order, List<OrderDetail> orderDetails);
    }
}
