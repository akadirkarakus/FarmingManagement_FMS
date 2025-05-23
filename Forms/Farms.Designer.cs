namespace FarmingManagement_FMS.Forms
{
    partial class Farms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farms));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLandNo = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcreage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPersonnelStatus = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcFarm = new System.Windows.Forms.PictureBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(679, 544);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(287, 80);
            this.btnAdd.TabIndex = 44;
            this.btnAdd.Text = "Add New Farm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(679, 719);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(285, 83);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete Selected Farm";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(278, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 72);
            this.label1.TabIndex = 42;
            this.label1.Text = "Manage Farms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(954, 348);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(477, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // txtLandNo
            // 
            this.txtLandNo.Location = new System.Drawing.Point(243, 184);
            this.txtLandNo.Name = "txtLandNo";
            this.txtLandNo.Size = new System.Drawing.Size(228, 45);
            this.txtLandNo.TabIndex = 31;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(243, 31);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(228, 45);
            this.txtID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(12, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 40);
            this.label6.TabIndex = 43;
            this.label6.Text = "Selected Farm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(198, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.TabIndex = 23;
            this.label7.Text = "ID:";
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean.Location = new System.Drawing.Point(503, 185);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(158, 48);
            this.btnClean.TabIndex = 30;
            this.btnClean.Text = "Clean Textboxes";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(105, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Farm Name:";
            // 
            // txtAcreage
            // 
            this.txtAcreage.Location = new System.Drawing.Point(243, 133);
            this.txtAcreage.Name = "txtAcreage";
            this.txtAcreage.Size = new System.Drawing.Size(228, 45);
            this.txtAcreage.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(79, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "Farm Acreage:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(243, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 45);
            this.txtName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(141, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "Land No:";
            // 
            // chkPersonnelStatus
            // 
            this.chkPersonnelStatus.AutoSize = true;
            this.chkPersonnelStatus.Checked = true;
            this.chkPersonnelStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPersonnelStatus.Font = new System.Drawing.Font("Agency FB", 14F);
            this.chkPersonnelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkPersonnelStatus.Location = new System.Drawing.Point(12, 146);
            this.chkPersonnelStatus.Name = "chkPersonnelStatus";
            this.chkPersonnelStatus.Size = new System.Drawing.Size(264, 37);
            this.chkPersonnelStatus.TabIndex = 49;
            this.chkPersonnelStatus.Text = "Displaying active lands only.";
            this.chkPersonnelStatus.UseVisualStyleBackColor = true;
            this.chkPersonnelStatus.CheckedChanged += new System.EventHandler(this.chkPersonnelStatus_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(840, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 48;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(679, 630);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(287, 83);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update Farm Info.";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtLandNo);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAcreage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(7, 557);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 245);
            this.panel1.TabIndex = 46;
            // 
            // pcFarm
            // 
            this.pcFarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFarm.Image = ((System.Drawing.Image)(resources.GetObject("pcFarm.Image")));
            this.pcFarm.Location = new System.Drawing.Point(574, 12);
            this.pcFarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcFarm.Name = "pcFarm";
            this.pcFarm.Size = new System.Drawing.Size(191, 147);
            this.pcFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFarm.TabIndex = 50;
            this.pcFarm.TabStop = false;
            // 
            // btnWork
            // 
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnWork.Location = new System.Drawing.Point(679, 812);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(285, 70);
            this.btnWork.TabIndex = 51;
            this.btnWork.Text = "Apply a Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAnimal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnimal.Location = new System.Drawing.Point(7, 812);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(285, 70);
            this.btnAnimal.TabIndex = 53;
            this.btnAnimal.Text = "Display Animals";
            this.btnAnimal.UseVisualStyleBackColor = true;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // Farms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(983, 894);
            this.Controls.Add(this.btnAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.pcFarm);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPersonnelStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Agency FB", 16F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Farms";
            this.Text = "Farms";
            this.Load += new System.EventHandler(this.Farms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLandNo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcreage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPersonnelStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pcFarm;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnAnimal;
    }
}