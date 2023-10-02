namespace CNPM_ver3
{
    partial class AddMember2Project
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
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.dataGridView_mInProject = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mInProject)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_user
            // 
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Location = new System.Drawing.Point(5, 24);
            this.dataGridView_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.RowHeadersWidth = 62;
            this.dataGridView_user.Size = new System.Drawing.Size(924, 194);
            this.dataGridView_user.TabIndex = 0;
            this.dataGridView_user.Click += new System.EventHandler(this.dataGridView_user_Click);
            // 
            // dataGridView_mInProject
            // 
            this.dataGridView_mInProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_mInProject.Location = new System.Drawing.Point(18, 263);
            this.dataGridView_mInProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_mInProject.Name = "dataGridView_mInProject";
            this.dataGridView_mInProject.RowHeadersWidth = 62;
            this.dataGridView_mInProject.Size = new System.Drawing.Size(924, 241);
            this.dataGridView_mInProject.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 271);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Member in project";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_user);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(936, 226);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Member in project";
            // 
            // AddMember2Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 518);
            this.Controls.Add(this.dataGridView_mInProject);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMember2Project";
            this.Text = "AddMember2Project";
            this.Load += new System.EventHandler(this.AddMember2Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_mInProject)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.DataGridView dataGridView_mInProject;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}