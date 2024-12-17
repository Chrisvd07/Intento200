using Microsoft.Extensions.DependencyInjection;
using Northwind.Application.Abstraction;
using Northwind.Models;

namespace Northwind
{
    public partial class Form1 : Form
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IServiceProvider _serviceProvider;

        public Form1(ISupplierRepository supplierRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _supplierRepository = supplierRepository;
            _serviceProvider = serviceProvider;
            Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            dataGridView1.DataSource = _supplierRepository.GetSuppliers();
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.DataSource = _supplierRepository.GetSuppliers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form2 = _serviceProvider.GetRequiredService<Categories>();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = _serviceProvider.GetRequiredService<Form2>();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var supplierId = (int)dataGridView1.SelectedRows[0].Cells["SupplierId"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _supplierRepository.RemoveSupplier(supplierId);
                    dataGridView1.DataSource = _supplierRepository.GetSuppliers();
                    MessageBox.Show("Supplier deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to delete.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Salir si clicas en el encabezado

            textBoxCompanyName.Text = dataGridView1.Rows[e.RowIndex].Cells["CompanyName"].Value?.ToString();
            TextboxContactName.Text = dataGridView1.Rows[e.RowIndex].Cells["ContactName"].Value?.ToString();
        }
    }
}
