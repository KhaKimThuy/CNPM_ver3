using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CNPM_ver3.Properties;
using DTOO;

namespace CNPM_ver3
{
    public partial class LoginForm : Form
    {
        UserBLL ul = new UserBLL();
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //btForget.FlatAppearance.MouseOverBackColor = Color.White;
            //btForget.FlatAppearance.MouseDownBackColor = Color.White;
            //button_show.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            //button_show.FlatAppearance.MouseDownBackColor = Color.WhiteSmoke;
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string username = textBox_userid.Text;
            string password = textBox_pass.Text;

//            string username = "FT_96418_IT";
  //          string password = "bikhi";

            if (username == "" || password == "")
            {
                MessageBox.Show(Properties.Resources.empty_field, Properties.Resources.login_fail_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (password == "" && username == "")
                {
                    textBox_userid.Focus();
                }
                else if (password == "")
                {
                    textBox_pass.Focus();
                }
                else
                {
                    textBox_userid.Focus();
                }
            }
            else
            {
                if (ul.loginCheck(username, password))
                {
                    MessageBox.Show(Properties.Resources.login_success, Properties.Resources.login_success_title);
                    this.Hide();
                    UserHomeForm infoForm = new UserHomeForm();
                    infoForm.Show();
                }
                else
                {
                    MessageBox.Show(Properties.Resources.login_notexist, Properties.Resources.login_fail_title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox_userid.Focus();
                }
            }
        }

        private void ApplyLanguage(object sender, EventArgs e)
        {
            var changeLanguage = comboBox_language.Text;
            if (changeLanguage == "English")
            {
                ChangeLanguageClass.UpdateLanguage("language", "en");
            }else if (changeLanguage == "Tiếng Việt")
            {
                ChangeLanguageClass.UpdateLanguage("language", "vi-VN");
            }
            Application.Restart();
        }

        //private void button_forget_Click(object sender, EventArgs e)
        //{
        //    string value = "";
        //    if (InputBox(Properties.Resources.get_password, Properties.Resources.ask_email, ref value) == DialogResult.OK)
        //    {
        //        if (ul.IsValidEmail(value))
        //        {
        //            string[] id_pass = ul.GetAccountByEmail(value);
        //            string id = id_pass[0];
        //            string pass = id_pass[1];
        //            string message = String.Format("Your USER ID: {0}\nYour PASSWORD: {1}", id, pass);
        //            string title = "Your SK account have just been created";
        //            ul.verifyEmail(value, title, message);

        //            MessageBox.Show(Properties.Resources.check_email_4_ac, Properties.Resources.get_password, MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        else
        //        {
        //            MessageBox.Show(Properties.Resources.login_notexist, Properties.Resources.get_password, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(36, 36, 372, 13);
            textBox.SetBounds(36, 86, 700, 20);
            buttonOk.SetBounds(228, 160, 160, 60);
            buttonCancel.SetBounds(400, 160, 160, 60);

            label.AutoSize = true;
            form.ClientSize = new Size(796, 307);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }

        private void button_addUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUForm = new AddUserForm();
            addUForm.Show();
        }

        private void btForget_Click(object sender, EventArgs e)
        {
            btForget.FlatStyle = FlatStyle.Flat;
            btForget.FlatAppearance.BorderSize = 0;
            ForgetPassForm forgetPassForm = new ForgetPassForm();
            forgetPassForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_language_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        bool holder_us = true;
        private void textBox_userid_Click(object sender, EventArgs e)
        {
            if (holder_us)
            {
                holder_us = false;
                textBox_userid.Text = "";
            }
        }

        bool holder_pw = true;
        private void textBox_pass_Click(object sender, EventArgs e)
        {
            if (holder_pw)
            {
                holder_pw = false;
                textBox_pass.Text = "";
            }
        }

        private void textBox_userid_Leave(object sender, EventArgs e)
        {
            if (textBox_userid.Text == "")
            {
                textBox_userid.Text = "Username";
                textBox_userid.ForeColor = Color.Gray;
                holder_us = true;
            }
        }

        private void textBox_pass_Leave(object sender, EventArgs e)
        {
            if (textBox_pass.Text == String.Empty)
            {
                textBox_pass.Text = "Password";
                textBox_pass.ForeColor = Color.Gray;
                holder_pw = true;
            }
        }

        private void textBox_userid_TextChanged(object sender, EventArgs e)
        {
            textBox_userid.ForeColor = Color.Black;
        }

        private void textBox_pass_TextChanged(object sender, EventArgs e)
        {
            textBox_pass.ForeColor = Color.Black;
        }

        private void textBox_userid_Enter(object sender, EventArgs e)
        {
            button_login_Click(sender, e);
        }

        private void textBox_userid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_login_Click(sender, e);
        }

        private void textBox_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button_login_Click(sender, e);
        }

        bool control_show = true;
        private void button_show_Click(object sender, EventArgs e)
        {
            if (control_show)
            {
                button_show.Image = Properties.Resources.hide4;
                control_show = false;
            }
            else
            {
                button_show.Image = Properties.Resources.view2;
                control_show = true;
            }
        }

        private void button_show_BackColorChanged(object sender, EventArgs e)
        {
            button_show.ForeColor = Color.White;
        }

        private void button_show_ForeColorChanged(object sender, EventArgs e)
        {
            button_show.ForeColor = Color.White;
        }

        private void btForget_MouseHover(object sender, EventArgs e)
        {
            btForget.Cursor = Cursors.Hand;
        }

        private void button_login_MouseHover(object sender, EventArgs e)
        {
            button_login.Cursor = Cursors.Hand;
        }

        private void checkBox_remember_MouseHover(object sender, EventArgs e)
        {
            checkBox_remember.Cursor = Cursors.Hand;
        }

        private void pro_name2_Click(object sender, EventArgs e)
        {

        }
    }
}
