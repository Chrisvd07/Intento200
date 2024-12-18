using Northwind.Application.Abstraction;
using Northwind.Models;
using Northwind.Application.Abstraction;
using Northwind.Models;

namespace Northwind.Application
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderService(IOrderRepository orderRepository, IOrderDetailRepository orderDetailRepository)
        {
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        public int CreateOrder(Order order, List<OrderDetail> orderDetails)
        {
            int orderID = _orderRepository.InsertOrder(order);

            foreach (var detail in orderDetails)
            {
                detail.OrderID = orderID;
                _orderDetailRepository.InsertOrderDetail(detail);
            }

            return orderID; 
        }
    }
}
