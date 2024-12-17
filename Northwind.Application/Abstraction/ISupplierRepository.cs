using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abstraction
{
    public interface ISupplierRepository
    {
        public IEnumerable<Supplier>GetSuppliers();
        void AddSupplier(Supplier supplier);
        void RemoveSupplier(int supplier);
        void UpdateSupplier(Supplier supplier);    
    }
}
