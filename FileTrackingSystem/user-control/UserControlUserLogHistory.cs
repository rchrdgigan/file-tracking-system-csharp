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

        private void loadSearch()
        {
            user.seachHistoryLog();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = user.dtable;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            user.fname = textBox1.Text;
            loadSearch();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            user.activity = textBox2.Text;
            loadSearch();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string dts = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            user.date_from = dts;
            loadSearch();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string dts = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            user.date_to = dts;
            loadSearch();
        }
    }
}
