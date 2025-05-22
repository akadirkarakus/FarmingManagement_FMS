namespace FarmingManagement_FMS
{
    partial class AdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMngEmp = new System.Windows.Forms.Button();
            this.btnRunSQL = new System.Windows.Forms.Button();
            this.btnFarminData = new System.Windows.Forms.Button();
            this.btnPresetQuery = new System.Windows.Forms.Button();
            this.vtbAccountManager = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(207, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // btnMngEmp
            // 
            this.btnMngEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMngEmp.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnMngEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnMngEmp.Location = new System.Drawing.Point(34, 165);
            this.btnMngEmp.Name = "btnMngEmp";
            this.btnMngEmp.Size = new System.Drawing.Size(300, 98);
            this.btnMngEmp.TabIndex = 1;
            this.btnMngEmp.Text = "Manage Employees";
            this.btnMngEmp.UseVisualStyleBackColor = true;
            this.btnMngEmp.Click += new System.EventHandler(this.btnMngEmp_Click);
            // 
            // btnRunSQL
            // 
            this.btnRunSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunSQL.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnRunSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRunSQL.Location = new System.Drawing.Point(349, 165);
            this.btnRunSQL.Name = "btnRunSQL";
            this.btnRunSQL.Size = new System.Drawing.Size(300, 98);
            this.btnRunSQL.TabIndex = 2;
            this.btnRunSQL.Text = "Run SQL Commands";
            this.btnRunSQL.UseVisualStyleBackColor = true;
            // 
            // btnFarminData
            // 
            this.btnFarminData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarminData.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnFarminData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFarminData.Location = new System.Drawing.Point(34, 278);
            this.btnFarminData.Name = "btnFarminData";
            this.btnFarminData.Size = new System.Drawing.Size(300, 98);
            this.btnFarminData.TabIndex = 3;
            this.btnFarminData.Text = "Manage Farming Data";
            this.btnFarminData.UseVisualStyleBackColor = true;
            this.btnFarminData.Click += new System.EventHandler(this.btnFarminData_Click);
            // 
            // btnPresetQuery
            // 
            this.btnPresetQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresetQuery.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnPresetQuery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPresetQuery.Location = new System.Drawing.Point(349, 278);
            this.btnPresetQuery.Name = "btnPresetQuery";
            this.btnPresetQuery.Size = new System.Drawing.Size(300, 98);
            this.btnPresetQuery.TabIndex = 4;
            this.btnPresetQuery.Text = "Manage Preset Queries";
            this.btnPresetQuery.UseVisualStyleBackColor = true;
            // 
            // vtbAccountManager
            // 
            this.vtbAccountManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vtbAccountManager.Font = new System.Drawing.Font("Agency FB", 18F);
            this.vtbAccountManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.vtbAccountManager.Location = new System.Drawing.Point(34, 389);
            this.vtbAccountManager.Name = "vtbAccountManager";
            this.vtbAccountManager.Size = new System.Drawing.Size(426, 72);
            this.vtbAccountManager.TabIndex = 5;
            this.vtbAccountManager.Text = "Account Manager";
            this.vtbAccountManager.UseVisualStyleBackColor = true;
            this.vtbAccountManager.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnLogout.ForeColor = System.Drawing.Color.Red;
            this.btnLogout.Location = new System.Drawing.Point(475, 389);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(174, 72);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button5_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(686, 495);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.vtbAccountManager);
            this.Controls.Add(this.btnPresetQuery);
            this.Controls.Add(this.btnFarminData);
            this.Controls.Add(this.btnRunSQL);
            this.Controls.Add(this.btnMngEmp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMngEmp;
        private System.Windows.Forms.Button btnRunSQL;
        private System.Windows.Forms.Button btnFarminData;
        private System.Windows.Forms.Button btnPresetQuery;
        private System.Windows.Forms.Button vtbAccountManager;
        private System.Windows.Forms.Button btnLogout;
    }
}