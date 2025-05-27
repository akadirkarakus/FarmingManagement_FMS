namespace FarmingManagement_FMS.Forms
{
    partial class EquipmentsForm
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
            this.lblBarnNo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtEquiID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkPersonnelStatus = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.btnUpdateUsage = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEquiID2 = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtReturn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReceive = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBarnNo
            // 
            this.lblBarnNo.AutoSize = true;
            this.lblBarnNo.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.lblBarnNo.ForeColor = System.Drawing.Color.Gold;
            this.lblBarnNo.Location = new System.Drawing.Point(12, 137);
            this.lblBarnNo.Name = "lblBarnNo";
            this.lblBarnNo.Size = new System.Drawing.Size(119, 44);
            this.lblBarnNo.TabIndex = 76;
            this.lblBarnNo.Text = "Storage:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.txtEquiID);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 619);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 297);
            this.panel1.TabIndex = 75;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 80;
            this.label3.Text = "Equipment Info.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(24, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 40);
            this.label2.TabIndex = 80;
            this.label2.Text = "Equi Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(156, 184);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 45);
            this.txtName.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(61, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 40);
            this.label5.TabIndex = 62;
            this.label5.Text = "Equi ID:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(464, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 57;
            this.button1.Text = "Clean Textboxes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(156, 82);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(228, 45);
            this.txtNo.TabIndex = 45;
            // 
            // txtEquiID
            // 
            this.txtEquiID.Location = new System.Drawing.Point(156, 133);
            this.txtEquiID.Name = "txtEquiID";
            this.txtEquiID.ReadOnly = true;
            this.txtEquiID.Size = new System.Drawing.Size(228, 45);
            this.txtEquiID.TabIndex = 47;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 15F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(390, 61);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(232, 64);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Delete Equipment";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 15F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(390, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 64);
            this.btnAdd.TabIndex = 72;
            this.btnAdd.Text = "Add Equipment";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 15F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(390, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 64);
            this.btnUpdate.TabIndex = 74;
            this.btnUpdate.Text = "Update Equipment Info.";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(19, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 40);
            this.label7.TabIndex = 50;
            this.label7.Text = "Storage No:";
            // 
            // chkPersonnelStatus
            // 
            this.chkPersonnelStatus.AutoSize = true;
            this.chkPersonnelStatus.Checked = true;
            this.chkPersonnelStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPersonnelStatus.Font = new System.Drawing.Font("Agency FB", 14F);
            this.chkPersonnelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkPersonnelStatus.Location = new System.Drawing.Point(12, 576);
            this.chkPersonnelStatus.Name = "chkPersonnelStatus";
            this.chkPersonnelStatus.Size = new System.Drawing.Size(305, 37);
            this.chkPersonnelStatus.TabIndex = 78;
            this.chkPersonnelStatus.Text = "Displaying active euipments only.";
            this.chkPersonnelStatus.UseVisualStyleBackColor = true;
            this.chkPersonnelStatus.CheckedChanged += new System.EventHandler(this.chkPersonnelStatus_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(1098, 144);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 40);
            this.btnRefresh.TabIndex = 71;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1212, 383);
            this.dataGridView1.TabIndex = 69;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(406, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 72);
            this.label1.TabIndex = 70;
            this.label1.Text = "Manage Equipments";
            // 
            // cmbStorage
            // 
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(124, 137);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(105, 48);
            this.cmbStorage.TabIndex = 77;
            this.cmbStorage.TextChanged += new System.EventHandler(this.cmbStorage_TextChanged);
            // 
            // btnUpdateUsage
            // 
            this.btnUpdateUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUsage.Font = new System.Drawing.Font("Agency FB", 15F);
            this.btnUpdateUsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateUsage.Location = new System.Drawing.Point(262, 265);
            this.btnUpdateUsage.Name = "btnUpdateUsage";
            this.btnUpdateUsage.Size = new System.Drawing.Size(228, 66);
            this.btnUpdateUsage.TabIndex = 78;
            this.btnUpdateUsage.Text = "Update Usage Info.";
            this.btnUpdateUsage.UseVisualStyleBackColor = true;
            this.btnUpdateUsage.Click += new System.EventHandler(this.btnUpdateUsage_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnUpdateUsage);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtEquiID2);
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Controls.Add(this.txtReturn);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtReceive);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Location = new System.Drawing.Point(662, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 336);
            this.panel2.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(13, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 40);
            this.label4.TabIndex = 81;
            this.label4.Text = "Equipment Use Info.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(167, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 40);
            this.label8.TabIndex = 80;
            this.label8.Text = "Equi ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(114, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 40);
            this.label6.TabIndex = 64;
            this.label6.Text = "Return Date:";
            // 
            // txtEquiID2
            // 
            this.txtEquiID2.Location = new System.Drawing.Point(262, 61);
            this.txtEquiID2.Name = "txtEquiID2";
            this.txtEquiID2.Size = new System.Drawing.Size(228, 45);
            this.txtEquiID2.TabIndex = 79;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(262, 214);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(228, 45);
            this.txtEmpID.TabIndex = 63;
            // 
            // txtReturn
            // 
            this.txtReturn.Location = new System.Drawing.Point(262, 163);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(228, 45);
            this.txtReturn.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(13, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(240, 40);
            this.label9.TabIndex = 60;
            this.label9.Text = "Last User Employee ID:";
            // 
            // txtReceive
            // 
            this.txtReceive.Location = new System.Drawing.Point(262, 112);
            this.txtReceive.Name = "txtReceive";
            this.txtReceive.Size = new System.Drawing.Size(228, 45);
            this.txtReceive.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(107, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 40);
            this.label10.TabIndex = 58;
            this.label10.Text = "Receive Date:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Location = new System.Drawing.Point(398, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 48);
            this.button3.TabIndex = 57;
            this.button3.Text = "Clean Textboxes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EquipmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1239, 931);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chkPersonnelStatus);
            this.Controls.Add(this.cmbStorage);
            this.Controls.Add(this.lblBarnNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "EquipmentsForm";
            this.Text = "Equipments - FMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EquipmentsForm_FormClosed);
            this.Load += new System.EventHandler(this.EquipmentsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBarnNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtEquiID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkPersonnelStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdateUsage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEquiID2;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReceive;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}