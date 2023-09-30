namespace CNPM_ver3
{
    partial class ManageMemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMemberForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_user = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_birthdate = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_address = new System.Windows.Forms.Label();
            this.textBox_cccd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.pictureBox_user = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // dataGridView_user
            // 
            resources.ApplyResources(this.dataGridView_user, "dataGridView_user");
            this.dataGridView_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_user.Name = "dataGridView_user";
            this.dataGridView_user.Click += new System.EventHandler(this.DataGridView_user_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox_username
            // 
            resources.ApplyResources(this.textBox_username, "textBox_username");
            this.textBox_username.Name = "textBox_username";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dateTimePicker_birthdate
            // 
            resources.ApplyResources(this.dateTimePicker_birthdate, "dateTimePicker_birthdate");
            this.dateTimePicker_birthdate.Name = "dateTimePicker_birthdate";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // label_address
            // 
            resources.ApplyResources(this.label_address, "label_address");
            this.label_address.Name = "label_address";
            // 
            // textBox_cccd
            // 
            resources.ApplyResources(this.textBox_cccd, "textBox_cccd");
            this.textBox_cccd.Name = "textBox_cccd";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox_email
            // 
            resources.ApplyResources(this.textBox_email, "textBox_email");
            this.textBox_email.Name = "textBox_email";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // comboBox_gender
            // 
            resources.ApplyResources(this.comboBox_gender, "comboBox_gender");
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            resources.GetString("comboBox_gender.Items"),
            resources.GetString("comboBox_gender.Items1"),
            resources.GetString("comboBox_gender.Items2")});
            this.comboBox_gender.Name = "comboBox_gender";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox_pass
            // 
            resources.ApplyResources(this.textBox_pass, "textBox_pass");
            this.textBox_pass.Name = "textBox_pass";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1")});
            this.comboBox1.Name = "comboBox1";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // comboBox_type
            // 
            resources.ApplyResources(this.comboBox_type, "comboBox_type");
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Name = "comboBox_type";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            resources.ApplyResources(this.button_update, "button_update");
            this.button_update.BackColor = System.Drawing.Color.Firebrick;
            this.button_update.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_update.Name = "button_update";
            this.button_update.UseVisualStyleBackColor = false;
            // 
            // pictureBox_user
            // 
            resources.ApplyResources(this.pictureBox_user, "pictureBox_user");
            this.pictureBox_user.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox_user.Name = "pictureBox_user";
            this.pictureBox_user.TabStop = false;
            // 
            // ManageMemberForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox_user);
            this.Controls.Add(this.textBox_cccd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_birthdate);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_user);
            this.Controls.Add(this.panel1);
            this.Name = "ManageMemberForm";
            this.Load += new System.EventHandler(this.ManageMemberForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.TextBox textBox_cccd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox_user;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Label label1;
    }
}