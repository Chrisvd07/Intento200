using Northwind.Application.Abstraction;
using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Application
{
    public class CategoryService
    {
        private readonly ICategoryRepositore _categoryRepositore;

        public CategoryService(ICategoryRepositore categoryRepositore)
        {
            this._categoryRepositore = categoryRepositore;
        }
        public IEnumerable<Category> GetAllCategories()
        {
            return _categoryRepositore.GetCategories();
        }


    }
}
