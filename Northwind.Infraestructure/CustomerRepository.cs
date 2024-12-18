using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Northwind.Application.Abstraction;

namespace Northwind.Infraestructure
{
    public class CustomerRepository :   ICustomerRepository
    {
        private readonly ISqlConnectionFasctory _sqlConnectionFasctory;

        public CustomerRepository(ISqlConnectionFasctory sqlConnectionFasctory) 
        {
            this._sqlConnectionFasctory = sqlConnectionFasctory;
        }
        public IEnumerable<Customers> GetCustomers()
        {
            var connection = _sqlConnectionFasctory.GetNewConnection();
            return connection.Query<Customers>("SELECT * FROM Customers");
        }


    }
}
