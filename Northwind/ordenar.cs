using Microsoft.Extensions.DependencyInjection;
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
    public partial class ordenar : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly ICustomerRepository _customerRepository;
        private readonly IEmployessRepositore _employessRepositore;
        private readonly IOrderService _orderService;
        private readonly IShipViaRepository _shipViaRepository;

        public ordenar(IServiceProvider serviceProvider, ICustomerRepository customerRepository, IEmployessRepositore employessRepositore, IOrderService orderService, IShipViaRepository shipViaRepository)
        {
            InitializeComponent();
            this._serviceProvider = serviceProvider;
            this._customerRepository = customerRepository;
            this._employessRepositore = employessRepositore;
            this._orderService = orderService;
            this._shipViaRepository = shipViaRepository;
        }


        private void ordenar_Load(object sender, EventArgs e)
        {
            // Esto lo puedes poner en el constructor de Form1 o en el evento Load
            if (dataGridView13.Columns.Count == 0)
            {
                dataGridView13.Columns.Add("ProductID", "Product ID");
                dataGridView13.Columns.Add("ProductName", "Product Name");
                dataGridView13.Columns.Add("UnitPrice", "Unit Price");
                dataGridView13.Columns.Add("Quantity", "Quantity");
                dataGridView13.Columns.Add("Discount", "Discount");
                dataGridView13.Columns.Add("SupplierName", "Supplier Name");
                dataGridView13.Columns.Add("CategoryName", "Category Name");
                dataGridView13.Columns.Add("ExtendedPrice", "Extended Price");
            }
            var customer = _customerRepository.GetCustomers();
            CustomerComboBox.DataSource = customer.ToList();
            CustomerComboBox.DisplayMember = "CompanyName";
            CustomerComboBox.ValueMember = "CustomerID";

            var employe = _employessRepositore.GetEmployesses();
            EmployeeComboBox.DataSource = employe.ToList();
            EmployeeComboBox.DisplayMember = "FirstName";
            EmployeeComboBox.ValueMember = "EmployeeID";

            var ship = _shipViaRepository.GetShipVias();
            ShipViaComboBox.DataSource = ship.ToList();
            ShipViaComboBox.DisplayMember = "CompanyName";
            ShipViaComboBox.ValueMember = "ShipperID";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            var addingProductForm = _serviceProvider.GetRequiredService<AddingProduct>();

            // Suscribirnos al evento ProductSelected para recibir los datos
            addingProductForm.ProductSelected += (productId, productName, unitPrice, quantity, discount, supplierName, categoryName) =>
            {
                // Calcular el Extended Price
                decimal extendedPrice = unitPrice * quantity * (1 - discount);

                // Verificar que el DataGridView tiene columnas
                if (dataGridView13.Columns.Count == 0)
                {
                    dataGridView13.Columns.Add("ProductID", "Product ID");
                    dataGridView13.Columns.Add("ProductName", "Product Name");
                    dataGridView13.Columns.Add("UnitPrice", "Unit Price");
                    dataGridView13.Columns.Add("Quantity", "Quantity");
                    dataGridView13.Columns.Add("Discount", "Discount");
                    dataGridView13.Columns.Add("SupplierName", "Supplier Name");
                    dataGridView13.Columns.Add("CategoryName", "Category Name");
                    dataGridView13.Columns.Add("ExtendedPrice", "Extended Price");
                }

                dataGridView13.Rows.Add(
                    productId,
                    productName,
                    unitPrice,
                    quantity,
                    discount,
                    supplierName,
                    categoryName,
                    extendedPrice.ToString("C2")
                );
            };

            addingProductForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                CustomerID = CustomerComboBox.SelectedValue.ToString(),
                EmployeeID = EmployeeComboBox.SelectedValue.ToString(),
                OrderDate = dateTimePicker1.Value,
                RequiredDate = dateTimePicker2.Value,
                ShippedDate = dateTimePicker3.Value,
                ShipAddress = txt_Address.Text,
                ShipCity = txt_City.Text,
                ShipRegion = txt_Region.SelectedItem?.ToString(),
                ShipPostalCode = txt_PostalCode.Text,
                ShipCountry = txt_ShipCountry.Text,
                ShipName = txt_ShipName.Text,
                ShipVia = (int)ShipViaComboBox.SelectedValue
            };

            // Crear la lista de detalles de la orden
            var orderDetails = new List<OrderDetail>();
            foreach (DataGridViewRow row in dataGridView13.Rows)
            {
                if (row.IsNewRow) continue;

                var orderDetail = new OrderDetail
                {
                    ProductID = (int)row.Cells["ProductID"].Value,
                    UnitPrice = (decimal)row.Cells["UnitPrice"].Value,
                    Quantity = (int)row.Cells["Quantity"].Value,
                    Discount = (decimal)row.Cells["Discount"].Value
                };

                orderDetails.Add(orderDetail);
            }

            // Llamar al servicio para crear la orden y sus detalles
            int orderID = _orderService.CreateOrder(order, orderDetails);

            // Mostrar el OrderID generado
            MessageBox.Show("Orden creada con ID: " + orderID);
        }
    }
}
