using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abstraction
{
    public interface IOrderRepository
    {
        int InsertOrder(Order order);
    }
    public interface IOrderDetailRepository
    {
        void InsertOrderDetail(OrderDetail orderDetail);
    }
}
