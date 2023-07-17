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
    public partial class AdminRevenue : UserControl
    {
        private static AdminRevenue _instance;
        public static AdminRevenue Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AdminRevenue();
                return _instance;
            }
        }

        private OrderRepository _orderRepository = new OrderRepository();
        private StatusRepository _statusRepository = new StatusRepository();
        private AccountRepository _accountRepository = new AccountRepository();
        private OrderDetailRepository _orderDetailRepository = new OrderDetailRepository();
        private ItemRepository _itemRepository = new ItemRepository();
        public AdminRevenue()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        public void LoadDataGridView()
        {
            var orders = _orderRepository.getAll();
            var status = _statusRepository.getAll();
            var account = _accountRepository.getAll();
            var ordersTable = from order in orders
                              join s in status on order.StatusId equals s.Id
                              join ac in account on order.EmployeeId equals ac.Id
                              select new
                              {
                                  ID = order.Id,
                                  Employee = ac.Username,
                                  Status = s.Status1,
                                  TotalMoney = order.TotalMoney,
                                  Date = order.Date
                              };
            var revenue = ordersTable.Sum(x => x.TotalMoney);
            lblRevenue.Text = revenue.ToString();
            lblTable.Text = "Orders list";
            dgvOrders.DataSource = new BindingSource { DataSource = ordersTable };
            button1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvOrders_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMessage.Text = string.Empty;
            var index = e.RowIndex + 1;
            if (index != null)
            {
                var orderDetails = _orderDetailRepository.getAll();
                var orders = _orderRepository.getAll();
                var items = _itemRepository.getAll();
                var details = from od in orderDetails
                              join o in orders on od.OrderId equals o.Id
                              join i in items on od.ItemId equals i.Id
                              where o.Id == index
                              select new
                              {
                                  ID = od.Id,
                                  Drinks = i.Name,
                                  Quantity = od.Quantity,
                                  Note = od.Note
                              };
                dgvOrders.DataSource = new BindingSource { DataSource = details };
                lblTable.Text = "Details";
                button1.Enabled = true;
                dgvOrders.CellContentDoubleClick -= dgvOrders_CellContentDoubleClick;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            var orders = _orderRepository.getAll();
            var status = _statusRepository.getAll();
            var account = _accountRepository.getAll();
            var ordersTable = from order in orders
                              join s in status on order.StatusId equals s.Id
                              join ac in account on order.EmployeeId equals ac.Id
                              select new
                              {
                                  ID = order.Id,
                                  Employee = ac.Username,
                                  Status = s.Status1,
                                  TotalMoney = order.TotalMoney,
                                  Date = order.Date
                              };
            var revenue = ordersTable.Sum(x => x.TotalMoney);
            lblRevenue.Text = revenue.ToString();
            lblTable.Text = "Orders list";
            dgvOrders.DataSource = new BindingSource { DataSource = ordersTable };
            button1.Enabled = false;
            dgvOrders.CellContentDoubleClick += dgvOrders_CellContentDoubleClick;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            dtpFrom.Value = dtpFrom.MinDate;
            dtpTo.Value = dtpTo.MaxDate;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var orders = _orderRepository.getAll();
            var status = _statusRepository.getAll();
            var account = _accountRepository.getAll();
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;
            var ordersTable = from order in orders
                              join s in status on order.StatusId equals s.Id
                              join ac in account on order.EmployeeId equals ac.Id
                              where order.Date >= fromDate && order.Date <= toDate
                              select new
                              {
                                  ID = order.Id,
                                  Employee = ac.Username,
                                  Status = s.Status1,
                                  TotalMoney = order.TotalMoney,
                                  Date = order.Date
                              };
            var revenue = ordersTable.Sum(x => x.TotalMoney);
            lblRevenue.Text = revenue.ToString();
            lblTable.Text = "Orders list";
            if (ordersTable.Count() == 0) lblMessage.Text = "No data found!";
            dgvOrders.DataSource = new BindingSource { DataSource = ordersTable };
            button1.Enabled = false;
        }
    }
}
