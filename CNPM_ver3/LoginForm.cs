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

namespace CNPM_ver3
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        //ResourceManager _rm = new ResourceManager("LoginForm", Assembly.GetExecutingAssembly());

        private void button_login_Click(object sender, EventArgs e)
        {
            UserBLL ul = new UserBLL();

            string username = textBox_userid.Text;
            string password = textBox_pass.Text;

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
                    textBox_userid.Clear();
                    textBox_pass.Clear();

                    // focus
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
    }
}
