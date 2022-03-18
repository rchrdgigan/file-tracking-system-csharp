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
    public partial class FarmerFilesForm : Form
    {
        public FarmerFilesForm()
        {
            InitializeComponent();
        }

        private void disable()
        {
            comboBox1.Visible = false;
            label4.Visible = false;
            labelCatFil.Visible = false;
            comboBoxCatFil.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = true;
            dashboardfrm.contentpanel.Enabled = true;
        }

        private void BtnMasterList_Click(object sender, EventArgs e)
        {
            LblHeader.Text = "Masterlist of Rice Farmers";
            disable();
        }

        private void BtnHybrid_Click(object sender, EventArgs e)
        {
            LblHeader.Text = "Hybrid Users";
            disable();
        }

        private void BtnCertSeeds_Click(object sender, EventArgs e)
        {
            LblHeader.Text = "Certified Seeds User";
            disable();
        }

        private void BtnFerti_Click(object sender, EventArgs e)
        {
            LblHeader.Text = "Fertilizer Users";
            disable();
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            LblHeader.Text = "All Categories";
            comboBox1.Visible = true;
            label4.Visible = true;
            labelCatFil.Visible = true;
            comboBoxCatFil.Visible = true;
        }

        private void FarmerFilesForm_Load(object sender, EventArgs e)
        {
            LblHeader.Text = UserControlFarmers.header_category;
        }
    }
}
