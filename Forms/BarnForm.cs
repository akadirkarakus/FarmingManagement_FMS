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
    public partial class BarnForm : FormBase    
    {
        public BarnForm()
        {
            InitializeComponent();
        }

        //SQL KISMI TAMAMLANDI. STORİNG-ID EKLENDİ. EF'Yİ GÜNCELLE. DGW'DEN TEXTBOX'A VERİ ÇEK VE BUTONLARI AKTİFLEŞTİR.

        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var barn = (from ba in db.Barns
                            join ln in db.Lands on ba.Land_no equals ln.Land_no
                            join s in db.Storing_products on ba.Barn_no equals s.Barn_no into spGroup
                            from s in spGroup.DefaultIfEmpty()
                            where ba.Status == barnStatus
                            group s by new { ba.Barn_no, ba.Barn_name, ln.Land_no, ln.Land_City, ba.Barn_acreage } into g
                            select new
                            {
                                g.Key.Barn_no,
                                g.Key.Barn_name,
                                g.Key.Barn_acreage,
                                g.Key.Land_City,
                                g.Key.Land_no,
                                Total_Stored = g.Sum(x => (int?)x.Stored_quantity) ?? 0
                            }).ToList();
                dataGridView1.DataSource = barn;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }
        private void BarnForm_Load(object sender, EventArgs e)
        {
            barnStatus = true;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtNo.Text = row.Cells["barn_no"].Value.ToString();
                txtName.Text = row.Cells["Barn_Name"].Value.ToString();
                txtLandNo.Text = row.Cells["Land_No"].Value.ToString();
                txtAcreage.Text = row.Cells["Barn_Acreage"].Value.ToString();
            }
        }

        private Boolean barnStatus;
        private void chkPersonnelStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (barnStatus)
            {
                barnStatus = false;
                chkPersonnelStatus.Text = "Displaying inactive barns only.";
                chkPersonnelStatus.ForeColor = Color.LightCoral;
                Reload();
            }

            else
            {
                barnStatus = true;
                chkPersonnelStatus.Text = "Displaying active barns only.";
                chkPersonnelStatus.ForeColor = Color.LightSkyBlue;
                Reload();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Barn name can not be null!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var db = new FarmingManagementSystemEntities())
            {
                int landNo;
                    int acreage;
                try
                {
                    acreage = Int32.Parse(txtAcreage.Text.Trim());
                    landNo = Int32.Parse(txtLandNo.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Invalid input.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var land = db.Lands.FirstOrDefault(S => S.Land_no == landNo);
                if(land == null)
                {
                    MessageBox.Show("Any land couldn't found with the entered land no.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Barn barn = new Barn()
                    {
                        Barn_name = txtName.Text.Trim(),
                        Barn_acreage = acreage,
                        Land_no = landNo,
                        Status = true
                    };
                    db.Barns.Add(barn);
                    db.SaveChanges();
                    MessageBox.Show("The new barn " + barn.Barn_name + " has been added successfully.", "Barn Has Been Added.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
            }
        }

        private void btnLand_Click(object sender, EventArgs e)
        {
            ManageLand l = new ManageLand();
            l.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to update the selected land?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Barn name can not be null!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int acreage;
                int landNo;
                int barnNo;
                try
                {
                    barnNo = Int32.Parse(txtNo.Text);
                    acreage = Int32.Parse(txtAcreage.Text.Trim());
                    landNo = Int32.Parse(txtLandNo.Text.Trim());
                }
                catch
                {
                    MessageBox.Show("Invalid input.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new FarmingManagementSystemEntities())
                {
                    var barn = db.Barns.FirstOrDefault(s => s.Barn_no == barnNo);
                    if (barn == null)
                    {
                        MessageBox.Show("Any barns couldn't found with this barn ID.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        barn.Barn_name = txtName.Text.Trim();
                        barn.Barn_acreage = acreage;
                        barn.Land_no = landNo;
                    }
                    db.SaveChanges();
                    MessageBox.Show("The new barn " + barn.Barn_name + " has been updated successfully.", "Barn Has Been Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to delete the selected land?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                int barnNo;
                try
                {
                    barnNo = Int32.Parse(txtNo.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Barn No", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new FarmingManagementSystemEntities())
                {
                    var barn = db.Barns.FirstOrDefault(s => s.Barn_no == barnNo);
                    if (barn == null)
                    {
                        MessageBox.Show("Any barns couldn't found with this barn No.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        barn.Status = false;
                    }
                    db.SaveChanges();
                    MessageBox.Show("The new barn " + barn.Barn_name + " has been deleted successfully.", "Barn Has Been Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAcreage.Text = "";
            txtLandNo.Text = "";
            txtNo.Text = "";
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            int barnNo = -1;
            ProductsForm form = new ProductsForm(barnNo);
            form.Show();
            this.Visible = false;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int barnNo;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                barnNo = Int32.Parse((row.Cells["barn_no"].Value.ToString()));
                ProductsForm form = new ProductsForm(barnNo);
                form.Show();
                this.Visible = false;
            }   
        }
    }
}
