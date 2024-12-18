using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abstraction
{
    public interface ICustomerRepository
    {
        public IEnumerable<Customers> GetCustomers();
    }
}
