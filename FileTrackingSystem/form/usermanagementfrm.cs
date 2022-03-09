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

        private void AdminUserRegistrationfrm_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;

            if (user.IsValidEmail(email) == true)
            {
                MessageBox.Show("Valid Email");

                if (comboBoxRole.Text != "Admin" && comboBoxRole.Text != "Staff")
                {
                    MessageBox.Show("The role must be Admin or Staff only!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Email");
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
