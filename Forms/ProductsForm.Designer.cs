namespace FarmingManagement_FMS.Forms
{
    partial class ProductsForm
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStoringID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBaseFarm = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBaseField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblBarnNo = new System.Windows.Forms.Label();
            this.cmbBarn = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(1001, 122);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 40);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1113, 348);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(341, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 72);
            this.label1.TabIndex = 60;
            this.label1.Text = "Manage Product Info";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtStoringID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmpID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBaseFarm);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBaseField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 521);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 298);
            this.panel1.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(81, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 40);
            this.label9.TabIndex = 66;
            this.label9.Text = "Storing ID:";
            // 
            // txtStoringID
            // 
            this.txtStoringID.Enabled = false;
            this.txtStoringID.Location = new System.Drawing.Point(204, 72);
            this.txtStoringID.Name = "txtStoringID";
            this.txtStoringID.Size = new System.Drawing.Size(228, 45);
            this.txtStoringID.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(447, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 40);
            this.label8.TabIndex = 64;
            this.label8.Text = "Employee ID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(588, 224);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(228, 45);
            this.txtEmpID.TabIndex = 65;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(461, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 40);
            this.label6.TabIndex = 62;
            this.label6.Text = "Base Farm:";
            // 
            // txtBaseFarm
            // 
            this.txtBaseFarm.Location = new System.Drawing.Point(588, 173);
            this.txtBaseFarm.Name = "txtBaseFarm";
            this.txtBaseFarm.Size = new System.Drawing.Size(228, 45);
            this.txtBaseFarm.TabIndex = 63;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(588, 72);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(228, 45);
            this.txtDate.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(468, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 40);
            this.label3.TabIndex = 60;
            this.label3.Text = "Base Field:";
            // 
            // txtBaseField
            // 
            this.txtBaseField.Location = new System.Drawing.Point(588, 122);
            this.txtBaseField.Name = "txtBaseField";
            this.txtBaseField.Size = new System.Drawing.Size(228, 45);
            this.txtBaseField.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(448, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 40);
            this.label4.TabIndex = 58;
            this.label4.Text = "Stored Date:";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(7, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 48);
            this.button1.TabIndex = 57;
            this.button1.Text = "Clean Textboxes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(204, 122);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(228, 45);
            this.txtNo.TabIndex = 45;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(204, 173);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 45);
            this.txtName.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 40);
            this.label5.TabIndex = 48;
            this.label5.Text = "Product Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(204, 224);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(228, 45);
            this.txtQuantity.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(36, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 40);
            this.label2.TabIndex = 44;
            this.label2.Text = "Product Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(99, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 40);
            this.label7.TabIndex = 50;
            this.label7.Text = "Barn No:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(863, 522);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(262, 80);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "Add Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(865, 736);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(260, 83);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.Text = "Substract Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(863, 627);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(262, 83);
            this.btnUpdate.TabIndex = 65;
            this.btnUpdate.Text = "Update Product Info.";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblBarnNo
            // 
            this.lblBarnNo.AutoSize = true;
            this.lblBarnNo.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold);
            this.lblBarnNo.ForeColor = System.Drawing.Color.Gold;
            this.lblBarnNo.Location = new System.Drawing.Point(12, 117);
            this.lblBarnNo.Name = "lblBarnNo";
            this.lblBarnNo.Size = new System.Drawing.Size(83, 44);
            this.lblBarnNo.TabIndex = 68;
            this.lblBarnNo.Text = "Barn:";
            // 
            // cmbBarn
            // 
            this.cmbBarn.FormattingEnabled = true;
            this.cmbBarn.Location = new System.Drawing.Point(90, 117);
            this.cmbBarn.Name = "cmbBarn";
            this.cmbBarn.Size = new System.Drawing.Size(121, 48);
            this.cmbBarn.TabIndex = 69;
            this.cmbBarn.TextChanged += new System.EventHandler(this.cmbBarn_TextChanged);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1140, 829);
            this.Controls.Add(this.cmbBarn);
            this.Controls.Add(this.lblBarnNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ProductsForm";
            this.Text = "Manage Products - FMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductsForm_FormClosed);
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblBarnNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBaseFarm;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBaseField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBarn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStoringID;
    }
}