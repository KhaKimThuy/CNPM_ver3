using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Mail;
using System.Net;
using BLLL;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace CNPM_ver3
{
    public partial class AddUserForm : Form
    {
        UserBLL ul = new UserBLL();

        public AddUserForm()
        {
            InitializeComponent();
        }
        bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9_%+-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            DateTime birthdate = dateTimePicker_birthdate.Value;
            string type = comboBox_type.Text;
            string dp = comboBox_dp.Text;
            string lv = comboBox_lv.Text;
            string cccd = textBox_cccd.Text;
            string gender = comboBox_gender.Text;

            string email = textBox_email.Text;
            string phone = textBox_phone.Text;

            string address = textBox_address.Text;

            byte[] image = null;
            try
            {
                MemoryStream ms = new MemoryStream();
                pictureBox_user.Image.Save(ms, pictureBox_user.Image.RawFormat);
                image = ms.ToArray();
            }catch
            {
                MessageBox.Show("Image is empty");
            }


            int y_user = birthdate.Year;
            int y_now = DateTime.Now.Year;

            // Validate information of new user
            if (type == "")
            {
                comboBox_type.Focus();
            }
            //else if (username == "" || !username.All(c => Char.IsLetter(c) || c == ' '))
            else if (username == "")
            {
                        MessageBox.Show("Name is invalid ", "Error");
            }
            // Validate birthdate
            else if (y_now - y_user < 18)
            {
                MessageBox.Show("Age is invalid", "Error");
            }
            else if (address == "")
            {
                MessageBox.Show("Address is invalid ", "Error");
            }
            else if (cccd.Length < 8)
            {
                MessageBox.Show("CCCD is invalid ", "Error");
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Email is invalid ", "Error");
            }
            else if (gender == "")
            {
                MessageBox.Show("Gender is invalid ", "Error");
            }
            else if (image==null)
            {
                MessageBox.Show("Image user is invalid ", "Error");
            }
            else
            {
                if (ul.insertUser(type, username, birthdate, address, cccd, image, email, gender, dp, lv, phone))
                {
                    MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fail to add new user", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            TypeBLL tl = new TypeBLL();
            string[] types = tl.getUserType();
            foreach (string t in types)
            {
                comboBox_type.Items.Add(t);
            }

            LevelBLL lv = new LevelBLL();
            string[] levels = lv.GetUserLevel();
            foreach (string t in levels)
            {
                comboBox_lv.Items.Add(t);
            }

            DepartmentBLL dp = new DepartmentBLL();
            string[] dps = dp.GetUserDP();
            foreach (string t in dps)
            {
                comboBox_dp.Items.Add(t);
            }
        }

        private void label_toLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm lg = new LoginForm();
            lg.Show();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            // `OpenFileDialog` cho phép người dùng chọn một hoặc nhiều tập tin từ hệ thống tệp tin.
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox_user.Image = Image.FromFile(ofd.FileName);
        }
    }
}
