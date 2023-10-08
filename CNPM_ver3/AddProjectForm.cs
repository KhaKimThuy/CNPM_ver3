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

        public bool ValidateDeadline(DateTime start, DateTime end, DateTime exp)
        {
            TimeSpan s_e = end - start;
            TimeSpan ex_e = end - exp;
            TimeSpan ex_s = exp - start;

            int start_end = s_e.Days;
            int exp_end = ex_e.Days;
            int exp_start = ex_s.Days;

            // Validate deadline
            if (start_end <= 0 || exp_end <= 0 || exp_start <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_addProject_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string ver = textBox_ver.Text;
            DateTime start = dateTimePicker_start.Value;
            DateTime end = dateTimePicker_end.Value;
            DateTime exp = dateTimePicker_exp.Value;
            string desc = textBox_desc.Text;
            string pk = Users.PK;

            if (ValidateChildren(ValidationConstraints.Enabled) && ValidateDeadline(start, end, exp))
            {
                if (pj.InsertPJ(name, desc, exp, start, end, ver, pk))
                {
                    MessageBox.Show(Properties.Resources.add_pj_success, Properties.Resources.title_success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(Properties.Resources.add_pj_fail, Properties.Resources.title_fail, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void AddProjectForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_name.Text))
            {
                e.Cancel = true;
                textBox_name.Focus();
                errorProvider1.SetError(textBox_name, "Please enter project name");
            }
        }
    }
}
