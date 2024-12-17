using Microsoft.Extensions.DependencyInjection;
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
    public partial class AddSupplier : Form
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly IServiceProvider _serviceProvider;

        public AddSupplier(ISupplierRepository supplierRepository, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            this._supplierRepository = supplierRepository;
            this._serviceProvider = serviceProvider;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var supplier = new Supplier
            {
                CompanyName = textBox1.Text,
                ContactName = textBox2.Text
            };
            _supplierRepository.AddSupplier(supplier);
             MessageBox.Show("Suppplier added succefully");
            var form2 = _serviceProvider.GetRequiredService<Form1>();
            form2.Show();
        }
    }
}
