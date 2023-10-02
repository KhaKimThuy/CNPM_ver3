using BLL;
using BLLL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CNPM_ver3
{
    public partial class ManageProjectForm : Form
    {
        ProjectBLL pj = new ProjectBLL();
        OverwriteForm ovf = new OverwriteForm();
        string curr_pj_id = null;

        public ManageProjectForm()
        {
            InitializeComponent();
        }

        private void ManageProjectForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridView_project.ReadOnly = true;
            dataGridView_project.DataSource = pj.GetProjectInfoAllOfMan(Users.USER_ID);
        }

        private void toolStripLabel_addProject_Click(object sender, EventArgs e)
        {
            ovf.openChildForm(new AddProjectForm(), ref panel_main);
        }

        private void toolStripLabel_back_Click(object sender, EventArgs e)
        {
            ovf.HomeForm(ref panel_main, ref panel_cover);
        }

        private void DataGridView_Project_Click(object sender, EventArgs e)
        {
            curr_pj_id = dataGridView_project.CurrentRow.Cells[0].Value.ToString();

            textBox_name.Text = dataGridView_project.CurrentRow.Cells[1].Value.ToString();
            textBox_desc.Text = dataGridView_project.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker_exp.Value = (DateTime)dataGridView_project.CurrentRow.Cells[3].Value;
            dateTimePicker_start.Value = (DateTime)dataGridView_project.CurrentRow.Cells[4].Value;
            dateTimePicker_end.Value = (DateTime)dataGridView_project.CurrentRow.Cells[5].Value;
            textBox_ver.Text = dataGridView_project.CurrentRow.Cells[6].Value.ToString();
        }

        private void button_addMember_Click(object sender, EventArgs e)
        {
            if (curr_pj_id != null)
            {
                ovf.openChildForm(new AddMember2Project(curr_pj_id), ref panel_main);
            }
            else
            {
                MessageBox.Show("Choose a project", "Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
