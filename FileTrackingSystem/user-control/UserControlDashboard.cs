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
    public partial class UserControlDashboard : UserControl
    {
        User user = new User();
        RSBSAClass rsbsa = new RSBSAClass();

        public UserControlDashboard()
        {
            InitializeComponent();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            user.countUser();
            labelCountUser.Text = user.count.ToString();

            rsbsa.countFisher();
            labelFisher.Text = rsbsa.countFishFolk.ToString();

            rsbsa.countFarmers();
            labelFarmer.Text = rsbsa.countFarmer.ToString();

            rsbsa.countFarmWorkers();
            labelFarmWor.Text = rsbsa.countFarmWor.ToString();
        }
    }
}
