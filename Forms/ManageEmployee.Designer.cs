namespace FarmingManagement_FMS.Forms
{
    partial class ManageEmployee
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFwork = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSwork = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAnnounce = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(522, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manage Employees";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1373, 551);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // txtFname
            // 
            this.txtFname.Enabled = false;
            this.txtFname.Location = new System.Drawing.Point(185, 153);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(249, 45);
            this.txtFname.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(52, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // txtSname
            // 
            this.txtSname.Enabled = false;
            this.txtSname.Location = new System.Drawing.Point(185, 204);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(249, 45);
            this.txtSname.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(23, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 40);
            this.label3.TabIndex = 7;
            this.label3.Text = "Second Name:";
            // 
            // txtLname
            // 
            this.txtLname.Enabled = false;
            this.txtLname.Location = new System.Drawing.Point(185, 306);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(249, 45);
            this.txtLname.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(55, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            // 
            // txtTname
            // 
            this.txtTname.Enabled = false;
            this.txtTname.Location = new System.Drawing.Point(185, 255);
            this.txtTname.Name = "txtTname";
            this.txtTname.Size = new System.Drawing.Size(249, 45);
            this.txtTname.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(47, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 40);
            this.label5.TabIndex = 9;
            this.label5.Text = "Third Name:";
            // 
            // txtMail
            // 
            this.txtMail.Enabled = false;
            this.txtMail.Location = new System.Drawing.Point(701, 121);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(266, 45);
            this.txtMail.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(615, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 40);
            this.label6.TabIndex = 15;
            this.label6.Text = "E-Mail:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(185, 102);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(249, 45);
            this.txtID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(139, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID:";
            // 
            // txtFwork
            // 
            this.txtFwork.Enabled = false;
            this.txtFwork.Location = new System.Drawing.Point(701, 223);
            this.txtFwork.Name = "txtFwork";
            this.txtFwork.Size = new System.Drawing.Size(266, 45);
            this.txtFwork.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(507, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 40);
            this.label8.TabIndex = 19;
            this.label8.Text = "First Work Space:";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(701, 172);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(266, 45);
            this.txtPhone.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(529, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 40);
            this.label9.TabIndex = 17;
            this.label9.Text = "Phone Number:";
            // 
            // txtSwork
            // 
            this.txtSwork.Enabled = false;
            this.txtSwork.Location = new System.Drawing.Point(701, 274);
            this.txtSwork.Name = "txtSwork";
            this.txtSwork.Size = new System.Drawing.Size(266, 45);
            this.txtSwork.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(478, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 40);
            this.label10.TabIndex = 21;
            this.label10.Text = "Second Work Space:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(1052, 790);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(343, 87);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update Employee Information";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(1052, 892);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(343, 87);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete Selected Employee";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(1052, 688);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(343, 87);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "Add New Employee";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnAnnounce
            // 
            this.btnAnnounce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnounce.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAnnounce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAnnounce.Location = new System.Drawing.Point(1052, 991);
            this.btnAnnounce.Name = "btnAnnounce";
            this.btnAnnounce.Size = new System.Drawing.Size(343, 87);
            this.btnAnnounce.TabIndex = 26;
            this.btnAnnounce.Text = "Make An Announcement";
            this.btnAnnounce.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSname);
            this.panel1.Controls.Add(this.txtSwork);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTname);
            this.panel1.Controls.Add(this.txtFwork);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLname);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMail);
            this.panel1.Location = new System.Drawing.Point(22, 688);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 390);
            this.panel1.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(364, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(331, 44);
            this.label11.TabIndex = 23;
            this.label11.Text = "Data Of Selected Employee";
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1419, 1106);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAnnounce);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFwork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSwork;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAnnounce;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
    }
}