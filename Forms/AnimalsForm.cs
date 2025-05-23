using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingManagement_FMS.Forms
{
    public partial class AnimalsForm : FormBase
    {
        private int farmNo;
        public AnimalsForm(int farmNo)
        {
            this.farmNo = farmNo;
            InitializeComponent();
            using (var db = new FarmingManagementSystemEntities())
            {
                var farmNumbers = db.Farms.Select(s => s.Farm_no.ToString()).ToList();
                farmNumbers.Insert(0, "All Farms");
                cmbFarmNo.DataSource = farmNumbers;
                if (farmNo == -1)
                {
                    cmbFarmNo.SelectedIndex = 0;
                }
                else
                    cmbFarmNo.Text = farmNo.ToString();
            }
        }

        private void Reload()
        {

            using (var db = new FarmingManagementSystemEntities())
            {
                String farmNum = cmbFarmNo.Text;

                if (cmbFarmNo.Text == "All Farms")
                {
                    var animal = (from a in db.Animals
                                  join ex in db.Examinations on a.Animal_id equals ex.Animal_id into exGroup
                                  from ex in exGroup.DefaultIfEmpty()
                                  join ve in db.Vets on ex.Vet_id equals ve.Vet_id into veGroup
                                  from ve in veGroup.DefaultIfEmpty()
                                  where a.Status == true
                                  select new
                                  {
                                      a.Farm_No,
                                      a.Animal_id,
                                      a.Species,
                                      a.Birth_date,
                                      Age = SqlFunctions.DateDiff("year", a.Birth_date, DateTime.Now),
                                      Visit_date = ex.Visit_date,
                                      Visit_reason = ex.Visit_reason,
                                      Treatment_given = ex.Treatment_given,
                                      Vet_name = ve.Vet_name,
                                      Vet_id = (int?)ve.Vet_id,
                                      Clinic_name = ve.Clinic_name
                                  }).ToList();
                    dataGridView1.DataSource = animal;
                    
                }
                else
                {
                    int fNo = Int32.Parse(cmbFarmNo.Text);
                    var animal = (from a in db.Animals
                                  join ex in db.Examinations on a.Animal_id equals ex.Animal_id into exGroup
                                  from ex in exGroup.DefaultIfEmpty()
                                  join ve in db.Vets on ex.Vet_id equals ve.Vet_id into veGroup
                                  from ve in veGroup.DefaultIfEmpty()
                                  where a.Farm_No == fNo
                                  where a.Status == true
                                  select new
                                  {
                                      //a.Farm_No,
                                      a.Animal_id,
                                      a.Species,
                                      a.Birth_date,
                                      Age = SqlFunctions.DateDiff("year", a.Birth_date, DateTime.Now),
                                      Visit_date = ex.Visit_date,
                                      Visit_reason = ex.Visit_reason,
                                      Treatment_given = ex.Treatment_given,
                                      Vet_name = ve.Vet_name,
                                      Vet_id = (int?)ve.Vet_id,
                                      Clinic_name = ve.Clinic_name
                                  }).ToList();
                    dataGridView1.DataSource = animal;
                }
                if (dataGridView1.Columns.Contains("Farm_No"))
                {
                    dataGridView1.Columns["Farm_No"].HeaderText = "Farm No";
                    dataGridView1.Columns["Farm_No"].DisplayIndex = 0;
                }
                dataGridView1.Columns["Animal_id"].HeaderText = "Animal ID";
                dataGridView1.Columns["Species"].HeaderText = "Species";
                dataGridView1.Columns["Birth_date"].HeaderText = "Birth Date";
                dataGridView1.Columns["Visit_date"].HeaderText = "Last Visit Date";
                dataGridView1.Columns["Visit_reason"].HeaderText = "Last Visit Reason";
                dataGridView1.Columns["Treatment_given"].HeaderText = "Treatment";
                dataGridView1.Columns["Vet_name"].HeaderText = "Vet Name";
                dataGridView1.Columns["Clinic_name"].HeaderText = "Clinic Name";

            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);

            //combobox
            String[] species = new string[]
            {
                "Cow","Calf","Sheep","Goat","Chicken"
            };
            cmbSpecies.Items.AddRange(species);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["Animal_id"].Value.ToString();
                if (dataGridView1.Columns.Contains("Farm_No"))
                {
                    txtFarmNo.Text = row.Cells["Farm_No"].Value.ToString();
                }
                else
                    txtFarmNo.Text = cmbFarmNo.Text;

                    cmbSpecies.Text = row.Cells["Species"].Value.ToString();
                txtBdate.Text = Convert.ToDateTime(row.Cells["Birth_date"].Value).ToString("yyyy.MM.dd");

                var visitDate = row.Cells["Visit_date"].Value;
                txtVisitDate.Text = visitDate != null ? Convert.ToDateTime(visitDate).ToString("yyyy.MM.dd") : "no data";
                txtVisitReason.Text = row.Cells["Visit_reason"].Value?.ToString() ?? "no data";
                txtTreatment.Text = row.Cells["Treatment_given"].Value?.ToString() ?? "no data";
                txtVetID.Text = row.Cells["Vet_id"].Value?.ToString() ?? "no data";

            }
        }
        private void AnimalsForm_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void button2_Click(object sender, EventArgs e)//display vets
        {
            VetPanel vet = new VetPanel();
            vet.Show();
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

        private void btnClean2_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtFarmNo.Text = "";
            cmbSpecies.SelectedIndex = -1;
            txtBdate.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                int farmNo;


                DateTime bDate = DateTime.ParseExact(txtBdate.Text.Trim(), "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                farmNo = Int32.Parse(txtFarmNo.Text);
                Animal a = new Animal()
                {
                    Farm_No = farmNo,
                    Species = cmbSpecies.Text,
                    Birth_date = bDate,
                    Status = true
                };
                db.Animals.Add(a);
                db.SaveChanges();
                MessageBox.Show("New animal has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int anID;
            int farmNo;
            try
            {
                anID = Int32.Parse(txtID.Text);
            }
            catch
            {
                MessageBox.Show("Invalid animal ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new FarmingManagementSystemEntities())
            {
                try
                {
                    var animal = db.Animals.FirstOrDefault(s => s.Animal_id == anID);
                    if (animal != null)
                    {
                        DateTime bDate = DateTime.ParseExact(txtBdate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        farmNo = Int32.Parse(txtFarmNo.Text);

                        animal.Farm_No = farmNo;
                        animal.Species = cmbSpecies.Text;
                        animal.Birth_date = bDate;

                        db.SaveChanges();
                        MessageBox.Show("The animal has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else
                        MessageBox.Show("The animal with the entered ID couldn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("An error occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void cmbFarmNo_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to delete the selected land?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                int anID;
                try
                {
                    anID = Int32.Parse(txtID.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid animal ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new FarmingManagementSystemEntities())
                {
                    try
                    {
                        var animal = db.Animals.FirstOrDefault(s => s.Animal_id == anID);
                        if (animal != null)
                        {
                            animal.Status = false;
                            db.SaveChanges();
                            MessageBox.Show("The animal has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reload();
                        }
                        else
                            MessageBox.Show("The animal with the entered ID couldn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show("An error occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            int anID;

            try
            {
                anID = Int32.Parse(txtID.Text);
            }
            catch
            {
                MessageBox.Show("Invalid animal ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new FarmingManagementSystemEntities())
            {
                try
                {
                    int vetID;
                    var ex = db.Examinations.FirstOrDefault(s => s.Animal_id == anID);
                    if (e != null)
                    {
                        DateTime visitDate = DateTime.ParseExact(txtVisitDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                        farmNo = Int32.Parse(txtFarmNo.Text);

                        try
                        {
                            vetID = Int32.Parse(txtVetID.Text.Trim());
                            var vet = db.Vets.FirstOrDefault(s => s.Vet_id == vetID);
                            if (vet == null)
                            {
                                MessageBox.Show("Invalid vet ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Invalid vet ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        ex.Animal_id = anID;
                        ex.Visit_reason = txtVisitReason.Text.Trim();
                        ex.Visit_date = visitDate;
                        ex.Treatment_given = txtTreatment.Text.Trim();
                        ex.Vet_id = vetID;

                        db.SaveChanges();
                        MessageBox.Show("The animal has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else
                        MessageBox.Show("The animal with the entered ID couldn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("An error occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtVisitDate.Text = "";
            txtVisitReason.Text = "";
            txtTreatment.Text = "";
            txtID.Text = "";
        }
    }
}
