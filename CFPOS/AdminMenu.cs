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
    public partial class AdminMenu : Form
    {

        //static AdminMenu _obj;
        //public static AdminMenu instance
        //{
        //    get
        //    {
        //        if (_obj == null)
        //        {
        //            _obj = new AdminMenu();
        //        }
        //        return _obj;
        //    }
        //}

        //public Panel pnlContainer
        //{
        //    get { return panelContainer; }
        //    set { panelContainer = value; }
        //}
        public AdminMenu()
        {
            InitializeComponent();

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }



        private void btnSchedule_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(EmployeeSchedule.Instance))
            {
                panelContainer.Controls.Add(EmployeeSchedule.Instance);
                EmployeeSchedule.Instance.Dock = DockStyle.Fill;
                EmployeeSchedule.Instance.BringToFront();
            }
            else
            {
                EmployeeSchedule.Instance.BringToFront();
            }

        }

        private void btnAdminDrinks_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(AdminDrinks.Instance))
            {
                panelContainer.Controls.Add(AdminDrinks.Instance);
                AdminDrinks.Instance.Dock = DockStyle.Fill;
                AdminDrinks.Instance.BringToFront();
            }
            else
            {
                AdminDrinks.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(AdminRevenue.Instance))
            {
                panelContainer.Controls.Add(AdminRevenue.Instance);
                AdminRevenue.Instance.Dock = DockStyle.Fill;
                AdminRevenue.Instance.BringToFront();
            }
            else
            {
                AdminRevenue.Instance.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!panelContainer.Controls.Contains(EmpManage.Instance))
            {
                panelContainer.Controls.Add(EmpManage.Instance);
                EmpManage.Instance.Dock = DockStyle.Fill;
                EmpManage.Instance.BringToFront();
            }
            else
            {
                EmpManage.Instance.BringToFront();
            }
        }
    }

}
