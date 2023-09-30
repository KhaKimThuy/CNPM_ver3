using BLL;
using BLLL;
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
    public partial class ManageMemberForm : Form
    {

        UserBLL ul = new UserBLL();

        public ManageMemberForm()
        {
            InitializeComponent();
        }

        private void ManageMemberForm_Load(object sender, EventArgs e)
        {
            TypeBLL tl = new TypeBLL();
            string[] types = tl.getUserType();
            foreach (string t in types)
            {
                comboBox_type.Items.Add(t);
            }
            showTable();
        }

        public void showTable()
        {
            dataGridView_user.ReadOnly = true;
            dataGridView_user.DataSource = ul.getUserInfoAll();
            dataGridView_user.RowTemplate.Height = 80;

            // Show image
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn = (DataGridViewImageColumn)dataGridView_user.Columns[5];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void DataGridView_user_Click(object sender, EventArgs e)
        {
            textBox_username.Text = dataGridView_user.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker_birthdate.Value = (DateTime)dataGridView_user.CurrentRow.Cells[2].Value;
            textBox1.Text = dataGridView_user.CurrentRow.Cells[3].Value.ToString();
            textBox_cccd.Text = dataGridView_user.CurrentRow.Cells[4].Value.ToString();

            byte[] img = (byte[])dataGridView_user.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox_user.Image = Image.FromStream(ms);

            textBox_email.Text = dataGridView_user.CurrentRow.Cells[6].Value.ToString();
            comboBox_gender.Text = dataGridView_user.CurrentRow.Cells[7].Value.ToString();
            textBox_pass.Text = dataGridView_user.CurrentRow.Cells[8].Value.ToString();
            comboBox_type.Text = dataGridView_user.CurrentRow.Cells[9].Value.ToString();
            comboBox1.Text = dataGridView_user.CurrentRow.Cells[10].Value.ToString();

        }
    }
}
