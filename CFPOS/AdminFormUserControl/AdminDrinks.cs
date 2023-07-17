using Services.Repository;
using Services.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace CFPOS
{
    public partial class AdminDrinks : UserControl
    {
        private static AdminDrinks _instance;
        public static AdminDrinks Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminDrinks();
                return _instance;
            }
        }

        CategoryRepository categoryRepository = new CategoryRepository();
        ItemRepository itemRepository = new ItemRepository();

        private AdminDrinks()
        {
            InitializeComponent();

            LoadDataGridViews();
        }

        public void LoadDataGridViews()
        {
            // Lấy danh sách Items
            var ListItems = itemRepository.getAll();

            // Gán dữ liệu vào DataGridView
            dgvAdminDrinks.Columns.Clear();
            dgvAdminDrinks.Rows.Clear();
            dgvAdminDrinks.DataSource = new BindingSource { DataSource = ListItems };
            dgvAdminDrinks.AllowUserToAddRows = false;


            // Cập nhật chỉ mục của các cột ẩn
            UpdateHiddenColumnsIndex();

            // Thêm cột mới cho giá tiền
            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.Name = "Price";
            priceColumn.HeaderText = "Price";
            priceColumn.DataPropertyName = "Price";
            priceColumn.DefaultCellStyle.Format = "###,###,###,##0.000";
            dgvAdminDrinks.Columns.Add(priceColumn);

            // Thêm cột mới cho StatusName
            DataGridViewTextBoxColumn statusColumn = new DataGridViewTextBoxColumn();
            statusColumn.Name = "StatusName";
            statusColumn.HeaderText = "Status";
            statusColumn.DataPropertyName = "Status";
            dgvAdminDrinks.Columns.Add(statusColumn);

            // Thêm cột mới cho tên Category
            DataGridViewTextBoxColumn categoryNameColumn = new DataGridViewTextBoxColumn();
            categoryNameColumn.Name = "CategoryName";
            categoryNameColumn.HeaderText = "Category";
            categoryNameColumn.DataPropertyName = "Category.Name";
            dgvAdminDrinks.Columns.Add(categoryNameColumn);

            // Xử lý sự kiện CellFormatting để hiển thị tên danh mục
            dgvAdminDrinks.CellFormatting += DgvAdminDrinks_CellFormatting;

            // Tạo dữ liệu khởi đầu cho combobox Category
            cmbCategory.DataSource = categoryRepository.getAll();
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.SelectedItem = null;

            // Tạo dữ liệu khởi đầu cho combobox Status
            var statusList = new List<KeyValuePair<string, bool>>
            {
                new KeyValuePair<string, bool>("Available", true),
                new KeyValuePair<string, bool>("Unavailable", false)
            };

            cmbStatus.DataSource = statusList;
            cmbStatus.DisplayMember = "Key";
            cmbStatus.ValueMember = "Value";
            cmbStatus.SelectedItem = null;
        }

        // Tạo class đại diện cho combobox Status
        private void DgvAdminDrinks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvAdminDrinks.Columns["CategoryName"].Index && e.RowIndex >= 0)
            {
                var item = dgvAdminDrinks.Rows[e.RowIndex].DataBoundItem as Item;
                if (item != null)
                {
                    var category = categoryRepository.getCategoryById(item.CategoryId.Value);
                    if (category != null)
                    {
                        e.Value = category.Name;
                    }
                }
            }
            else if (e.ColumnIndex == dgvAdminDrinks.Columns["StatusName"].Index && e.RowIndex >= 0)
            {
                var item = dgvAdminDrinks.Rows[e.RowIndex].DataBoundItem as Item;
                if (item != null)
                {
                    if (item.Status.Value)
                    {
                        e.Value = "Available";
                    }
                    else
                    {
                        e.Value = "Unavailable";
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any input fields are empty
                if (string.IsNullOrEmpty(txtItemName.Text) ||
                    string.IsNullOrEmpty(txtItemPrice.Text) ||
                    cmbCategory.SelectedItem == null ||
                    string.IsNullOrEmpty(txtItemDescription.Text) ||
                    cmbStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all the fields.", "Warning", MessageBoxButtons.OK);
                    return;
                }

                // Check if txtItemPrice contains a valid decimal value
                if (!decimal.TryParse(txtItemPrice.Text, out decimal itemPrice))
                {
                    MessageBox.Show("Invalid input for Item Price. Please enter a decimal value.", "Warning", MessageBoxButtons.OK);
                    return;
                }


                if (itemPrice < 0)
                {
                    MessageBox.Show("Invalid input for Item Price. Please enter a > 0 value.", "Warning", MessageBoxButtons.OK);
                    return;
                }

                if (!string.IsNullOrEmpty(txtItemId.Text))
                {
                    MessageBox.Show("Do not fill in the ID box as it will be automatically marked", "Warning", MessageBoxButtons.OK);
                    txtItemId.Text = string.Empty;
                    return;
                }


                //Create a new Item
                var selectedCategory = (Category)cmbCategory.SelectedItem;
                var selectedStatus = (KeyValuePair<string, bool>)cmbStatus.SelectedItem;
                itemRepository.createItem(txtItemName.Text, txtItemDescription.Text, itemPrice, selectedStatus.Value, selectedCategory.Id);
                MessageBox.Show("Create Successfully!", "Warning", MessageBoxButtons.OK);

                txtItemName.Text = string.Empty;
                txtItemPrice.Text = string.Empty;
                txtItemDescription.Text = string.Empty;
                cmbCategory.SelectedItem = null;

                // Cập nhật DataGridViews
                LoadDataGridViews();
            }
            catch (Exception)
            {
                MessageBox.Show("Input Invalid. Please Try Again", "Warning", MessageBoxButtons.OK);
            }
        }

        private void dgvAdminDrinks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvAdminDrinks.Rows.Count)
            {
                DataGridViewRow selectedRow = dgvAdminDrinks.Rows[e.RowIndex];
                var item = selectedRow.DataBoundItem as Item;

                if (item != null)
                {
                    txtItemId.Text = item.Id.ToString();
                    txtItemName.Text = item.Name;

                    if (item.Price.HasValue)
                    {
                        txtItemPrice.Text = item.Price.ToString();
                    }
                    else
                    {
                        txtItemPrice.Text = string.Empty;
                    }

                    txtItemDescription.Text = item.Description;
                    cmbCategory.SelectedValue = item.CategoryId;
                    cmbStatus.SelectedValue = item.Status;
                }
            }
        }

        private void UpdateHiddenColumnsIndex()
        {
            if (dgvAdminDrinks.Columns.Contains("Price"))
            {
                dgvAdminDrinks.Columns["Price"].Visible = false;
            }

            if (dgvAdminDrinks.Columns.Contains("CategoryId"))
            {
                dgvAdminDrinks.Columns["CategoryId"].Visible = false;
            }

            if (dgvAdminDrinks.Columns.Contains("Category"))
            {
                dgvAdminDrinks.Columns["Category"].Visible = false;
            }

            if (dgvAdminDrinks.Columns.Contains("OrderDetails"))
            {
                dgvAdminDrinks.Columns["OrderDetails"].Visible = false;
            }

            if (dgvAdminDrinks.Columns.Contains("Status"))
            {
                dgvAdminDrinks.Columns["Status"].Visible = false;
            }
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any input fields are empty
                if (string.IsNullOrEmpty(txtItemName.Text) ||
                    string.IsNullOrEmpty(txtItemPrice.Text) ||
                    cmbCategory.SelectedItem == null ||
                    string.IsNullOrEmpty(txtItemDescription.Text) ||
                    cmbStatus.SelectedItem == null)
                {
                    MessageBox.Show("Please fill in all the fields.", "Warning", MessageBoxButtons.OK);
                    return;
                }

                // Check if txtItemPrice contains a valid decimal value
                if (!decimal.TryParse(txtItemPrice.Text, out decimal itemPrice))
                {
                    MessageBox.Show("Invalid input for Item Price. Please enter a decimal value.", "Warning", MessageBoxButtons.OK);
                    return;
                }

                if (!int.TryParse(txtItemId.Text, out int itemId))
                {
                    MessageBox.Show("Invalid input for Item Id. Please enter a int value.", "Warning", MessageBoxButtons.OK);
                    return;
                }

                Item existItem = itemRepository.getAll().FirstOrDefault(Item => Item.Id == itemId);

                //Item exist
                if (existItem != null)
                {//Update Item
                    existItem.Name = txtItemName.Text;
                    existItem.Price = itemPrice;
                    existItem.Description = txtItemDescription.Text;

                    var selectedCategory = (Category)cmbCategory.SelectedItem;
                    var selectedStatus = (KeyValuePair<string, bool>)cmbStatus.SelectedItem;
                    existItem.CategoryId = selectedCategory.Id;
                    existItem.Status = selectedStatus.Value;

                    itemRepository.update(existItem);
                    MessageBox.Show("Create Successfully!", "Warning", MessageBoxButtons.OK);

                    txtItemName.Text = string.Empty;
                    txtItemPrice.Text = string.Empty;
                    txtItemDescription.Text = string.Empty;
                    cmbCategory.SelectedItem = null;
                    cmbStatus.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("ID Not Found! Please Try Again", "Warning", MessageBoxButtons.OK);
                }

                // Cập nhật DataGridViews
                LoadDataGridViews();
            }
            catch (Exception)
            {
                MessageBox.Show("Input Invalid. Please Try Again", "Warning", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Kiểm tra xem đã chọn một dòng dữ liệu trong DataGridView chưa?
            if (dgvAdminDrinks.SelectedCells.Count > 0)
            {
                // Lấy chỉ số dòng dữ liệu được chọn
                int selectedIndex = dgvAdminDrinks.SelectedCells[0].RowIndex;

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Are you want to delete this Item?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    // Lấy thông tin Item từ dòng dữ liệu được chọn
                    Item selectedItem = dgvAdminDrinks.Rows[selectedIndex].DataBoundItem as Item;

                    //Xóa Item
                    bool deleteResult = itemRepository.delete(selectedItem);

                    if (deleteResult)
                    {

                        //Cập nhật lại DataGridViews
                        LoadDataGridViews();

                        MessageBox.Show("Delete Successfully!", "Warning", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Item", "Error", MessageBoxButtons.OK);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an Item to delete", "Warning", MessageBoxButtons.OK);
            }
        }
    }
}
