namespace FarmingManagement_FMS
{
    partial class Announcement
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 26F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.LightYellow;
            this.label2.Location = new System.Drawing.Point(302, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 62);
            this.label2.TabIndex = 3;
            this.label2.Text = "Make An Announcement";
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Agency FB", 18F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(608, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(335, 90);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Announce";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(610, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "To which department:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(608, 55);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(335, 172);
            this.checkedListBox1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(14, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(588, 268);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(7, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 40);
            this.label3.TabIndex = 11;
            this.label3.Text = "Announcement:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 345);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Agency FB", 14F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(309, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "Clear The Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Announcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(988, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Agency FB", 16F);
            this.Location = new System.Drawing.Point(1052, 1049);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Announcement";
            this.Text = "Announcement";
            this.Load += new System.EventHandler(this.Announcement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}