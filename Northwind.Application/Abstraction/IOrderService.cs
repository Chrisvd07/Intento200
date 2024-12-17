using Northwind.Models;

namespace Northwind.Application.Abstraction
{
    public interface IOrderService
    {
        void LoadComboBoxes(ComboBox customerComboBox, ComboBox employeeComboBox, ComboBox shipViaComboBox);
        void CreateOrder(string customerId, string employeeId, string shipViaId, List<Orderdetails> orderDetails);
    }
}
