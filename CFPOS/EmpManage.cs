using FluentValidation.Results;
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
    public partial class EmpManage : UserControl
    {

        private int _id;


        AccountRepository _listAccount;
        List<Account> _list;
        BindingList<string> errors = new BindingList<string>();

        private static EmpManage instance;

        private static EmpManage instanceEmp;
        public static EmpManage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmpManage();
                }
                return instance;
            }

        }

        public static EmpManage InstanceEmp (int id)
        {
            
                if (instanceEmp == null)
                {
                    instanceEmp = new EmpManage(id);
                }
                return instanceEmp;
            

        }

        public EmpManage()
        {
            InitializeComponent();
            loadInitData();
        }

        public EmpManage(int id)
        {
            InitializeComponent1();
            _listAccount = new AccountRepository();
            var accountinfo = _listAccount?.getAll().FirstOrDefault(p => p.Id == id, null);
            txtId.Text = accountinfo.Id.ToString();
            txtName.Text = accountinfo.Fullname;
            txtPass.Text = accountinfo.Password;
            txtDesc.Text = accountinfo.Description;
            txtUser.Text = accountinfo.Username;
            txtSalary.Text = accountinfo.Salary.ToString();
            txtRoleid.Text = accountinfo.RoleId.ToString();
            dtpDob.Value = accountinfo.DateOfBirth.Value;

        }

        private void EmpManage_Load(object sender, EventArgs e)
        {
            
        }


        private void loadInitDataEmp(int _id)
        {
            var checkEmployee = _listAccount.getAll().FirstOrDefault(a => a.Id == _id);
            dgvEmp.DataSource = new BindingSource() { DataSource = checkEmployee };
            btnEdit.Enabled = false;
            btnDel.Enabled = false;
            showVisible();

        }

        private void loadInitData()
        {
            _listAccount = new AccountRepository();
            _list = new List<Account>();
            _list = _listAccount.getAll();
            dgvEmp.DataSource = new BindingSource() { DataSource = _list };

            showVisible();

            lbError.DataSource = errors;
        }
        private void showVisible()
        {
            DataGridViewBand band = dgvEmp.Columns[7];
            DataGridViewBand band1 = dgvEmp.Columns[9];
            DataGridViewBand band2 = dgvEmp.Columns[10];
            DataGridViewBand band3 = dgvEmp.Columns[11];
            DataGridViewBand band4 = dgvEmp.Columns[12];


            band.Visible = false;
            band1.Visible = false;
            band2.Visible = false;
            band3.Visible = false;
            band4.Visible = false;
        }




        public void getData(Account account)
        {

            account.Fullname = txtName.Text;
            var id = account.Id;
            int.TryParse(txtId.Text, out id);
            account.Id = id;
            account.DateOfBirth = dtpDob.Value;
            account.Username = txtUser.Text;
            account.Password = txtPass.Text;
            account.Description = txtDesc.Text;
            String tSa = txtSalary.Text;
            int? salary = account.Salary;
            if (int.TryParse(tSa, out int temp))
                salary = temp;
            else
            {
                salary = null;
            }
            account.Salary = salary;

            String tRol = txtRoleid.Text;
            int? roleid = account.RoleId;
            if (int.TryParse(tRol, out int temp1))
                roleid = temp1;
            else
            {
                roleid = null;
            }
            account.RoleId = roleid;
            account.Status = true;
            account.Orders = null;

        }




        private void emptyForm()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            txtRoleid.Text = "";
            txtDesc.Text = "";
            txtSalary.Text = "";
            txtUser.Text = "";
        }


        private void accValidate(Account account /* i want to add function attribute here*/)
        {
            AccountValidation validator = new AccountValidation();
            ValidationResult result = validator.Validate(account);
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }
            else
            {
                // i want to function attribure run here
            }
        }

        private void emptyErrorsSuccess()
        {
            errors.Clear();
            errors.Add("Success");
        }

        private void dgvEmp_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var account = _listAccount.getAll().ToList()[dgvEmp.CurrentRow.Index];
            txtId.Text = account.Id.ToString();
            txtName.Text = account.Fullname;
            txtPass.Text = account.Password;
            txtDesc.Text = account.Description;
            txtUser.Text = account.Username;
            txtSalary.Text = account.Salary.ToString();
            txtRoleid.Text = account.RoleId.ToString();
            txtId.Enabled = false;
            btnDel.Enabled = true;
            btnEdit.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var account = new Account();
            errors.Clear();
            getData(account);
            AccountValidation validator = new AccountValidation();
            ValidationResult result = validator.Validate(account);
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }
            else
            {
                // i want to function attribure run here

                _listAccount.createAccount(account.Fullname, account.Description, account.Salary, account.Username, account.RoleId, account.Password,account.DateOfBirth);

                dgvEmp.DataSource = new BindingSource() { DataSource = _listAccount.getAll() };
                showVisible();
                emptyErrorsSuccess();

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var account = _listAccount.getAll()[dgvEmp.CurrentRow.Index];
            errors.Clear();
            AccountValidation validator = new AccountValidation();
            ValidationResult result = validator.Validate(account);
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }
            else
            {
                // i want to function attribure run here
                getData(account);
                _listAccount.update(account);
                txtId.Enabled = true;
                btnEdit.Enabled = false;
                btnDel.Enabled = false;
                emptyForm();
                emptyErrorsSuccess();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var account = _listAccount.getAll().ToList()[dgvEmp.CurrentRow.Index];

            AccountValidation validator = new AccountValidation();
            ValidationResult result = validator.Validate(account);
            if (!result.IsValid)
            {
                foreach (ValidationFailure failure in result.Errors)
                {
                    errors.Add($"{failure.PropertyName}: {failure.ErrorMessage}");
                }
            }
            else
            {
                // i want to function attribure run here

                _listAccount.delete(account);
                dgvEmp.DataSource = new BindingSource() { DataSource = _listAccount.getAll() };
                emptyForm();
                emptyErrorsSuccess();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();

            var check = _listAccount.getAll().Where(x => x.Username.ToLower().Contains(search));
            dgvEmp.DataSource = new BindingSource() { DataSource = check };
        }
    }
}
