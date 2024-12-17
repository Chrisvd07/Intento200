using Microsoft.Data.SqlClient;

namespace Northwind.Infraestructure
{
    public interface ISqlConnectionFasctory
    {
        SqlConnection GetNewConnection();
    }
}