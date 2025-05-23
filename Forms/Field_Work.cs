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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace FarmingManagement_FMS.Forms
{
    public partial class Field_Work : FormBase
    {
        public Field_Work()
        {
            InitializeComponent();
        }

        public  Boolean allValue;
        private void Field_Work_Load(object sender, EventArgs e)
        {
            Reload();
            List<string> fieldOperations = new List<string>
            {"Plowing", "Sowing","Fertilizing", "Irrigation","Hoeing","Spraying","Harvesting","Weed Control","Soil Testing","Seed Selection"};

            comboBox1.Items.AddRange(fieldOperations.ToArray());
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                if (allValue == false)
                {
                    int fno = Fields.fieldNo;
                    var data = (from fi in db.Fields
                                join fw in db.Field_works on fi.Field_no equals fw.Field_no
                                join emp in db.Field_work_employees2 on fw.Work_id equals emp.Work_id
                                join se in db.Field_work_seeds3 on fw.Work_id equals se.Work_id
                                where fi.Field_no == fno
                                where fi.Status == true
                                select new
                                {
                                    fi.Field_no,
                                    fi.Name,
                                    fi.Planting_date,
                                    fw.Work_id,
                                    fw.Field_WorkDone,
                                    fw.Work_Date,
                                    se.Seed_genus,
                                    emp.Emp_id
                                }).ToList();
                    dataGridView1.DataSource = data;
                    lblFieldName.Text = "Field: " + fno.ToString();
                }
                else
                {
                    int fno = Fields.fieldNo;
                    var data = (from fi in db.Fields
                                join fw in db.Field_works on fi.Field_no equals fw.Field_no
                                join emp in db.Field_work_employees2 on fw.Work_id equals emp.Work_id
                                join se in db.Field_work_seeds3 on fw.Work_id equals se.Work_id
                                where fi.Status == true
                                select new
                                {
                                    fi.Field_no,
                                    fi.Name,
                                    fi.Planting_date,
                                    fw.Work_id,
                                    fw.Field_WorkDone,
                                    fw.Work_Date,
                                    se.Seed_genus,
                                    emp.Emp_id
                                }).ToList();
                    dataGridView1.DataSource = data;
                    lblFieldName.Visible = false;
                }
                var seedList = db.Seeds.Select(s => s.Seed_genus).ToList();
                cmbSeed.DataSource = seedList;

            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);


        }

        private void btnDisplaySeed_Click(object sender, EventArgs e)
        {
            SeedInfo sı = new SeedInfo(); 
            sı.Show();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    int fieldNo = Int32.Parse(txtFieldNo.Text.Trim());
                    String empID = txtEmpID.Text.Trim();
                    DateTime workDate = DateTime.ParseExact(txtWorkDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);


                    Field_works few = new Field_works()
                    {
                        Field_no = fieldNo,
                        Field_WorkDone = comboBox1.Text,
                        Work_Date = workDate
                    };

                    db.Field_works.Add(few);
                    db.SaveChanges();
                    int workID = few.Work_id;

                    Field_work_seeds3 fws = new Field_work_seeds3()
                    {
                        Work_id = workID,
                        Seed_genus = cmbSeed.Text.Trim()
                    };
                    db.Field_work_seeds3.Add(fws);
                    db.SaveChanges();

                    try
                    {
                        Field_work_employees2 fwe = new Field_work_employees2()
                        {
                            Work_id = workID,
                            Emp_id = txtEmpID.Text.Trim()
                        };
                        db.Field_work_employees2.Add(fwe);
                        db.SaveChanges();
                    }
                    catch 
                    {
                        MessageBox.Show("Employee colundn't found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }


                    if (comboBox1.Text.Equals("Sowing"))
                    {
                        var plant = db.Fields.FirstOrDefault(s => s.Field_no == fieldNo);
                        if(plant != null)
                        {
                            plant.Planting_date = workDate;
                            db.SaveChanges();
                        }
                    }

                    MessageBox.Show("New work applied successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
            }
            catch
            {
                MessageBox.Show("Error occured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtFieldNo.Text = row.Cells["Field_no"].Value.ToString();
                txtWorkDate.Text = DateTime.Parse(row.Cells["Work_Date"].Value.ToString()).ToString("yyyy.MM.dd");
                txtEmpID.Text = row.Cells["Emp_id"].Value.ToString();
                comboBox1.Text = row.Cells["Field_WorkDone"].Value.ToString();
                cmbSeed.Text = row.Cells["Seed_Genus"].Value.ToString();
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("All of the textboxes will be cleared. Do you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                CleanTxt();
            }
        }
        private void CleanTxt()
        {
            txtFieldNo.Text = "";
            cmbSeed.SelectedIndex = -1;
            txtWorkDate.Text = "";
            txtEmpID.Text = "";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
