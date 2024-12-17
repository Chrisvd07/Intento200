using Northwind.Application;
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
    public partial class Categories : Form
    {
        private readonly CategoryService _categoryService;
        private readonly ICategoryRepositore _categoryRepositore;

        public Categories(CategoryService categoryService, ICategoryRepositore categoryRepositore)
        {
            InitializeComponent();
            this._categoryService = categoryService;
            this._categoryRepositore = categoryRepositore;
            Load += Categories_Load1;
        }

        private void Categories_Load1(object? sender, EventArgs e)
        {
            dataGridView1.DataSource = _categoryService.GetAllCategories();
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var CategoryId = (int)dataGridView1.SelectedRows[0].Cells["CategoryID"].Value;
                var result = MessageBox.Show("Are you sure you want to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    _categoryRepositore.RemoveCategory(CategoryId);
                    dataGridView1.DataSource = _categoryService.GetAllCategories();
                    MessageBox.Show("Supplier deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("Please select a supplier to delete.");
            }
        }
    }
}
