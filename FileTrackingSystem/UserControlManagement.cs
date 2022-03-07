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

        public UserControlManagement()
        {
            InitializeComponent();
        }

        private void UserControlManagement_Load(object sender, EventArgs e)
        {
            user.listUser();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = user.dtable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUserRegistrationfrm user_registration = new AdminUserRegistrationfrm();
            user_registration.Show();
        }
    }
}
