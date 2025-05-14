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
    public partial class AccountManager : FormBase
    {
        public AccountManager()
        {
            InitializeComponent();
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                String id = getEmpID(); 
                var employee = db.Employees.FirstOrDefault(emp => emp.Emp_id == id);

                if (employee != null)
                {
                    txtID.Text = id;
                    txtFname.Text = employee.Emp_name;
                   //txtSname.Text = employee.Second_name;
                   //txtTname.Text = employee.Third_name;
                  //  txtLname.Text = employee.Surname;
                    txtBdate.Text = employee.Birth_date?.ToString("dd.MM.yyyy") ?? "";
                    txtMail.Text = employee.eMail;
                    txtPhone.Text = employee.phoneNumber;
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
