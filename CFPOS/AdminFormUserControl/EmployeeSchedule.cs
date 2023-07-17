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
using System.Xml.Linq;

namespace CFPOS
{
    public partial class EmployeeSchedule : UserControl
    {
        private static EmployeeSchedule instance;
        public static EmployeeSchedule Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EmployeeSchedule();
                }
                return instance;
            }

        }
        ScheduleRepository _scheduleRepository;
        AccountRepository _accountRepository;
        AccountScheduleRepository _accountScheduleRepository;
        public EmployeeSchedule()
        {
            InitializeComponent();
            _scheduleRepository = new ScheduleRepository();
            _accountRepository = new AccountRepository();
            _accountScheduleRepository = new AccountScheduleRepository();
            generateList();
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            int.TryParse(txtStart.Text, out int start);
            int.TryParse(txtEnd.Text, out int end);
            if (start >= end)
            {
                MessageBox.Show("Start must be larger than End", "Loi", MessageBoxButtons.OK);
            }
            else
            {
                var listAccount = _accountRepository.getAll();
                var listAccountSchedule = _accountScheduleRepository.getAll();
                var listSchedule = _scheduleRepository.getAll();


                var listSchedule1 = (from a in listAccount
                                     join aSche in listAccountSchedule on a.Id equals aSche.AccountId
                                     join schedule in listSchedule on aSche.ScheduleId equals schedule.Id
                                     where schedule.TimeStart >= start && schedule.TimeEnd <= end
                                     select new
                                     {
                                         AccountId = a.Id,
                                         Name = a.Fullname,
                                         ScheduleId = schedule.Id,
                                         Start = schedule.TimeStart,
                                         End = schedule.TimeEnd,
                                         Date = schedule.Date,
                                         Status = schedule.Status
                                     });

                dgvSchedule.DataSource = new BindingSource() { DataSource = listSchedule1 };
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void generateList()
        {
            var listAccount = _accountRepository.getAll();
            var listAccountSchedule = _accountScheduleRepository.getAll();
            var listSchedule = _scheduleRepository.getAll();


            var listSchedule1 = (from a in listAccount
                                 join aSche in listAccountSchedule on a.Id equals aSche.AccountId
                                 join schedule in listSchedule on aSche.ScheduleId equals schedule.Id
                                 select new
                                 {
                                     AccountId = a.Id,
                                     Name = a.Fullname,
                                     ScheduleId = schedule.Id,
                                     Start = schedule.TimeStart,
                                     End = schedule.TimeEnd,
                                     Date = schedule.Date,
                                     Status = schedule.Status
                                 }).ToList();



            dgvSchedule.DataSource = new BindingSource() { DataSource = listSchedule1 };
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AdminSchedule schedule = new AdminSchedule();

            int.TryParse(txtIdCRUD.Text, out int id);
            int.TryParse(cbbScheduleId.SelectedValue.ToString(), out int scheduleId);
            AccountSchedule accountSchedule = _accountScheduleRepository.getAll()[dgvSchedule.CurrentRow.Index];
            accountSchedule.AccountId = id;

            _accountScheduleRepository.updateAccountSchedule(accountSchedule, scheduleId);

            generateList();


        }

        private void dgvSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            var listAccount = _accountRepository.getAll();
            var listAccountSchedule = _accountScheduleRepository.getAll();
            var listSchedule = _scheduleRepository.getAll();


            var listSchedule1 = (from a in listAccount
                                 join aSche in listAccountSchedule on a.Id equals aSche.AccountId
                                 join schedule1 in listSchedule on aSche.ScheduleId equals schedule1.Id
                                 select new
                                 {
                                     AccountId = a.Id,
                                     Name = a.Fullname,
                                     ScheduleId = schedule1.Id,
                                     Start = schedule1.TimeStart,
                                     End = schedule1.TimeEnd,
                                     Date = schedule1.Date,
                                     Status = schedule1.Status
                                 }).ToList();
            var schedule = listSchedule1[e.RowIndex];
            var listOfAssignedSchedule = (from schedule2 in listSchedule
                                          join aSche1 in listAccountSchedule on schedule2.Id equals aSche1.ScheduleId
                                          where aSche1.AccountId == schedule.AccountId
                                          select schedule2);
            List<Schedule> listOfNotAssignedSchedule = listSchedule.Except(listOfAssignedSchedule).ToList();
            Schedule selectedSchedule = listOfAssignedSchedule.FirstOrDefault(s => s.Id == schedule.ScheduleId);
            listOfNotAssignedSchedule.Add(selectedSchedule);

            //Add value to combobox
            cbbScheduleId.DataSource = listOfNotAssignedSchedule;
            cbbScheduleId.ValueMember = "Id";
            cbbScheduleId.DisplayMember = "Id";
            cbbScheduleId.Enabled = true;
            int index = cbbScheduleId.FindStringExact(schedule.ScheduleId.ToString());
            cbbScheduleId.SelectedIndex = index;

            //Add value to textbox
            txtIdCRUD.Text = schedule.AccountId.ToString();
            txtName.Text = schedule.Name;
            txtStartCRUD.Text = schedule.Start.ToString();
            txtEndCRUD.Text = schedule.End.ToString();
            txtDateCRUD.Text = schedule.Date.ToString();
            txtStatusCRUD.Text = schedule.Status.ToString();

        }

        private void cbbScheduleId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cbbScheduleId.Text, out int scheduleId);
            //int.TryParse(txtIdCRUD.Text, out int id);
            //string name = txtName.Text;
            if (scheduleId != 0)
            {

                ScheduleRepository _scheduleRepo = new ScheduleRepository();
                var selectedSchedule = _scheduleRepo.getAll().FirstOrDefault(s => s.Id == scheduleId);
                //txtIdCRUD.Text = id.ToString();
                //txtName.Text = name;
                txtStartCRUD.Text = selectedSchedule.TimeStart.ToString();
                txtEndCRUD.Text = selectedSchedule.TimeEnd.ToString();
                txtDateCRUD.Text = selectedSchedule.Date;
                txtStatusCRUD.Text = selectedSchedule.Status.ToString();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdCRUD.Text, out int id);
            int.TryParse(cbbScheduleId.SelectedValue.ToString(), out int scheduleId);
            var aSche = _accountScheduleRepository.getAll().FirstOrDefault(s => s.ScheduleId == scheduleId && s.AccountId == id);
            if (aSche == null)
            {
                MessageBox.Show("Schedule of Account does not exist", "Error", MessageBoxButtons.OK);
            }
            else
            {
                _accountScheduleRepository.delete(aSche);
            }

            generateList();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            int.TryParse(txtIdCRUD.Text, out int id);
            int.TryParse(cbbScheduleId.Text, out int scheduleId);
            var aSche = _accountScheduleRepository.getAll().FirstOrDefault(s => s.ScheduleId == scheduleId && s.AccountId == id);
            if (aSche != null)
            {
                MessageBox.Show("Schedule of Account already existed", "Error", MessageBoxButtons.OK);
            }
            else
            {
                AccountSchedule accountScheduleToBeAdded = new AccountSchedule();
                accountScheduleToBeAdded.AccountId = id;
                accountScheduleToBeAdded.ScheduleId = scheduleId;
                _accountScheduleRepository.create(accountScheduleToBeAdded);
            }
            generateList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            generateList();
        }
    }
}
