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
        RSBSAClass rsbsa = new RSBSAClass();

        private static string gender, religion, civil_stat, high_formal_educ;
        private static bool pwd, four_ps;
        private static string IDType;
        private static string IDNum;
        private static string MFA, MIG;
        private static string livelihood;

        private static bool rice;
        private static bool corn;
        private static string other_crops;
        private static string other_livestock;
        private static string other_poultry;

        private static bool land_p;
        private static bool planting;
        private static bool cultivation;
        private static bool harvesting;
        private static string far_wor_os;

        private static bool fish_cap;
        private static bool aqua;
        private static bool glean;
        private static bool fish_pro;
        private static bool fish_ven;
        private static string fish_os;

        private static bool part_farm_hh;
        private static bool att_form_afrc;
        private static bool att_nonform_afrc;
        private static bool participated_aaap;
        private static string others_agri_youth;

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
            if (radioButtonHHNo.Checked) {
                textBoxNameHH.Enabled = true;
                textBoxHHRelationship.Enabled = true;
            }else {
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            

            if (radioButtonMale.Checked) { gender = "Male"; }
            else if (radioButtonFemale.Checked) { gender = "Female"; }

            if (radioButtonChristian.Checked) { religion = "Christianity"; }
            else if (radioButtonIslam.Checked) { religion = "Islam"; }
            else if (radioButtonOtherReligion.Checked) { religion = textBoxRegion.Text; }

            if (radioButtonSingle.Checked) { civil_stat = "Single"; }
            else if (radioButtonMarried.Checked) { civil_stat = "Married"; }
            else if (radioButtonWidowed.Checked) { civil_stat = "Widowed"; }
            else if (radioButtonSeparated.Checked) { civil_stat = "Separated"; }

            if (radioButtonPreSchool.Checked) { high_formal_educ = "Pre-school"; }
            else if (radioButtonElementary.Checked) { high_formal_educ = "Elementary"; }
            else if (radioButtonHighSchoolNoK12.Checked) { high_formal_educ = "High School"; }
            else if (radioButtonJuniorHighSchoolK12.Checked) { high_formal_educ = "Junior High School"; }
            else if (radioButtonSeniorHighK12.Checked) { high_formal_educ = "Senior High School"; }
            else if (radioButtonCollege.Checked) { high_formal_educ = "College"; }
            else if (radioButtonVocational.Checked) { high_formal_educ = "Vocational"; }
            else if (radioButtonPostGrad.Checked) { high_formal_educ = "Post-graduate"; }
            else if (radioButtonNone.Checked) { high_formal_educ = "None"; }

            if (radioButtonPWDYes.Checked) { pwd = true; }
            else if (radioButtonPWDNo.Checked) { pwd = false; }

            if (radioButton4PsYes.Checked) { four_ps = true; }
            else if (radioButton4PsNo.Checked) { four_ps = false; }

            if (radioButtonMIGYes.Checked) { MIG = textBoxMFASpecify.Text; }

            if (radioButtonGovIDYes.Checked)
            {
                if (textBoxIDType.Text == "" && textBoxIDNum.Text == "")
                {
                    MessageBox.Show("Please fillup government ID type and ID number!");
                }
                else
                {
                    IDType = textBoxIDType.Text;
                    IDNum = textBoxIDNum.Text;
                }
            }

            if (radioButtonMFAYes.Checked) { MFA = textBoxMFASpecify.Text; }

            if (radioButtonFarmer.Checked) { livelihood = "FARMER"; }
            else if (radioButtonFarmworker.Checked) { livelihood = "FARMERWORKER/LABORER"; }
            else if (radioButtonFisherFolk.Checked) { livelihood = "FISHERFOLK"; }
            else if (radioButtonAgriYouth.Checked) { livelihood = "AGRI YOUTH"; }

            if (checkBoxFarmerRice.Checked) { rice = true; } else { rice = false; }
            if (checkBoxFamerCorn.Checked) { corn = true; } else { corn = false; }
            if (checkBoxFarOC.Checked)
            {
                if (textBoxFarOC.Text == "")
                {
                    MessageBox.Show("Please fillup for farmers other crops!");
                }
                else
                {
                    other_crops = textBoxFarOC.Text;
                }
            }
            if (checkBoxFarOL.Checked)
            {
                if (textBoxFarOL.Text == "")
                {
                    MessageBox.Show("Please fillup for farmers other livestock!");
                }
                else
                {
                    other_livestock = textBoxFarOL.Text;
                }
            }
            if (checkBoxFarOP.Checked)
            {
                if (textBoxFarOP.Text == "")
                {
                    MessageBox.Show("Please fillup for farmers other poultry!");
                }
                else
                {
                    other_poultry = textBoxFarOP.Text;
                }
            }

            if (checkBoxFarWorLP.Checked) { land_p = true; } else { land_p = false; }
            if (checkBoxFarWorPT.Checked) { planting = true; } else { planting = false; }
            if (checkBoxFarWorC.Checked) { cultivation = true; } else { cultivation = false; }
            if (checkBoxFarWorH.Checked) { harvesting = true; } else { harvesting = false; }
            if (checkBoxFarWorOS.Checked)
            {
                if (textBoxFarWorOS.Text == "")
                {
                    MessageBox.Show("Please fillup for farmworkers of other specify kind of work!");
                }
                else
                {
                    far_wor_os = textBoxFarWorOS.Text;
                }
            }

            if (checkBoxFFFishCap.Checked) { fish_cap = true; } else { fish_cap = false; }
            if (checkBoxFFAquaculture.Checked) { aqua = true; } else { aqua = false; }
            if (checkBoxFFGleaning.Checked) { glean = true; } else { glean = false; }
            if (checkBoxFFFishProcessing.Checked) { fish_pro = true; } else { fish_pro = false; }
            if (checkBoxFFFishVending.Checked) { fish_ven = true; } else { fish_ven = false; }
            if (checkBoxFFOS.Checked)
            {
                if (textBoxFFOS.Text == "")
                {
                    MessageBox.Show("Please fillup for fisherfolk of other specify fishing activity!");
                }
                else
                {
                    fish_os = textBoxFFOS.Text;
                }
            }

            if (checkBoxAYFH.Checked) { part_farm_hh = true; } else { part_farm_hh = false; }
            if (checkBoxAYAFARC.Checked) { att_form_afrc = true; } else { att_form_afrc = false; }
            if (checkBoxAYANFARC.Checked) { att_nonform_afrc = true; } else { att_nonform_afrc = false; }
            if (checkBoxAYPAAA.Checked) { participated_aaap = true; } else { participated_aaap = false; }
            if (checkBoxAYOS.Checked)
            {
                if (textBoxAYOS.Text == "")
                {
                    MessageBox.Show("Please fillup for agri youth of other specify type of involvement!");
                }
                else
                {
                    others_agri_youth = textBoxAYOS.Text;
                }
            }

            rsbsa.surname = textBoxSurname.Text;
            rsbsa.fname = textBoxFirstName.Text;
            rsbsa.mname = textBoxMiddleName.Text;
            rsbsa.extension = textBoxExtensionName.Text;
            rsbsa.gender = gender;
            rsbsa.purok = textBoxPurok.Text;
            rsbsa.street = textBoxStreet.Text;
            rsbsa.brgy = comboBoxBarangay.Text;
            rsbsa.municipality = textBoxMunicipality.Text;
            rsbsa.province = textBoxProvince.Text;
            rsbsa.region = textBoxRegion.Text;
            rsbsa.mobile_no = textBoxMobileNum.Text;
            rsbsa.landline_no = textBoxLandlineNum.Text;
            rsbsa.birthdate = dateTimePickerBirth.Text;
            rsbsa.birth_place = textBoxPlaceBirth.Text;
            rsbsa.religion = religion;
            rsbsa.civil_stat = civil_stat;
            rsbsa.spouse_name = textBoxNameSpouse.Text;
            rsbsa.mother_maiden = textBoxMothersMaiden.Text;
            rsbsa.household_head = textBoxNameHH.Text;
            rsbsa.hh_relationship = textBoxHHRelationship.Text;
            rsbsa.no_living_mem = textBoxNumLHHM.Text;
            rsbsa.num_male = textBoxNumMale.Text;
            rsbsa.num_female = textBoxNumFemale.Text;
            rsbsa.high_formal_educ = high_formal_educ;
            rsbsa.pdw = pwd;
            rsbsa.four_ps = four_ps;
            rsbsa.mem_indigenous_group = MIG;
            rsbsa.govID_type = IDType;
            rsbsa.ID_no = IDNum;
            rsbsa.mem_farmer_association = MFA;
            rsbsa.person_case_emergency = textBoxPNCE.Text;
            rsbsa.contact_num = textBoxPNCE.Text;
            rsbsa.livelihood = livelihood;

            rsbsa.rice = rice;
            rsbsa.corn = corn;
            rsbsa.other_crops = other_crops;
            rsbsa.other_livestock = other_livestock;
            rsbsa.other_poultry = other_poultry;

            rsbsa.land_preparation = land_p;
            rsbsa.planting = planting;
            rsbsa.cultivation = cultivation;
            rsbsa.harvesting = harvesting;
            rsbsa.others_fish = far_wor_os;

            rsbsa.fish_capture = fish_cap;
            rsbsa.aquaculture = aqua;
            rsbsa.gleaning = glean;
            rsbsa.fish_processing = fish_pro;
            rsbsa.fish_vending = fish_ven;
            rsbsa.others_fish = fish_os;

            rsbsa.part_farm_hh = part_farm_hh;
            rsbsa.att_form_afrc = att_form_afrc;
            rsbsa.att_nonform_afrc = att_nonform_afrc;
            rsbsa.participated_aaap = participated_aaap;
            rsbsa.others_agri_youth = others_agri_youth;
            rsbsa.income_farming = textBoxFarmingGAILY.Text;
            rsbsa.income_nonfarming = textBoxNonFarmingGAILY.Text;

            rsbsa.createRSBSA();
            MessageBox.Show("" + rsbsa.message, "Register Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = true;
            dashboardfrm.contentpanel.Enabled = true;
        }
    }
}
