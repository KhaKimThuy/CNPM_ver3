using DTOO;
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

namespace CNPM_ver3
{
    public partial class UserHomeForm : Form
    {
        public UserHomeForm()
        {
            InitializeComponent();
        }

        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panel_main.Controls.Add(childForm);

            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void UserHomeForm_Load(object sender, EventArgs e)
        {
            if (Users.VT_NAME=="Intern")
            {
                panel_tool.BackColor = Color.FromArgb(14, 33, 160);
                panel_header.BackColor = Color.FromArgb(14, 33, 160);
                button_manageMenber.Visible = false;
                button_addMember.Visible = false;
                button_assign.Visible = false;
                button_profile.BackColor = Color.FromArgb(77, 45, 183);
                button_3.BackColor = Color.FromArgb(77, 45, 183);
                button_4.BackColor = Color.FromArgb(77, 45, 183);
            }

            try
            {
                byte[] img = (byte[])Users.USER_IMAGE;
                MemoryStream ms = new MemoryStream(img);
                pictureBox_user.Image = Image.FromStream(ms);

                label_role.Text = Users.VT_NAME;
                label_username.Text = Users.USER_NAME;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void button_addmember_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.Show();
        }

        private void button_manageMenber_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageMemberForm());
        }

        private void button_addMember_Click_1(object sender, EventArgs e)
        {
            openChildForm(new AddUserForm());
        }

        private void button_profile_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfileForm());
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            if (activeform != null)
                activeform.Close();
            panel_main.Controls.Add(panel_cover);
        }


    }
}
