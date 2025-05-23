namespace FarmingManagement_FMS.Forms
{
    partial class Farm_Works
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Farm_Works));
            this.label1 = new System.Windows.Forms.Label();
            this.pcFarm = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFarmName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtWorkDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFarmNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbFarms = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(364, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 72);
            this.label1.TabIndex = 63;
            this.label1.Text = "Add Work";
            // 
            // pcFarm
            // 
            this.pcFarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFarm.Image = ((System.Drawing.Image)(resources.GetObject("pcFarm.Image")));
            this.pcFarm.Location = new System.Drawing.Point(557, 22);
            this.pcFarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcFarm.Name = "pcFarm";
            this.pcFarm.Size = new System.Drawing.Size(191, 147);
            this.pcFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFarm.TabIndex = 67;
            this.pcFarm.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(925, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 66;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFarmName
            // 
            this.lblFarmName.AutoSize = true;
            this.lblFarmName.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.lblFarmName.ForeColor = System.Drawing.Color.Gold;
            this.lblFarmName.Location = new System.Drawing.Point(24, 127);
            this.lblFarmName.Name = "lblFarmName";
            this.lblFarmName.Size = new System.Drawing.Size(98, 50);
            this.lblFarmName.TabIndex = 65;
            this.lblFarmName.Text = "Farm:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtWorkDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFarmNo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Location = new System.Drawing.Point(12, 486);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 258);
            this.panel2.TabIndex = 64;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(342, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 48);
            this.comboBox1.TabIndex = 57;
            // 
            // txtWorkDate
            // 
            this.txtWorkDate.Location = new System.Drawing.Point(342, 139);
            this.txtWorkDate.Name = "txtWorkDate";
            this.txtWorkDate.Size = new System.Drawing.Size(228, 45);
            this.txtWorkDate.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(214, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 40);
            this.label3.TabIndex = 56;
            this.label3.Text = "Work Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(241, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 40);
            this.label2.TabIndex = 53;
            this.label2.Text = "Farm No:";
            // 
            // txtFarmNo
            // 
            this.txtFarmNo.Enabled = false;
            this.txtFarmNo.Location = new System.Drawing.Point(342, 37);
            this.txtFarmNo.Name = "txtFarmNo";
            this.txtFarmNo.Size = new System.Drawing.Size(228, 45);
            this.txtFarmNo.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(214, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 40);
            this.label8.TabIndex = 45;
            this.label8.Text = "Work Done:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(248, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 40);
            this.label10.TabIndex = 47;
            this.label10.Text = "Emp ID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(342, 88);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(228, 45);
            this.txtEmpID.TabIndex = 51;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean.Location = new System.Drawing.Point(794, 486);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(255, 58);
            this.btnClean.TabIndex = 60;
            this.btnClean.Text = "Clean Textboxes";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnWork
            // 
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWork.Location = new System.Drawing.Point(794, 660);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(257, 78);
            this.btnWork.TabIndex = 52;
            this.btnWork.Text = "Apply Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(26, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 40);
            this.label5.TabIndex = 58;
            this.label5.Text = "Work";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1037, 285);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 18F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(794, 574);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 78);
            this.button2.TabIndex = 61;
            this.button2.Text = "Display Employees";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbFarms
            // 
            this.cmbFarms.FormattingEnabled = true;
            this.cmbFarms.Location = new System.Drawing.Point(118, 130);
            this.cmbFarms.Name = "cmbFarms";
            this.cmbFarms.Size = new System.Drawing.Size(121, 48);
            this.cmbFarms.TabIndex = 68;
            this.cmbFarms.TextChanged += new System.EventHandler(this.cmbFarms_TextChanged);
            // 
            // Farm_Works
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1061, 760);
            this.Controls.Add(this.cmbFarms);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcFarm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFarmName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Farm_Works";
            this.Text = "Farm_Work";
            this.Load += new System.EventHandler(this.Farm_Work_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcFarm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFarmName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtWorkDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFarmNo;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbFarms;
    }
}