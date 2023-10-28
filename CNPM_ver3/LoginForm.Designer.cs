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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.checkBox_remember = new System.Windows.Forms.CheckBox();
            this.comboBox_language = new System.Windows.Forms.ComboBox();
            this.label_remember = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_addUser = new System.Windows.Forms.Button();
            this.pro_name4 = new System.Windows.Forms.Label();
            this.pro_name2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.pro_name1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.textBox_userid = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.btForget = new System.Windows.Forms.Button();
            this.button_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txt_namecomp = new System.Windows.Forms.Label();
            this.txt_infocomp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.text_welcome = new System.Windows.Forms.Label();
            this.text_suggest = new System.Windows.Forms.Label();
            this.button_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_remember
            // 
            resources.ApplyResources(this.checkBox_remember, "checkBox_remember");
            this.checkBox_remember.ForeColor = System.Drawing.Color.Black;
            this.checkBox_remember.Name = "checkBox_remember";
            this.checkBox_remember.UseVisualStyleBackColor = true;
            this.checkBox_remember.MouseHover += new System.EventHandler(this.checkBox_remember_MouseHover);
            // 
            // comboBox_language
            // 
            this.comboBox_language.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("comboBox_language.AutoCompleteCustomSource"),
            resources.GetString("comboBox_language.AutoCompleteCustomSource1")});
            this.comboBox_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_language.FormattingEnabled = true;
            this.comboBox_language.Items.AddRange(new object[] {
            resources.GetString("comboBox_language.Items"),
            resources.GetString("comboBox_language.Items1")});
            resources.ApplyResources(this.comboBox_language, "comboBox_language");
            this.comboBox_language.Name = "comboBox_language";
            this.comboBox_language.SelectedIndexChanged += new System.EventHandler(this.comboBox_language_SelectedIndexChanged);
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
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            // pro_name4
            // 
            resources.ApplyResources(this.pro_name4, "pro_name4");
            this.pro_name4.ForeColor = System.Drawing.Color.Gray;
            this.pro_name4.Name = "pro_name4";
            // 
            // pro_name2
            // 
            this.pro_name2.AllowParentOverrides = false;
            this.pro_name2.AutoEllipsis = false;
            resources.ApplyResources(this.pro_name2, "pro_name2");
            this.pro_name2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pro_name2.CursorType = System.Windows.Forms.Cursors.Default;
            this.pro_name2.ForeColor = System.Drawing.Color.Red;
            this.pro_name2.Name = "pro_name2";
            this.pro_name2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pro_name2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.pro_name2.Click += new System.EventHandler(this.pro_name2_Click);
            // 
            // pro_name1
            // 
            this.pro_name1.AllowParentOverrides = false;
            this.pro_name1.AutoEllipsis = false;
            this.pro_name1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pro_name1.CursorType = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pro_name1, "pro_name1");
            this.pro_name1.ForeColor = System.Drawing.Color.Gray;
            this.pro_name1.Name = "pro_name1";
            this.pro_name1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.pro_name1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBox_userid
            // 
            this.textBox_userid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_userid.CausesValidation = false;
            resources.ApplyResources(this.textBox_userid, "textBox_userid");
            this.textBox_userid.ForeColor = System.Drawing.Color.Gray;
            this.textBox_userid.Name = "textBox_userid";
            this.textBox_userid.Click += new System.EventHandler(this.textBox_userid_Click);
            this.textBox_userid.TextChanged += new System.EventHandler(this.textBox_userid_TextChanged);
            this.textBox_userid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_userid_KeyDown);
            this.textBox_userid.Leave += new System.EventHandler(this.textBox_userid_Leave);
            // 
            // textBox_pass
            // 
            this.textBox_pass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_pass.CausesValidation = false;
            resources.ApplyResources(this.textBox_pass, "textBox_pass");
            this.textBox_pass.ForeColor = System.Drawing.Color.Gray;
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Click += new System.EventHandler(this.textBox_pass_Click);
            this.textBox_pass.TextChanged += new System.EventHandler(this.textBox_pass_TextChanged);
            this.textBox_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pass_KeyDown);
            this.textBox_pass.Leave += new System.EventHandler(this.textBox_pass_Leave);
            // 
            // btForget
            // 
            this.btForget.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btForget, "btForget");
            this.btForget.ForeColor = System.Drawing.Color.Black;
            this.btForget.Name = "btForget";
            this.btForget.UseVisualStyleBackColor = true;
            this.btForget.Click += new System.EventHandler(this.btForget_Click);
            this.btForget.MouseHover += new System.EventHandler(this.btForget_MouseHover);
            // 
            // button_login
            // 
            this.button_login.AllowAnimations = true;
            this.button_login.AllowMouseEffects = true;
            this.button_login.AllowToggling = false;
            this.button_login.AnimationSpeed = 200;
            this.button_login.AutoGenerateColors = false;
            this.button_login.AutoRoundBorders = false;
            this.button_login.AutoSizeLeftIcon = true;
            this.button_login.AutoSizeRightIcon = true;
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.BackColor1 = System.Drawing.Color.Black;
            resources.ApplyResources(this.button_login, "button_login");
            this.button_login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_login.ButtonText = "Login";
            this.button_login.ButtonTextMarginLeft = 0;
            this.button_login.ColorContrastOnClick = 45;
            this.button_login.ColorContrastOnHover = 45;
            this.button_login.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.button_login.CustomizableEdges = borderEdges2;
            this.button_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_login.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_login.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_login.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.button_login.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.button_login.IconMarginLeft = 11;
            this.button_login.IconPadding = 10;
            this.button_login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_login.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.button_login.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.button_login.IconSize = 25;
            this.button_login.IdleBorderColor = System.Drawing.Color.Black;
            this.button_login.IdleBorderRadius = 10;
            this.button_login.IdleBorderThickness = 1;
            this.button_login.IdleFillColor = System.Drawing.Color.Black;
            this.button_login.IdleIconLeftImage = null;
            this.button_login.IdleIconRightImage = null;
            this.button_login.IndicateFocus = false;
            this.button_login.Name = "button_login";
            this.button_login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.button_login.OnDisabledState.BorderRadius = 10;
            this.button_login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_login.OnDisabledState.BorderThickness = 1;
            this.button_login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.button_login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.button_login.OnDisabledState.IconLeftImage = null;
            this.button_login.OnDisabledState.IconRightImage = null;
            this.button_login.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_login.onHoverState.BorderRadius = 10;
            this.button_login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_login.onHoverState.BorderThickness = 1;
            this.button_login.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.button_login.onHoverState.ForeColor = System.Drawing.Color.White;
            this.button_login.onHoverState.IconLeftImage = null;
            this.button_login.onHoverState.IconRightImage = null;
            this.button_login.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.button_login.OnIdleState.BorderRadius = 10;
            this.button_login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_login.OnIdleState.BorderThickness = 1;
            this.button_login.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.button_login.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.button_login.OnIdleState.IconLeftImage = null;
            this.button_login.OnIdleState.IconRightImage = null;
            this.button_login.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_login.OnPressedState.BorderRadius = 10;
            this.button_login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.button_login.OnPressedState.BorderThickness = 1;
            this.button_login.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.button_login.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.button_login.OnPressedState.IconLeftImage = null;
            this.button_login.OnPressedState.IconRightImage = null;
            this.button_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_login.TextMarginLeft = 0;
            this.button_login.TextPadding = new System.Windows.Forms.Padding(0);
            this.button_login.UseDefaultRadiusAndThickness = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            this.button_login.MouseHover += new System.EventHandler(this.button_login_MouseHover);
            // 
            // txt_namecomp
            // 
            resources.ApplyResources(this.txt_namecomp, "txt_namecomp");
            this.txt_namecomp.ForeColor = System.Drawing.Color.Red;
            this.txt_namecomp.Name = "txt_namecomp";
            // 
            // txt_infocomp
            // 
            resources.ApplyResources(this.txt_infocomp, "txt_infocomp");
            this.txt_infocomp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_infocomp.Name = "txt_infocomp";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // text_welcome
            // 
            resources.ApplyResources(this.text_welcome, "text_welcome");
            this.text_welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_welcome.Name = "text_welcome";
            this.text_welcome.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_suggest
            // 
            resources.ApplyResources(this.text_suggest, "text_suggest");
            this.text_suggest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.text_suggest.Name = "text_suggest";
            // 
            // button_show
            // 
            this.button_show.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.button_show, "button_show");
            this.button_show.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button_show.Image = global::CNPM_ver3.Properties.Resources.view2;
            this.button_show.Name = "button_show";
            this.button_show.UseVisualStyleBackColor = false;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // LoginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.text_suggest);
            this.Controls.Add(this.text_welcome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_infocomp);
            this.Controls.Add(this.txt_namecomp);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.btForget);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_userid);
            this.Controls.Add(this.pro_name4);
            this.Controls.Add(this.button_addUser);
            this.Controls.Add(this.label_remember);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBox_language);
            this.Controls.Add(this.checkBox_remember);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pro_name1);
            this.Controls.Add(this.pro_name2);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_remember;
        private System.Windows.Forms.ComboBox comboBox_language;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_remember;
        private System.Windows.Forms.Button button_addUser;
        private System.Windows.Forms.Label pro_name4;
        private Bunifu.UI.WinForms.BunifuLabel pro_name2;
        private Bunifu.UI.WinForms.BunifuLabel pro_name1;
        private System.Windows.Forms.TextBox textBox_userid;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button btForget;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton button_login;
        private System.Windows.Forms.Label txt_namecomp;
        private System.Windows.Forms.Label txt_infocomp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label text_welcome;
        private System.Windows.Forms.Label text_suggest;
        private System.Windows.Forms.Button button_show;
    }
}



