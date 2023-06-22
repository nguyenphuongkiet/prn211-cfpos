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
    }
}
