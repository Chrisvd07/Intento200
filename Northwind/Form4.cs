using Northwind.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind
{
    public partial class Form4 : Form
    {
        private readonly ProductService _productService;

        public Form4(ProductService productService)
        {
            InitializeComponent();
            this._productService = productService;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Asignar el DataSource primero
            dataGridView1.DataSource = _productService.GetAllProducts();
            
        }
    }
}
