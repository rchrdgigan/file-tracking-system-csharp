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
    public partial class UserControlFarmers : UserControl
    {
        public UserControlFarmers()
        {
            InitializeComponent();
        }

        public static string header_category;

        private void openForm()
        {
            FarmerFilesForm fff = new FarmerFilesForm();
            fff.Show();
            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = false;
            dashboardfrm.contentpanel.Enabled = false;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.MediumAquamarine;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Aquamarine;
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Cursor = Cursors.Default;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.LightSeaGreen;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.DarkTurquoise;
            pictureBox4.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
            pictureBox3.Cursor = Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            header_category = "Masterlist of Rice Farmers";
            openForm();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            header_category = "Hybrid Users";
            openForm();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            header_category = "Certified Seeds User";
            openForm();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            header_category = "Fertilizer Users";
            openForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            header_category = "All Category";
            openForm();
        }
    }
}
