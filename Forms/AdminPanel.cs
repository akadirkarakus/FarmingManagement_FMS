using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FarmingManagement_FMS.Forms;

namespace FarmingManagement_FMS
{
    public partial class AdminPanel : FormBase
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry; 
            this.Close(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AccountManager a = new AccountManager();
            a.ShowDialog();
        }

        private void btnMngEmp_Click(object sender, EventArgs e)
        {
            ManageEmployee m = new ManageEmployee();
            this.Visible = false;
            m.ShowDialog();
            this.Visible = true;
        }

        private void btnFarminData_Click(object sender, EventArgs e)
        {
            ManageFarmingData f = new ManageFarmingData();
            this.Visible = false;
            f.ShowDialog();
            this.Visible = true;
        }
    }
}
