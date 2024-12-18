using Northwind.Application.Abstraction;
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
    public partial class AddProduct : Form
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly ICategoryRepositore _categoryRepositore;
        private readonly IProductRepository _productRepository;

        public AddProduct(ISupplierRepository supplierRepository, ICategoryRepositore categoryRepositore, IProductRepository productRepository)
        {
            InitializeComponent();
            this._supplierRepository = supplierRepository;
            this._categoryRepositore = categoryRepositore;
            this._productRepository = productRepository;
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            var suppliers = _supplierRepository.GetSuppliers();
            comboBox1.DataSource = suppliers.ToList();
            comboBox1.DisplayMember = "CompanyName";
            comboBox1.ValueMember = "SupplierId";

            var categories = _categoryRepositore.GetCategories();
            comboBox2.DataSource = categories.ToList();
            comboBox2.DisplayMember = "CategoryName";
            comboBox2.ValueMember = "CategoryId";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produts = new AddProductos
            {
                ProductName = textBox1.Text,
                CategoryID = (int)comboBox2.SelectedValue,
                SupplierID = (int)comboBox1.SelectedValue,
                UnitPrice = Convert.ToInt32(textBox2.Text)

            };
            _productRepository.AddProduct(produts);
            textBox1.Text = "";
            textBox2.Text = "";
            MessageBox.Show("Producto agregado correctamente");

        }
    }
}
