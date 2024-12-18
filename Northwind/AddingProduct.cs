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
using System.Windows.Forms;


namespace Northwind
{
    public partial class AddingProduct : Form
    {


        public event Action<int, string, decimal, int, decimal, string, string> ProductSelected;
        private readonly ProductService _productService;
        private readonly ordenar _ordenar;

        public AddingProduct(ProductService productService, ordenar ordenar)
        {
            InitializeComponent();
            this._productService = productService;
            this._ordenar = ordenar;
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddingProduct_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _productService.GetAllProducts();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Comprobamos si se seleccionó un producto
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtener los detalles del producto
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int productId = Convert.ToInt32(selectedRow.Cells["ProductID"].Value);
                    string productName = selectedRow.Cells["ProductName"].Value.ToString();
                    decimal unitPrice = Convert.ToDecimal(selectedRow.Cells["UnitPrice"].Value);
                    string supplierName = selectedRow.Cells["CompanyName"].Value.ToString();
                    string categoryName = selectedRow.Cells["CategoryName"].Value.ToString();

                    // Mostrar el formulario para ingresar cantidad y descuento
                    Form3 form3 = new Form3(productName, unitPrice, supplierName, categoryName);
                    DialogResult dialogResult = form3.ShowDialog();

                    if (dialogResult == DialogResult.OK)
                    {
                        // Obtener la cantidad y el descuento desde Form3
                        int quantity = form3.Quantity;
                        decimal discount = form3.Discount;

                        // Calcular el ExtendedPrice
                        decimal extendedPrice = unitPrice * quantity * (1 - discount);

                        // Llamamos al evento y pasamos los datos a Form1
                        ProductSelected?.Invoke(productId, productName, unitPrice, quantity, discount, supplierName, categoryName);

                        // Cerrar el formulario AddingProduct
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
