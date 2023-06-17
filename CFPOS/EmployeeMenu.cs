using DGVPrinterHelper;
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
        private int _id;
        private string _name;
        CategoryRepository categoryRepository;
        ItemRepository itemRepository;
        OrderDetailRepository orderDetailRepository;
        OrderRepository orderRepository;

        //TableRepository tableRepository;
        public EmployeeMenu(int id, string name)
        {
            InitializeComponent();
            //get id of user after login
            _id = id;
            //get id of user after login and add to the txtName
            _name = name;
            txtEmployeeName.Text = name;
            //enable the timer 
            timer1.Enabled = true;

            if (!panelContainer.Controls.Contains(ucWelcome.Instance))
            {
                panelContainer.Controls.Add(ucWelcome.Instance);
                ucWelcome.Instance.Dock = DockStyle.Fill;
                ucWelcome.Instance.BringToFront();
            }
            else
            {
                ucWelcome.Instance.BringToFront();
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTime.Text = DateTime.Now.ToString("h:mm:ss tt");
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to sign out?", "Alert", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(ucEmployeeMenu.Instance(_id, _name)))
            {
                panelContainer.Controls.Add(ucEmployeeMenu.Instance(_id, _name));
                ucEmployeeMenu.Instance(_id, _name).Dock = DockStyle.Fill;
                ucEmployeeMenu.Instance(_id, _name).BringToFront();
            }
            else
            {
                ucEmployeeMenu.Instance(_id, _name).BringToFront();
            }
        }
    }
}
