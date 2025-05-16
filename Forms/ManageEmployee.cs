using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingManagement_FMS.Forms
{
    public partial class ManageEmployee : FormBase
    {
        public ManageEmployee()
        {
            InitializeComponent();
        }

        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            string rowNumber = (e.RowIndex + 1).ToString(); // 1'den başlasın

            using (var brush = new SolidBrush(grid.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    rowNumber,
                    grid.DefaultCellStyle.Font,
                    brush,
                    e.RowBounds.Location.X + 15,
                    e.RowBounds.Location.Y + 4
                );
            }
        }

        private void Reload()//Reload datagridview
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                if(empStatus)
                {
                    var joinData = (from emp in db.Employees
                                    join space in db.Employee_Workspace
                                    on emp.Emp_id equals space.Emp_id
                                    where emp.Status == true
                                    select new
                                    {
                                        emp.Emp_id,
                                        emp.Emp_name,
                                        emp.Birth_date,
                                        emp.phoneNumber,
                                        emp.eMail,
                                        emp.Status,
                                        space.Workspace_1,
                                        space.Workspace_2
                                    }).ToList();
                    dataGridView1.DataSource = joinData;
                }
                else
                {
                    var joinData = (from emp in db.Employees
                                    join space in db.Employee_Workspace
                                    on emp.Emp_id equals space.Emp_id
                                    where emp.Status == false
                                    select new
                                    {
                                        emp.Emp_id,
                                        emp.Emp_name,
                                        emp.Birth_date,
                                        emp.phoneNumber,
                                        emp.eMail,
                                        emp.Status,
                                        space.Workspace_1,
                                        space.Workspace_2
                                    }).ToList();
                    dataGridView1.DataSource = joinData;
                }

                   
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ReadOnly = true;
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["Emp_id"].Value.ToString();
                txtMail.Text = row.Cells["eMail"].Value.ToString();
                txtBdate.Text = Convert.ToDateTime(row.Cells["Birth_date"].Value).ToString("yyyy.MM.dd");
                txtPhone.Text = row.Cells["phoneNumber"].Value.ToString();
                txtFwork.Text = row.Cells["Workspace_1"].Value.ToString();
                txtSwork.Text = row.Cells["Workspace_2"].Value?.ToString() ?? "null";

                String id = txtID.Text;
                using (var db = new FarmingManagementSystemEntities())
                {
                    var employee = db.Employees.FirstOrDefault(emp => emp.Emp_id == id);
                    if (employee != null)
                    {
                        txtFname.Text = employee.First_name;
                        txtSname.Text = employee.Second_name;
                        txtTname.Text = employee.Third_name;
                        txtLname.Text = employee.Surname;
                        emp_name = employee.Emp_name;
                    }
                    else
                        MessageBox.Show("Employee couldn't found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(AttributeControl())
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    String id = txtID.Text.Trim();
                    var employee = db.Employees.FirstOrDefault(emp => emp.Emp_id == id);
                    if(employee == null)
                    {
                        bDate = DateTime.ParseExact(txtBdate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        Employee newEmp = new Employee()
                        {
                            Emp_id = id,
                            First_name = txtFname.Text.Trim(),
                            Second_name = txtSname.Text.Trim(),
                            Third_name = txtTname.Text.Trim(),
                            Surname = txtLname.Text.Trim(),
                            eMail = txtMail.Text.Trim(),
                            Status = true,
                            Birth_date = bDate,
                            phoneNumber = txtPhone.Text.Trim(),
                            Password = PasswordGenerate(txtLname.Text.Trim(),id)
                        };

                        Employee_Workspace ws = new Employee_Workspace
                        {
                            Emp_id = id,
                            Workspace_1 = txtFwork.Text.Trim(),
                            Workspace_2 = string.IsNullOrWhiteSpace(txtSwork.Text) ? null : txtSwork.Text.Trim()
                        };

                        db.Employees.Add(newEmp);
                        db.Employee_Workspace.Add(ws);
                        db.SaveChanges();

                        MessageBox.Show("New employee " + newEmp.Emp_name + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        employee.Status = true;
                        db.SaveChanges();
                        MessageBox.Show("Old employee " + employee.Emp_name + " has been added again successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Reload();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(AttributeControl())
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    bDate = DateTime.ParseExact(txtBdate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    String id = txtID.Text.Trim();
                    var employee = db.Employees.FirstOrDefault(emp => emp.Emp_id.Equals(id));
                    var workspace = db.Employee_Workspace.FirstOrDefault(ws => ws.Emp_id.Equals(id));

                    if(employee != null)
                    {
                        if(employee.Status == true)
                        {
                            employee.First_name = txtFname.Text.Trim();
                            employee.Second_name = txtSname.Text.Trim();
                            employee.Third_name = txtTname.Text.Trim();
                            employee.Surname = txtLname.Text.Trim();
                            employee.Birth_date = bDate;
                            employee.eMail = txtMail.Text.Trim();
                            employee.phoneNumber = txtPhone.Text.Trim();
                            workspace.Workspace_1 = txtFwork.Text.Trim();
                            workspace.Workspace_2 = txtSwork.Text.Trim();
                            db.SaveChanges();
                            MessageBox.Show("All of the changed information about the employee " + employee.Emp_name + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reload();
                            CleanTxt();
                        }
                        else
                            MessageBox.Show("Information of older employees cannot be changed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("No employee was found with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private DateTime? bDate;
        private bool AttributeControl()
        {
            if (txtID.Text.Trim().Length != 11)
            {
                MessageBox.Show("ID must be consist of 11 character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtFname.Text.Trim().Length < 3)
            {
                MessageBox.Show("The first name can not be shorter than 3 characters.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtLname.Text.Trim().Length < 2)
            {
                MessageBox.Show("Last name can not be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtFwork.Text.Trim().Length < 2)
            {
                MessageBox.Show("First Workspace can not be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //Birthdate
            if (string.IsNullOrEmpty(txtBdate.Text))
            {
                bDate = null;
                return true;
            }
            if(!DateTime.TryParseExact(txtBdate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
            {
                MessageBox.Show("Please enter a valid birth date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.ReadOnly == true)
            {
                DialogResult d = MessageBox.Show("Change ID just for adding a new employee otherwise you may get an error. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    txtID.ReadOnly = false;
                }
            }
        }
        
        private String PasswordGenerate(String surname, string id)
        {
            String pass = string.Concat(surname, id);
            return HashPassword(pass);
        }
        private void CleanTxt()
        {
            txtID.Text = "";
            txtFname.Text = "";
            txtSname.Text = "";
            txtTname.Text = "";
            txtLname.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            txtFwork.Text = "";
            txtSwork.Text = "";
            txtBdate.Text = "";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            
                DialogResult d = MessageBox.Show("All of the textboxes will be cleared. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    CleanTxt();
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private Boolean bdateBoolean = true;
        private void txtBdate_Enter(object sender, EventArgs e)
        {
            if(bdateBoolean)
            {
                txtBdate.Text = "";
                bdateBoolean = false;
            }
                
            
        }
        private String emp_name;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to delete the employee "+emp_name+"?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(d == DialogResult.Yes)
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    String id = txtID.Text.Trim();

                    var employee = db.Employees.FirstOrDefault(emp => emp.Emp_id == id);
         
                    if (employee != null)
                    {
                        if(employee.Status == true)
                        {
                            employee.Status = false;
                            db.SaveChanges();
                            MessageBox.Show("The employee " + employee.Emp_name + " has been deleted. You can see the information of deleted employee through changing the chechbox.", "Employee Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reload();
                        }
                        else
                            MessageBox.Show("A deleted employee can not deleted again. You can use add button to add an employee deleted employee.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }    
            }
        }
        private bool empStatus = true;
        private void chkPersonnelStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (empStatus)
            {
                empStatus = false;
                lblPersonStatus.Text = "Former Employees";
                lblPersonStatus.ForeColor = Color.Red;
                chkPersonnelStatus.Text = "Displaying inactive employees only.";
                Reload();
            }

            else
            {
                empStatus = true;
                lblPersonStatus.Text = "Active Employees";
                lblPersonStatus.ForeColor = Color.Lime;
                chkPersonnelStatus.Text = "Displaying active employees only.";
                Reload();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("The first password of an employee is assigned by the system automatically which is assigned as the surname and the id of the employee coterminously. Then, it can be changed by related person.", "Passwrod Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAnnounce_Click(object sender, EventArgs e)
        {
            Announcement a = new Announcement();
            a.Show();
        }
    }
}
