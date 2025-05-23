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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 406);
            this.dataGridView1.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(389, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 72);
            this.label1.TabIndex = 68;
            this.label1.Text = "Animals";
            // 
            // pcFarm
            // 
            this.pcFarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcFarm.Image = ((System.Drawing.Image)(resources.GetObject("pcFarm.Image")));
            this.pcFarm.Location = new System.Drawing.Point(539, 32);
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
            this.lblFarmName.Location = new System.Drawing.Point(28, 151);
            this.lblFarmName.Name = "lblFarmName";
            this.lblFarmName.Size = new System.Drawing.Size(98, 50);
            this.lblFarmName.TabIndex = 70;
            this.lblFarmName.Text = "Farm:";
            // 
            // AnimalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1083, 969);
            this.Controls.Add(this.lblFarmName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcFarm);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Agency FB", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "AnimalsForm";
            this.Text = "AnimalsForm";
            this.Load += new System.EventHandler(this.AnimalsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcFarm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcFarm;
        private System.Windows.Forms.Label lblFarmName;
    }
}