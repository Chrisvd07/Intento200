using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
