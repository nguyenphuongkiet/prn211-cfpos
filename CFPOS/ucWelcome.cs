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
    public partial class ucWelcome : UserControl
    {
        private static ucWelcome _instance;
        public static ucWelcome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucWelcome();
                return _instance;
            }
        }

        public ucWelcome()
        {
            InitializeComponent();
        }
    }
}
