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
            dataGridView_project.DataSource = pj.GetProjectInfoAllOfMan(Users.PK);
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
            curr_pj_id = dataGridView_project.CurrentRow.Cells["PJ_ID"].Value.ToString();

            textBox_name.Text = dataGridView_project.CurrentRow.Cells["PJ_NAME"].Value.ToString();
            textBox_desc.Text = dataGridView_project.CurrentRow.Cells["PJ_DES"].Value.ToString();
            dateTimePicker_exp.Value = (DateTime)dataGridView_project.CurrentRow.Cells["PJ_EXPECT_FIN"].Value;
            dateTimePicker_start.Value = (DateTime)dataGridView_project.CurrentRow.Cells["PJ_START"].Value;
            dateTimePicker_end.Value = (DateTime)dataGridView_project.CurrentRow.Cells["PJ_FINISH"].Value;
            textBox_ver.Text = dataGridView_project.CurrentRow.Cells["PJ_VERSION"].Value.ToString();
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

        private void button_del_Click(object sender, EventArgs e)
        {
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (curr_pj_id != null)
            {
                curr_pj_id = dataGridView_project.CurrentRow.Cells[0].Value.ToString();

                string pj_name = textBox_name.Text;
                string desc = textBox_desc.Text;
                DateTime exp = dateTimePicker_exp.Value;
                DateTime start = dateTimePicker_start.Value;
                DateTime end = dateTimePicker_end.Value;
                string ver = textBox_ver.Text;

                if (pj.UpdateProject(curr_pj_id, pj_name, desc, exp, start, end, ver, Users.PK))
                {
                    MessageBox.Show("Update project information successfully");
                    showTable();
                }
                else
                {
                    MessageBox.Show("Fail to update project information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Choose a project", "Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
/*            dataGridView_project.DataSource = pj.searchStudent(textBox_search.Text);
            dataGridView_project.RowTemplate.Height = 80;

            // Xử lý cột dữ liệu chứa ảnh
            // `DataGridViewImageColumn` kế thừa từ `DataGridViewColumn` và cung cấp các chức năng để hiển thị hình
            // ảnh trong các ô của cột tương ứng.
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)DataGridView_student.Columns[7];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; */
        }
    }
}
