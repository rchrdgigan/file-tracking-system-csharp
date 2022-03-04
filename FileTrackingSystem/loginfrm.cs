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
        public loginfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //to hide this login form
            this.Hide();

            //to show dashboard form
            dashboardfrm dashboardForm = new dashboardfrm();
            dashboardForm.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
