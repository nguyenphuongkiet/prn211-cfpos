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

    public partial class Login : Form
    {
        
        POSContext _context;
        AccountRepository accountService;
        public Login()
        {
            InitializeComponent();
            _context = new POSContext();
            accountService = new AccountRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            var checkEmployee = accountService.getAll().FirstOrDefault(a => a.Username == username && a.Password == password && a.RoleId == 2);
            var checkAdmin = accountService.getAll().FirstOrDefault(a => a.Username == username && a.Password == password && a.RoleId == 1);

            

            if (checkEmployee != null)
            {
                //check if employee logged in successful, pass the id and full to employeeMenu
                int id = checkEmployee.Id;
                string name = checkEmployee.Fullname;
                //then forward to employeeMenu
                this.Hide();
                Form employee = new EmployeeMenu(id, name);
                employee.ShowDialog();
                
            }
            else if (checkAdmin != null){
                //login success
                this.Hide();
                Form admin = new AdminMenu();
                admin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào hệ thống.", "Alert", MessageBoxButtons.OK);
            }
            btnLogin.Enabled = true;
        }
    }
}
