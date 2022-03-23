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
    public partial class UserControlCalamityDamage : UserControl
    {
        public static string header_category;

        public UserControlCalamityDamage()
        {
            InitializeComponent();
        }
        private void openForm()
        {
            CalamityDamageForm cdf = new CalamityDamageForm();
            cdf.Show();
            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = false;
            dashboardfrm.contentpanel.Enabled = false;
        }
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.LightSeaGreen;
            pictureBox1.Cursor = Cursors.Hand;
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.CornflowerBlue;
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.PaleVioletRed;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.DarkSalmon;
            pictureBox4.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Cursor = Cursors.Default;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.LightGreen;
            pictureBox6.Cursor = Cursors.Hand;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Cursor = Cursors.Default;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Flood
            header_category = "Flood";
            openForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Typhoon
            header_category = "Typhoon";
            openForm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Drought
            header_category = "Drought";
            openForm();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Ash Fall
            header_category = "Ash Fall";
            openForm();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Salf intrusion
            header_category = "Salf intrusion";
            openForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            header_category = "All Category";
            openForm();
        }
    }
}
