using Northwind.Application;
using Northwind.Application.Abstraction;
using Northwind.Infraestructure;
using Northwind.Models;
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
    public partial class Form2 : Form
    {
        private readonly ProductService _productService;
        private readonly IProductRepository _productRepository;

        public Form2(ProductService productService, IProductRepository productRepository)
        {
            InitializeComponent();
            this._productService = productService;
            this._productRepository = productRepository;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            var products = _productService.GetAllProducts();
            dataGridView1.DataSource = products;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var Productid = (int)dataGridView1.SelectedRows[0].Cells["ProductID"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _productRepository.DeleteProduct(Productid);
                    dataGridView1.DataSource = _productService.GetAllProducts();
                    MessageBox.Show("Product deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to delete.");
            }
        }
    }
}
