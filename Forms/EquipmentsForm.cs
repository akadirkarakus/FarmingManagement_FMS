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
    public partial class EquipmentsForm : FormBase
    {
        private int storNo;
        public EquipmentsForm(int storageNo)
        {
            this.storNo = storageNo;
            InitializeComponent();
            equiStatus = true;
            using (var db = new FarmingManagementSystemEntities())
            {
                var stNum = db.Storages.Where(b => b.Status == true)
                                          .Select(s => s.Storage_no.ToString()).ToList();
                stNum.Insert(0, "All");
                cmbStorage.DataSource = stNum;
                if (storNo == -1)
                    cmbStorage.SelectedIndex = 0;
                else
                    cmbStorage.Text = storNo.ToString();

                Reload();
            }
        }

        private String empID_perso;
        public EquipmentsForm(int storageNo, String empID_perso)
        {
            InitializeComponent();
            this.empID_perso = empID_perso;

            equiStatus = true;
            using (var db = new FarmingManagementSystemEntities())
            {
                var stNum = (from se in db.Storage_work_employee
                             join st in db.Storages on se.Storage_no equals st.Storage_no
                             where st.Status == true
                             where se.emp_id == empID_perso
                             select st.Storage_no.ToString()).Distinct().ToList();
                cmbStorage.DataSource = stNum;
                cmbStorage.SelectedIndex = 0;

                PersonnelReload();
            }
        }
        private void EquipmentsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }

        private void PersonnelReload()
        {
            int stNo =Int32.Parse(cmbStorage.Text);
            using (var db = new FarmingManagementSystemEntities())
            {
                var eq = (from e in db.Equipments
                          join s in db.Storages on e.storage_no equals s.Storage_no
                          join se in db.Storage_work_employee on s.Storage_no equals se.Storage_no
                          join u in db.Equipment_Use on e.Equi_id equals u.Equi_id into useGroup
                          from u in useGroup.DefaultIfEmpty()
                          join em in db.Employees on u.Emp_id equals em.Emp_id into empGroup
                          from em in empGroup.DefaultIfEmpty()
                          where e.Status == equiStatus
                          where se.emp_id == empID_perso
                          where s.Storage_no == stNo
                          select new
                          {
                              e.Equi_id,
                              e.Equi_name,
                              e.storage_no,
                              Emp_id = u.Emp_id,
                              Emp_name = em.Emp_name,
                              Date_receive = u.Date_receive,
                              Date_return = u.Date_return
                          }).ToList();
                dataGridView1.DataSource = eq;
                dataGridView1.Columns["Storage_No"].DisplayIndex = 0;
            }
        }
        private bool equiStatus;
        private void Reload()
        {
            if(cmbStorage.SelectedIndex == 0)
            {
                using(var db = new FarmingManagementSystemEntities())
                {
                    var eq = (from e in db.Equipments
                              join u in db.Equipment_Use on e.Equi_id equals u.Equi_id into useGroup
                              from u in useGroup.DefaultIfEmpty()
                              join em in db.Employees on u.Emp_id equals em.Emp_id into empGroup
                              from em in empGroup.DefaultIfEmpty()
                              where e.Status == equiStatus
                              select new
                              {
                                  e.Equi_id,
                                  e.Equi_name,
                                  e.storage_no,
                                  Emp_id = u.Emp_id,
                                  Emp_name = em.Emp_name,
                                  Date_receive = u.Date_receive,
                                  Date_return = u.Date_return
                              }).ToList();
                    dataGridView1.DataSource = eq;
                    dataGridView1.Columns["Storage_No"].DisplayIndex = 0;
                }
            }
            else
            {
                int sNo = Int32.Parse(cmbStorage.Text);
                using (var db = new FarmingManagementSystemEntities())
                {
                    var eq = (from e in db.Equipments
                              join u in db.Equipment_Use on e.Equi_id equals u.Equi_id into useGroup
                              from u in useGroup.DefaultIfEmpty()
                              join em in db.Employees on u.Emp_id equals em.Emp_id into empGroup
                              from em in empGroup.DefaultIfEmpty()
                              where e.Status == equiStatus
                              where e.storage_no == sNo
                              select new
                              {
                                  e.Equi_id,
                                  e.Equi_name,
                                  e.storage_no,
                                  Emp_id = u.Emp_id,
                                  Emp_name = em.Emp_name,
                                  Date_receive = u.Date_receive,
                                  Date_return = u.Date_return
                              }).ToList();
                    dataGridView1.DataSource = eq;
                }
            }
            
        }

        private void cmbStorage_TextChanged(object sender, EventArgs e)
        {
            if (empID_perso == null)
            {
                Reload();
            }
            else
            {
                PersonnelReload();
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void chkPersonnelStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (equiStatus)
            {
                equiStatus = false;
                chkPersonnelStatus.Text = "Displaying inactive euipments only.";
                chkPersonnelStatus.ForeColor = Color.LightCoral;
                Reload();
            }

            else
            {
                equiStatus = true;
                chkPersonnelStatus.Text = "Displaying active euipments only.";
                chkPersonnelStatus.ForeColor = Color.LightSkyBlue;
                Reload();
            }
        }

        private void EquipmentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (empID_perso == null)
            {
                StorageForm s = new StorageForm();
                s.Visible = true;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


                if (dataGridView1.Columns.Contains("Storage_No"))
                {
                    txtNo.Text = row.Cells["Storage_No"].Value?.ToString() ?? "";
                }
                else
                    txtNo.Text = cmbStorage.Text;

                txtEquiID.Text = row.Cells["Equi_id"].Value.ToString();
                txtEquiID2.Text = row.Cells["Equi_id"].Value.ToString();
                txtName.Text = row.Cells["Equi_Name"].Value.ToString();
                var receiveVal = row.Cells["Date_receive"].Value;
                txtReceive.Text = receiveVal != null ? Convert.ToDateTime(receiveVal).ToString("yyyy.MM.dd") : "no receive";

                var returnVal = row.Cells["Date_Return"].Value;
                txtReturn.Text = returnVal != null ? Convert.ToDateTime(returnVal).ToString("yyyy.MM.dd") : "no return";
                txtEmpID.Text = row.Cells["Emp_id"].Value?.ToString() ?? "no value";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int storNo;
            //int equiID;
            try
            {
                storNo = Int32.Parse(txtNo.Text);
                //equiID = Int32.Parse(txtEquiID.Text);
            }
            catch
            {
                MessageBox.Show("Invalip Input. Check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new FarmingManagementSystemEntities())
            {
                Equipment equipment = new Equipment()
                {
                    Equi_name = txtName.Text.Trim(),
                    storage_no = storNo,
                    Status = true
                };
                db.Equipments.Add(equipment);
                db.SaveChanges();
                MessageBox.Show("The new Equipment " + equipment.Equi_name + " has been added successfully.", "Equipment Has Been Added.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int storNo;
            int equiID;
            try
            {
                storNo = Int32.Parse(txtNo.Text);
                equiID = Int32.Parse(txtEquiID.Text);
            }
            catch
            {
                MessageBox.Show("Invalip Input. Check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new FarmingManagementSystemEntities())
            {
                var use = db.Equipments.FirstOrDefault(se => se.Equi_id == equiID);
                if(use != null)
                {
                    use.Equi_name = txtNo.Text.Trim();
                    use.storage_no = storNo;
                }
                db.SaveChanges();
                MessageBox.Show("The equipment has been updated successfully.", "Equipment Has Been Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int equiID;
            try
            {
                equiID = Int32.Parse(txtEquiID.Text);
            }
            catch
            {
                MessageBox.Show("Equipment couldn't found!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new FarmingManagementSystemEntities())
            {
                var use = db.Equipments.FirstOrDefault(s => s.Equi_id == equiID);
                if (use != null)
                {
                    use.Status = false;
                }
                db.SaveChanges();
                MessageBox.Show("The equipment has been deleted successfully.", "Equipment Has Been Deleted.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }
        
        private void btnUpdateUsage_Click(object sender, EventArgs e)
        {
            int equiID;
            DateTime receive;
            DateTime returnD;

            try
            {
                equiID = Int32.Parse(txtEquiID.Text);
                receive = DateTime.ParseExact(txtReceive.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                returnD = DateTime.ParseExact(txtReturn.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
            }
            catch
            {
                MessageBox.Show("Invalip Inout. Check your inputs.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new FarmingManagementSystemEntities())
            {
                var equi = db.Equipment_Use.FirstOrDefault(se => se.Equi_id == equiID);
                if (equi != null)
                {
                    equi.Date_return = returnD;
                    equi.Date_receive = receive;
                    equi.Emp_id = txtEmpID.Text.Trim();
                }
                try
                {
                    db.SaveChanges();
                    MessageBox.Show("The equipment has been updated successfully.", "Equipment Has Been Updated.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                catch
                {
                    MessageBox.Show("An error occured. Check the return and receive dates.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtNo.Text = "";
            txtEquiID.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEquiID2.Text = "";
            txtReceive.Text = "";
            txtReturn.Text = "";
            txtEmpID.Text = "";
        }
    }
}
