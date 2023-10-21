using BLL;
using BLLL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CNPM_ver3
{
    public partial class ManageMemberForm : Form
    {

        UserBLL ul = new UserBLL();
        OverwriteForm ovf = new OverwriteForm();
        string curr_pk = "";
        int flag = 0;

        public ManageMemberForm()
        {
            InitializeComponent();
            btDisable.Text = "Disable";
            button_update.Visible = true;
        }

        private void ManageMemberForm_Load(object sender, EventArgs e)
        {
            loadTable();
        }

        public void loadTable()
        {
            TypeBLL tl = new TypeBLL();
            string[] types = tl.getUserType();
            foreach (string t in types)
            {
                comboBox_type.Items.Add(t);
            }

            LevelBLL lv = new LevelBLL();
            string[] levels = lv.GetUserLevel();
            foreach (string t in levels)
            {
                comboBox_lv.Items.Add(t);
            }

            DepartmentBLL dp = new DepartmentBLL();
            string[] dps = dp.GetUserDP();
            foreach (string t in dps)
            {
                comboBox_dp.Items.Add(t);
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
            imageColumn = (DataGridViewImageColumn)dataGridView_user.Columns["USER_IMAGE"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void toolStripLabel_addUser_Click(object sender, EventArgs e)
        {
            ovf.openChildForm(new AddUserForm(), ref panel_main);
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string u_name = textBox_username.Text;
            DateTime bd = dateTimePicker_birthdate.Value;
            string cccd = textBox_cccd.Text;
            string addr = textBox_addr.Text;
            string gd = comboBox_gender.Text;
            string email = textBox_email.Text;
            string vt_name = comboBox_type.Text;
            string u_pass = textBox_pass.Text;
            string lv_name = comboBox_lv.Text;
            string dp_name = comboBox_dp.Text;
            string u_phone = textBox_phone.Text;

            MemoryStream ms = new MemoryStream();
            pictureBox_user.Image.Save(ms, pictureBox_user.Image.RawFormat);
            byte[] img = ms.ToArray();
            if (ul.UpdateUserInfo(curr_pk, u_name, bd, cccd, addr, gd, email, vt_name, u_pass, lv_name, dp_name, u_phone, img))
            {
                MessageBox.Show("Update user information successfully");
            }
            else
            {
                MessageBox.Show("Fail to update user information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Photo(*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox_user.Image = Image.FromFile(ofd.FileName);
        }

        private void btDisable_Click(object sender, EventArgs e)
        {

            if (curr_pk.Equals("")) return;

            if(flag == 0)
            {
                if (MessageBox.Show("Do you want to disable this user?", "Disable User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int res = ul.disableUser(curr_pk, flag);

                    if (res == 1)
                    {

                        MessageBox.Show("This user has been disabled", "Sucessfully Disable User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadTable();

                    }
                }

                return;
            }

            if (flag == 1)
            {
                if (MessageBox.Show("Do you want to enable this user?", "Enable User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int res = ul.disableUser(curr_pk, flag);

                    if (res == 1)
                    {

                        MessageBox.Show("This user has been enabled", "Sucessfully Enable User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        loadTableDis();

                    }
                }

                return;
            }


        }


        // function loadTableDisable 
        // copy from function loadTable above

        public void loadTableDis()
        {
            TypeBLL tl = new TypeBLL();
            string[] types = tl.getUserType();
            foreach (string t in types)
            {
                comboBox_type.Items.Add(t);
            }

            LevelBLL lv = new LevelBLL();
            string[] levels = lv.GetUserLevel();
            foreach (string t in levels)
            {
                comboBox_lv.Items.Add(t);
            }

            DepartmentBLL dp = new DepartmentBLL();
            string[] dps = dp.GetUserDP();
            foreach (string t in dps)
            {
                comboBox_dp.Items.Add(t);
            }
            showTableDis();
        }

        // function showTableDisable
        // copy from function showTable above

        public void showTableDis()
        {
            dataGridView_user.ReadOnly = true;
            dataGridView_user.DataSource = ul.getUserInfoDis();
            dataGridView_user.RowTemplate.Height = 80;

            try
            {
                // Show image
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
                imageColumn = (DataGridViewImageColumn)dataGridView_user.Columns[7];
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            } catch { }
            
        }


        // function to switch between disable and enable list
        private void btDisableList_Click(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                loadTableDis();
                flag = 1;
                btDisableList.Text = "Return management form";
                btDisable.Text = "Enable";
                button_update.Visible = false;
                return;
            }

            if(flag == 1)
            {
                loadTable();
                flag = 0;
                btDisableList.Text = "Disabled user list";
                btDisable.Text = "Disable";
                button_update.Visible = true;
                return;

            }
        }
    }
}
