using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            String id;
            using (var db = new FarmingManagementSystemEntities())
            {
                var joinData = (from emp in db.Employees
                                 join space in db.Employee_Workspace
                                 on emp.Emp_id equals space.Emp_id
                                 select new
                                 {
                                     emp.Emp_id,
                                     emp.Emp_name,
                                     emp.Birth_date,
                                     emp.phoneNumber,
                                     emp.eMail,
                                     space.Workspace_1,
                                     space.Workspace_2
                                 }).ToList();
                dataGridView1.DataSource = joinData;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
                

                
            }


            
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["Emp_id"].Value.ToString();
                txtMail.Text = row.Cells["eMail"].Value.ToString();
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
                    }
                }
                    

            }
        }
    }
}
