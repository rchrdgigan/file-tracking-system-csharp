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
                MessageBox.Show("Please input username and password...");
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.BackColor = Color.MistyRose;
                    textBox2.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input username...");
                }
                else if (textBox2.Text == "")
                {
                    textBox2.BackColor = Color.MistyRose;
                    textBox1.BackColor = DefaultBackColor;
                    MessageBox.Show("Please input password...");
                }
                else
                {
                    user.log_username = textBox1.Text;
                    user.log_password = textBox2.Text;
                    bool verify = user.userVerification();
                    if (verify)
                    {
                        MessageBox.Show("Successfully Login!");
                        _role = user.log_role;
                        _username = user.log_username;
                        _fname = user.fname;

                        //to hide this login form
                        this.Hide();

                        //to show dashboard form
                        dashboardfrm dashboardForm = new dashboardfrm();
                        dashboardForm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("User does not exist!");
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
        }
    }
}
