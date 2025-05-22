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
    public partial class ManageLand : FormBase
    {
        public ManageLand()
        {
            InitializeComponent();
        }

        private bool landStatus = true;
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                    var land = db.Lands
                        .Where(ln => ln.Status == landStatus)
                        .Select(ln => new
                        {
                            ln.Land_no,
                            ln.Land_name,
                            ln.Acreage,
                            ln.Land_City,
                            ln.Location,
                            ln.Date_purchase
                        }).ToList();
                    dataGridView1 .DataSource = land;
                dataGridView1.Columns["Land_no"].HeaderText = "Land No";
                dataGridView1.Columns["Land_Name"].HeaderText = "Land Name";
                dataGridView1.Columns["Land_City"].HeaderText = "Land City";
                dataGridView1.Columns["Date_Purchase"].HeaderText = "Purchase Date";
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }
        private void ManageLand_Load(object sender, EventArgs e)
        {
            Reload();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult d = MessageBox.Show("Are you sure to delete the selected land?","Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    int id = Int32.Parse(txtID.Text);
                    var land = db.Lands.FirstOrDefault(lan => lan.Land_no == id);
                    if(land != null)
                    {
                        if(land.Status == true)
                        {
                            land.Status = false;
                            land.Status = false;
                            db.SaveChanges();
                            MessageBox.Show("The land " + land.Land_name + " has been deleted. You can see the information of deleted lands by changing the chechbox.", "Land Has Been Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reload();
                        }
                        else
                            MessageBox.Show("The land has been alreade deleted.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
            txtID.Text = "";
            txtName.Text = "";
            txtLocation.Text = "";
            txtAcreage.Text = "";
            txtDate.Text = "";
            txtCity.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)//refresh
        {
            Reload();
        }

        private void chkPersonnelStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (landStatus)
            {
                landStatus = false;
                chkPersonnelStatus.Text = "Displaying inactive lands only.";
                chkPersonnelStatus.ForeColor = Color.LightCoral;
                Reload();
            }

            else
            {
                landStatus = true;
                chkPersonnelStatus.Text = "Displaying active lands only.";
                chkPersonnelStatus.ForeColor = Color.LightSkyBlue;
                Reload();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(AttributeControl())
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    DateTime pDate = DateTime.ParseExact(txtDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                   
                    var land = db.Lands.FirstOrDefault(lan => lan.Land_name == txtName.Text.Trim());
                    var loc = db.Lands.FirstOrDefault(loca => loca.Location == txtLocation.Text.Trim());
                    if(land == null)
                    {
                        if(loc == null)
                        {
                            Land newLand = new Land()
                            {
                                Land_name = txtName.Text.Trim(),
                                Acreage = Double.Parse(txtAcreage.Text.Trim()),
                                Land_City = txtCity.Text.Trim(),
                                Location = txtLocation.Text.Trim(),
                                Date_purchase = pDate,
                                Status = true
                            };

                            db.Lands.Add(newLand);
                            db.SaveChanges();

                            MessageBox.Show("New land " + newLand.Land_name + " has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("There is a land which has the same location with this location on the database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if(land.Status == false)
                    {
                        land.Status = true;
                        db.SaveChanges();
                        MessageBox.Show("Old land " + land.Land_name + " has been added again successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(land.Land_name + " name is already exist on database.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Reload();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["Land_no"].Value.ToString();
                txtName.Text = row.Cells["Land_Name"].Value.ToString();
                txtLocation.Text = row.Cells["Location"].Value.ToString();
                txtDate.Text = Convert.ToDateTime( row.Cells["Date_Purchase"].Value).ToString("yyyy.MM.dd");
                txtAcreage.Text = row.Cells["Acreage"].Value.ToString();
                txtCity.Text = row.Cells["Land_City"].Value.ToString();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All of the land numbers are assigned by the system automatically and can not changed by the user.", "Land Numbers", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DateTime pDate = DateTime.ParseExact(txtDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);

            if(AttributeControl())
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    int landNo = int.Parse(txtID.Text.Trim());  

                    var land = db.Lands.FirstOrDefault(l =>l.Land_no == landNo);
                    var loc = db.Lands.FirstOrDefault(locn => locn.Location == txtLocation.Text.Trim());
                    var name = db.Lands.FirstOrDefault(n => n.Land_name == txtName.Text.Trim());

                    if(name == null)
                    {
                        if(loc == null)
                        {
                            land.Land_name = txtName.Text.Trim();
                            land.Land_City = txtCity.Text.Trim();
                            land.Acreage = Double.Parse(txtAcreage.Text.Trim());
                            land.Location = txtLocation.Text.Trim();
                            land.Date_purchase = pDate;

                            db.SaveChanges();
                            MessageBox.Show("The land " + land.Land_name + " has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("There is a land that has the same location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("There is a land that has the same name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool AttributeControl()
        {
            if(txtName.Text.Trim().Length <1)
            {
                MessageBox.Show("Land name can not be empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtAcreage.Text.Trim().Length <1)
            {
                MessageBox.Show("Acreage can not be empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtCity.Text.Trim().Length <1)
            {
                MessageBox.Show("City part can not be empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if(txtLocation.Text.Trim().Length <1)
            {
                MessageBox.Show("Location of land can not be empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
