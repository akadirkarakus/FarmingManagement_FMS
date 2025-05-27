namespace FarmingManagement_FMS.Forms
{
    partial class Field_Work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Field_Work));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDisplaySeed = new System.Windows.Forms.Button();
            this.btnWork = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbSeed = new System.Windows.Forms.ComboBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtWorkDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFieldNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFieldName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pcFarm = new System.Windows.Forms.PictureBox();
            this.cmbFarms = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(839, 292);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(294, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 72);
            this.label1.TabIndex = 42;
            this.label1.Text = "Add Work";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(300, 89);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(228, 45);
            this.txtEmpID.TabIndex = 51;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(161, 248);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 40);
            this.label9.TabIndex = 49;
            this.label9.Text = "Seed Genus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(206, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 40);
            this.label10.TabIndex = 47;
            this.label10.Text = "Emp ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(172, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 40);
            this.label8.TabIndex = 45;
            this.label8.Text = "Work Done:";
            // 
            // btnDisplaySeed
            // 
            this.btnDisplaySeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplaySeed.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDisplaySeed.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnDisplaySeed.Location = new System.Drawing.Point(534, 38);
            this.btnDisplaySeed.Name = "btnDisplaySeed";
            this.btnDisplaySeed.Size = new System.Drawing.Size(255, 57);
            this.btnDisplaySeed.TabIndex = 53;
            this.btnDisplaySeed.Text = "Display Seed Info.";
            this.btnDisplaySeed.UseVisualStyleBackColor = true;
            this.btnDisplaySeed.Click += new System.EventHandler(this.btnDisplaySeed_Click);
            // 
            // btnWork
            // 
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnWork.Location = new System.Drawing.Point(538, 215);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(257, 78);
            this.btnWork.TabIndex = 52;
            this.btnWork.Text = "Apply Work";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.cmbSeed);
            this.panel2.Controls.Add(this.btnClean);
            this.panel2.Controls.Add(this.btnDisplaySeed);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.txtWorkDate);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtFieldNo);
            this.panel2.Controls.Add(this.btnWork);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtEmpID);
            this.panel2.Location = new System.Drawing.Point(16, 473);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 310);
            this.panel2.TabIndex = 56;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Agency FB", 18F);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(534, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 58);
            this.button2.TabIndex = 62;
            this.button2.Text = "Display Employees";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSeed
            // 
            this.cmbSeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeed.FormattingEnabled = true;
            this.cmbSeed.Location = new System.Drawing.Point(300, 245);
            this.cmbSeed.Name = "cmbSeed";
            this.cmbSeed.Size = new System.Drawing.Size(228, 48);
            this.cmbSeed.TabIndex = 61;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean.Location = new System.Drawing.Point(6, 214);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(108, 88);
            this.btnClean.TabIndex = 60;
            this.btnClean.Text = "Clean Textboxes";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(300, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 48);
            this.comboBox1.TabIndex = 57;
            // 
            // txtWorkDate
            // 
            this.txtWorkDate.Location = new System.Drawing.Point(300, 140);
            this.txtWorkDate.Name = "txtWorkDate";
            this.txtWorkDate.Size = new System.Drawing.Size(228, 45);
            this.txtWorkDate.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(172, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 40);
            this.label3.TabIndex = 56;
            this.label3.Text = "Work Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(199, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 40);
            this.label2.TabIndex = 53;
            this.label2.Text = "Field No:";
            // 
            // txtFieldNo
            // 
            this.txtFieldNo.Enabled = false;
            this.txtFieldNo.Location = new System.Drawing.Point(300, 38);
            this.txtFieldNo.Name = "txtFieldNo";
            this.txtFieldNo.Size = new System.Drawing.Size(228, 45);
            this.txtFieldNo.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(30, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 40);
            this.label5.TabIndex = 58;
            this.label5.Text = "Work";
            // 
            // lblFieldName
            // 
            this.lblFieldName.AutoSize = true;
            this.lblFieldName.Font = new System.Drawing.Font("Agency FB", 20F, System.Drawing.FontStyle.Bold);
            this.lblFieldName.ForeColor = System.Drawing.Color.Gold;
            this.lblFieldName.Location = new System.Drawing.Point(28, 122);
            this.lblFieldName.Name = "lblFieldName";
            this.lblFieldName.Size = new System.Drawing.Size(92, 50);
            this.lblFieldName.TabIndex = 59;
            this.lblFieldName.Text = "Field:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(731, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 60;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcFarm
            // 
            this.pcFarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFarm.Image = ((System.Drawing.Image)(resources.GetObject("pcFarm.Image")));
            this.pcFarm.Location = new System.Drawing.Point(458, 20);
            this.pcFarm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcFarm.Name = "pcFarm";
            this.pcFarm.Size = new System.Drawing.Size(191, 147);
            this.pcFarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcFarm.TabIndex = 61;
            this.pcFarm.TabStop = false;
            // 
            // cmbFarms
            // 
            this.cmbFarms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFarms.FormattingEnabled = true;
            this.cmbFarms.Location = new System.Drawing.Point(112, 127);
            this.cmbFarms.Name = "cmbFarms";
            this.cmbFarms.Size = new System.Drawing.Size(121, 48);
            this.cmbFarms.TabIndex = 69;
            this.cmbFarms.TextChanged += new System.EventHandler(this.cmbFarms_TextChanged);
            // 
            // Field_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(871, 801);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbFarms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcFarm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblFieldName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Field_Work";
            this.Text = "Field Works - FMS";
            this.Load += new System.EventHandler(this.Field_Work_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDisplaySeed;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtWorkDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFieldNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFieldName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbSeed;
        private System.Windows.Forms.PictureBox pcFarm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbFarms;
    }
}