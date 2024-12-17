using Northwind.Application.Abstraction;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application
{
    public class OrderService : IOrderService
    {
        private readonly IOrderepositori orderepositori;
        private readonly IComboBoxLoader _comboBoxLoader;

        public OrderService(IOrderepositori orderepositori, IComboBoxLoader comboBoxLoader)
        {
            
            this.orderepositori = orderepositori;
            _comboBoxLoader = comboBoxLoader;
        }

        public void LoadComboBoxes(ComboBox customerComboBox, ComboBox employeeComboBox, ComboBox shipViaComboBox)
        {
            // Cargar los datos de los combos desde la base de datos
            _comboBoxLoader.LoadCustomers(customerComboBox);
            _comboBoxLoader.LoadEmployees(employeeComboBox);
            _comboBoxLoader.LoadShippers(shipViaComboBox);
        }

        public void CreateOrder(string customerId, string employeeId, string shipViaId, List<Orderdetails> orderDetails)
        {
            // Crear la orden
            int orderId = orderepositori.CreateOrder(customerId, employeeId, shipViaId);

            // Crear los detalles de la orden
            orderepositori.CreateOrderDetails(orderId, orderDetails);
        }
    }
}
