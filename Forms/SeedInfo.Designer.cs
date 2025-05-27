namespace FarmingManagement_FMS.Forms
{
    partial class SeedInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeedInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.pcField = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtGenus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCultivation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(115, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 72);
            this.label1.TabIndex = 42;
            this.label1.Text = "Seed Information";
            // 
            // pcField
            // 
            this.pcField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcField.Image = ((System.Drawing.Image)(resources.GetObject("pcField.Image")));
            this.pcField.Location = new System.Drawing.Point(461, 32);
            this.pcField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcField.Name = "pcField";
            this.pcField.Size = new System.Drawing.Size(145, 147);
            this.pcField.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcField.TabIndex = 43;
            this.pcField.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(633, 310);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Location = new System.Drawing.Point(461, 514);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(203, 67);
            this.btnAdd.TabIndex = 45;
            this.btnAdd.Text = "Add New Seed";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Location = new System.Drawing.Point(461, 680);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(203, 67);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete Seed";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Location = new System.Drawing.Point(461, 597);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(203, 67);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update Seed";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtGenus
            // 
            this.txtGenus.Location = new System.Drawing.Point(184, 27);
            this.txtGenus.Name = "txtGenus";
            this.txtGenus.Size = new System.Drawing.Size(228, 45);
            this.txtGenus.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(41, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 40);
            this.label7.TabIndex = 53;
            this.label7.Text = "Seed Genus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 40);
            this.label2.TabIndex = 48;
            this.label2.Text = "Planting Time:";
            // 
            // txtCultivation
            // 
            this.txtCultivation.Location = new System.Drawing.Point(184, 129);
            this.txtCultivation.Name = "txtCultivation";
            this.txtCultivation.Size = new System.Drawing.Size(228, 45);
            this.txtCultivation.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(2, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 40);
            this.label5.TabIndex = 51;
            this.label5.Text = "Cultivation Time:";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(184, 78);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(228, 45);
            this.txtTime.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtGenus);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCultivation);
            this.panel1.Location = new System.Drawing.Point(31, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 197);
            this.panel1.TabIndex = 54;
            // 
            // btnClean
            // 
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Agency FB", 12F);
            this.btnClean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClean.Location = new System.Drawing.Point(348, 514);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(103, 39);
            this.btnClean.TabIndex = 55;
            this.btnClean.Text = "Clean ";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(540, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 56;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(43, 533);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 40);
            this.label6.TabIndex = 58;
            this.label6.Text = "Selected Seed";
            // 
            // SeedInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(693, 765);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcField);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SeedInfo";
            this.Text = "Seed Info - FMS";
            this.Load += new System.EventHandler(this.SeedInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtGenus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCultivation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}