using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FarmingManagement_FMS.Forms
{

    //BARN NO, DGW'YE ÇİFT TIKLANDIĞINDA YANLIŞ DEĞER GÖNDERİYOR.
    public partial class PersonnelStart : FormBase
    {
        private string empID;
        public PersonnelStart(string empID)
        {
            InitializeComponent();
            this.empID = empID;
        }

        private void PersonnelStart_Load(object sender, EventArgs e)
        {
            lblSpace.TextAlign = ContentAlignment.MiddleCenter;
            lblSpace.AutoSize = false;
            chart1.Legends[0].Docking = Docking.Bottom; 


            Activation();
            CommonLoad();
            Reload();

            dgwWork.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwWork.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwWork.DefaultCellStyle.Font = new Font("Segoe UI", 13);

            dgwField.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwField.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwField.DefaultCellStyle.Font = new Font("Segoe UI", 13);

        }

        private void Reload()
        {
            LoadAnnouncement();
            String text = cmbWorkSpace.Text;
            switch (text)
            {
                case "Field":
                    LoadField();
                    break;
                case "Farm":
                    LoadFarm(-1);
                    break;
                case "Barn":
                    LoadBarn(-1);
                    break;
                case "Storage":
                    LoadStorage(-1);
                    break;
            }
        }
        private void CommonLoad()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var emp = db.Employees.FirstOrDefault(s => s.Emp_id == empID);
                var w = db.Employee_Workspace.FirstOrDefault(s => s.Emp_id == empID);
                if (emp != null)
                {
                    lblID.Text =emp.Emp_id;
                    lblName.Text = emp.Emp_name;
                    lblMail.Text =  emp.eMail;
                    lblWorkingAreas.Text = w.Workspace_1 +", "+ w.Workspace_2;
                }
                cmbWorkSpace.Text = w.Workspace_1;
                LoadAnnouncement();
            }
        }
        private void LoadAnnouncement()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                //announcement
                String ws = cmbWorkSpace.Text;
                var notices = db.Notices
                                .Where(n => n.Workspace == ws)
                                .Join(db.Employees,
                                          n => n.Supervisor_id,
                                          e => e.Emp_id,
                                          (n, e) => new
                                          {
                                              n.notice_id,
                                              n.message,
                                              n.Workspace,
                                              n.Supervisor_id,
                                              SupervisorName = e.Emp_name
                                          })
                                .OrderByDescending(n => n.notice_id)
                                .Take(5).ToList();
                rchAnnounce.Clear();

                foreach (var notice in notices)
                {
                    rchAnnounce.AppendText($"[{notice.Workspace}] (by {notice.SupervisorName})\n{notice.message}\n\n");
                }
            }
                
        }
        private void Activation()
        {
            using (var db = new FarmingManagementSystemEntities())
            {
                var work = db.Employee_Workspace.FirstOrDefault(s => s.Emp_id == empID);

                ArrayList workspace = new ArrayList();
                workspace.Add(work.Workspace_1);

                if(work.Workspace_2 != null)
                {
                    workspace.Add(work.Workspace_2);
                }

                cmbWorkSpace.Items.AddRange(workspace.ToArray());
                cmbWorkSpace.SelectedIndex = 0;
                
            }
        }
        private void LoadField()
        {
            lblInfo.Visible = false;
            lnkGoBack.Visible = false;
            lblWork.Text = "Last Works Done";
            lblStatistic.Text = "Work Done Statistics";
            lblStorageInfo.Visible = false;

            using (var db = new FarmingManagementSystemEntities())
            {
                var empWorks = (from fwe in db.Field_work_employees2
                                join fw in db.Field_works on fwe.Work_id equals fw.Work_id
                                join field in db.Fields on fw.Field_no equals field.Field_no
                                where fwe.Emp_id == empID
                                orderby fw.Work_Date descending
                                select new
                                {
                                    fw.Work_id,
                                    fw.Field_no,
                                    fw.Field_WorkDone,
                                    fw.Work_Date,
                                }).Take(10).ToList();
                dgwWork.DataSource = empWorks;

                var fields = (from f in db.Fields
                              join fw in db.Field_works on f.Field_no equals fw.Field_no
                              join fe in db.Field_work_employees2 on fw.Work_id equals fe.Work_id
                              join lan in db.Lands on f.Land_no equals lan.Land_no
                              join fes in db.Field_work_seeds3 on fw.Work_id equals fes.Work_id
                              join se in db.Seeds on fes.Seed_genus equals se.Seed_genus
                              where fe.Emp_id == empID
                              select new
                              {
                                  f.Field_no,
                                  f.Field_acreage,
                                  lan.Land_City,
                                  fes.Seed_genus,
                                  f.Planting_date,
                                  EstimatedHarvestDate = DbFunctions.AddDays(f.Planting_date, (int)se.Cultivation_time),
                                  f.Status
                              }).ToList();
                dgwField.DataSource = fields;

                //chart -----------------------------------
                var data = db.Field_work_employees2
                             .Where(fwe => fwe.Emp_id == empID)
                             .Join(db.Field_works,
                                fwe => fwe.Work_id,
                                fw => fw.Work_id,
                                (fwe, fw) => fw.Field_WorkDone)
                             .GroupBy(work => work)
                             .Select(g => new { WorkType = g.Key, Count = g.Count() }).ToList();

                chart1.Series.Clear();
                var series = chart1.Series.Add("Work Frequency");
                series.ChartType = SeriesChartType.Column;

                foreach (var item in data)
                {
                    series.Points.AddXY(item.WorkType, item.Count);
                }
                chart1.ChartAreas[0].AxisX.Interval = 1; // her etiketi göster
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // eğik yazı
            }
            
        }

        private void LoadFarm(int farmNo)
        {
            lnkGoBack.Visible = false;
            lblInfo.Visible = true;
            lblInfo.Text = "Double click farm to display animals in that farm.";
            lblSpace.Text = "Relaated Farm Info.";
            lblWork.Text = "Last Works Done";
            lblStatistic.Text = "Work Done Statistics";
            lblStorageInfo.Visible = false;

            using (var db = new FarmingManagementSystemEntities())
            {
                var empWork = (from fw in db.Farm_work_employee2
                               join fa in db.Farm_Work on fw.Work_id equals fa.Work_id
                               join farm in db.Farms on fa.Farm_no equals farm.Farm_no
                               where fw.Emp_id == empID
                               orderby fa.Work_Date descending
                               select new
                               {
                                   fa.Work_id,
                                   fa.Farm_no,
                                   farm.Farm_name,
                                   fa.Farm_WorkDone,
                                   fa.Work_Date
                               }).ToList();
                dgwWork.DataSource = empWork;

                if(farmNo == -1)
                {
                    var farms = (from fw in db.Farm_work_employee2
                                 join fa in db.Farm_Work on fw.Work_id equals fa.Work_id
                                 join farm in db.Farms on fa.Farm_no equals farm.Farm_no
                                 join lan in db.Lands on farm.Land_no equals lan.Land_no
                                 where fw.Emp_id == empID
                                 select new
                                 {
                                     farm.Farm_no,
                                     farm.Farm_name,
                                     lan.Land_City,
                                     farm.Farm_acreage,
                                     AnimalCount = db.Animals.Count(a => a.Farm_No == farm.Farm_no)
                                 }).ToList();
                    dgwField.DataSource = farms;
                }
                else //ANIMANLS
                {
                    lblSpace.Text = "Animals";
                    lnkGoBack.Visible = true;
                    var animal = (from farm in db.Farms
                                  join a in db.Animals on farm.Farm_no equals a.Farm_No
                                  join ex in db.Examinations on a.Animal_id equals ex.Animal_id
                                  where a.Status == true
                                  where farm.Farm_no == farmNo
                                  select new
                                  {
                                      farm.Farm_no,
                                      a.Animal_id,
                                      a.Species,
                                      Age = SqlFunctions.DateDiff("year", a.Birth_date, DateTime.Now),
                                      ex.Visit_date,
                                      ex.Visit_reason,
                                      ex.Treatment_given
                                  }).ToList();
                    dgwField.DataSource = animal;
                }

                //CHART
                var data = db.Farm_work_employee2
                             .Where(fwe => fwe.Emp_id == empID)
                             .Join(db.Farm_Work,
                                fwe => fwe.Work_id,
                                fw => fw.Work_id,
                                (fwe, fw) => fw.Farm_WorkDone)
                             .GroupBy(work => work)
                             .Select(g => new { WorkType = g.Key, Count = g.Count() }).ToList();

                chart1.Series.Clear();
                var series = chart1.Series.Add("Work Frequency");
                series.ChartType = SeriesChartType.Column;

                foreach (var item in data)
                {
                    series.Points.AddXY(item.WorkType, item.Count);
                }
                chart1.ChartAreas[0].AxisX.Interval = 1; // her etiketi göster
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // eğik yazı
            }
        }
        private void LoadBarn(int barnNo)
        {
            lnkGoBack.Visible = false;
            lblInfo.Visible = true;
            lblInfo.Text = "Double click barn to display products in that barn.";
            lblSpace.Text = "Relaated Barn Info.";
            lblWork.Text = "Last Works Done";
            lblStatistic.Text = "Work Done Statistics";
            lblStorageInfo.Visible = false;

            using (var db = new FarmingManagementSystemEntities())
            {
                var empWork = (from ba in db.Barns
                               join st in db.Storing_products on ba.Barn_no equals st.Barn_no
                               where st.Emp_id == empID
                               select new
                               {
                                   st.Barn_no,
                                   ba.Barn_name,
                                   st.Stored_product,
                                   st.Stored_quantity,
                                   st.Stored_date,
                                   st.Field_no,
                                   st.Farm_no,
                                   st.Storing_id
                               }).ToList();
                dgwWork.DataSource = empWork;

                if (barnNo == -1)
                {
                    var farms = (from ba in db.Barns
                                 join w in db.Storing_products on ba.Barn_no equals w.Barn_no
                                 join lan in db.Lands on ba.Land_no equals lan.Land_no
                                 where w.Emp_id == empID
                                 group w by new { ba.Barn_no, ba.Barn_name, ba.Barn_acreage, lan.Land_name, lan.Land_City } into g
                                 select new
                                 {
                                     g.Key.Barn_no,
                                     g.Key.Barn_name,
                                     g.Key.Barn_acreage,
                                     TotalStored = g.Sum(x => x.Stored_quantity),
                                     g.Key.Land_name,
                                     g.Key.Land_City
                                 }).ToList();
                    dgwField.DataSource = farms;
                }
                else //PRODUCTS
                {
                    lblSpace.Text = "Products";
                    lnkGoBack.Visible = true;

                    var animal = (from ba in db.Barns
                                  join w in db.Storing_products on ba.Barn_no equals w.Barn_no
                                  join em in db.Employees on w.Emp_id equals em.Emp_id
                                  where w.Barn_no== barnNo
                                  select new
                                  {
                                      w.Barn_no,
                                    w.Storing_id,
                                    w.Stored_product,
                                    w.Stored_quantity,
                                    w.Stored_date,
                                    w.Field_no,
                                    w.Farm_no,
                                    em.Emp_name
                                  }).ToList();
                    dgwField.DataSource = animal;
                }

                //CHART
                var data = db.Storing_products
                             .Where(s => s.Emp_id == empID)
                             .GroupBy(s => s.Stored_product)
                             .Select(g => new { WorkType = g.Key, Count = g.Count() }).ToList();

                chart1.Series.Clear();
                var series = chart1.Series.Add("Work Frequency");
                series.ChartType = SeriesChartType.Column;

                foreach (var item in data)
                {
                    series.Points.AddXY(item.WorkType, item.Count);
                }
                chart1.ChartAreas[0].AxisX.Interval = 1; // her etiketi göster
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // eğik yazı
            }
        }
        private void LoadStorage(int storageNo)
        {

            //storage info in dgwWork.
            //equi info in dgwField.

            lblWork.Text = "Storage Information";
            lblInfo.Visible = false;
            lnkGoBack.Visible = false;
            lblSpace.Text = "Equipments";
            lblWork.Text = "Related Storages";

            lblStorageInfo.Visible = true;
            lblStorageInfo.Text = "Double click storage to list equipments";

            using (var db = new FarmingManagementSystemEntities())
            {
                var storage = (from stw in db.Storage_work_employee
                               join stor in db.Storages on stw.Storage_no equals stor.Storage_no
                               join lan in db.Lands on stor.Land_no equals lan.Land_no
                               join equi in db.Equipments on stor.Storage_no equals equi.storage_no
                               where stor.Status == true
                               where stw.emp_id == empID
                               group new { stor, lan } by new
                               {
                                   stor.Storage_no,
                                   stor.Storage_Name,
                                   stor.Storage_acreage,
                                   lan.Land_City
                               } into g
                               select new
                               {
                                   g.Key.Storage_no,
                                   g.Key.Storage_Name,
                                   g.Key.Storage_acreage,
                                   g.Key.Land_City,
                                   TotalEquipments = g.Count()
                               }).ToList();
                dgwWork.DataSource = storage;

                //for dgw2
                if(storageNo == -1)
                {
                    var equipments = (from stw in db.Storage_work_employee
                                      join stor in db.Storages on stw.Storage_no equals stor.Storage_no
                                      join equi in db.Equipments on stor.Storage_no equals equi.storage_no
                                      join euse in db.Equipment_Use on equi.Equi_id equals euse.Equi_id
                                      join emp in db.Employees on euse.Emp_id equals emp.Emp_id
                                      where stw.emp_id == empID
                                      where stor.Status == true
                                      select new
                                      {
                                          stor.Storage_no,
                                          equi.Equi_id,
                                          equi.Equi_name,
                                          equi.Status,
                                          euse.Date_receive,
                                          euse.Date_return,
                                          emp.Emp_name,
                                          euse.Emp_id
                                      }).ToList();
                    dgwField.DataSource = equipments;
                }
                else
                {
                    lblStorageInfo.Visible = false;
                    lnkGoBack.Visible = true;
                    var equipments = (from stw in db.Storage_work_employee
                                      join stor in db.Storages on stw.Storage_no equals stor.Storage_no
                                      join equi in db.Equipments on stor.Storage_no equals equi.storage_no
                                      join euse in db.Equipment_Use on equi.Equi_id equals euse.Equi_id
                                      join emp in db.Employees on euse.Emp_id equals emp.Emp_id
                                      where stw.emp_id == empID
                                      where stor.Storage_no == storageNo
                                      select new
                                      {
                                          stor.Storage_no,
                                          equi.Equi_id,
                                          equi.Equi_name,
                                          equi.Status,
                                          euse.Date_receive,
                                          euse.Date_return,
                                          emp.Emp_name,
                                          euse.Emp_id
                                      }).ToList();
                    dgwField.DataSource = equipments;
                }

                //CHART
                lblStatistic.Text = "Equipments Per Storage";
                var data = (from s in db.Storages
                            join e in db.Equipments on s.Storage_no equals e.storage_no
                            join se in db.Storage_work_employee on s.Storage_no equals se.Storage_no
                            where se.emp_id == empID
                            group e by new { s.Storage_no, s.Storage_Name } into g
                            select new
                            {
                                g.Key.Storage_no,
                                g.Key.Storage_Name,
                                EquipmentCount = g.Count()
                            }).ToList();


                chart1.Series.Clear();
                var series = chart1.Series.Add("Equipment Count");
                series.ChartType = SeriesChartType.Column;

                foreach (var item in data)
                {
                    series.Points.AddXY(item.Storage_Name, item.EquipmentCount);
                }

                chart1.ChartAreas[0].AxisX.Interval = 1; // her etiketi göster
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45; // eğik yazı

            }





        }
        private void cmbWorkSpace_TextChanged(object sender, EventArgs e)
        {
            Reload();
        }

        private void dgwField_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cmbWorkSpace.Text =="Farm")
            {
                if (e.RowIndex >= 0)
                {
                    int farmNo;
                    DataGridViewRow row = dgwWork.Rows[e.RowIndex];

                    farmNo = Int32.Parse(row.Cells["Farm_no"].Value.ToString());
                    LoadFarm(farmNo);
                }
            }
            if (cmbWorkSpace.Text == "Barn")
            {
                if (e.RowIndex >= 0)
                {
                    int barnNo;
                    DataGridViewRow row = dgwField.Rows[e.RowIndex];

                    barnNo = Convert.ToInt32(dgwField.Rows[e.RowIndex].Cells[0].Value);
                    LoadBarn(barnNo);
                }
            }
            if(cmbWorkSpace.Text == "Storage")
            {
                if (e.RowIndex >= 0)
                {
                    int storNo;
                    DataGridViewRow row = dgwField.Rows[e.RowIndex];

                    storNo = Convert.ToInt32(dgwField.Rows[e.RowIndex].Cells[0].Value);
                    LoadStorage(storNo);
                }
            }
            

        }

        private void lnkGoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            String space = cmbWorkSpace.Text;
            switch(space)
            {
                case "Farm":
                    LoadFarm(-1);
                    break;
                case "Barn":
                    LoadBarn(-1);
                    break;
                case "Storage":
                    LoadStorage(-1);
                    break;
            }
            
        }

        private void btnAccountManager_Click(object sender, EventArgs e)
        {
            setEmpID(empID);
            AccountManager a = new AccountManager();
            a.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void dgwWork_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(cmbWorkSpace.Text == "Storage")
            {
                if(e.RowIndex >= 0)
                {
                    int storNo;
                    DataGridViewRow row = dgwWork.Rows[e.RowIndex];

                    storNo = Int32.Parse(row.Cells["Storage_No"].Value.ToString());
                    LoadStorage(storNo);
                }
            }
        }

        private void btnRefreshWork_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnRefreshField_Click(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnFarminData_Click(object sender, EventArgs e)
        {
            String text = cmbWorkSpace.Text;
            switch (text)
            {
                case "Field":
                    Field_Work fw = new Field_Work(-1, empID);
                    fw.Show();
                    break;
                case "Farm":
                    Farm_Works fs = new Farm_Works(empID);
                    fs.Show();
                    break;
                case "Barn":
                    ProductsForm p = new ProductsForm(-1, empID);
                    p.Show();
                    break;
                case "Storage":
                    EquipmentsForm eq = new EquipmentsForm(-1, empID);
                    eq.Show();
                    break;
            }
        }
    }
}
