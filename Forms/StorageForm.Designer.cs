namespace FarmingManagement_FMS.Forms
{
    partial class StorageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StorageForm));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAcreage = new System.Windows.Forms.TextBox();
            this.txtLandNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcBarn = new System.Windows.Forms.PictureBox();
            this.chkPersonnelStatus = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBarn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRefresh.Location = new System.Drawing.Point(819, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(124, 40);
            this.btnRefresh.TabIndex = 66;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.txtNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtAcreage);
            this.panel1.Controls.Add(this.txtLandNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 594);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 347);
            this.panel1.TabIndex = 65;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Agency FB", 14F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean.Location = new System.Drawing.Point(8, 12);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(158, 48);
            this.btnClean.TabIndex = 57;
            this.btnClean.Text = "Clean Textboxes";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // txtNo
            // 
            this.txtNo.Enabled = false;
            this.txtNo.Location = new System.Drawing.Point(242, 86);
            this.txtNo.Name = "txtNo";
            this.txtNo.ReadOnly = true;
            this.txtNo.Size = new System.Drawing.Size(228, 45);
            this.txtNo.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(139, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 40);
            this.label3.TabIndex = 46;
            this.label3.Text = "Land No:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(242, 137);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(228, 45);
            this.txtName.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(48, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 40);
            this.label5.TabIndex = 48;
            this.label5.Text = "Storage Acreage:";
            // 
            // txtAcreage
            // 
            this.txtAcreage.Location = new System.Drawing.Point(242, 188);
            this.txtAcreage.Name = "txtAcreage";
            this.txtAcreage.Size = new System.Drawing.Size(228, 45);
            this.txtAcreage.TabIndex = 49;
            // 
            // txtLandNo
            // 
            this.txtLandNo.Location = new System.Drawing.Point(242, 239);
            this.txtLandNo.Name = "txtLandNo";
            this.txtLandNo.Size = new System.Drawing.Size(228, 45);
            this.txtLandNo.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(159, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 40);
            this.label2.TabIndex = 44;
            this.label2.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(190, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 40);
            this.label7.TabIndex = 50;
            this.label7.Text = "No:";
            // 
            // btnProducts
            // 
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnProducts.Location = new System.Drawing.Point(616, 858);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(327, 83);
            this.btnProducts.TabIndex = 64;
            this.btnProducts.Text = "Equipments";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(616, 594);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(329, 80);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "Add New Storage";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(616, 769);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(327, 83);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Text = "Delete Selected Storage";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(616, 680);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(329, 83);
            this.btnUpdate.TabIndex = 63;
            this.btnUpdate.Text = "Update Storage Info.";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(189, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 72);
            this.label1.TabIndex = 60;
            this.label1.Text = "Manage Storages";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(931, 409);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // pcBarn
            // 
            this.pcBarn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcBarn.Image = ((System.Drawing.Image)(resources.GetObject("pcBarn.Image")));
            this.pcBarn.Location = new System.Drawing.Point(532, 22);
            this.pcBarn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcBarn.Name = "pcBarn";
            this.pcBarn.Size = new System.Drawing.Size(191, 137);
            this.pcBarn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcBarn.TabIndex = 67;
            this.pcBarn.TabStop = false;
            // 
            // chkPersonnelStatus
            // 
            this.chkPersonnelStatus.AutoSize = true;
            this.chkPersonnelStatus.Checked = true;
            this.chkPersonnelStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPersonnelStatus.Font = new System.Drawing.Font("Agency FB", 14F);
            this.chkPersonnelStatus.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkPersonnelStatus.Location = new System.Drawing.Point(12, 138);
            this.chkPersonnelStatus.Name = "chkPersonnelStatus";
            this.chkPersonnelStatus.Size = new System.Drawing.Size(264, 37);
            this.chkPersonnelStatus.TabIndex = 68;
            this.chkPersonnelStatus.Text = "Displaying active lands only.";
            this.chkPersonnelStatus.UseVisualStyleBackColor = true;
            this.chkPersonnelStatus.CheckedChanged += new System.EventHandler(this.chkPersonnelStatus_CheckedChanged);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(955, 949);
            this.Controls.Add(this.chkPersonnelStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcBarn);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "StorageForm";
            this.Text = "Storage - FMS";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcBarn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAcreage;
        private System.Windows.Forms.TextBox txtLandNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pcBarn;
        private System.Windows.Forms.CheckBox chkPersonnelStatus;
    }
}