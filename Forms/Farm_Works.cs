using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingManagement_FMS.Forms
{
    public partial class Farm_Works : FormBase
    {
      
        public Farm_Works() //eğer bütün farmlar listelenecekse farmNo değeri -1 olur.
        {
            InitializeComponent();
            using (var db = new FarmingManagementSystemEntities())
            {
                var farmNumbers = db.Farms.Select(s => s.Farm_no.ToString()).ToList();
                farmNumbers.Insert(0, "All Farms");
                cmbFarms.DataSource = farmNumbers;
            }
            Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                String farmNum = cmbFarms.Text;

                if (farmNum == "All Farms")
                {
                    var data = (from fa in db.Farms
                                join fw in db.Farm_Work on fa.Farm_no equals fw.Farm_no
                                join fe in db.Farm_work_employee2 on fw.Work_id equals fe.Work_id
                                join em in db.Employees on fe.Emp_id equals em.Emp_id
                                where fa.Status == true
                                select new
                                {
                                    fa.Farm_no,
                                    fa.Farm_name,
                                    fw.Farm_WorkDone,
                                    fw.Work_id,
                                    em.Emp_name,
                                    em.Emp_id,
                                    fw.Work_Date
                                }).ToList();
                    dataGridView1.DataSource = data;
                }
                else
                {
                    int farmNo = Int32.Parse(farmNum);
                    var data = (from fa in db.Farms
                                join fw in db.Farm_Work on fa.Farm_no equals fw.Farm_no
                                join fe in db.Farm_work_employee2 on fw.Work_id equals fe.Work_id
                                join em in db.Employees on fe.Emp_id equals em.Emp_id
                                where fa.Status == true
                                where fa.Farm_no == farmNo
                                select new
                                {
                                    fa.Farm_no,
                                    fa.Farm_name,
                                    fw.Farm_WorkDone,
                                    fw.Work_id,
                                    em.Emp_name,
                                    em.Emp_id,
                                    fw.Work_Date

                                }).ToList();
                    dataGridView1.DataSource = data;
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);

                List<string> farmTask = new List<string>
                {
                 "Feeding","Milking", "Barn Cleaning","Animal Inspection", "Vaccination", "Watering", "Birth Monitoring", "Weighing", "Veterinary Care", "Feed Preparation"
                 };

                comboBox1.DataSource = farmTask;
                comboBox1.SelectedIndex = -1;

                
            }
        }

        private void Farm_Work_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtFarmNo.Text = row.Cells["Farm_no"].Value.ToString();
                txtWorkDate.Text = Convert.ToDateTime(row.Cells["Work_Date"].Value).ToString("yyyy-MM-dd");
                txtEmpID.Text = row.Cells["Emp_id"].Value.ToString();
                comboBox1.Text = row.Cells["Farm_WorkDone"].Value.ToString();
                txtWorkDate.Text = row.Cells["Work_Date"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageEmployee emp = new ManageEmployee();
            emp.Show();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                int farmNo = Int32.Parse(txtFarmNo.Text.Trim());
                String empID = txtEmpID.Text.Trim();
                DateTime workDate = DateTime.ParseExact(txtWorkDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);

                Farm_Work fw = new Farm_Work()
                {
                    Farm_no = farmNo,
                    Farm_WorkDone = comboBox1.Text,
                    Work_Date = workDate
                };
                db.Farm_Work.Add(fw);
                db.SaveChanges();
                int work_id = fw.Work_id;

                Farm_work_employee2 em = new Farm_work_employee2()
                {
                    Work_id = work_id,
                    Emp_id = empID
                };
                db.Farm_work_employee2.Add(em);
                db.SaveChanges();

                
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("All of the textboxes will be cleared. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                Clean();
            }
        }
        private void Clean()
        {
            txtEmpID.Text = "";
            txtFarmNo.Text = "";
            txtWorkDate.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void cmbFarms_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
