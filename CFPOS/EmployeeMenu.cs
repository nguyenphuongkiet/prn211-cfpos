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
        OrderDetailRepository orderDetailRepository;
        OrderRepository orderRepository;
        TableRepository tableRepository;
        public EmployeeMenu()
        {
            InitializeComponent();

            LoadItems();

        }

        private void LoadItems()
        {
            // Query database to retrieve all available items
            // Bind results to the ComboBox control
            categoryRepository = new CategoryRepository();
            itemRepository = new ItemRepository();
            cboCategory.DataSource = categoryRepository.getAll();
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "Id";
            cboCategory.SelectedIndex = 0;

            // Add event handler for SelectedIndexChanged event
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;
            cboItem.SelectedIndexChanged += CboItem_SelectedIndexChanged;

            var selectedCategoryId = ((Category)cboCategory.SelectedItem).Id;
            cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == selectedCategoryId).ToList();
            cboItem.DisplayMember = "Name";
            cboItem.ValueMember = "Id";
            cboItem.SelectedIndex = 0;
            var selectedItemId = ((Item)cboItem.SelectedItem).Id;

            // Retrieve the selected item's price from the database using the item ID
            var selectedItem = itemRepository.getItemById(selectedItemId);
            var price = selectedItem.Price;

            txtPrice.Text = price.ToString();
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCategory.SelectedItem != null)
            {
                var selectedCategoryId = ((Category)cboCategory.SelectedItem).Id;
                cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == selectedCategoryId).ToList();
            }
        }
        private void CboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboItem.SelectedItem != null)
            {
                var selectedItemId = ((Item)cboItem.SelectedItem).Id;
                var selectedItem = itemRepository.getItemById(selectedItemId);
                var price = selectedItem.Price;
                txtPrice.Text = price.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Retrieve selected values
            string category = cboCategory.SelectedItem.ToString();
            string item = cboItem.SelectedItem.ToString();
            string note = txtNote.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(nudQuantity.Value.ToString());
            decimal total = price * quantity;

            // Add row to DataGridView
            dgvOrder.Rows.Add(item, price, quantity, total, note);

            // Sum the total of the bill
            decimal sum = 0;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                sum += decimal.Parse(dgvOrder.Rows[i].Cells[3].Value.ToString());
            }

            txtTotal.Text = sum.ToString();
        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            // Create a new Order object
            // Populate the Order object with necessary information (employee ID, table ID, total money, date, etc.)
            // Insert the new Order into the database
            // Iterate through the rows of the DataGridView control and insert each OrderDetail object into the database with the corresponding order ID
            // Generate a bill or receipt based on the order information and print it out or export it as desired
            // Reset the table selection and clear the DataGridView control to prepare for the next customer
        }


    }
}
