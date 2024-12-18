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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int Quantity { get; private set; }
        public decimal Discount { get; private set; }

        private string productName;
        private decimal unitPrice;
        private string supplierName;
        private string categoryName;

        public Form3(string productName, decimal unitPrice, string supplierName, string categoryName)
        {
            InitializeComponent();
            this.productName = productName;
            this.unitPrice = unitPrice;
            this.supplierName = supplierName;
            this.categoryName = categoryName;

            label3.Text = productName;
            label4.Text = unitPrice.ToString("C");
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int quantity))
            {
                // Limpiar el valor de los posibles símbolos y caracteres no numéricos
                string discountString = textBox2.Text.Replace("%", "").Trim(); // Elimina el símbolo '%' si existe
                string unitPriceString = label4.Text.Replace("$", "").Replace("€", "").Replace(",", ".").Trim();

                // Intentar convertir discount y unitPrice a decimal
                if (decimal.TryParse(unitPriceString, out decimal unitPrice) && decimal.TryParse(discountString, out decimal discount))
                {
                    // Si el descuento es mayor que 100, tratarlo como porcentaje
                    if (discount > 100)
                    {
                        discount /= 100; // Convertir de porcentaje a decimal (10 -> 0.1)
                    }

                    // Verificar que el descuento esté dentro del rango válido
                    if (discount < 0 || discount > 1)
                    {
                        MessageBox.Show("El descuento debe estar entre 0 y 1 (por ejemplo, 0.1 para 10%).", "Descuento inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Asignar los valores de cantidad y descuento
                    Quantity = quantity;
                    Discount = discount;

                    // Cerrar el formulario y retornar los datos
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa valores válidos para cantidad y descuento.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
