using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
