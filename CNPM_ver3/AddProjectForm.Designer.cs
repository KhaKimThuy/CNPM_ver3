namespace CNPM_ver3
{
    partial class AddProjectForm
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
            this.components = new System.ComponentModel.Container();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_exp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.button_addProject = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(477, 368);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 20);
            this.label9.TabIndex = 107;
            this.label9.Text = "Version";
            // 
            // textBox_ver
            // 
            this.textBox_ver.Location = new System.Drawing.Point(549, 363);
            this.textBox_ver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_ver.Name = "textBox_ver";
            this.textBox_ver.Size = new System.Drawing.Size(118, 26);
            this.textBox_ver.TabIndex = 106;
            this.textBox_ver.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Expect";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(496, 314);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 104;
            // 
            // dateTimePicker_exp
            // 
            this.dateTimePicker_exp.Location = new System.Drawing.Point(549, 305);
            this.dateTimePicker_exp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_exp.Name = "dateTimePicker_exp";
            this.dateTimePicker_exp.Size = new System.Drawing.Size(408, 26);
            this.dateTimePicker_exp.TabIndex = 103;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 254);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 102;
            this.label6.Text = "End";
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(549, 245);
            this.dateTimePicker_end.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(408, 26);
            this.dateTimePicker_end.TabIndex = 101;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 189);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "Start";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(549, 180);
            this.dateTimePicker_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(408, 26);
            this.dateTimePicker_start.TabIndex = 99;
            // 
            // button_addProject
            // 
            this.button_addProject.BackColor = System.Drawing.Color.IndianRed;
            this.button_addProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addProject.Location = new System.Drawing.Point(1044, 600);
            this.button_addProject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_addProject.Name = "button_addProject";
            this.button_addProject.Size = new System.Drawing.Size(126, 60);
            this.button_addProject.TabIndex = 98;
            this.button_addProject.Text = "Add project";
            this.button_addProject.UseVisualStyleBackColor = false;
            this.button_addProject.Click += new System.EventHandler(this.button_addProject_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 428);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 97;
            this.label3.Text = "Project description";
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(549, 423);
            this.textBox_desc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_desc.Multiline = true;
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(448, 153);
            this.textBox_desc.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 95;
            this.label2.Text = "Project name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(549, 123);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(408, 26);
            this.textBox_name.TabIndex = 94;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1566, 851);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_ver);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_exp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_addProject);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProjectForm";
            this.Text = "AddProjectForm";
            this.Load += new System.EventHandler(this.AddProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_exp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.Button button_addProject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}