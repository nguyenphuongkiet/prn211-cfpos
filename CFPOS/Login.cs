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
            var check = accountService.getAll().FirstOrDefault(a => a.Username == username && a.Password == password);
            int id = check.Id;
            string name = check.Fullname;
            if (check != null)
            {
                //login success
                this.Hide();
                Form employee = new EmployeeMenu(id, name);
                employee.ShowDialog();
                // Set the UserId property to the ID of the logged-in account
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào hệ thống.", "Alert", MessageBoxButtons.OK);
            }
            btnLogin.Enabled = true;
        }
    }
}
