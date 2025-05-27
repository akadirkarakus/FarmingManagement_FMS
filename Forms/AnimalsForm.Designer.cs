namespace FarmingManagement_FMS.Forms
{
    partial class AnimalsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalsForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pcFarm = new System.Windows.Forms.PictureBox();
            this.lblFarmName = new System.Windows.Forms.Label();
            this.txtBdate = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFarmNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSpecies = new System.Windows.Forms.ComboBox();
            this.btnClean2 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtVisitDate = new System.Windows.Forms.TextBox();
            this.txtVisitReason = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtVetID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnAddExamination = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbFarmNo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1378, 406);
            this.dataGridView1.TabIndex = 63;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(553, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 72);
            this.label1.TabIndex = 68;
            this.label1.Text = "Animals";
            // 
            // pcFarm
            // 
            this.pcFarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFarm.Image = ((System.Drawing.Image)(resources.GetObject("pcFarm.Image")));
            this.pcFarm.Location = new System.Drawing.Point(703, 31);
            this.pcFarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcFarm.Name = "pcFarm";
            this.pcFarm.Size = new System.Drawing.Size(191, 147);
            this.pcFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFarm.TabIndex = 69;
            this.pcFarm.TabStop = false;
            // 
            // lblFarmName
            // 
            this.lblFarmName.AutoSize = true;
            this.lblFarmName.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.lblFarmName.ForeColor = System.Drawing.Color.Gold;
            this.lblFarmName.Location = new System.Drawing.Point(28, 148);
            this.lblFarmName.Name = "lblFarmName";
            this.lblFarmName.Size = new System.Drawing.Size(98, 50);
            this.lblFarmName.TabIndex = 70;
            this.lblFarmName.Text = "Farm:";
            // 
            // txtBdate
            // 
            this.txtBdate.Location = new System.Drawing.Point(137, 239);
            this.txtBdate.Name = "txtBdate";
            this.txtBdate.Size = new System.Drawing.Size(228, 45);
            this.txtBdate.TabIndex = 78;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(137, 82);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(228, 45);
            this.txtID.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(20, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 40);
            this.label7.TabIndex = 77;
            this.label7.Text = "Animal ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 71;
            this.label2.Text = "Farm No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(27, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 40);
            this.label5.TabIndex = 75;
            this.label5.Text = "Speicies:";
            // 
            // txtFarmNo
            // 
            this.txtFarmNo.Location = new System.Drawing.Point(137, 133);
            this.txtFarmNo.Name = "txtFarmNo";
            this.txtFarmNo.Size = new System.Drawing.Size(228, 45);
            this.txtFarmNo.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(11, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 40);
            this.label3.TabIndex = 73;
            this.label3.Text = "Birth Date:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbSpecies);
            this.panel1.Controls.Add(this.btnClean2);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.txtBdate);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtFarmNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(23, 626);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 336);
            this.panel1.TabIndex = 79;
            // 
            // cmbSpecies
            // 
            this.cmbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpecies.FormattingEnabled = true;
            this.cmbSpecies.Location = new System.Drawing.Point(137, 184);
            this.cmbSpecies.Name = "cmbSpecies";
            this.cmbSpecies.Size = new System.Drawing.Size(228, 48);
            this.cmbSpecies.TabIndex = 97;
            // 
            // btnClean2
            // 
            this.btnClean2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean2.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnClean2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean2.Location = new System.Drawing.Point(499, 3);
            this.btnClean2.Name = "btnClean2";
            this.btnClean2.Size = new System.Drawing.Size(158, 48);
            this.btnClean2.TabIndex = 96;
            this.btnClean2.Text = "Clean Textboxes";
            this.btnClean2.UseVisualStyleBackColor = true;
            this.btnClean2.Click += new System.EventHandler(this.btnClean2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(380, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(277, 80);
            this.btnAdd.TabIndex = 92;
            this.btnAdd.Text = "Add New Animal";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(380, 231);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(277, 83);
            this.btnDelete.TabIndex = 93;
            this.btnDelete.Text = "Delete Selected Animal";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(380, 142);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(277, 83);
            this.btnUpdate.TabIndex = 94;
            this.btnUpdate.Text = "Update Animal Info.";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtVisitDate
            // 
            this.txtVisitDate.Location = new System.Drawing.Point(214, 82);
            this.txtVisitDate.Name = "txtVisitDate";
            this.txtVisitDate.Size = new System.Drawing.Size(228, 45);
            this.txtVisitDate.TabIndex = 80;
            // 
            // txtVisitReason
            // 
            this.txtVisitReason.Location = new System.Drawing.Point(214, 131);
            this.txtVisitReason.Name = "txtVisitReason";
            this.txtVisitReason.Size = new System.Drawing.Size(228, 45);
            this.txtVisitReason.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(98, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 40);
            this.label6.TabIndex = 85;
            this.label6.Text = "Visit Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(86, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 40);
            this.label8.TabIndex = 83;
            this.label8.Text = "Treatment:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(70, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 40);
            this.label9.TabIndex = 79;
            this.label9.Text = "Visit Reason:";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(214, 180);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(228, 45);
            this.txtTreatment.TabIndex = 84;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtVetID);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnAddExamination);
            this.panel2.Controls.Add(this.txtVisitDate);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtTreatment);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtVisitReason);
            this.panel2.Location = new System.Drawing.Point(700, 626);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(701, 336);
            this.panel2.TabIndex = 89;
            // 
            // txtVetID
            // 
            this.txtVetID.Location = new System.Drawing.Point(214, 229);
            this.txtVetID.Name = "txtVetID";
            this.txtVetID.Size = new System.Drawing.Size(228, 45);
            this.txtVetID.TabIndex = 99;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(134, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 40);
            this.label13.TabIndex = 98;
            this.label13.Text = "Vet ID:";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 18F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(459, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 104);
            this.button2.TabIndex = 97;
            this.button2.Text = "Display Vets";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean.Location = new System.Drawing.Point(533, 6);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(158, 48);
            this.btnClean.TabIndex = 92;
            this.btnClean.Text = "Clean Textboxes";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnAddExamination
            // 
            this.btnAddExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExamination.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAddExamination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddExamination.Location = new System.Drawing.Point(459, 182);
            this.btnAddExamination.Name = "btnAddExamination";
            this.btnAddExamination.Size = new System.Drawing.Size(219, 104);
            this.btnAddExamination.TabIndex = 95;
            this.btnAddExamination.Text = "Add New Examination";
            this.btnAddExamination.UseVisualStyleBackColor = true;
            this.btnAddExamination.Click += new System.EventHandler(this.btnAddExamination_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(41, 610);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 40);
            this.label11.TabIndex = 90;
            this.label11.Text = "Animal Info.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(715, 610);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(184, 40);
            this.label12.TabIndex = 91;
            this.label12.Text = "Examination Info.";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(1277, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 93;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cmbFarmNo
            // 
            this.cmbFarmNo.FormattingEnabled = true;
            this.cmbFarmNo.Location = new System.Drawing.Point(120, 151);
            this.cmbFarmNo.Name = "cmbFarmNo";
            this.cmbFarmNo.Size = new System.Drawing.Size(121, 48);
            this.cmbFarmNo.TabIndex = 94;
            this.cmbFarmNo.TextChanged += new System.EventHandler(this.cmbFarmNo_TextChanged);
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1416, 985);
            this.Controls.Add(this.cmbFarmNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblFarmName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcFarm);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "AnimalsForm";
            this.Text = "Animals - FMS";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcFarm;
        private System.Windows.Forms.Label lblFarmName;
        private System.Windows.Forms.TextBox txtBdate;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFarmNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVisitDate;
        private System.Windows.Forms.TextBox txtVisitReason;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddExamination;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClean2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtVetID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbSpecies;
        private System.Windows.Forms.ComboBox cmbFarmNo;
    }
}