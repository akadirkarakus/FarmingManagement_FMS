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
    public partial class StorageForm : FormBase
    {
        public StorageForm()
        {
            InitializeComponent();
        }

        private bool status;
        private void StorageForm_Load(object sender, EventArgs e)
        {
            status = true;
            Reload();
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var storage = (from s in db.Storages
                               join l in db.Lands on s.Land_no equals l.Land_no
                               where s.Status == status
                               select new
                               {
                                   s.Storage_no,
                                   s.Storage_Name,
                                   s.Storage_acreage,
                                   l.Land_no,
                                   l.Land_City
                               }).ToList();
                dataGridView1.DataSource = storage;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void chkPersonnelStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (status)
            {
                status = false;
                chkPersonnelStatus.Text = "Displaying inactive farms only.";
                chkPersonnelStatus.ForeColor = Color.LightCoral;
                Reload();
            }

            else
            {
                status = true;
                chkPersonnelStatus.Text = "Displaying active farms only.";
                chkPersonnelStatus.ForeColor = Color.LightSkyBlue;
                Reload();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNo.Text = row.Cells["Storage_no"].Value.ToString();
                txtName.Text = row.Cells["Storage_Name"].Value.ToString();
                txtAcreage.Text = row.Cells["Storage_acreage"].Value.ToString();
                txtLandNo.Text = row.Cells["Land_no"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length == 0)
            {
                MessageBox.Show("The name can not be null!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var db = new FarmingManagementSystemEntities())
            {
                Double ac;//acreage
                int land;
                try
                { 
                    ac = Double.Parse(txtAcreage.Text.Trim());
                    land = Int32.Parse(txtLandNo.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Invalip Inout. Check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Storage s = new Storage()
                {
                    Storage_Name = txtName.Text.Trim(),
                    Storage_acreage = ac,
                    Land_no = land,
                    Status = true
                };
                db.Storages.Add(s);
                db.SaveChanges();
                MessageBox.Show("The new storage " + s.Storage_Name + " has been added successfully.", "Storage Has Been Added.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                int sNo;
                int ac;//acreage
                int land;
                try
                {
                    sNo = Int32.Parse(txtNo.Text);
                    ac = Int32.Parse(txtAcreage.Text.Trim());
                    land = Int32.Parse(txtLandNo.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Invalip Inout. Check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var s = db.Storages.FirstOrDefault(k => k.Storage_no == sNo);
                if(s != null)
                {
                    s.Storage_no = sNo;
                    s.Storage_acreage = ac;
                    s.Land_no = land;
                    s.Storage_Name = txtName.Text.Trim();
                }
                db.SaveChanges();
                MessageBox.Show("The  storage " + s.Storage_Name + " has been updated successfully.", "Storage Has Been Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                int sNo;
               
                try
                {
                    sNo = Int32.Parse(txtNo.Text);
                }
                catch
                {
                    MessageBox.Show("Any storage couldn't found with the entered ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var s = db.Storages.FirstOrDefault(k => k.Storage_no == sNo);
                if (s != null)
                {
                    s.Status = false;
                }
                db.SaveChanges();
                MessageBox.Show("The  storage " + s.Storage_Name + " has been deleted successfully.", "Storage Has Been Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            EquipmentsForm eq = new EquipmentsForm(-1);
            eq.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int storNo;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                storNo = Int32.Parse(row.Cells["Storage_No"].Value.ToString());
                EquipmentsForm eq = new EquipmentsForm(storNo);
                eq.Show();
                this.Visible = false;
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
