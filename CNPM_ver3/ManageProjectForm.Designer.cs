namespace CNPM_ver3
{
    partial class ManageProjectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_addProject = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_back = new System.Windows.Forms.ToolStripLabel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.button_del = new System.Windows.Forms.Button();
            this.button_addMember = new System.Windows.Forms.Button();
            this.button_addGroup = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ver = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_exp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView_project = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel_main.SuspendLayout();
            this.panel_cover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_project)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(240, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 45);
            this.panel1.TabIndex = 68;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Silver;
            this.button_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_search.Location = new System.Drawing.Point(953, 9);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(79, 29);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(737, 13);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(210, 20);
            this.textBox_search.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_addProject,
            this.toolStripLabel_back});
            this.toolStrip1.Location = new System.Drawing.Point(0, 45);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1060, 25);
            this.toolStrip1.TabIndex = 69;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel_addProject
            // 
            this.toolStripLabel_addProject.Name = "toolStripLabel_addProject";
            this.toolStripLabel_addProject.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel_addProject.Text = "Add project";
            this.toolStripLabel_addProject.Click += new System.EventHandler(this.toolStripLabel_addProject_Click);
            // 
            // toolStripLabel_back
            // 
            this.toolStripLabel_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel_back.ForeColor = System.Drawing.Color.Red;
            this.toolStripLabel_back.Name = "toolStripLabel_back";
            this.toolStripLabel_back.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel_back.Text = "Back";
            this.toolStripLabel_back.Click += new System.EventHandler(this.toolStripLabel_back_Click);
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 70);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1060, 592);
            this.panel_main.TabIndex = 70;
            // 
            // panel_cover
            // 
            this.panel_cover.AutoScroll = true;
            this.panel_cover.Controls.Add(this.button_del);
            this.panel_cover.Controls.Add(this.button_addMember);
            this.panel_cover.Controls.Add(this.button_addGroup);
            this.panel_cover.Controls.Add(this.button_update);
            this.panel_cover.Controls.Add(this.label9);
            this.panel_cover.Controls.Add(this.textBox_ver);
            this.panel_cover.Controls.Add(this.textBox_desc);
            this.panel_cover.Controls.Add(this.label2);
            this.panel_cover.Controls.Add(this.textBox_name);
            this.panel_cover.Controls.Add(this.label7);
            this.panel_cover.Controls.Add(this.label3);
            this.panel_cover.Controls.Add(this.dateTimePicker_exp);
            this.panel_cover.Controls.Add(this.label4);
            this.panel_cover.Controls.Add(this.label6);
            this.panel_cover.Controls.Add(this.dateTimePicker_end);
            this.panel_cover.Controls.Add(this.dateTimePicker_start);
            this.panel_cover.Controls.Add(this.label5);
            this.panel_cover.Controls.Add(this.dataGridView_project);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1060, 592);
            this.panel_cover.TabIndex = 0;
            // 
            // button_del
            // 
            this.button_del.BackColor = System.Drawing.Color.Firebrick;
            this.button_del.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_del.Location = new System.Drawing.Point(629, 510);
            this.button_del.Name = "button_del";
            this.button_del.Size = new System.Drawing.Size(85, 32);
            this.button_del.TabIndex = 124;
            this.button_del.Text = "Delete";
            this.button_del.UseVisualStyleBackColor = false;
            this.button_del.Click += new System.EventHandler(this.button_del_Click);
            // 
            // button_addMember
            // 
            this.button_addMember.BackColor = System.Drawing.Color.ForestGreen;
            this.button_addMember.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addMember.Location = new System.Drawing.Point(717, 510);
            this.button_addMember.Name = "button_addMember";
            this.button_addMember.Size = new System.Drawing.Size(85, 32);
            this.button_addMember.TabIndex = 123;
            this.button_addMember.Text = "Add member";
            this.button_addMember.UseVisualStyleBackColor = false;
            this.button_addMember.Click += new System.EventHandler(this.button_addMember_Click);
            // 
            // button_addGroup
            // 
            this.button_addGroup.BackColor = System.Drawing.Color.Navy;
            this.button_addGroup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addGroup.Location = new System.Drawing.Point(809, 510);
            this.button_addGroup.Name = "button_addGroup";
            this.button_addGroup.Size = new System.Drawing.Size(85, 32);
            this.button_addGroup.TabIndex = 122;
            this.button_addGroup.Text = "Add group";
            this.button_addGroup.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.IndianRed;
            this.button_update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_update.Location = new System.Drawing.Point(543, 510);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(85, 32);
            this.button_update.TabIndex = 121;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 120;
            this.label9.Text = "Version";
            // 
            // textBox_ver
            // 
            this.textBox_ver.Location = new System.Drawing.Point(247, 434);
            this.textBox_ver.Name = "textBox_ver";
            this.textBox_ver.Size = new System.Drawing.Size(253, 20);
            this.textBox_ver.TabIndex = 119;
            this.textBox_ver.Text = "1";
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(247, 477);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(253, 66);
            this.textBox_desc.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 118;
            this.label2.Text = "Expect";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(247, 396);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(253, 20);
            this.textBox_name.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(162, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Project name";
            // 
            // dateTimePicker_exp
            // 
            this.dateTimePicker_exp.Location = new System.Drawing.Point(661, 475);
            this.dateTimePicker_exp.Name = "dateTimePicker_exp";
            this.dateTimePicker_exp.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker_exp.TabIndex = 116;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Project description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 115;
            this.label6.Text = "End";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(661, 436);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker_end.TabIndex = 114;
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(661, 395);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker_start.TabIndex = 112;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(626, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Start";
            // 
            // dataGridView_project
            // 
            this.dataGridView_project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_project.Location = new System.Drawing.Point(12, 3);
            this.dataGridView_project.Name = "dataGridView_project";
            this.dataGridView_project.RowHeadersWidth = 62;
            this.dataGridView_project.Size = new System.Drawing.Size(1036, 352);
            this.dataGridView_project.TabIndex = 0;
            this.dataGridView_project.ClientSizeChanged += new System.EventHandler(this.toolStripLabel_addProject_Click);
            this.dataGridView_project.Click += new System.EventHandler(this.DataGridView_Project_Click);
            // 
            // ManageProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 662);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProjectForm";
            this.Text = "ManageProjectForm";
            this.Load += new System.EventHandler(this.ManageProjectForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel_main.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_project)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_addProject;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.DataGridView dataGridView_project;
        private System.Windows.Forms.Button button_addGroup;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ver;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_exp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_back;
        private System.Windows.Forms.Button button_addMember;
        private System.Windows.Forms.Button button_del;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
    }
}