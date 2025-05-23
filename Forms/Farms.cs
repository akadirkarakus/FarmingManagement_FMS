using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmingManagement_FMS.Forms
{
    //ANİMALS FORMUNU OLUŞTUR: GERKLİ BAĞLANTILARI YAP.
    //FARMS'TA GÖZÜKEN FARMLARDA, BİR DE EXİSTİNG ANİMAL İSİMLİ BİR SÜTUN OLSUN VE O FARMDA KAÇ HAYVAN OLDUĞUNU GÖSTERSİN.
    //vet TABLOSUNU YAP. EXAMINATION İLE BİRLİKTE.






    public partial class Farms : FormBase
    {
        public Farms()
        {
            InitializeComponent();
        }

       
        private void Farms_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                    var farm = (from fa in db.Farms
                                join la in db.Lands on fa.Land_no equals la.Land_no
                                where fa.Status == farmStatus
                                select new
                                {
                                    fa.Farm_no,
                                    fa.Farm_name,
                                    fa.Land_no,
                                    la.Land_name,
                                    la.Land_City,
                                    fa.Farm_acreage
                                }).ToList();
                    dataGridView1.DataSource = farm;

                dataGridView1.Columns["Farm_No"].HeaderText = "Farm No";
                dataGridView1.Columns["Farm_Name"].HeaderText = "Farm Name";
                dataGridView1.Columns["Land_No"].HeaderText = "Land No";
                dataGridView1.Columns["Land_Name"].HeaderText = "Land Name";
                dataGridView1.Columns["Land_City"].HeaderText = "Land City";
                dataGridView1.Columns["Farm_Acreage"].HeaderText = "Farm Acreage";
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }
        private void button1_Click(object sender, EventArgs e)//Reload
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

        private Boolean farmStatus = true;
        private void chkPersonnelStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (farmStatus)
            {
                farmStatus = false;
                chkPersonnelStatus.Text = "Displaying inactive farms only.";
                chkPersonnelStatus.ForeColor = Color.LightCoral;
                Reload();
            }

            else
            {
                farmStatus = true;
                chkPersonnelStatus.Text = "Displaying active farms only.";
                chkPersonnelStatus.ForeColor = Color.LightSkyBlue;
                Reload();
            }
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            Farm_Works fw = new Farm_Works(-1);
            fw.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["Farm_no"].Value.ToString();
                txtName.Text = row.Cells["Farm_Name"].Value.ToString();
                txtLandNo.Text = row.Cells["Land_No"].Value.ToString();
                txtAcreage.Text = row.Cells["Farm_Acreage"].Value.ToString();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (farmStatus == true)
            {
                if (e.RowIndex >= 0)
                {
                    int farmNo;
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    farmNo = Int32.Parse(row.Cells["Farm_no"].Value.ToString());
                    Farm_Works fw = new Farm_Works(farmNo);
                    fw.Show();
                }
            }
            else
                MessageBox.Show("Work cannot be applied to deleted farms.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
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
            txtID.Text = "";
            txtName.Text = "";
            txtLandNo.Text = "";
            txtAcreage.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    int farmNo = Int32.Parse(txtID.Text);
                    var far = db.Farms.FirstOrDefault(f => f.Farm_no == farmNo);
                    if(far == null)
                    {
                        Farm farm = new Farm()
                        {
                            Farm_name = txtName.Text.Trim(),
                            Farm_acreage = Int32.Parse(txtAcreage.Text.Trim()),
                            Land_no = Int32.Parse(txtLandNo.Text.Trim()),
                            Status = true
                        };
                        db.Farms.Add(farm);
                        MessageBox.Show("The new farm " + farm.Farm_name + " has been added successfully.", "Farm Has Been Added.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        far.Status = true;
                        MessageBox.Show("The old farm " + far.Farm_name + " has been added again successfully.", "Farm Has Been Added.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    db.SaveChanges();
                    Reload();
                }
           }
           catch
            {
               MessageBox.Show("Some errors occured. Be sure that all of the textboxes filled in a correct form.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to update the selected land?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    int farmNo;
                    try
                    {
                        farmNo = Int32.Parse(txtID.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("Any farm couldn't found with this farm number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var farm = db.Farms.FirstOrDefault(f => f.Farm_no == farmNo);
                    if (farm != null)
                    {
                        farm.Farm_name = txtName.Text.Trim();
                        farm.Farm_acreage = Int32.Parse(txtAcreage.Text.Trim());
                        farm.Land_no = Int32.Parse(txtLandNo.Text.Trim());
                        db.SaveChanges();
                        MessageBox.Show("The farm " + farm.Farm_name + " has been updated successfully.", "Farm Has Been Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else
                        MessageBox.Show("Any farm couldn't found with this farm number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                    int farmNo;
                    try
                    {
                        farmNo = Int32.Parse(txtID.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Any farm couldn't found with this farm number.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var farm = db.Farms.FirstOrDefault(f => f.Farm_no == farmNo);
                    if (farm.Status == true)
                    {
                        farm.Status = false;
                        db.SaveChanges();
                        MessageBox.Show("The farm " + farm.Farm_name + " has been deleted successfully.", "Farm Has Been Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else
                        MessageBox.Show("A deleted farm can not be deleted again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {

        }
    }
}
