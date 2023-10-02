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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
            checkState();
            
        }

        void checkState()
        {
            UserBLL myUL = new UserBLL();

            string s_id = Users.USER_ID;
            //string s_id = "05907";
            DataRow myRow = myUL.checkRequest(s_id);
            if(myRow != null)
            {
                tReq.Text = myRow["R_DES"].ToString();
                bt_Request.Text = "CHANGE";
            } else
            {
                tReq.Text = "";
                bt_Request.Text = "REQUEST";
            }

        }
        

        private void bt_delete_Click(object sender, EventArgs e)
        {
            UserBLL myUL = new UserBLL();
            string s_id = Users.USER_ID;
            myUL.updateRequest(s_id);
            tReq.Text = "";
            bt_Request.Text = "REQUEST";

        }

        private void bt_Request_Click(object sender, EventArgs e)
        {
            UserBLL myUL = new UserBLL();
            string myText = bt_Request.Text.ToString();
            string myDes = tReq.Text.ToString();

            string s_id = Users.USER_ID;
            //string s_id = "05907";
            string r_id = "85001";

            if (!myText.Equals("REQUEST"))
            {
                myUL.updateRequest(s_id);
            
            }

            int res = myUL.addRequest(myDes, s_id, r_id);

            if (res == 1)
            {
                MessageBox.Show("Update request successfully", "Add Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_Request.Text = "CHANGE";
            }
            else
            {
                string hello = "lalaland";
                MessageBox.Show(hello, "Add Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

      

      

        }



    }
}
