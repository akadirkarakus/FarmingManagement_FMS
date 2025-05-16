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
    public partial class Login : FormBase
    {
        public Login()
        {
            InitializeComponent();
        }

        public String userType = "admin";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                string ID = txtID.Text.Trim();
                String pass = HashPassword(txtPass.Text.Trim());

                var user = db.Employees.FirstOrDefault(emp => emp.Emp_id == ID && emp.Password == pass);

                if (user != null)
                {
                    setEmpID(ID);
                    this.DialogResult = DialogResult.OK; // Giriş başarılı
                    this.Close(); // Formu kapat (gizleme!)
                }
                else
                {
                    MessageBox.Show("Invalid user ID or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
