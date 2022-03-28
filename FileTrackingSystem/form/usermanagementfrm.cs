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
    public partial class AdminUserRegistrationfrm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        User user = new User();

        public AdminUserRegistrationfrm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxFname.Text == "" || textBoxLname.Text == "" || textBoxContact.Text == "" || textBoxEmail.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill-up all entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (user.IsValidEmail(textBoxEmail.Text) == true)
                {
                    if (comboBoxRole.Text != "Admin" && comboBoxRole.Text != "Staff")
                    {
                        MessageBox.Show("The role must be Admin or Staff only!");
                    }
                    else
                    {
                        user.fname = textBoxFname.Text;
                        user.lname = textBoxLname.Text;
                        user.email = textBoxEmail.Text;
                        user.contact = textBoxContact.Text;
                        user.log_username = textBoxUsername.Text;
                        user.log_password = textBoxPassword.Text;
                        string roles = comboBoxRole.Text;
                        user.create(roles);
                        if (user.message != "User Already Exist!")
                        {
                            MessageBox.Show("" + user.message, "Register Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //History Log
                            user.activity = "Created " + comboBoxRole.Text + " account in User Management...";
                            user.user_id = loginfrm._log_id;
                            user.createLog();
                            //End Log
                            user.listUser();
                            this.Close();
                            //To activate navbar and body
                            dashboardfrm.navpanel.Enabled = true;
                            dashboardfrm.contentpanel.Enabled = true;
                            dashboardfrm.managementBtn_refesh.PerformClick();
                        }
                        else
                        {
                            MessageBox.Show("" + user.message, "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Email");
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            //To activate navbar and body
            dashboardfrm.navpanel.Enabled = true;
            dashboardfrm.contentpanel.Enabled = true;
        }

        private void AdminUserRegistrationfrm_Load(object sender, EventArgs e)
        {
            TransitionsAPI.AnimateWindow(this.Handle, 100, TransitionsAPI.fadeIN);

        }
    }
}
