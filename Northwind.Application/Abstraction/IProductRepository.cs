using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application.Abstraction
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(AddProductos product);
        void UpdateProduct(Product product);
        void DeleteProduct(int ProductID);
        void AllPorductpp(Product product);
    }
}
