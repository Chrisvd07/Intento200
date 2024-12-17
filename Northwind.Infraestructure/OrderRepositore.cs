using Microsoft.Data.SqlClient;
using Northwind.Application.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Northwind.Models;


namespace Northwind.Infraestructure
{
    public class OrderRepositore : IOrderepositori
    {
        private readonly string _connectionString;

        public OrderRepositore(string connectionstring) 
        {
            this._connectionString = connectionstring;
        }
        public int CreateOrder(string customerId, string employeeId, string shipViaId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var orderQuery = @"
                    INSERT INTO Orders 
                    (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipVia)
                    OUTPUT INSERTED.OrderID
                    VALUES
                    (@CustomerID, @EmployeeID, GETDATE(), GETDATE(), GETDATE(), @ShipVia);
                ";
                return connection.ExecuteScalar<int>(orderQuery, new { CustomerID = customerId, EmployeeID = employeeId, ShipVia = shipViaId });
            }
        }
        public void CreateOrderDetails(int orderId, List<Orderdetails> orderDetails)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                var orderDetailsQuery = @"
            INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
            VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);
        ";
                foreach (var detail in orderDetails)
                {
                    connection.Execute(orderDetailsQuery, new
                    {
                        OrderID = orderId,
                        ProductID = detail.ProductId,
                        UnitPrice = detail.UnitPrice,
                        Quantity = detail.Quantity,
                        Discount = detail.Discount
                    });
                }
            }
        }
    }


}
