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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFPOS
{
    public partial class AdminSchedule : UserControl
    {

        private static AdminSchedule instance;
        public static AdminSchedule Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AdminSchedule();
                }
                return instance;
            }

        }

        ScheduleRepository _scheduleRepo;
        public AdminSchedule()
        {
            InitializeComponent();
            _scheduleRepo = new ScheduleRepository();
            List<string> listDay = new List<string>();
            listDay.Add("Monday");
            listDay.Add("Tuesday");
            listDay.Add("Wednesday");
            listDay.Add("Thursday");
            listDay.Add("Friday");
            listDay.Add("Saturday");
            listDay.Add("Sunday");
            cbbDate.DataSource = listDay;
            cbbStatus.Items.Add("true");
            cbbStatus.Items.Add("false");
            btnUpdate.Enabled = false;
            generateList();
        }

        private void generateList()
        {
            var list = _scheduleRepo.getAll();
            dgvSchedule.DataSource = new BindingSource() { DataSource = list };


        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvSchedule_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var schedule = _scheduleRepo.getAll()[e.RowIndex];
            if (schedule != null)
            {
                txtTimeStart.Text = schedule.TimeStart.ToString();
                txtTimeEnd.Text = schedule.TimeEnd.ToString();
                int dateIndex = cbbDate.FindStringExact(schedule.Date);
                cbbDate.SelectedIndex = dateIndex;
                if (schedule.Status.Value)
                {
                    int index = cbbStatus.FindStringExact("true");
                    cbbStatus.SelectedIndex = index;
                }
                else
                {
                    int index = cbbStatus.FindStringExact("false");
                    cbbStatus.SelectedIndex = index;
                }
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;

            }
            else
            {
                MessageBox.Show("Da co loi xay ra", "Loi", MessageBoxButtons.OK);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string timeStartText = txtTimeStart.Text;
            string timeEndText = txtTimeEnd.Text;
            string date = cbbDate.Text;
            string status = cbbStatus.Text;
            if (int.TryParse(timeStartText, out int timeStart) && int.TryParse(timeEndText, out int timeEnd))
            {
                Schedule schedule = new Schedule();
                schedule.TimeStart = timeStart;
                schedule.TimeEnd = timeEnd;
                schedule.Date = date;
                if (status == "true")
                {
                    schedule.Status = true;
                }
                else if (status == "false")
                {
                    schedule.Status = false;
                }

                ScheduleValidator validator = new ScheduleValidator();
                ValidationResult results = validator.Validate(schedule);

                if (results.IsValid == false)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        MessageBox.Show($"{failure.ErrorMessage}", "Add failed", MessageBoxButtons.OK);
                        break;
                    }
                }
                else
                {
                    _scheduleRepo.create(schedule);
                    generateList();
                    MessageBox.Show("Add successfully", "Notification", MessageBoxButtons.OK);
                    txtTimeStart.Text = "";
                    txtTimeEnd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Time Start and Time End must be Integer");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string timeStartText = txtTimeStart.Text;
            string timeEndText = txtTimeEnd.Text;
            string date = cbbDate.Text;
            string status = cbbStatus.Text;
            if (int.TryParse(timeStartText, out int timeStart) && int.TryParse(timeEndText, out int timeEnd))
            {
                Schedule schedule = _scheduleRepo.getAll()[dgvSchedule.CurrentRow.Index];
                schedule.TimeStart = timeStart;
                schedule.TimeEnd = timeEnd;
                schedule.Date = date;
                if (status == "true")
                {
                    schedule.Status = true;
                }
                else if (status == "false")
                {
                    schedule.Status = false;
                }

                ScheduleValidator validator = new ScheduleValidator();
                ValidationResult results = validator.Validate(schedule);

                if (results.IsValid == false)
                {
                    foreach (ValidationFailure failure in results.Errors)
                    {
                        MessageBox.Show($"{failure.ErrorMessage}", "Update failed", MessageBoxButtons.OK);
                        break;
                    }
                }
                else
                {
                    _scheduleRepo.update(schedule);
                    generateList();
                    MessageBox.Show("Update successfully", "Notification", MessageBoxButtons.OK);
                    txtTimeStart.Text = "";
                    txtTimeEnd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Time Start and Time End must be Integer");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchDate = txtSearch.Text;
            var result = _scheduleRepo.getAll().Where(s => s.Date.Contains(searchDate, StringComparison.OrdinalIgnoreCase));
            if (!result.Any())
            {
                MessageBox.Show("Khong co ket qua tim kiem nao");
            }
            dgvSchedule.DataSource = new BindingSource() { DataSource = result };   
        }
    }
}
