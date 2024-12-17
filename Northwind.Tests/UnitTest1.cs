using Microsoft.Data.SqlClient;
using Northwind.Infraestructure;

namespace Northwind.Tests
{
    public class SupplierRepositoryUnitTest
    {
        public class fakeconnectionFactory : ISqlConnectionFasctory
        {
            public SqlConnection GetNewConnection()
            {
                return new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
            }
        }
        [Fact]
        public void Test_Getsuppliers_retusturs_any_data()
        {
            var repository = new SupplierRepository(new fakeconnectionFactory());


            var supploier = repository.GetSuppliers();

            Assert.True(supploier.Any());
        }
    }
}