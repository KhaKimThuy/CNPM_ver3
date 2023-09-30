﻿using DTOO;
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
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            if (Users.VT_NAME == "Intern")
            {
                panel_header.BackColor = Color.FromArgb(14, 33, 160);
            }

            try
            {
                textBox_username.Text = Users.USER_NAME;
                dateTimePicker_birthdate.Value = (DateTime)Users.USER_BIRTH;
                textBox_pass.Text = Users.PASSWORD;
                comboBox_type.Text = Users.VT_NAME;
                textBox_cccd.Text = Users.USER_CCCD;
                comboBox_enable.Text = Users.ENABLE.ToString();
                comboBox_gender.Text = Users.USER_GENDER;
                textBox_email.Text = Users.USER_EMAIL;
                textBox_address.Text = Users.USER_ADDRESS;


                byte[] img = (byte[])Users.USER_IMAGE;
                MemoryStream ms = new MemoryStream(img);
                pictureBox_user.Image = Image.FromStream(ms);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
