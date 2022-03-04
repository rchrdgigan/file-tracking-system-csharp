using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTrackingSystem
{
    public partial class dashboardfrm : Form
    {
        public static string _username;

        public dashboardfrm()
        {
            InitializeComponent();
        }

        private void dashboardfrm_Load(object sender, EventArgs e)
        {
            welcomeLbl.Text = "Welcome, " + loginfrm._fname + " !";
            usernameLbl.Text = loginfrm._username;
            roleLbl.Text = loginfrm._role;
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            _username = usernameLbl.Text;
            this.Close();
            loginfrm loginFrm = new loginfrm();
            loginFrm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this Application?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Close the Application
                Application.Exit();
            }
            
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = dashboardBtn.Top;
            panelMark.Height = dashboardBtn.Height;

            UserControlDashboard UCDashdashboard = new UserControlDashboard();
            showPanel.Controls.Add(UCDashdashboard);
            UCDashdashboard.BringToFront();
        }

        private void farmersBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = farmersBtn.Top;
            panelMark.Height = farmersBtn.Height;

            UserControlFarmers UCFarmers = new UserControlFarmers();
            showPanel.Controls.Add(UCFarmers);
            UCFarmers.BringToFront();
        }

    }
}
