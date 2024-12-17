using Dapper;
using Northwind.Application.Abstraction;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infraestructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly ISqlConnectionFasctory _connectionFactory;

        public ProductRepository(ISqlConnectionFasctory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IEnumerable<Product> GetProducts()
        {
            using var connection = _connectionFactory.GetNewConnection();
            string query = @"
        SELECT 
            p.ProductId,
            p.ProductName,
            c.CategoryName,
            s.CompanyName,
            p.UnitPrice
        FROM Products p
        INNER JOIN Categories c ON p.CategoryId = c.CategoryId
        INNER JOIN Suppliers s ON p.SupplierId = s.SupplierId";

            return connection.Query<Product>(query);
        }
        public void AddProduct(Product product)
        {
            using (var connection = _connectionFactory.GetNewConnection())
            {
                var query = "INSERT INTO Products (ProductName, CategoryID,SupplierID,UnitPrice) VALUES (@ProductName,@CategoryID,@SupplierID,@UnitPrice)";
                connection.Execute(query, product);
            }
        }
        public void UpdateProduct(Product product)
        {
            using(var  connection = _connectionFactory.GetNewConnection())
            {
                var query = "UPDATE Products Set ProductName = @ProductName, CategoryName = @CategoryName, CompanyName = @CompanyName, UnitPrice = @UnitPrice WHERE ProductId, @ProductId";
                connection.Execute(query, product);
            }

        }
        public void DeleteProduct(int Productid) 
        {
            using(var conenection = _connectionFactory.GetNewConnection())
            {
                var query = "DELETE FROM Products WHERE ProductID = @ProductId";
                conenection.Execute(query, new { ProductId = Productid });
            }
        }

        
    }
}
