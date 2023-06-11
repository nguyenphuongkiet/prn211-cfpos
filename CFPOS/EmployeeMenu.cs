using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Services.Models;
using Services.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFPOS
{
    public partial class EmployeeMenu : Form
    {
        CategoryRepository categoryRepository;
        ItemRepository itemRepository;
        public EmployeeMenu()
        {
            InitializeComponent();
            categoryRepository = new CategoryRepository();
            itemRepository = new ItemRepository();
            cboCategory.DataSource = categoryRepository.getAll();
            cboCategory.DisplayMember = "Name";
            var selectedCategoryId = ((Category)cboCategory.SelectedItem).Id;
            cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == selectedCategoryId).ToList();
            cboItem.DisplayMember = "Name";
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            if (btnTable1.BackColor == Color.White)
                btnTable1.BackColor = Color.Gray;

            // Specify which columns to display
            dgvOrder.Columns["name"].HeaderText = "Item Name";
            dgvOrder.Columns["quantity"].HeaderText = "Quantity";
            dgvOrder.Columns["price"].HeaderText = "Price";
        }
    }
}
