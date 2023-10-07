using BLL;
using DTOO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_ver3
{
    public partial class ForgetPassForm : Form
    {

        string myUser;

        UserBLL ul = new UserBLL();

        public ForgetPassForm()
        {
            InitializeComponent();
            tbCCCD.Text = string.Empty;
            tbEmail.Text = string.Empty;
  
        }

        private void bt_n1_FPF_Click(object sender, EventArgs e)
        {

            myUser = verifyValues();
            if (myUser.Equals("")) return;

            Users.F_USER = myUser;
            Users.F_EMAIL = tbEmail.Text.ToString();

            int OTP = gerenateOTP();

            string title = "Reset password OTP";

            string m = "Your OTP : " + OTP;

            ul.verifyEmail(Users.F_EMAIL, title, m);

            ul.addOTP(Users.F_USER, OTP.ToString());

            this.Hide();
            ForgetPassForm1 forgetPassForm1 = new ForgetPassForm1();
            forgetPassForm1.Closed += (s, args) => this.Close();
            forgetPassForm1.Show();


        }


        // get the pk of user

        private string verifyValues()
        {
            string cccd = tbCCCD.Text.ToString();
            
            string email = tbEmail.Text.ToString();

            if(cccd.Equals("") || email.Equals(""))
            {
                MessageBox.Show("Please fill everything before click", "Fill Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }

            
            myUser = ul.checkForgot(cccd, email);

            if (myUser.Equals(""))
            {
                MessageBox.Show("Can not find your account ", "Find Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return "";
            }


            return myUser;


        }


        private int gerenateOTP()
        {
            Random random = new Random();
            return random.Next(100000, 999999);
        }

    }
}
