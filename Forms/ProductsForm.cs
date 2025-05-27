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
    public partial class ProductsForm : FormBase
    {
        private int barnNo;
        public ProductsForm(int barnNo)
        {
            InitializeComponent();
            this.barnNo = barnNo;

            using (var db = new FarmingManagementSystemEntities())
            {
                var barnNumbers = db.Barns.Where(b => b.Status == true)
                                          .Select(s => s.Barn_no.ToString()).ToList();
                barnNumbers.Insert(0, "All Barns");
                cmbBarn.DataSource = barnNumbers;
            }
            if (barnNo == -1)
            {
                cmbBarn.SelectedIndex = 0;
            }
            else
            {
                cmbBarn.Text = barnNo.ToString();
            }
            Reload();
        }


        private string empID_perso = null;
        public ProductsForm(int barnNo, String empID_perso)
        {
            InitializeComponent();
            txtEmpID.Text = empID_perso;
            txtEmpID.Enabled = false;

            this.empID_perso=empID_perso;

            using (var db = new FarmingManagementSystemEntities())
            {
                var barnNumbers = (from p in db.Storing_products
                                   where p.Emp_id == empID_perso
                                   select p.Barn_no.ToString()).Distinct().ToList();
                cmbBarn.DataSource = barnNumbers;
                cmbBarn.SelectedIndex = 0;
            }
            PersonnelReload();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);

        }
        private void PersonnelReload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {

                var barn = (from st in db.Storing_products
                            join ba in db.Barns on st.Barn_no equals ba.Barn_no
                            join l in db.Lands on ba.Land_no equals l.Land_no
                            join e in db.Employees on st.Emp_id equals e.Emp_id
                            where st.Emp_id == empID_perso

                            select new
                            {
                                st.Storing_id,
                                st.Barn_no,
                                l.Land_City,
                                st.Stored_product,
                                st.Stored_quantity,
                                st.Stored_date,
                                st.Field_no,
                                st.Farm_no,
                                e.Emp_name,
                                st.Emp_id
                            }).ToList();
                dataGridView1.DataSource = barn;
                dataGridView1.Columns["Barn_no"].DisplayIndex = 1;
            }
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                if (cmbBarn.SelectedIndex == 0)
                {
                    var barn = (from st in db.Storing_products
                                join ba in db.Barns on st.Barn_no equals ba.Barn_no
                                join l in db.Lands on ba.Land_no equals l.Land_no
                                join e in db.Employees on st.Emp_id equals e.Emp_id

                                select new
                                {
                                    st.Storing_id,
                                    st.Barn_no,
                                    l.Land_City,
                                    st.Stored_product,
                                    st.Stored_quantity,
                                    st.Stored_date,
                                    st.Field_no,
                                    st.Farm_no,
                                    e.Emp_name,
                                    st.Emp_id
                                }).ToList();
                    dataGridView1.DataSource = barn;
                    dataGridView1.Columns["Barn_no"].DisplayIndex = 1;
                }
                else
                {
                    int barnNo = Int32.Parse(cmbBarn.Text);
                    var barn = (from st in db.Storing_products
                                join ba in db.Barns on st.Barn_no equals ba.Barn_no
                                join l in db.Lands on ba.Land_no equals l.Land_no
                                join e in db.Employees on st.Emp_id equals e.Emp_id
                                where st.Barn_no == barnNo
                                select new
                                {
                                    st.Storing_id,
                                    //st.Barn_no,
                                    l.Land_City,
                                    st.Stored_product,
                                    st.Stored_quantity,
                                    st.Stored_date,
                                    st.Field_no,
                                    st.Farm_no,
                                    e.Emp_name,
                                    st.Emp_id
                                }).ToList();
                    dataGridView1.DataSource = barn;
                }
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                if (cmbBarn.SelectedIndex == 0)
                {
                    txtNo.Text = row.Cells["Barn_No"].Value.ToString();
                }
                else
                {
                    txtNo.Text = cmbBarn.Text;
                }

                txtStoringID.Text = row.Cells["Storing_id"].Value.ToString();
                txtName.Text = row.Cells["Stored_product"].Value.ToString();
                txtQuantity.Text = row.Cells["Stored_quantity"].Value.ToString();
                txtDate.Text = Convert.ToDateTime(row.Cells["Stored_date"].Value).ToString("yyyy.MM.dd");
                txtBaseField.Text = row.Cells["Field_no"].Value?.ToString() ?? "";
                txtBaseFarm.Text = row.Cells["Farm_no"].Value?.ToString() ?? "";
                txtEmpID.Text = row.Cells["Emp_id"].Value.ToString();
            }
        }

        private void ProductsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(empID_perso == null)
            {
                BarnForm barnForm = new BarnForm();
                barnForm.Visible = true;
            }
            
        }

        private void cmbBarn_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNo.Text = "";
            txtEmpID.Text = "";
            txtStoringID.Text = "";
            txtName.Text = "";
            txtQuantity.Text = "";
            txtDate.Text = "";
            txtBaseField.Text = "";
            txtBaseFarm.Text = "";
        }

        private Boolean AttributeControl()
        {
            if (txtName.Text.Length != 0 && txtQuantity.Text.Length != 0 && txtNo.Text.Length != 0 && txtDate.Text.Length != 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Invalid Input! Please be sure that you filled all the necessary textboxes.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (AttributeControl())
            {
                int no;
                int? fieldNo = null;
                int? farmNo = null;
                int quant;
                DateTime workDate;
                try
                {
                    no = Int32.Parse(txtNo.Text.Trim());
                    if (txtBaseFarm.Text.Length == 0)
                    {
                        fieldNo = Int32.Parse(txtBaseField.Text.Trim());
                    }
                    else
                    {
                        farmNo = Int32.Parse(txtBaseFarm.Text.Trim());
                    }
                    quant = Int32.Parse(txtQuantity.Text.Trim());
                    workDate = DateTime.ParseExact(txtDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);

                }
                catch
                {
                    MessageBox.Show("Invalid Input! Please be sure that you filled all the necessary textboxes.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new FarmingManagementSystemEntities())
                {
                    Storing_products s = new Storing_products()
                    {
                        Barn_no = no,
                        Stored_product = txtName.Text.Trim(),
                        Stored_quantity = quant,
                        Field_no = fieldNo,
                        Farm_no = farmNo,
                        Emp_id = txtEmpID.Text.Trim(),
                        Stored_date = workDate
                    };
                    db.Storing_products.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("The product added to the barn has " + barnNo, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int no;
            int? fieldNo = null;
            int? farmNo = null;
            int quant;
            int stID;
            DateTime workDate;
            try
            {
                no = Int32.Parse(txtNo.Text.Trim());
                if (txtBaseFarm.Text.Length == 0)
                {
                    fieldNo = Int32.Parse(txtBaseField.Text.Trim());
                }
                else
                {
                    farmNo = Int32.Parse(txtBaseFarm.Text.Trim());
                }
                quant = Int32.Parse(txtQuantity.Text.Trim());
                workDate = DateTime.ParseExact(txtDate.Text.Trim(), "yyyy.MM.dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
                stID = Int32.Parse(txtStoringID.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Input! Please be sure that you filled all the necessary textboxes.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new FarmingManagementSystemEntities())
            {
                var s = db.Storing_products.FirstOrDefault(k => k.Storing_id == stID);

                if (s != null)
                {
                    s.Barn_no = no;
                    s.Stored_product = txtName.Text.Trim();
                    s.Stored_quantity = quant;
                    s.Field_no = fieldNo;
                    s.Farm_no = farmNo;
                    s.Emp_id = txtEmpID.Text.Trim();
                    s.Stored_date = workDate;

                    db.SaveChanges();
                    MessageBox.Show("The product has been updated Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
                else
                    MessageBox.Show("An error occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Are you sure to subtract the selected product?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {

                int stID;
                try
                {
                    stID = Int32.Parse(txtStoringID.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid Input! Storing ID coulnd't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var db = new FarmingManagementSystemEntities())
                {
                    var s = db.Storing_products.FirstOrDefault(k => k.Storing_id == stID);
                    if (s != null)
                    {
                        db.Storing_products.Remove(s);
                        db.SaveChanges();
                        MessageBox.Show("The product has been substracted from the barn Successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else
                        MessageBox.Show("An error occured.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

    }
}
