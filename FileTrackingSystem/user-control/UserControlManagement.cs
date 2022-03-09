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
        ConnectionClass cc = new ConnectionClass();
        User user = new User();

        public static Button _refresh;

        public UserControlManagement()
        {
            InitializeComponent();
        }

        private void UserControlManagement_Load(object sender, EventArgs e)
        {
            _refresh = buttonRefresh;

            user.listUser();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = user.dtable;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUserRegistrationfrm user_registration = new AdminUserRegistrationfrm();
            user_registration.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            user.listUser();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = user.dtable;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if( e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxUsername.Text = row.Cells["Username"].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to delete this user account?";
            string title = "Deleting Data";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //To Do Delete
                if (textBoxUsername.Text == "")
                {
                    MessageBox.Show("Please select an specific data to delete!", "Deleting Data?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    user.delUser(textBoxUsername.Text);
                    user.listUser();
                    dataGridView1.AutoGenerateColumns = false;
                    dataGridView1.DataSource = user.dtable;
                    MessageBox.Show("Account successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

             
        }
    }
}
