using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmingManagement_FMS
{
    public partial class Announcement : FormBase
    {
        public Announcement()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String text = richTextBox1.Text.Trim();

            if (text.Length >0)
            {
                if (checkedListBox1.SelectedItem != null)
                {
                    using (var db = new FarmingManagementSystemEntities())
                    {
                        foreach (var item in checkedListBox1.CheckedItems)
                        {
                            string deptName = item.ToString();

                            var employees = (from emp in db.Employee_Workspace
                                             where emp.Workspace_1 == deptName ||
                                             emp.Workspace_2 == deptName
                                             select new
                                             {
                                                 emp.Emp_id
                                             }).ToList();

                            string superID = "10045206007"; //getEmpID();*********************************DELETE**********************
                            Notice newNotice = new Notice()
                            {
                                Supervisor_id = superID,
                                message = text,
                                Workspace = deptName
                            };
                            db.Notices.Add(newNotice);
                        }
                        db.SaveChanges();
                        MessageBox.Show("Notice has been sen to selected departments.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("Any item has not selected for the department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Announcement part is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Announcement_Load(object sender, EventArgs e)
        {

            checkedListBox1.Items.Add("Field");
            checkedListBox1.Items.Add("Farm");
            checkedListBox1.Items.Add("Barn");
            checkedListBox1.Items.Add("Storage");
        }

        private void button1_Click(object sender, EventArgs e)//CLEAR TEXTBOX
        {
            DialogResult d = MessageBox.Show("Announcement text will be deleted from your screen. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                richTextBox1.Text = "";
            }
        }
    }
}
