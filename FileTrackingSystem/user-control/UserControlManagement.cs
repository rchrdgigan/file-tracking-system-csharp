using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTrackingSystem
{
    public partial class UserControlManagement : UserControl
    {
        User user = new User();

        public static Button _refresh;

        public UserControlManagement()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            user.listUser();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = user.dtable;
        }

        private void loadSearch()
        {
            user.search();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = user.dtable;
        }

        private void UserControlManagement_Load(object sender, EventArgs e)
        {
            user.countUser();
            labelCountUser.Text = user.count.ToString();
            _refresh = buttonRefresh;
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUserRegistrationfrm user_registration = new AdminUserRegistrationfrm();
            user_registration.Show();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = false;
            dashboardfrm.contentpanel.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //To Do Delete
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Please select an specific data to delete!", "Deleting Data?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure want to delete this user account?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    //History Log
                    user.activity = "Removed account in User Management..";
                    user.user_id = loginfrm._log_id;
                    user.createLog();
                    //End Log

                    user.delUser(textBoxUsername.Text);
                    loadData();
                    MessageBox.Show("Account successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user.fname = textBox1.Text;
            loadSearch();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            user.lname = textBox2.Text;
            loadSearch();
        }

        private void archiveBtn_Click(object sender, EventArgs e)
        {
            //To Do Archive
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Please select an specific data to archived!", "Archive Data?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure want to archive this user account?", "Archive Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //History Log
                    user.activity = "Archived account in User Management..";
                    user.user_id = loginfrm._log_id;
                    user.createLog();
                    //End Log

                    user.archive(textBoxUsername.Text);
                    loadData();
                    MessageBox.Show("Account successfully archived!", "Archive Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Select data by cell
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxUsername.Text = row.Cells["Username"].Value.ToString();
            }
        }
    }
}
