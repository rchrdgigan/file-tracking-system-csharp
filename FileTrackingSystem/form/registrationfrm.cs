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
    public partial class registrationfrm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        User user = new User();
        loginfrm lf = new loginfrm();

        public static string _username;

        public registrationfrm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            lf.Show();
            this.Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxFname.Text == "" || textBoxLname.Text == "" || textBoxEmail.Text == "" || textBoxContact.Text == "" || textBoxUsername.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Please fill-up all entry!", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (user.IsValidEmail(textBoxEmail.Text) == false)
                {
                    MessageBox.Show("Invalid Email", "Format", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    user.fname = textBoxFname.Text;
                    user.lname = textBoxLname.Text;
                    user.email = textBoxEmail.Text;
                    user.contact = textBoxContact.Text;
                    user.log_username = textBoxUsername.Text;
                    user.log_password = textBoxPassword.Text;
                    string roles = "";
                    user.create(roles);
                    if (user.message != "User Already Exist!")
                    {
                        //History Log
                        user.activity = "Created own Staff account in user registration...";
                        user.user_id = user.modifId.ToString();
                        user.createLog();
                        //End Log

                        MessageBox.Show("" + user.message, "Register Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lf.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("" + user.message, "Register Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            
        }
    }
}
