using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abstraction
{
    public interface IOrderepositori
    {
        int CreateOrder(string customerId, string employeeId, string shipViaId);
        void CreateOrderDetails(int orderId, List<Orderdetails> orderDetails);
    }
}
