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
    public partial class RunSqlForm : FormBase
    {
        public RunSqlForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new FarmingManagementSystemEntities())
                {
                    String query = rchQuery.Text.Trim();
                    dataGridView1.DataSource = ExecuteDynamicSql(query);
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 13);
                }
            }
            catch
            {
                MessageBox.Show("An error occured. Check your query.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            rchQuery.Text = "";
        }

        private void RunSqlForm_Load(object sender, EventArgs e)
        {

        }
    }
}
