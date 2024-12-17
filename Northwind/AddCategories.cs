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
    public partial class AddCategories : Form
    {
        private readonly ICategoryRepositore _categoryRepositore;

        public AddCategories(ICategoryRepositore categoryRepositore)
        {
            InitializeComponent();
            this._categoryRepositore = categoryRepositore;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var CATE = new Category()
            {
                CategoryName = textBox1.Text,
                Description = textBox2.Text,
            };
            _categoryRepositore.AddCategory(CATE);
            MessageBox.Show("Categoria agregada correctamente");
        }
    }
}
