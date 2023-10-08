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
    public partial class ForgetPassForm2 : Form
    {

        string np1, np2;
        UserBLL ul = new UserBLL();


        public ForgetPassForm2()
        {
            InitializeComponent();
            tbNPass.Text = string.Empty;
            tbNPass2.Text = string.Empty;
        }

        private void bt_n3_FPF_Click(object sender, EventArgs e)
        {
            np1 = tbNPass.Text;
            np2 = tbNPass2.Text;

            if (np1.Equals("") || np2.Equals(""))
            {
                MessageBox.Show("Please fill everything before click", "Fill Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!(np1.Equals(np2)))
            {
                MessageBox.Show("Your confirm password is not the same", "Valid Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbNPass.Text = string.Empty;
                tbNPass2.Text = string.Empty;
                return;
            }

            ul.updatePassword(Users.F_USER, np1);

            MessageBox.Show("Your password has been updated. Please login", "Update successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Close();
            
        }
    }
}
