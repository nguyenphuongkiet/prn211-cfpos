using DGVPrinterHelper;
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
    public partial class ucEmployeeMenu : UserControl
    {
        private int _id;
        private string _name;
        CategoryRepository categoryRepository;
        ItemRepository itemRepository;
        OrderDetailRepository orderDetailRepository;
        OrderRepository orderRepository;

        private static ucEmployeeMenu _instance;
        public static ucEmployeeMenu Instance(int id, string name)
        {
            if (_instance == null)
            {
                _instance = new ucEmployeeMenu(id, name);
            }

            return _instance;
        }


        public ucEmployeeMenu(int id, string name)
        {
            //get id of user after login
            _id = id;
            //get id of user after login and add to the txtName
            _name = name;
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
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
            dgvOrder.Rows.Add(item, price, quantity, total, note, category);

            // Sum the total of the bill
            decimal sum = 0;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                sum += decimal.Parse(dgvOrder.Rows[i].Cells[3].Value.ToString());
            }

            txtTotal.Text = sum.ToString();
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Retrieve selected values
            string category = cboCategory.SelectedItem.ToString();
            string item = cboItem.SelectedItem.ToString();
            string note = txtNote.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(nudQuantity.Value.ToString());
            decimal total = price * quantity;

            // Get the index of the selected row
            int rowIndex = dgvOrder.SelectedRows[0].Index;

            // Update the values of the cells in the selected row
            dgvOrder.Rows[rowIndex].Cells[0].Value = item; // Name
            dgvOrder.Rows[rowIndex].Cells[1].Value = price; // Price
            dgvOrder.Rows[rowIndex].Cells[2].Value = quantity; // Quantity
            dgvOrder.Rows[rowIndex].Cells[3].Value = total; // Total
            dgvOrder.Rows[rowIndex].Cells[4].Value = note; // Note

            // Sum the total of the bill
            decimal sum = 0;
            for (int i = 0; i < dgvOrder.Rows.Count; i++)
            {
                sum += decimal.Parse(dgvOrder.Rows[i].Cells[3].Value.ToString());
            }

            txtTotal.Text = sum.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvOrder.SelectedRows.Count > 0)
            {
                // Prompt the user to confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Remove the selected row from the DataGridView control
                    dgvOrder.Rows.Remove(dgvOrder.SelectedRows[0]);

                    // Recalculate the total cost of the order
                    decimal sum = 0;
                    for (int i = 0; i < dgvOrder.Rows.Count; i++)
                    {
                        sum += decimal.Parse(dgvOrder.Rows[i].Cells[3].Value.ToString());
                    }

                    txtTotal.Text = sum.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error");
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            orderRepository = new OrderRepository();
            orderDetailRepository = new OrderDetailRepository();
            // Get the employee ID from the LoginForm
            int employeeId = _id;

            // Get the total cost of the order from the txtTotal TextBox
            decimal totalCost = decimal.Parse(txtTotal.Text);

            // Get the current date and time
            DateTime date = DateTime.Now;

            // Create a new Order object with the necessary information
            Order newOrder = new Order
            {
                EmployeeId = employeeId,
                StatusId = 2,
                TotalMoney = totalCost,
                Date = date
            };

            // Save the new order to the database
            orderRepository.create(newOrder);

            // Iterate through the rows in the dgvOrder DataGridView control
            foreach (DataGridViewRow row in dgvOrder.Rows)
            {
                // Get the details of the item that was ordered from the row
                string itemName = row.Cells[0].Value.ToString();
                int quantity = int.Parse(row.Cells[2].Value.ToString());
                string note = row.Cells[4].Value.ToString();

                // Find the corresponding Item object in the database
                Item orderedItem = itemRepository.getItemByName(itemName);

                // Create a new OrderDetail object with the necessary information
                OrderDetail orderDetail = new OrderDetail
                {
                    OrderId = newOrder.Id,
                    ItemId = orderedItem.Id,
                    Quantity = quantity,
                    Note = note
                };

                // Save the new order detail to the database
                orderDetailRepository.create(orderDetail);


            }

            // Display a success message or perform any other necessary actions
            MessageBox.Show("Order successfully saved!");

            /*
                Bill Export
             */

            /*// create the text file

            string filePath = @"D:\FPTU2022_2025\SECOND YEAR\SUMMER2023\Backend .NET\Source\BillStorage\" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Order made by " + _name);
                sw.WriteLine("Time: " + DateTime.Now);
                sw.WriteLine();
                // write the header row
                foreach (DataGridViewColumn column in dgvOrder.Columns)
                {
                    sw.Write(column.HeaderText + "\t\t");
                }
                sw.WriteLine();

                // write the data rows
                foreach (DataGridViewRow row in dgvOrder.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        sw.Write(cell.Value.ToString() + "\t");
                    }
                    sw.WriteLine();
                }

                sw.WriteLine("Total all: " + txtTotal.Text);
            }

            // inform the user that the bill has been exported
            MessageBox.Show("The bill has been exported to:\n" + filePath);*/

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Custormer Bill";
            printer.SubTitle = string.Format("Cashier: {0}", _name);
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString());
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = string.Format("Total money: {0}", txtTotal.Text);
            printer.PrintDataGridView(dgvOrder);

            //clear the datagridview
            dgvOrder.Rows.Clear();
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Check if a valid row is selected
            {
                // Retrieve the list of all categories and bind it to cboCategory
                List<Category> categories = categoryRepository.getAll();
                cboCategory.DisplayMember = "Name";
                cboCategory.ValueMember = "Id";
                cboCategory.DataSource = categories;

                DataGridViewRow row = dgvOrder.Rows[e.RowIndex];
                string name = row.Cells[0].Value.ToString(); // Get the name of the selected item

                // Find the category of the selected item
                int? categoryId = itemRepository.getItemByName(name).CategoryId;

                // Set the selected category in cboCategory
                cboCategory.SelectedValue = categoryId;

                // Bind the items under the selected category to cboItem
                cboItem.DataSource = itemRepository.getAll().Where(a => a.CategoryId == categoryId).ToList();
                cboItem.DisplayMember = "Name";
                cboItem.ValueMember = "Id";

                // Set the selected item in cboItem
                cboItem.Text = name;

                // Set the price, quantity and note in their respective controls
                txtPrice.Text = row.Cells[1].Value.ToString();
                nudQuantity.Value = int.Parse(row.Cells[2].Value.ToString());
                txtNote.Text = row.Cells[4].Value.ToString();

            }
        }
    }
}
