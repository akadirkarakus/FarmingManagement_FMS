namespace FarmingManagement_FMS.Forms
{
    partial class Fields
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fields));
            this.chkPersonnelStatus = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLand = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPlantDate = new System.Windows.Forms.TextBox();
            this.btnSeed = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLandNo = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.txtFieldNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAcreage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcField = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcField)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPersonnelStatus
            // 
            this.chkPersonnelStatus.AutoSize = true;
            this.chkPersonnelStatus.Checked = true;
            this.chkPersonnelStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPersonnelStatus.Font = new System.Drawing.Font("Agency FB", 14F);
            this.chkPersonnelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkPersonnelStatus.Location = new System.Drawing.Point(28, 131);
            this.chkPersonnelStatus.Name = "chkPersonnelStatus";
            this.chkPersonnelStatus.Size = new System.Drawing.Size(262, 37);
            this.chkPersonnelStatus.TabIndex = 40;
            this.chkPersonnelStatus.Text = "Displaying active fields only.";
            this.chkPersonnelStatus.UseVisualStyleBackColor = true;
            this.chkPersonnelStatus.CheckedChanged += new System.EventHandler(this.chkPersonnelStatus_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(879, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 39;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(688, 90);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(285, 73);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update Field Info.";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(25, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 40);
            this.label6.TabIndex = 34;
            this.label6.Text = "Selected Field";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLand);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPlantDate);
            this.panel1.Controls.Add(this.btnSeed);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtLandNo);
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.btnWork);
            this.panel1.Controls.Add(this.txtFieldNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAcreage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Location = new System.Drawing.Point(16, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 335);
            this.panel1.TabIndex = 37;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLand
            // 
            this.btnLand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLand.Font = new System.Drawing.Font("Agency FB", 15F);
            this.btnLand.ForeColor = System.Drawing.Color.Linen;
            this.btnLand.Location = new System.Drawing.Point(15, 234);
            this.btnLand.Name = "btnLand";
            this.btnLand.Size = new System.Drawing.Size(139, 94);
            this.btnLand.TabIndex = 55;
            this.btnLand.Text = "Display Lands";
            this.btnLand.UseVisualStyleBackColor = true;
            this.btnLand.Click += new System.EventHandler(this.btnLand_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(345, 275);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 45);
            this.textBox1.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(202, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 40);
            this.label8.TabIndex = 47;
            this.label8.Text = "Seed Genus:";
            // 
            // txtPlantDate
            // 
            this.txtPlantDate.Location = new System.Drawing.Point(345, 224);
            this.txtPlantDate.Name = "txtPlantDate";
            this.txtPlantDate.Size = new System.Drawing.Size(228, 45);
            this.txtPlantDate.TabIndex = 46;
            // 
            // btnSeed
            // 
            this.btnSeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeed.Font = new System.Drawing.Font("Agency FB", 15F);
            this.btnSeed.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSeed.Location = new System.Drawing.Point(15, 134);
            this.btnSeed.Name = "btnSeed";
            this.btnSeed.Size = new System.Drawing.Size(139, 93);
            this.btnSeed.TabIndex = 44;
            this.btnSeed.Text = "Display Seed Info.";
            this.btnSeed.UseVisualStyleBackColor = true;
            this.btnSeed.Click += new System.EventHandler(this.btnSeed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(579, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(188, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 40);
            this.label4.TabIndex = 45;
            this.label4.Text = "Planting Date:";
            // 
            // txtLandNo
            // 
            this.txtLandNo.Location = new System.Drawing.Point(345, 173);
            this.txtLandNo.Name = "txtLandNo";
            this.txtLandNo.Size = new System.Drawing.Size(228, 45);
            this.txtLandNo.TabIndex = 31;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean.Location = new System.Drawing.Point(15, 36);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(139, 91);
            this.btnClean.TabIndex = 30;
            this.btnClean.Text = "Clean Textboxes";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnWork
            // 
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnWork.Location = new System.Drawing.Point(688, 250);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(285, 70);
            this.btnWork.TabIndex = 42;
            this.btnWork.Text = "Apply a Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // txtFieldNo
            // 
            this.txtFieldNo.Location = new System.Drawing.Point(345, 20);
            this.txtFieldNo.Name = "txtFieldNo";
            this.txtFieldNo.ReadOnly = true;
            this.txtFieldNo.Size = new System.Drawing.Size(228, 45);
            this.txtFieldNo.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(244, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 40);
            this.label7.TabIndex = 23;
            this.label7.Text = "Field No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(213, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 40);
            this.label2.TabIndex = 14;
            this.label2.Text = "Field Name:";
            // 
            // txtAcreage
            // 
            this.txtAcreage.Location = new System.Drawing.Point(345, 122);
            this.txtAcreage.Name = "txtAcreage";
            this.txtAcreage.Size = new System.Drawing.Size(228, 45);
            this.txtAcreage.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(236, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 40);
            this.label5.TabIndex = 19;
            this.label5.Text = "Acreage:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(345, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 45);
            this.txtName.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(242, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 40);
            this.label3.TabIndex = 16;
            this.label3.Text = "Land No:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(688, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(285, 70);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Add New Field";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(688, 171);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(285, 73);
            this.btnDelete.TabIndex = 36;
            this.btnDelete.Text = "Delete Selected Field";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(319, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 72);
            this.label1.TabIndex = 33;
            this.label1.Text = "Manage Fields";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(985, 442);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // pcField
            // 
            this.pcField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcField.Image = ((System.Drawing.Image)(resources.GetObject("pcField.Image")));
            this.pcField.Location = new System.Drawing.Point(597, 14);
            this.pcField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcField.Name = "pcField";
            this.pcField.Size = new System.Drawing.Size(145, 147);
            this.pcField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcField.TabIndex = 41;
            this.pcField.TabStop = false;
            // 
            // Fields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1025, 987);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcField);
            this.Controls.Add(this.chkPersonnelStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Fields";
            this.Text = "Fields - FMS";
            this.Load += new System.EventHandler(this.Fields_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPersonnelStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtLandNo;
        private System.Windows.Forms.TextBox txtFieldNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAcreage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pcField;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnSeed;
        private System.Windows.Forms.TextBox txtPlantDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLand;
    }
}