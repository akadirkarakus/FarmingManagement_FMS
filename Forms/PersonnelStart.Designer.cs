namespace FarmingManagement_FMS.Forms
{
    partial class PersonnelStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAccountManager = new System.Windows.Forms.Button();
            this.lblWorkingAreas = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rchAnnounce = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRefreshField = new System.Windows.Forms.Button();
            this.lblStatistic = new System.Windows.Forms.Label();
            this.lblSpace = new System.Windows.Forms.Label();
            this.dgwField = new System.Windows.Forms.DataGridView();
            this.btnRefreshWork = new System.Windows.Forms.Button();
            this.dgwWork = new System.Windows.Forms.DataGridView();
            this.lblWork = new System.Windows.Forms.Label();
            this.cmbWorkSpace = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFarminData = new System.Windows.Forms.Button();
            this.lblStorageInfo = new System.Windows.Forms.Label();
            this.lnkGoBack = new System.Windows.Forms.LinkLabel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(73, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 62);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personnel Start Page";
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(1411, 103);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(174, 72);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMail);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAccountManager);
            this.panel1.Controls.Add(this.lblWorkingAreas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(12, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 307);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(118, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 39);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mail:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblMail.Location = new System.Drawing.Point(178, 102);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(60, 40);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "Mail:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblID.Location = new System.Drawing.Point(178, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 40);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(138, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 39);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(6, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Working Areas:";
            // 
            // btnAccountManager
            // 
            this.btnAccountManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountManager.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAccountManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAccountManager.Location = new System.Drawing.Point(86, 223);
            this.btnAccountManager.Name = "btnAccountManager";
            this.btnAccountManager.Size = new System.Drawing.Size(289, 65);
            this.btnAccountManager.TabIndex = 10;
            this.btnAccountManager.Text = "Account Manager";
            this.btnAccountManager.UseVisualStyleBackColor = true;
            this.btnAccountManager.Click += new System.EventHandler(this.btnAccountManager_Click);
            // 
            // lblWorkingAreas
            // 
            this.lblWorkingAreas.AutoSize = true;
            this.lblWorkingAreas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblWorkingAreas.Location = new System.Drawing.Point(178, 142);
            this.lblWorkingAreas.Name = "lblWorkingAreas";
            this.lblWorkingAreas.Size = new System.Drawing.Size(164, 40);
            this.lblWorkingAreas.TabIndex = 8;
            this.lblWorkingAreas.Text = "Working Areas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(102, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblName.Location = new System.Drawing.Point(178, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 40);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Name:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(669, 65);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(399, 492);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // rchAnnounce
            // 
            this.rchAnnounce.Location = new System.Drawing.Point(12, 543);
            this.rchAnnounce.Name = "rchAnnounce";
            this.rchAnnounce.ReadOnly = true;
            this.rchAnnounce.Size = new System.Drawing.Size(468, 251);
            this.rchAnnounce.TabIndex = 17;
            this.rchAnnounce.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(19, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 40);
            this.label6.TabIndex = 11;
            this.label6.Text = "Announcements:";
            // 
            // btnRefreshField
            // 
            this.btnRefreshField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshField.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnRefreshField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshField.Location = new System.Drawing.Point(539, 318);
            this.btnRefreshField.Name = "btnRefreshField";
            this.btnRefreshField.Size = new System.Drawing.Size(124, 40);
            this.btnRefreshField.TabIndex = 65;
            this.btnRefreshField.Text = "Refresh";
            this.btnRefreshField.UseVisualStyleBackColor = true;
            this.btnRefreshField.Click += new System.EventHandler(this.btnRefreshField_Click);
            // 
            // lblStatistic
            // 
            this.lblStatistic.AutoSize = true;
            this.lblStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblStatistic.Location = new System.Drawing.Point(710, 22);
            this.lblStatistic.Name = "lblStatistic";
            this.lblStatistic.Size = new System.Drawing.Size(223, 40);
            this.lblStatistic.TabIndex = 64;
            this.lblStatistic.Text = "Work Done Statistics";
            // 
            // lblSpace
            // 
            this.lblSpace.AutoSize = true;
            this.lblSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblSpace.Location = new System.Drawing.Point(194, 322);
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(260, 40);
            this.lblSpace.TabIndex = 63;
            this.lblSpace.Text = "Related Field Information";
            this.lblSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgwField
            // 
            this.dgwField.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwField.Location = new System.Drawing.Point(10, 361);
            this.dgwField.Name = "dgwField";
            this.dgwField.RowHeadersWidth = 62;
            this.dgwField.RowTemplate.Height = 28;
            this.dgwField.Size = new System.Drawing.Size(653, 237);
            this.dgwField.TabIndex = 62;
            this.dgwField.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwField_CellDoubleClick);
            // 
            // btnRefreshWork
            // 
            this.btnRefreshWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshWork.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnRefreshWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefreshWork.Location = new System.Drawing.Point(539, 22);
            this.btnRefreshWork.Name = "btnRefreshWork";
            this.btnRefreshWork.Size = new System.Drawing.Size(124, 40);
            this.btnRefreshWork.TabIndex = 61;
            this.btnRefreshWork.Text = "Refresh";
            this.btnRefreshWork.UseVisualStyleBackColor = true;
            this.btnRefreshWork.Click += new System.EventHandler(this.btnRefreshWork_Click);
            // 
            // dgwWork
            // 
            this.dgwWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwWork.Location = new System.Drawing.Point(10, 63);
            this.dgwWork.Name = "dgwWork";
            this.dgwWork.RowHeadersWidth = 62;
            this.dgwWork.RowTemplate.Height = 28;
            this.dgwWork.Size = new System.Drawing.Size(653, 233);
            this.dgwWork.TabIndex = 17;
            this.dgwWork.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwWork_CellDoubleClick);
            // 
            // lblWork
            // 
            this.lblWork.AutoSize = true;
            this.lblWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblWork.Location = new System.Drawing.Point(254, 22);
            this.lblWork.Name = "lblWork";
            this.lblWork.Size = new System.Drawing.Size(181, 40);
            this.lblWork.TabIndex = 11;
            this.lblWork.Text = "Last Works Done";
            // 
            // cmbWorkSpace
            // 
            this.cmbWorkSpace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWorkSpace.FormattingEnabled = true;
            this.cmbWorkSpace.Location = new System.Drawing.Point(709, 135);
            this.cmbWorkSpace.Name = "cmbWorkSpace";
            this.cmbWorkSpace.Size = new System.Drawing.Size(177, 48);
            this.cmbWorkSpace.TabIndex = 19;
            this.cmbWorkSpace.TextChanged += new System.EventHandler(this.cmbWorkSpace_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(512, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 40);
            this.label8.TabIndex = 17;
            this.label8.Text = "Select Work Area:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnFarminData);
            this.panel2.Controls.Add(this.lblStorageInfo);
            this.panel2.Controls.Add(this.lnkGoBack);
            this.panel2.Controls.Add(this.lblInfo);
            this.panel2.Controls.Add(this.btnRefreshField);
            this.panel2.Controls.Add(this.lblWork);
            this.panel2.Controls.Add(this.lblStatistic);
            this.panel2.Controls.Add(this.chart1);
            this.panel2.Controls.Add(this.lblSpace);
            this.panel2.Controls.Add(this.dgwWork);
            this.panel2.Controls.Add(this.dgwField);
            this.panel2.Controls.Add(this.btnRefreshWork);
            this.panel2.Location = new System.Drawing.Point(498, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1088, 641);
            this.panel2.TabIndex = 20;
            // 
            // btnFarminData
            // 
            this.btnFarminData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarminData.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnFarminData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFarminData.Location = new System.Drawing.Point(669, 564);
            this.btnFarminData.Name = "btnFarminData";
            this.btnFarminData.Size = new System.Drawing.Size(399, 72);
            this.btnFarminData.TabIndex = 66;
            this.btnFarminData.Text = "Manage Farming Data";
            this.btnFarminData.UseVisualStyleBackColor = true;
            this.btnFarminData.Click += new System.EventHandler(this.btnFarminData_Click);
            // 
            // lblStorageInfo
            // 
            this.lblStorageInfo.AutoSize = true;
            this.lblStorageInfo.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic);
            this.lblStorageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblStorageInfo.Location = new System.Drawing.Point(177, 295);
            this.lblStorageInfo.Name = "lblStorageInfo";
            this.lblStorageInfo.Size = new System.Drawing.Size(301, 28);
            this.lblStorageInfo.TabIndex = 68;
            this.lblStorageInfo.Text = "Double click storage to list equipments";
            // 
            // lnkGoBack
            // 
            this.lnkGoBack.AutoSize = true;
            this.lnkGoBack.LinkColor = System.Drawing.Color.Yellow;
            this.lnkGoBack.Location = new System.Drawing.Point(13, 319);
            this.lnkGoBack.Name = "lnkGoBack";
            this.lnkGoBack.Size = new System.Drawing.Size(95, 40);
            this.lnkGoBack.TabIndex = 67;
            this.lnkGoBack.TabStop = true;
            this.lnkGoBack.Text = "Go Back";
            this.lnkGoBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGoBack_LinkClicked);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Italic);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblInfo.Location = new System.Drawing.Point(15, 601);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(38, 28);
            this.lblInfo.TabIndex = 66;
            this.lblInfo.Text = "Info";
            // 
            // PersonnelStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1597, 834);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbWorkSpace);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rchAnnounce);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "PersonnelStart";
            this.Text = "Farming Management System";
            this.Load += new System.EventHandler(this.PersonnelStart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWork)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWorkingAreas;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnAccountManager;
        private System.Windows.Forms.RichTextBox rchAnnounce;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgwWork;
        private System.Windows.Forms.Label lblWork;
        private System.Windows.Forms.ComboBox cmbWorkSpace;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStatistic;
        private System.Windows.Forms.Label lblSpace;
        private System.Windows.Forms.DataGridView dgwField;
        private System.Windows.Forms.Button btnRefreshWork;
        private System.Windows.Forms.Button btnRefreshField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFarminData;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.LinkLabel lnkGoBack;
        private System.Windows.Forms.Label lblStorageInfo;
    }
}