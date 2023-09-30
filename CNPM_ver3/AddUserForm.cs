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

namespace CNPM_ver3
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            UserBLL ul = new UserBLL();

            string vt_name = comboBox_type.Text;
            string username = textBox_username.Text;
            DateTime birthdate = dateTimePicker_birthdate.Value;
            string address = textBox_address.Text;
            string cccd = textBox_cccd.Text;
            string email = textBox_email.Text;
            string gender = comboBox_gender.Text;

            MemoryStream ms = new MemoryStream();
            pictureBox_user.Image.Save(ms, pictureBox_user.Image.RawFormat);
            byte[] image = ms.ToArray();
            if (ul.insertUser(vt_name, username, birthdate, address, cccd, image, email, gender))
            {
                MessageBox.Show("New User Added", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
