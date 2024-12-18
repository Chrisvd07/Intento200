﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CompanyName { get; set; }
        public string CategoryName { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryID { private get; set; }
        public int SupplierID { private get; set; }

       
    }
   

}
