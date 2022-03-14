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
    public partial class RSBSAregistraionfrm : Form
    {
        VScrollBar vscrollbar = new VScrollBar();
        public RSBSAregistraionfrm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = true;
            dashboardfrm.contentpanel.Enabled = true;
        }

        protected void clearFarmProf()
        {
            checkBoxFarmerRice.Checked = false;
            checkBoxFamerCorn.Checked = false;
            checkBoxFarOC.Checked = false;
            textBoxFarOC.Clear();
            checkBoxFarOL.Checked = false;
            textBoxFarOL.Clear();
            checkBoxFarOP.Checked = false;
            textBoxFarOP.Clear();

            checkBoxFarWorLP.Checked = false;
            checkBoxFarWorPT.Checked = false;
            checkBoxFarWorC.Checked = false;
            checkBoxFarWorH.Checked = false;
            checkBoxFarWorOS.Checked = false;
            textBoxFarWorOS.Clear();

            checkBoxFFFishCap.Checked = false;
            checkBoxFFAquaculture.Checked = false;
            checkBoxFFGleaning.Checked = false;
            checkBoxFFOS.Checked = false;
            textBoxFFOS.Clear();

            checkBoxAYFH.Checked = false;
            checkBoxAYAFARC.Checked = false;
            checkBoxAYPAAA.Checked = false;
            checkBoxAYOS.Checked = false;
            textBoxAYOS.Clear();
        }

        private void RSBSAregistraionfrm_Load(object sender, EventArgs e)
        {
            this.AutoScroll = true;

            textBoxSpecifyReligion.Enabled = false;

            textBoxNameSpouse.Enabled = false;

            textBoxMIGSpecify.Enabled = false;

            textBoxNameHH.Enabled = false;
            textBoxHHRelationship.Enabled = false;

            textBoxMFASpecify.Enabled = false;

            groupBoxFarmers.Enabled = false;
            groupBoxFarmerworkers.Enabled = false;
            groupBoxFisher.Enabled = false;
            groupBoxAgriYouth.Enabled = false;
        }

        private void radioButtonOtherReligion_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonOtherReligion.Checked ? textBoxSpecifyReligion.Enabled = true : textBoxSpecifyReligion.Enabled = false;
        }

        private void radioButtonMarried_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonMarried.Checked ? textBoxNameSpouse.Enabled = true : textBoxNameSpouse.Enabled = false;
        }

        private void radioButtonMIGYes_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonMIGYes.Checked ? textBoxMIGSpecify.Enabled = true : textBoxMIGSpecify.Enabled = false;
        }

        private void radioButtonHHNo_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonHHNo.Checked)
            {
                textBoxNameHH.Enabled = true;
                textBoxHHRelationship.Enabled = true;
            }
            else
            {
                textBoxNameHH.Enabled = false;
                textBoxHHRelationship.Enabled = false;
            }
        }

        private void radioButtonMFAYes_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonMFAYes.Checked ? textBoxMFASpecify.Enabled = true : textBoxMFASpecify.Enabled = false;
        }

        private void radioButtonFarmer_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonFarmer.Checked ? groupBoxFarmers.Enabled = true : groupBoxFarmers.Enabled = false;
            clearFarmProf();
        }

        private void radioButtonFarmworker_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonFarmworker.Checked ? groupBoxFarmerworkers.Enabled = true : groupBoxFarmerworkers.Enabled = false;
            clearFarmProf();
        }

        private void radioButtonFisherFolk_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonFisherFolk.Checked ? groupBoxFisher.Enabled = true : groupBoxFisher.Enabled = false;
            clearFarmProf();
        }

        private void radioButtonAgriYouth_CheckedChanged(object sender, EventArgs e)
        {
            bool radioBtn = radioButtonAgriYouth.Checked ? groupBoxAgriYouth.Enabled = true : groupBoxAgriYouth.Enabled = false;
            clearFarmProf();
        }
    }
}
