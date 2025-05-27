using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FarmingManagement_FMS.Forms
{
    public partial class PresetQueryForm : FormBase
    {
        public PresetQueryForm()
        {
            InitializeComponent();
        }

        private bool queryStatus;
        private void PresetQueryForm_Load(object sender, EventArgs e)
        {
            queryStatus = true;
            Reload();
        }
        private void Reload()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var query = db.PresetQueries.Where(p => p.Status == queryStatus).ToList();
                dataGridView1.DataSource = query;
                //VERİ YÜKLE.
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells["query_id"].Value.ToString();
                txtName.Text = row.Cells["query_name"].Value.ToString();
                txtDescription.Text = row.Cells["query_description"].Value?.ToString()??"";
                rchStatement.Text = row.Cells["SQL_statement"].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 0 && rchStatement.Text.Length > 0)
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    PresetQuery p = new PresetQuery()
                    {
                        query_name = txtName.Text.Trim(),
                        query_description = txtDescription.Text.Trim(),
                        SQL_statement = rchStatement.Text.Trim(),
                        Status = true
                    };
                    db.PresetQueries.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("The new query has been added.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
            }
            else
            {
                MessageBox.Show("The Invalid Input.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && rchStatement.Text.Length > 0)
            {
                int qID;
                try
                {
                    qID = Int32.Parse(txtID.Text);
                }
                catch
                {
                    MessageBox.Show("Qeury ID couldn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new FarmingManagementSystemEntities())
                {
                   var d = db.PresetQueries.FirstOrDefault(s => s.query_id == qID);
                    if(d != null)
                    {
                        d.query_name = txtName.Text.Trim();
                        d.query_description = txtDescription.Text.Trim();
                        d.SQL_statement = rchStatement.Text.Trim();
                    }
                    db.SaveChanges();
                    MessageBox.Show("The query has been updated.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reload();
                }
            }
            else
            {
                MessageBox.Show("The Invalid Input.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
                int qID;
                try
                {
                    qID = Int32.Parse(txtID.Text);
                }
                catch
                {
                    MessageBox.Show("Qeury ID couldn't found.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (var db = new FarmingManagementSystemEntities())
                {
                    var d = db.PresetQueries.FirstOrDefault(s => s.query_id == qID);
                    if (d != null)
                    {
                        d.Status = false;
                    }
                    db.SaveChanges();
                    MessageBox.Show("The query has been deleted.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reload();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String query;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                query = row.Cells["SQL_statement"].Value.ToString();
            }
            try
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    query = rchStatement.Text.Trim();
                    dataGridView2.DataSource = ExecuteDynamicSql(query);
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView2.DefaultCellStyle.Font = new Font("Segoe UI", 13);
                }
            }
            catch
            {
                MessageBox.Show("An error occured. The query may be wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private DataTable ExecuteDynamicSql(string sql)
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var conn = db.Database.Connection;
                var dt = new DataTable();

                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = sql;
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }

                return dt;
            }
        }
    }
}
