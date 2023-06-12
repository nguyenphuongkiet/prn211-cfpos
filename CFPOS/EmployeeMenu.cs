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

            var selectedCategoryId = ((Category)cboCategory.SelectedItem).Id;
            cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == selectedCategoryId).ToList();
            cboItem.DisplayMember = "Name";
            cboItem.ValueMember = "Id";
        }

        private void CboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategoryId = ((Category)cboCategory.SelectedItem).Id;
            cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == selectedCategoryId).ToList();
        }


        private void LoadOrderDetails()
        {
            orderDetailRepository = new OrderDetailRepository();
            // Query database to retrieve order details for the specified table ID
            // Bind the retrieved data to the DataGridView control
            DataSet dataSet = new DataSet();
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Name");
            table.Columns.Add("Price");
            table.Columns.Add("Quantity");
            dataSet.Tables.Add(table);
            dgvOrder.DataSource = dataSet.Tables[0];

/*           dgvOrder.DataSource = new BindingSource() { DataSource = orderDetailRepository };
*/
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            if (btnTable1.BackColor == Color.White)
                btnTable1.BackColor = Color.Gray;
            LoadOrderDetails();

        }
        private void btnTable2_Click(object sender, EventArgs e)
        {
            if (btnTable2.BackColor == Color.White)
                btnTable2.BackColor = Color.Gray;
        }
        private void btnTable3_Click(object sender, EventArgs e)
        {
            if (btnTable3.BackColor == Color.White)
                btnTable3.BackColor = Color.Gray;
        }
        private void btnTable4_Click(object sender, EventArgs e)
        {
            if (btnTable4.BackColor == Color.White)
                btnTable4.BackColor = Color.Gray;
        }
        private void btnTable5_Click(object sender, EventArgs e)
        {
            if (btnTable5.BackColor == Color.White)
                btnTable5.BackColor = Color.Gray;
        }
        private void btnTable6_Click(object sender, EventArgs e)
        {
            if (btnTable6.BackColor == Color.White)
                btnTable6.BackColor = Color.Gray;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            int item = cboItem.SelectedIndex;
            int quantity = (int)nudQuantity.Value;

            orderDetail.Quantity = quantity;
            orderDetail.ItemId = item;
            orderDetailRepository.create(orderDetail);
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
