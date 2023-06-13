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
        public EmployeeSchedule()
        {
            InitializeComponent();
        }
        
    }
}
