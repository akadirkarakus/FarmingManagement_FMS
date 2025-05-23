using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmingManagement_FMS.Forms
{
    public partial class VetPanel : FormBase
    {
        public VetPanel()
        {
            InitializeComponent();
        }

        private void VetPanel_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var vet = db.Vets
                .Where(e => e.Status == true)
                .Select(e => new
     {
                        e.Vet_id,
                        e.Vet_name,
                        e.Clinic_name,
                        e.Clinic_Location,
                        e.Status
                    }).ToList();
                dataGridView1.DataSource = vet;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtClinicName.Text = row.Cells["Clinic_Name"].Value.ToString();
                txtID.Text = row.Cells["Vet_id"].Value.ToString();
                txtLocation.Text = row.Cells["Clinic_Location"].Value.ToString();
                txtVetName.Text = row.Cells["Vet_Name"].Value.ToString();
            }
        }
        private void Clean()
        {
            txtClinicName.Text = "";
            txtID.Text = "";
            txtLocation.Text = "";
            txtVetName.Text = "";
        }

        private void btnClean2_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                int vetID;
                try
                {
                     vetID = Int32.Parse(txtID.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid vet ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                var vet = db.Vets.FirstOrDefault(s => s.Vet_id == vetID);
                if (vet == null)
                {
                    Vet v = new Vet()
                    {
                        Vet_id = vetID,
                        Vet_name = txtVetName.Text,
                        Clinic_Location = txtLocation.Text,
                        Clinic_name = txtClinicName.Text,
                        Status = true
                    };
                    db.Vets.Add(v);
                    db.SaveChanges();
                    MessageBox.Show("New seed " + v.Vet_name+ " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else
                    MessageBox.Show("There is a vet has same ID", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                int vetID;
                try
                {
                    vetID = Int32.Parse(txtID.Text);
                }
                catch
                {
                    MessageBox.Show("Vet ID couldn't found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var vet = db.Vets.FirstOrDefault(s => s.Vet_id == vetID);
                if (vet != null)
                {
                    vet.Vet_name = txtVetName.Text;
                    vet.Clinic_name = txtClinicName.Text;
                    vet.Clinic_Location = txtLocation.Text;
                    db.SaveChanges();
                    MessageBox.Show("New seed " + vet.Vet_name + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else
                    MessageBox.Show("The Vet couldn't found with this ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                int vetID;
                try
                {
                     vetID = Int32.Parse(txtID.Text);
                }
                catch
                {
                    MessageBox.Show("Vet ID couldn't found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                var vet = db.Vets.FirstOrDefault(s => s.Vet_id == vetID);
                if (vet != null)
                {
                    vet.Status = false;
                    db.SaveChanges();
                    MessageBox.Show("New seed " + vet.Vet_name + " has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else
                    MessageBox.Show("The Vet couldn't found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }
    }
}
