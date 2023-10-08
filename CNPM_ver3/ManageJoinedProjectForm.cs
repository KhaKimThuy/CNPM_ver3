using BLL;
using BLLL;
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
    public partial class ManageJoinedProjectForm : Form
    {
        UserBLL ul = new UserBLL();
        ProjectBLL pj = new ProjectBLL();
        public ManageJoinedProjectForm()
        {
            InitializeComponent();
        }

        private void ManageJoinedProjectForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            dataGridView_myJProject.ReadOnly = true;
            dataGridView_myJProject.DataSource = ul.GetAllProjectOfUser(Users.PK);
        }

        private void button_search_Click(object sender, EventArgs e)
        {   
            if (!string.IsNullOrEmpty(textBox_search.Text))
            {
                dataGridView_myJProject.DataSource = pj.SearchProjectU(Users.PK, textBox_search.Text);
            }
            else
            {
                MessageBox.Show("Search without any hint error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
