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
        public EmployeeMenu()
        {
            InitializeComponent();

            LoadItems();

        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            if (btnTable1.BackColor == Color.White)
                btnTable1.BackColor = Color.Gray;

            
        }


        private void LoadItems()
        {
            // Query database to retrieve all available items
            // Bind results to the ComboBox control
            categoryRepository = new CategoryRepository();
            itemRepository = new ItemRepository();
            cboCategory.DataSource = categoryRepository.getAll();
            cboCategory.DisplayMember = "Name";

            // Add event handler for SelectedIndexChanged event
            cboCategory.SelectedIndexChanged += CboCategory_SelectedIndexChanged;

            var selectedCategoryId = ((Category)cboCategory.SelectedItem).Id;
            cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == selectedCategoryId).ToList();
            cboItem.DisplayMember = "Name";
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryId = ((Category)cboCategory.SelectedItem).Id;
            cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == selectedCategoryId).ToList();
        }


        private void LoadOrderDetails(int tableId)
        {
            orderDetailRepository = new OrderDetailRepository();
            // Query database to retrieve order details for the specified table ID
            // Bind the retrieved data to the DataGridView control
            
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            // Get the selected item and quantity from the ComboBox and TextBox controls
            // Add the item and quantity to the DataGridView control
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
