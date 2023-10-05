namespace CNPM_ver3
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_remember = new System.Windows.Forms.CheckBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_forget = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.label_remember = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_showPass = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_pass = new CNPM_ver3.TxtBox1();
            this.textBox_userid = new CNPM_ver3.TxtBox1();
            this.button_addUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Name = "label4";
            // 
            // checkBox_remember
            // 
            resources.ApplyResources(this.checkBox_remember, "checkBox_remember");
            this.checkBox_remember.ForeColor = System.Drawing.Color.Black;
            this.checkBox_remember.Name = "checkBox_remember";
            this.checkBox_remember.UseVisualStyleBackColor = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.IndianRed;
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.Name = "button_login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_forget
            // 
            this.button_forget.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.button_forget, "button_forget");
            this.button_forget.Name = "button_forget";
            this.button_forget.UseVisualStyleBackColor = true;
            this.button_forget.Click += new System.EventHandler(this.button_forget_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // comboBox_language
            // 
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            resources.GetString("comboBox_language.Items"),
            resources.GetString("comboBox_language.Items1")});
            resources.ApplyResources(this.comboBox_language, "comboBox_language");
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.TextChanged += new System.EventHandler(this.ApplyLanguage);
            // 
            // label_remember
            // 
            resources.ApplyResources(this.label_remember, "label_remember");
            this.label_remember.Name = "label_remember";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // button_showPass
            // 
            resources.ApplyResources(this.button_showPass, "button_showPass");
            this.button_showPass.ForeColor = System.Drawing.Color.White;
            this.button_showPass.Name = "button_showPass";
            this.button_showPass.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // textBox_pass
            // 
            this.textBox_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_pass, "textBox_pass");
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.UseSystemPasswordChar = true;
            // 
            // textBox_userid
            // 
            this.textBox_userid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBox_userid, "textBox_userid");
            this.textBox_userid.Name = "textBox_userid";
            // 
            // button_addUser
            // 
            this.button_addUser.BackColor = System.Drawing.Color.DarkOrange;
            this.button_addUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.button_addUser, "button_addUser");
            this.button_addUser.Name = "button_addUser";
            this.button_addUser.UseVisualStyleBackColor = false;
            this.button_addUser.Click += new System.EventHandler(this.button_addUser_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_addUser);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_userid);
            this.Controls.Add(this.label_remember);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox_language);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_forget);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.button_showPass);
            this.Controls.Add(this.checkBox_remember);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "LoginForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_remember;
        private TxtBox1 textBox_userid;
        private TxtBox1 textBox_pass;
        private System.Windows.Forms.Button button_showPass;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_forget;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_remember;
        private System.Windows.Forms.Button button_addUser;
    }
}



