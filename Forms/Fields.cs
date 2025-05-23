using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingManagement_FMS.Forms
{
    public partial class Fields : Form
    {
        public Fields()
        {
            InitializeComponent();
        }

        private void Fields_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {

                // Field > Field_Works(work_id) > Seed_genus(work_id) > Seed

                var field = (from fi in db.Fields
                             join lan in db.Lands on fi.Land_no equals lan.Land_no
                             where fi.Status == status
                             select new
                             {
                                 fi.Field_no,
                                 fi.Name,
                                 fi.Field_acreage,
                                 fi.Planting_date,
                                 lan.Land_City,
                                 fi.Land_no,
                                 lan.Land_name,
                                 fi.Status
                             }).ToList();
                /*
                var field = (from ln in db.Fields
                             join land in db.Lands on ln.Land_no equals land.Land_no
                             join fw in db.Field_works on ln.Field_no equals fw.Field_no
                             join fs in db.Field_work_seeds3 on fw.Work_id equals fs.Work_id
                             join se in db.Seeds on fs.Seed_genus equals se.Seed_genus
                             join st in db.Seed_Treatment on se.Seed_genus equals st.Seed_genus
                             join emp in db.Field_work_employees2 on fw.Work_id equals emp.Work_id
                             select new
                             {
                                 ln.Field_no,
                                 ln.Name,
                                 ln.Field_acreage,
                                 land.Land_City,
                                 ln.Land_no,
                                 land.Land_name,
                                 ln.Planting_date,
                                 fw.Field_WorkDone,
                                 fw.Work_id,
                                 se.Seed_genus,
                                 se.Seed_date,
                                 se.Cultivation_time,
                                 emp.Emp_id

                             }).ToList();

                */

                dataGridView1.DataSource = field;

                //VERİ DOLDURMA: Field, Feild_Works. Seed'de kaldım. Yukarda join edilen bütün entityler doldurulacak.

                dataGridView1.Columns["Field_No"].HeaderText = "Field No";
                dataGridView1.Columns["Name"].HeaderText = "Field Name";
                dataGridView1.Columns["Land_City"].HeaderText = "City";
                dataGridView1.Columns["Field_acreage"].HeaderText = "Field Acreage";
                dataGridView1.Columns["Land_no"].HeaderText = "Land No";
                dataGridView1.Columns["Land_name"].HeaderText = "Land Name";
                dataGridView1.Columns["Planting_date"].HeaderText = "Planting Date";
                /*
                dataGridView1.Columns["Field_WorkDone"].HeaderText = "Work Done";
                dataGridView1.Columns["Work_id"].HeaderText = "Work ID";
                dataGridView1.Columns["Seed_genus"].HeaderText = "Seed Genus";
                dataGridView1.Columns["Seed_date"].HeaderText = "Seed Date";
                dataGridView1.Columns["Cultivation_time"].HeaderText = "Cultivation Time";
                dataGridView1.Columns["Emp_id"].HeaderText = "Employee work done by";
                */
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(AttributeControl())
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    var field = db.Fields.FirstOrDefault(f => f.Name == txtName.Text.Trim());
                    if(field == null)
                    {
                        DateTime plantDate = DateTime.ParseExact(txtPlantDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        Field nf = new Field()
                        {
                            
                            Field_acreage = Int32.Parse(txtAcreage.Text.Trim()),
                            Name = txtName.Text.Trim(),
                            Land_no = Int32.Parse(txtLandNo.Text.Trim()),
                            Planting_date =  plantDate,
                            Status = true
                        };
                        db.Fields.Add(nf);
                        MessageBox.Show("New Field " + Name + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        if (field.Status == true)
                        {
                            MessageBox.Show("There is already a land which has the same name and the status is true.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            field.Status = true;
                            MessageBox.Show("Old Field " + Name + " has been added again successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    db.SaveChanges();
                    Reload();
                }
            }
        }
        private bool AttributeControl()
        {
            if (txtName.Text.Trim().Length < 3)
            {
                MessageBox.Show("The field name can not be null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtAcreage.Text.Trim().Length < 2)
            {
                MessageBox.Show("Acreage of a field can not be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtLandNo.Text.Trim().Length < 2)
            {
                MessageBox.Show("The land that field located in can not be null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                return true;
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(AttributeControl())
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    DateTime plantDate = DateTime.ParseExact(txtPlantDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                    int no = Int32.Parse(txtFieldNo.Text.Trim());
                    var field = db.Fields.FirstOrDefault(f => f.Field_no == no);
                    if(field != null)
                    {
                        double ac = Double.Parse(txtAcreage.Text.Trim());
                        int landno = Int32.Parse(txtLandNo.Text.Trim());
                        field.Field_acreage = ac;
                        field.Name = txtName.Text.Trim();
                        field.Land_no = landno;
                        field.Planting_date = plantDate;

                        db.SaveChanges();
                        MessageBox.Show("The field " + field.Name + " has been updated successfully.", "Field Has Been Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else
                        MessageBox.Show("A field with the entered field no could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to delete the selected land?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    int no;
                    try
                    {
                        no = Int32.Parse(txtFieldNo.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("The field colundn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var fields = db.Fields.FirstOrDefault(lan => lan.Field_no == no);
                    if (fields != null)
                    {
                        if (fields.Status == true)
                        {
                            fields.Status = false;
                            db.SaveChanges();
                            MessageBox.Show("The field " + fields.Name + " has been deleted. You can see the information of deleted lands by changing the chechbox.", "Field Has Been Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reload();
                        }
                        else
                            MessageBox.Show("The field has been alreade deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("The field colundn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            txtName.Text = "";
            txtAcreage.Text = "";
            txtLandNo.Text = "";
            txtPlantDate.Text = "";
        }

   //     private bool fieldStatus;

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the location of the land that the field is located. Location of an land can be changed by manage land interface.","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private Boolean status = true;
        private void chkPersonnelStatus_CheckedChanged_1(object sender, EventArgs e)
        {
            if (status)
            {
                status = false;
                chkPersonnelStatus.Text = "Displaying inactive fields only.";
                chkPersonnelStatus.ForeColor = Color.LightCoral;
                Reload();
            }

            else
            {
                status = true;
                chkPersonnelStatus.Text = "Displaying active fields only.";
                chkPersonnelStatus.ForeColor = Color.LightSkyBlue;
                Reload();
            }
        }

        private void button1_Click(object sender, EventArgs e) //refresh
        {
            Reload();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                string rowNumber = (e.RowIndex + 1).ToString();
                e.Graphics.DrawString(
                    rowNumber,
                    dataGridView1.Font,
                    b,
                    e.RowBounds.Location.X + 15,
                    e.RowBounds.Location.Y + 4
                );
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            Field_Work fw = new Field_Work();
            fw.allValue = true;
            fw.Show();
        }

        private void btnSeed_Click(object sender, EventArgs e)
        {
            SeedInfo sı = new SeedInfo();
            sı.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtFieldNo.Text = row.Cells["Field_no"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtLandNo.Text = row.Cells["Land_No"].Value.ToString();
                txtAcreage.Text = row.Cells["Field_Acreage"].Value.ToString();
                txtPlantDate.Text = Convert.ToDateTime(row.Cells["Planting_Date"].Value).ToString("yyyy.MM.dd");
            }
        }

        public static int fieldNo;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (status == true)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    fieldNo = Int32.Parse(row.Cells["Field_no"].Value.ToString());
                    Field_Work fw = new Field_Work();
                    fw.allValue = false;
                    fw.Show();
                }
            }
            else
                MessageBox.Show("Work cannot be applied to deleted fields.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
