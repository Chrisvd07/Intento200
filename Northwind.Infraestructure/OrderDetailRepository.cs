using Microsoft.Data.SqlClient;
using Northwind.Application.Abstraction;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Northwind.Infraestructure
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly string _connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False;";

        public void InsertOrderDetail(OrderDetail orderDetail)
        {
            string query = @"
            INSERT INTO [Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
            VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);
            ";

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Execute(query, orderDetail);
            }
        }
    }
}
