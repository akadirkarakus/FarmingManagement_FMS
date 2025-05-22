using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FarmingManagement_FMS.Forms
{
    public partial class SeedInfo : FormBase
    {
        public SeedInfo()
        {
            InitializeComponent();
        }

        private void SeedInfo_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var seed = db.Seeds.Select(s => new
                {
                    s.Seed_genus,
                    s.Seed_date,
                    s.Cultivation_time
                }).ToList();
                dataGridView1.DataSource = seed;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
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
            txtCultivation.Text = "";
            txtGenus.Text = "";
            txtTime.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var seed = db.Seeds.FirstOrDefault(s => s.Seed_genus == txtGenus.Text.Trim());

                if (seed == null)
                {
                    Seed ns = new Seed()
                    {
                        Seed_genus = txtGenus.Text.Trim(),
                        Seed_date = txtTime.Text.Trim(),
                        Cultivation_time = Int32.Parse(txtCultivation.Text.Trim())
                    };
                    db.Seeds.Add(ns);
                    db.SaveChanges();
                    MessageBox.Show("New seed " + ns.Seed_genus + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else
                    MessageBox.Show("There is a seed which has the same genus name on the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var seed = db.Seeds.FirstOrDefault(s => s.Seed_genus == txtGenus.Text.Trim());
                if (seed != null)
                {
                    seed.Seed_date = txtTime.Text.Trim();
                    seed.Cultivation_time = Int32.Parse(txtCultivation.Text.Trim());
                    db.SaveChanges();
                    MessageBox.Show("Seed " + seed.Seed_genus + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else
                    MessageBox.Show("The seed coldn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var seed = db.Seeds.Find(txtGenus.Text.Trim());
                if (seed != null)
                {
                    db.Seeds.Remove(seed);
                    db.SaveChanges();
                    MessageBox.Show("Seed " + seed.Seed_genus + " has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else
                    MessageBox.Show("The seed coldn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtGenus.Text = row.Cells["Seed_Genus"].Value.ToString();
                txtTime.Text = row.Cells["Seed_Date"].Value.ToString();
                txtCultivation.Text = row.Cells["Cultivation_time"].Value.ToString();

            }
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
    }
}
