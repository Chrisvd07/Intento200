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
    public partial class AddingProduct : Form
    {
        private readonly ProductService _productService;

        public AddingProduct(ProductService productService)
        {
            InitializeComponent();
            this._productService = productService;
        }

        private void AddingProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
