using Dapper;
using Northwind.Application.Abstraction;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Infraestructure
{
    public class CategoryRepository : ICategoryRepositore
    {
        private readonly ISqlConnectionFasctory _connectionFasctory;

        public CategoryRepository(ISqlConnectionFasctory connectionFasctory) 
        {
            this._connectionFasctory = connectionFasctory;
        }
        public IEnumerable<Category> GetCategories()
        {
            var conenection = _connectionFasctory.GetNewConnection();
            return conenection.Query<Category>("SELECT * FROM Categories");
        }
        public void AddCategory(Category category)
        {
            using (var conection = _connectionFasctory.GetNewConnection())
            {
                var query = "INSERT INTO Categories (CategoryName, Description) VALUES (@CategoryName, @Description)";
                conection.Execute(query, category);
            }
        }
        public void UpdateCategory(Category category)
        {
            using (var connection = _connectionFasctory.GetNewConnection())
            {
                var query = "UPDATE Categories SET CategoryName = @CategoryName, Description = @Description WHERE CategoryID = @CategoryID";
                connection.Execute(query, category);
            }
        }


        public void RemoveCategory(int CategoryId)
        {
            using (var connection = _connectionFasctory.GetNewConnection())
            {
                var query = "DELETE FROM Categories WHERE CategoryID = @CategoryID";
                connection.Execute(query, new { CategoryID = CategoryId });
            }
        }
    }
}
