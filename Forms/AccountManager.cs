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

        private String id;
        private Employee employee;
        private void AccountManager_Load(object sender, EventArgs e)
        {
            this.ActiveControl = btnUpdate;

            id = getEmpID();
            using (var db = new FarmingManagementSystemEntities())
            {
                employee = db.Employees.FirstOrDefault(emp => emp.Emp_id == id);

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

        private Boolean Confirm()
        {
            String curPas = HashPassword(txtCurPass.Text);
            using (var db = new FarmingManagementSystemEntities())
            {
                if(employee.Password==curPas) 
                {
                    return true;
                }
                else
                    return false;   
            }
                
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtMail.Text.Trim().Length > 6 && (( txtPhone.Text.Trim().Length > 6)))
            { 
                if(Confirm() == true)
                {
                    using (var db = new FarmingManagementSystemEntities())
                    {
                        //günellenecek çalışanı bulma // yukarda bulduk.
                        //var employee = db.Employees.FirstOrDefault(emp => emp.Emp_id == id);

                        if(employee!= null)
                        {
                            //yeni veri atama
                            employee.eMail = txtMail.Text.Trim();
                            employee.phoneNumber = txtPhone.Text.Trim();

                            //veri tabanına kaydetme.
                            db.SaveChanges();

                            MessageBox.Show("Your information updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                    MessageBox.Show("Current password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Invalid mail address or phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            using(var db = new FarmingManagementSystemEntities())
            {
                if (txtNewPass.Text.Trim().Length >5)
                {
                    if(Confirm() == true)
                    {
                        String newPassword = HashPassword(txtNewPass.Text.Trim());
                        if(employee != null)
                        {
                            employee.Password = newPassword;
                            db.SaveChanges();
                            MessageBox.Show("Your password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        MessageBox.Show("Current password is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Password must be longer than 5 characters.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            if (txtMail.ReadOnly == true)
            {
                DialogResult d = MessageBox.Show("Are you sure to change your E-Mail Address?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    txtMail.ReadOnly = false;
                }
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.ReadOnly == true)
            {
                DialogResult d = MessageBox.Show("Are you sure to change your phone number?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    txtPhone.ReadOnly = false;
                }
            }
        }

        private void txtNewPass_Enter(object sender, EventArgs e)
        {
            if (txtNewPass.ReadOnly == true)
            {
                DialogResult d = MessageBox.Show("Are you sure to change your password Address?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    txtNewPass.ReadOnly = false;
                }
            }
        }
    }
}
