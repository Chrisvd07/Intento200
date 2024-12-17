using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Northwind.Application.Abstraction;
using Northwind.Models;

namespace Northwind.Infraestructure
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly ISqlConnectionFasctory _connectionFasctory;

        public SupplierRepository(ISqlConnectionFasctory connectionFasctory) 
        {
            this._connectionFasctory = connectionFasctory;
        }
        public IEnumerable<Supplier> GetSuppliers()
        {
            var connection = _connectionFasctory.GetNewConnection();
            return connection.Query<Supplier>("SELECT * FROM Suppliers");
        }

        public void AddSupplier(Supplier supplier)
        {
            using (var conection = _connectionFasctory.GetNewConnection())
            {
                var query = "INSERT INTO Suppliers (CompanyName, ContactName) VALUES (@CompanyName, @ContactName)";
                conection.Execute(query, supplier);
            }
        }
        public void UpdateSupplier(Supplier supplier)
        {
            using (var connection = _connectionFasctory.GetNewConnection())
            {
                var query = "UPDATE Suppliers SET CompanyName = @CompanyName, ContactName = @ContactName WHERE SupplierId = @SupplierId";
                connection.Execute(query, supplier);
            }
        }


        public void RemoveSupplier( int supplierId)
        {
            using (var connection = _connectionFasctory.GetNewConnection())
            {
                var query = "DELETE FROM Suppliers WHERE SupplierId = @SupplierId";
                connection.Execute(query, new { SupplierId = supplierId });
            }
        }

        public class SqlConnectionFasctory : ISqlConnectionFasctory
        {
            private readonly IConfiguration _configuration;

            public SqlConnectionFasctory(IConfiguration configuration)
            {
                this._configuration = configuration;
            }

            public SqlConnection GetNewConnection()
            {
                return new SqlConnection(_configuration.GetConnectionString("NorthwindConnectionString"));
            }
        }
    }
}
