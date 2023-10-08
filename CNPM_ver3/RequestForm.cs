using BLL;
using BLLL;
using DTOO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_ver3
{
    public partial class RequestForm : Form
    {
        RequestBLL reqBll = new RequestBLL();
        List<string> files = new List<string>();
        UserBLL myUL = new UserBLL();


        public RequestForm()
        {
            InitializeComponent();
            checkState();
            
        }


        void checkState()
        {
            UserBLL myUL = new UserBLL();

            string s_id = Users.PK;
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
            textBox_subject.Clear();
            textBox_toUser.Clear();
            textBox_content.Clear();
        }

        private void bt_Request_Click(object sender, EventArgs e)
        {
            /*
            string myDes = tReq.Text.ToString();
            string s_id = Users.PK;
            //string s_id = "05907";
            string r_id = "85001";

            if (!myText.Equals("REQUEST"))
            {
                myUL.updateRequest(s_id);
            
            }
            */

            string subject = textBox_subject.Text;
            string pk_receiver = textBox_toUser.Text;
            string content = textBox_content.Text;
            string pk_sender = Users.PK;
            if (reqBll.AddRequest(subject, content, pk_sender, pk_receiver, files))
            {
                MessageBox.Show("Request successfully", "Add Request", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail to request", "Add Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            /*using(OpenFileDialog dlg = new OpenFileDialog() { Filter = "Text Documents (*.pdf;) |*.pdf", ValidateNames=true})
            {
                if(dlg.ShowDialog() == DialogResult.OK) 
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to upload this file?", "Attach file", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.Yes)
                    {
                        string filename = dlg.FileName;
                        reqBll.UploadFile(Users.PK, textBox_toUser.Text, filename);
                    }
                    else
                    {
                        return;
                    }
                }
            }*/
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    files.Add(file);
                }
                MessageBox.Show("Uploaded " + files.Count + " successfully");
            }
        }
    }
}
