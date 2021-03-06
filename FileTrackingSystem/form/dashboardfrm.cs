using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileTrackingSystem
{
    public partial class dashboardfrm : Form
    {
        public static string _username;
        public static Panel navpanel;
        public static Panel contentpanel;
        public static Button rsbsa_refesh;
        public static Button managementBtn_refesh;
        User user = new User();

        public dashboardfrm()
        {
            InitializeComponent();
        }

        private void dashboardfrm_Load(object sender, EventArgs e)
        {
            navpanel = panel1;
            contentpanel = showPanel;
            rsbsa_refesh = RSBSAbtn;
            managementBtn_refesh = managementBtn;
            welcomeLbl.Text = "Welcome, " + loginfrm._fname + " !";
            usernameLbl.Text = loginfrm._username;
            roleLbl.Text = loginfrm._role;

            if (roleLbl.Text == "Staff")
            {
                budgetBtn.Hide();
                managementBtn.Hide();
                logBtn.Hide();
                buttonArchive.Hide();
            }
            else
            {
                TransitionsAPI.AnimateWindow(this.Handle, 1000, TransitionsAPI.fadeIN);
            }
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure want to logout?";
            string title = "Logout";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                _username = usernameLbl.Text;
                this.Close();
                loginfrm loginFrm = new loginfrm();
                loginFrm.Show();
                //History Log
                user.activity = "Logout user account...";
                user.user_id = loginfrm._log_id;
                user.createLog();
                //End Log
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string message = "Do you want to close this Application?";
            string title = "Close Application";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //History Log
                user.activity = "Closed the application...";
                user.user_id = loginfrm._log_id;
                user.createLog();
                //End Log

                // Close the Application
                Application.Exit();
            }
            
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = dashboardBtn.Top;
            panelMark.Height = dashboardBtn.Height;

            UserControlDashboard dashboard = new UserControlDashboard();
            showPanel.Controls.Add(dashboard);
            dashboard.BringToFront();
        }

        private void farmersBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = farmersBtn.Top;
            panelMark.Height = farmersBtn.Height;

            UserControlFarmers farmers = new UserControlFarmers();
            showPanel.Controls.Add(farmers);
            farmers.BringToFront();
        }

        private void managementBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = managementBtn.Top;
            panelMark.Height = managementBtn.Height;

            UserControlManagement user_management = new UserControlManagement();
            showPanel.Controls.Add(user_management);
            user_management.BringToFront();
        }

        private void RSBSAbtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = RSBSAbtn.Top;
            panelMark.Height = RSBSAbtn.Height;

            UserControlRSBSA rsbsa = new UserControlRSBSA();
            showPanel.Controls.Add(rsbsa);
            rsbsa.BringToFront();
        }

        private void fisheriesBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = fisheriesBtn.Top;
            panelMark.Height = fisheriesBtn.Height;

            UserControlFisheries fisheries = new UserControlFisheries();
            showPanel.Controls.Add(fisheries);
            fisheries.BringToFront();
        }

        private void budgetBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = budgetBtn.Top;
            panelMark.Height = budgetBtn.Height;

            UserControlCalamityDamage calamity = new UserControlCalamityDamage();
            showPanel.Controls.Add(calamity);
            calamity.BringToFront();
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = logBtn.Top;
            panelMark.Height = logBtn.Height;

            UserControlUserLogHistory ulh = new UserControlUserLogHistory();
            showPanel.Controls.Add(ulh);
            ulh.BringToFront();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            panelMark.Visible = true;
            panelMark.Top = buttonArchive.Top;
            panelMark.Height = buttonArchive.Height;

            UserControlArchiveHistory arch_his = new UserControlArchiveHistory();
            showPanel.Controls.Add(arch_his);
            arch_his.BringToFront();
        }
    }
}
