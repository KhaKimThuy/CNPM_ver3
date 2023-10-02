using BLLL;
using DTOO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_ver3
{
    public partial class AddProjectForm : Form
    {
        ProjectBLL pj = new ProjectBLL();
        public AddProjectForm()
        {
            InitializeComponent();
        }

        

        private void button_addProject_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string ver = textBox_ver.Text;
            DateTime start = dateTimePicker_start.Value;
            DateTime end = dateTimePicker_end.Value;
            DateTime exp = dateTimePicker_exp.Value;
            string desc = textBox_desc.Text;
            string u_id = Users.USER_ID;

            if (pj.InsertPJ(name, desc, exp, start, end, ver, u_id))
            {
                MessageBox.Show(Properties.Resources.add_pj_success, Properties.Resources.title_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(Properties.Resources.add_pj_fail, Properties.Resources.title_fail, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddProjectForm_Load(object sender, EventArgs e)
        {

        }
    }
}
