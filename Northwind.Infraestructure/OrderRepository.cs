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
    public class OrderRepository : IOrderRepository
    {
        private readonly string _connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False;";

        public int InsertOrder(Order order)
        {
            string query = @"
            INSERT INTO Orders 
            (CustomerID, EmployeeID, OrderDate, RequiredDate, ShippedDate, ShipAddress, ShipCity, ShipRegion, ShipPostalCode, ShipCountry, ShipName, ShipVia)
            OUTPUT INSERTED.OrderID
            VALUES
            (@CustomerID, @EmployeeID, @OrderDate, @RequiredDate, @ShippedDate, @ShipAddress, @ShipCity, @ShipRegion, @ShipPostalCode, @ShipCountry, @ShipName, @ShipVia);
            ";

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.ExecuteScalar<int>(query, order);
            }
        }
    }
}
