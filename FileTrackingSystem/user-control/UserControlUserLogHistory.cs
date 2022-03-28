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
    public partial class UserControlUserLogHistory : UserControl
    {
        User user = new User();

        public UserControlUserLogHistory()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            user.diplayHistoryLog();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = user.dtable;
        }

        private void UserControlUserLogHistory_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
