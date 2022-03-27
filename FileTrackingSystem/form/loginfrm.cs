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
    public partial class loginfrm : Form
    {
        ConnectionClass cc = new ConnectionClass();
        User user = new User();

        public static string _username;
        public static string _role;
        public static string _fname;
        public static string _log_id;

        public loginfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                textBox1.BackColor = Color.MistyRose;
                textBox2.BackColor = Color.MistyRose;
                MessageBox.Show("Please input username and password...","Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.MistyRose;
                    textBox2.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input username...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.MistyRose;
                    textBox1.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input password...", "Remember", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    user.log_username = textBox1.Text;
                    user.log_password = textBox2.Text;
                    bool verify = user.userVerification();
                    if (verify == true)
                    {
                        MessageBox.Show("Successfully Login!", "Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _role = user.log_role;
                        _username = user.log_username;
                        _fname = user.fname;
                        _log_id = user.log_id;

                        //to hide this login form
                        this.Hide();

                        //to show dashboard form
                        dashboardfrm dashboardForm = new dashboardfrm();
                        dashboardForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User does not exist!", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox1.BackColor = DefaultBackColor;
                        textBox2.BackColor = DefaultBackColor;
                    }
                }

            }
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginfrm_Load(object sender, EventArgs e)
        {
            textBox1.Text = dashboardfrm._username;
            textBox1.Text = user.log_username;
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            registrationfrm sr = new registrationfrm();
            sr.Show();
        }
    }
}
