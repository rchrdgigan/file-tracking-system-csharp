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

        private void functionCreateOrUpdate()
        {
            if (!string.IsNullOrEmpty(textBoxSurname.Text))
            {
                if (!string.IsNullOrEmpty(textBoxFirstName.Text))
                {
                    if (!string.IsNullOrEmpty(textBoxMiddleName.Text))
                    {
                        if (radioButtonMale.Checked || radioButtonFemale.Checked)
                        {
                            if (radioButtonMale.Checked) { gender = "Male"; }
                            else if (radioButtonFemale.Checked) { gender = "Female"; }

                            if (!string.IsNullOrEmpty(textBoxPurok.Text))
                            {
                                if (!string.IsNullOrEmpty(textBoxStreet.Text))
                                {
                                    if (!string.IsNullOrEmpty(comboBoxBarangay.Text))
                                    {
                                        if (!string.IsNullOrEmpty(textBoxMunicipality.Text))
                                        {
                                            if (!string.IsNullOrEmpty(textBoxProvince.Text))
                                            {
                                                if (!string.IsNullOrEmpty(textBoxRegion.Text))
                                                {
                                                    if (!string.IsNullOrEmpty(textBoxMobileNum.Text))
                                                    {
                                                        if (!string.IsNullOrEmpty(textBoxPlaceBirth.Text))
                                                        {
                                                            if (radioButtonChristian.Checked || radioButtonIslam.Checked || radioButtonOtherReligion.Checked)
                                                            {
                                                                if (radioButtonChristian.Checked) { religion = "Christianity"; }
                                                                else if (radioButtonIslam.Checked) { religion = "Islam"; }
                                                                else if (radioButtonOtherReligion.Checked) { religion = textBoxRegion.Text; }

                                                                if (radioButtonSingle.Checked || radioButtonMarried.Checked || radioButtonWidowed.Checked || radioButtonSeparated.Checked)
                                                                {
                                                                    if (radioButtonSingle.Checked) { civil_stat = "Single"; }
                                                                    else if (radioButtonMarried.Checked) { civil_stat = "Married"; }
                                                                    else if (radioButtonWidowed.Checked) { civil_stat = "Widowed"; }
                                                                    else if (radioButtonSeparated.Checked) { civil_stat = "Separated"; }

                                                                    if (radioButtonMarried.Checked)
                                                                    {
                                                                        if (textBoxNameSpouse.Text == "")
                                                                        {
                                                                            MessageBox.Show("Spouse Name is required");
                                                                        }
                                                                    }

                                                                    if (radioButtonHHYes.Checked || radioButtonHHNo.Checked)
                                                                    {
                                                                        if (radioButtonHHNo.Checked)
                                                                        {
                                                                            if (textBoxHHRelationship.Text == "" && textBoxNameHH.Text == "")
                                                                            {
                                                                                MessageBox.Show("House head name and Relationship is required");
                                                                            }
                                                                        }

                                                                        if (!string.IsNullOrEmpty(textBoxNumLHHM.Text))
                                                                        {
                                                                            if (!string.IsNullOrEmpty(textBoxNumMale.Text))
                                                                            {
                                                                                if (!string.IsNullOrEmpty(textBoxNumFemale.Text))
                                                                                {
                                                                                    if (radioButtonPreSchool.Checked || radioButtonElementary.Checked || radioButtonHighSchoolNoK12.Checked || radioButtonJuniorHighSchoolK12.Checked || radioButtonSeniorHighK12.Checked || radioButtonCollege.Checked || radioButtonVocational.Checked || radioButtonPostGrad.Checked || radioButtonNone.Checked)
                                                                                    {
                                                                                        if (radioButtonPreSchool.Checked) { high_formal_educ = "Pre-school"; }
                                                                                        else if (radioButtonElementary.Checked) { high_formal_educ = "Elementary"; }
                                                                                        else if (radioButtonHighSchoolNoK12.Checked) { high_formal_educ = "High School"; }
                                                                                        else if (radioButtonJuniorHighSchoolK12.Checked) { high_formal_educ = "Junior High School"; }
                                                                                        else if (radioButtonSeniorHighK12.Checked) { high_formal_educ = "Senior High School"; }
                                                                                        else if (radioButtonCollege.Checked) { high_formal_educ = "College"; }
                                                                                        else if (radioButtonVocational.Checked) { high_formal_educ = "Vocational"; }
                                                                                        else if (radioButtonPostGrad.Checked) { high_formal_educ = "Post-graduate"; }
                                                                                        else if (radioButtonNone.Checked) { high_formal_educ = "None"; }

                                                                                        if (radioButtonPWDYes.Checked || radioButtonPWDNo.Checked)
                                                                                        {
                                                                                            if (radioButtonPWDYes.Checked) { pwd = true; }
                                                                                            else if (radioButtonPWDNo.Checked) { pwd = false; }

                                                                                            if (radioButton4PsYes.Checked || radioButton4PsNo.Checked)
                                                                                            {
                                                                                                if (radioButton4PsYes.Checked) { four_ps = true; }
                                                                                                else if (radioButton4PsNo.Checked) { four_ps = false; }

                                                                                                if (radioButtonMIGYes.Checked || radioButtonMIGNo.Checked)
                                                                                                {
                                                                                                    if (radioButtonMIGYes.Checked)
                                                                                                    {
                                                                                                        if (textBoxMIGSpecify.Text == "")
                                                                                                        {
                                                                                                            MessageBox.Show("Specify Member of Indigenous Group is required");
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            MIG = textBoxMFASpecify.Text;
                                                                                                        }
                                                                                                    }
                                                                                                    else if (radioButtonMIGNo.Checked)
                                                                                                    {
                                                                                                        MIG = textBoxMFASpecify.Text;
                                                                                                    }

                                                                                                    if (radioButtonGovIDYes.Checked || radioButtonGovIDNo.Checked)
                                                                                                    {
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
                                                                                                        else
                                                                                                        {
                                                                                                            IDType = textBoxIDType.Text;
                                                                                                            IDNum = textBoxIDNum.Text;
                                                                                                        }

                                                                                                        if (radioButtonMFAYes.Checked || radioButtonMFANo.Checked)
                                                                                                        {
                                                                                                            if (radioButtonMFAYes.Checked)
                                                                                                            {
                                                                                                                if (textBoxMFASpecify.Text == "")
                                                                                                                {
                                                                                                                    MessageBox.Show("Please fillup government ID type and ID number!");
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    MFA = textBoxMFASpecify.Text;
                                                                                                                }
                                                                                                            }
                                                                                                            else if (radioButtonMFANo.Checked)
                                                                                                            {
                                                                                                                MFA = textBoxMFASpecify.Text;
                                                                                                            }

                                                                                                            if (!string.IsNullOrEmpty(textBoxPNCE.Text))
                                                                                                            {
                                                                                                                if (!string.IsNullOrEmpty(textBoxContactNumPNCE.Text))
                                                                                                                {
                                                                                                                    if (radioButtonFarmer.Checked || radioButtonFarmworker.Checked || radioButtonFisherFolk.Checked || radioButtonAgriYouth.Checked)
                                                                                                                    {
                                                                                                                        if (radioButtonFarmer.Checked) { livelihood = "FARMER"; }
                                                                                                                        else if (radioButtonFarmworker.Checked) { livelihood = "FARMERWORKER/LABORER"; }
                                                                                                                        else if (radioButtonFisherFolk.Checked) { livelihood = "FISHERFOLK"; }
                                                                                                                        else if (radioButtonAgriYouth.Checked) { livelihood = "AGRI YOUTH"; }

                                                                                                                        bool execute = true;

                                                                                                                        if (checkBoxFarmerRice.Checked) { rice = true; } else { rice = false; }
                                                                                                                        if (checkBoxFamerCorn.Checked) { corn = true; } else { corn = false; }
                                                                                                                        if (checkBoxFarOC.Checked)
                                                                                                                        {
                                                                                                                            if (textBoxFarOC.Text == "")
                                                                                                                            {
                                                                                                                                execute = false;
                                                                                                                                MessageBox.Show("Please fillup for farmers other crops!");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                other_crops = textBoxFarOC.Text;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else { other_crops = ""; }

                                                                                                                        if (checkBoxFarOL.Checked)
                                                                                                                        {
                                                                                                                            if (textBoxFarOL.Text == "")
                                                                                                                            {
                                                                                                                                execute = false;
                                                                                                                                MessageBox.Show("Please fillup for farmers other livestock!");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                other_livestock = textBoxFarOL.Text;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else { other_livestock = ""; }

                                                                                                                        if (checkBoxFarOP.Checked)
                                                                                                                        {
                                                                                                                            if (textBoxFarOP.Text == "")
                                                                                                                            {
                                                                                                                                execute = false;
                                                                                                                                MessageBox.Show("Please fillup for farmers other poultry!");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                other_poultry = textBoxFarOP.Text;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else { other_poultry = ""; }

                                                                                                                        if (checkBoxFarWorLP.Checked) { land_p = true; } else { land_p = false; }
                                                                                                                        if (checkBoxFarWorPT.Checked) { planting = true; } else { planting = false; }
                                                                                                                        if (checkBoxFarWorC.Checked) { cultivation = true; } else { cultivation = false; }
                                                                                                                        if (checkBoxFarWorH.Checked) { harvesting = true; } else { harvesting = false; }
                                                                                                                        if (checkBoxFarWorOS.Checked)
                                                                                                                        {
                                                                                                                            if (textBoxFarWorOS.Text == "")
                                                                                                                            {
                                                                                                                                execute = false;
                                                                                                                                MessageBox.Show("Please fillup for farmworkers of other specify kind of work!");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                far_wor_os = textBoxFarWorOS.Text;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else { far_wor_os = ""; }

                                                                                                                        if (checkBoxFFFishCap.Checked) { fish_cap = true; } else { fish_cap = false; }
                                                                                                                        if (checkBoxFFAquaculture.Checked) { aqua = true; } else { aqua = false; }
                                                                                                                        if (checkBoxFFGleaning.Checked) { glean = true; } else { glean = false; }
                                                                                                                        if (checkBoxFFFishProcessing.Checked) { fish_pro = true; } else { fish_pro = false; }
                                                                                                                        if (checkBoxFFFishVending.Checked) { fish_ven = true; } else { fish_ven = false; }
                                                                                                                        if (checkBoxFFOS.Checked)
                                                                                                                        {
                                                                                                                            if (textBoxFFOS.Text == "")
                                                                                                                            {
                                                                                                                                execute = false;
                                                                                                                                MessageBox.Show("Please fillup of other specify for fisherfolk type of fishing activity!");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                fish_os = textBoxFFOS.Text;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else { fish_os = ""; }

                                                                                                                        if (checkBoxAYFH.Checked) { part_farm_hh = true; } else { part_farm_hh = false; }
                                                                                                                        if (checkBoxAYAFARC.Checked) { att_form_afrc = true; } else { att_form_afrc = false; }
                                                                                                                        if (checkBoxAYANFARC.Checked) { att_nonform_afrc = true; } else { att_nonform_afrc = false; }
                                                                                                                        if (checkBoxAYPAAA.Checked) { participated_aaap = true; } else { participated_aaap = false; }
                                                                                                                        if (checkBoxAYOS.Checked)
                                                                                                                        {
                                                                                                                            if (textBoxAYOS.Text == "")
                                                                                                                            {
                                                                                                                                execute = false;
                                                                                                                                MessageBox.Show("Please fillup for agri youth of other specify type of involvement!");
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                others_agri_youth = textBoxAYOS.Text;
                                                                                                                            }
                                                                                                                        }
                                                                                                                        else { others_agri_youth = ""; }

                                                                                                                        if (!execute == false)
                                                                                                                        {
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
                                                                                                                            rsbsa.contact_num = textBoxContactNumPNCE.Text;
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
                                                                                                                            rsbsa.others_farm = far_wor_os;

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
                                                                                                                            if(UserControlRSBSA._methods == "Create")
                                                                                                                            {
                                                                                                                                rsbsa.createRSBSA();
                                                                                                                                MessageBox.Show("" + rsbsa.message, "Register Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                                                                this.Close();

                                                                                                                                //To disable navbar and body
                                                                                                                                dashboardfrm.navpanel.Enabled = true;
                                                                                                                                dashboardfrm.contentpanel.Enabled = true;
                                                                                                                                dashboardfrm.rsbsa_refesh.PerformClick();
                                                                                                                            }
                                                                                                                            else
                                                                                                                            {
                                                                                                                                rsbsa.updateRSBSA(labelId.Text);
                                                                                                                                MessageBox.Show("" + rsbsa.message, "Update Succeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                                                                                this.Close();

                                                                                                                                //To disable navbar and body
                                                                                                                                dashboardfrm.navpanel.Enabled = true;
                                                                                                                                dashboardfrm.contentpanel.Enabled = true;
                                                                                                                                dashboardfrm.rsbsa_refesh.PerformClick();
                                                                                                                            }
                                                                                                                            
                                                                                                                        }
                                                                                                                    }
                                                                                                                    else
                                                                                                                    {
                                                                                                                        MessageBox.Show("Main livelihood is required");
                                                                                                                    }
                                                                                                                }
                                                                                                                else
                                                                                                                {
                                                                                                                    MessageBox.Show("Contact Number is required");
                                                                                                                }
                                                                                                            }
                                                                                                            else
                                                                                                            {
                                                                                                                MessageBox.Show("Person to notifify in case of emergency is required");
                                                                                                            }
                                                                                                        }
                                                                                                        else
                                                                                                        {
                                                                                                            MessageBox.Show("Farmers Association/Cooperative option is required");
                                                                                                        }
                                                                                                    }
                                                                                                    else
                                                                                                    {
                                                                                                        MessageBox.Show("Government ID option is required");
                                                                                                    }
                                                                                                }
                                                                                                else
                                                                                                {
                                                                                                    MessageBox.Show("Indigenous Group option is required");
                                                                                                }
                                                                                            }
                                                                                            else
                                                                                            {
                                                                                                MessageBox.Show("4P's beneficiary option is required");
                                                                                            }
                                                                                        }
                                                                                        else
                                                                                        {
                                                                                            MessageBox.Show("PWD option is required");
                                                                                        }
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        MessageBox.Show("Highest Formal Education is required");
                                                                                    }
                                                                                }
                                                                                else
                                                                                {
                                                                                    MessageBox.Show("No. of female is required");
                                                                                }
                                                                            }
                                                                            else
                                                                            {
                                                                                MessageBox.Show("No. of male is required");
                                                                            }
                                                                        }
                                                                        else
                                                                        {
                                                                            MessageBox.Show("No. of living household members is required");
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        MessageBox.Show("House Head is required");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Civil Status is required");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                MessageBox.Show("Regligion is required");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Place of Birth is required");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Mobile Number is required");
                                                    }
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Region is required");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Province is required");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Municipality/City is required");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Barangay is required");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Street/Sitio/SubDV. is required");
                                }
                            }
                            else
                            {
                                MessageBox.Show("House/Lot/BLDG. No/Purok is required");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Sex is required");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Middle Name is required");
                    }
                }
                else
                {
                    MessageBox.Show("First Name is required");
                }
            }
            else
            {
                MessageBox.Show("Surname is required");
            }
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

        private void getData()
        {
            textBoxSurname.Text = UserControlRSBSA._surname;
            textBoxFirstName.Text = UserControlRSBSA._fname;
            textBoxMiddleName.Text = UserControlRSBSA._mname;
            if (UserControlRSBSA._gender == "Male") { radioButtonMale.Checked = true; }
            else if (UserControlRSBSA._gender == "Female") { radioButtonFemale.Checked = true; }
            textBoxPurok.Text = UserControlRSBSA._purok;
            textBoxStreet.Text = UserControlRSBSA._street;
            comboBoxBarangay.Text = UserControlRSBSA._brgy;
            textBoxMunicipality.Text = UserControlRSBSA._municipality;
            textBoxProvince.Text = UserControlRSBSA._province;
            textBoxRegion.Text = UserControlRSBSA._region;
            textBoxMobileNum.Text = UserControlRSBSA._mobile_no;
            textBoxLandlineNum.Text = UserControlRSBSA._landline_no;
            dateTimePickerBirth.Text = UserControlRSBSA._birthdate;
            textBoxPlaceBirth.Text = UserControlRSBSA._birth_place;
            if (UserControlRSBSA._religion == "Christianity") { radioButtonChristian.Checked = true; textBoxSpecifyReligion.Enabled = false; }
            else if (UserControlRSBSA._religion == "Islam") { radioButtonIslam.Checked = true; textBoxSpecifyReligion.Enabled = false; }
            else { radioButtonOtherReligion.Checked = true; textBoxSpecifyReligion.Text = UserControlRSBSA._religion; }

            if (UserControlRSBSA._civil_stat == "Single") { radioButtonSingle.Checked = true; }
            else if (UserControlRSBSA._civil_stat == "Married") { radioButtonMarried.Checked = true; }
            else if (UserControlRSBSA._civil_stat == "Widowed") { radioButtonWidowed.Checked = true; }
            else if (UserControlRSBSA._civil_stat == "Separated") { radioButtonSeparated.Checked = true; }
            if (radioButtonMarried.Checked)
            {
                if (!string.IsNullOrEmpty(UserControlRSBSA._spouse_name)) { textBoxNameSpouse.Text = UserControlRSBSA._spouse_name; }
            }
            else
            {
                textBoxNameSpouse.Enabled = false;
            }

            if (!string.IsNullOrEmpty(UserControlRSBSA._mother_maiden)) { textBoxMothersMaiden.Text = UserControlRSBSA._mother_maiden; }

            if (!string.IsNullOrEmpty(UserControlRSBSA._household_head) || !string.IsNullOrEmpty(UserControlRSBSA._hh_relationship))
            {
                textBoxNameHH.Text = UserControlRSBSA._household_head;
                textBoxHHRelationship.Text = UserControlRSBSA._hh_relationship;

                radioButtonHHNo.Checked = true;
            }
            else
            {
                textBoxNameHH.Enabled = false;
                textBoxHHRelationship.Enabled = false;
                radioButtonHHYes.PerformClick();
            }

            textBoxNumLHHM.Text = UserControlRSBSA._no_living_mem;
            textBoxNumMale.Text = UserControlRSBSA._num_male;
            textBoxNumFemale.Text = UserControlRSBSA._num_female;

            if (UserControlRSBSA._high_formal_educ == "Pre-school") { radioButtonPreSchool.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "Elementary") { radioButtonElementary.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "High School") { radioButtonHighSchoolNoK12.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "Junior High School") { radioButtonJuniorHighSchoolK12.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "Senior High School") { radioButtonSeniorHighK12.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "College") { radioButtonCollege.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "Vocational") { radioButtonVocational.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "Post-graduate") { radioButtonPostGrad.Checked = true; }
            else if (UserControlRSBSA._high_formal_educ == "None") { radioButtonNone.Checked = true; }

            if (UserControlRSBSA._pdw == true) { radioButtonPWDYes.Checked = true; }
            else { radioButtonPWDNo.Checked = true; }

            if (UserControlRSBSA._four_ps == true) { radioButton4PsYes.Checked = true; }
            else { radioButton4PsNo.Checked = true; }

            if (!string.IsNullOrEmpty(UserControlRSBSA._mem_indigenous_group))
            {
                textBoxMIGSpecify.Text = UserControlRSBSA._mem_indigenous_group;
            }
            else { radioButtonMIGNo.PerformClick(); textBoxMIGSpecify.Enabled = false; }

            if (!string.IsNullOrEmpty(UserControlRSBSA._govID_type) && !string.IsNullOrEmpty(UserControlRSBSA._ID_no))
            {
                textBoxIDType.Text = UserControlRSBSA._govID_type;
                textBoxIDNum.Text = UserControlRSBSA._ID_no;
            }
            else { radioButtonGovIDNo.PerformClick(); textBoxIDType.Enabled = false; textBoxIDNum.Enabled = false; }

            if (!string.IsNullOrEmpty(UserControlRSBSA._mem_farmer_association))
            {
                textBoxMFASpecify.Text = UserControlRSBSA._mem_farmer_association;
            }
            else { radioButtonMFANo.PerformClick(); textBoxMFASpecify.Enabled = false; }

            textBoxPNCE.Text = UserControlRSBSA._person_case_emergency;
            textBoxContactNumPNCE.Text = UserControlRSBSA._contact_num;

            if (UserControlRSBSA._livelihood == "FARMER")
            {
                radioButtonFarmer.Checked = true;
                groupBoxFarmers.Enabled = true;
                groupBoxFarmerworkers.Enabled = false;
                groupBoxFisher.Enabled = false;
                groupBoxAgriYouth.Enabled = false;
            }
            else if (UserControlRSBSA._livelihood == "FARMERWORKER/LABORER")
            {
                radioButtonFarmworker.Checked = true;
                groupBoxFarmers.Enabled = false;
                groupBoxFarmerworkers.Enabled = true;
                groupBoxFisher.Enabled = false;
                groupBoxAgriYouth.Enabled = false;
            }
            else if (UserControlRSBSA._livelihood == "FISHERFOLK")
            {
                radioButtonFisherFolk.Checked = true;
                groupBoxFarmers.Enabled = false;
                groupBoxFarmerworkers.Enabled = false;
                groupBoxFisher.Enabled = true;
                groupBoxAgriYouth.Enabled = false;
            }
            else if (UserControlRSBSA._livelihood == "AGRI YOUTH")
            {
                radioButtonAgriYouth.Checked = true;
                groupBoxFarmers.Enabled = false;
                groupBoxFarmerworkers.Enabled = false;
                groupBoxFisher.Enabled = false;
                groupBoxAgriYouth.Enabled = true;
            }

            bool rice = UserControlRSBSA._rice == true ? checkBoxFarmerRice.Checked = true : checkBoxFarmerRice.Checked = false;

            bool corn = UserControlRSBSA._corn == true ? checkBoxFamerCorn.Checked = true : checkBoxFamerCorn.Checked = false;

            if (!string.IsNullOrEmpty(UserControlRSBSA._other_crops))
            {
                checkBoxFarOC.Checked = true;
                textBoxFarOC.Text = UserControlRSBSA._other_crops;
            }
            else
            {
                checkBoxFarOC.Checked = false;
                textBoxFarOC.Enabled = false;
            }

            if (!string.IsNullOrEmpty(UserControlRSBSA._other_livestock))
            {
                checkBoxFarOL.Checked = true;
                textBoxFarOL.Text = UserControlRSBSA._other_livestock;
            }
            else
            {
                checkBoxFarOL.Checked = false;
                textBoxFarOL.Enabled = false;
            }

            if (!string.IsNullOrEmpty(UserControlRSBSA._other_poultry))
            {
                checkBoxFarOP.Checked = true;
                textBoxFarOP.Text = UserControlRSBSA._other_poultry;
            }
            else
            {
                checkBoxFarOP.Checked = false;
                textBoxFarOP.Enabled = false;
            }

            bool land = UserControlRSBSA._land_preparation == true ? checkBoxFarWorLP.Checked = true : checkBoxFarWorLP.Checked = false;
            bool plant = UserControlRSBSA._planting == true ? checkBoxFarWorPT.Checked = true : checkBoxFarWorPT.Checked = false;
            bool cultiv = UserControlRSBSA._cultivation == true ? checkBoxFarWorC.Checked = true : checkBoxFarWorC.Checked = false;
            bool harvest = UserControlRSBSA._harvesting == true ? checkBoxFarWorH.Checked = true : checkBoxFarWorH.Checked = false;
            if (!string.IsNullOrEmpty(UserControlRSBSA._others_farm))
            {
                checkBoxFarWorOS.Checked = true;
                textBoxFarWorOS.Text = UserControlRSBSA._others_farm;
            }
            else
            {
                checkBoxFarWorOS.Checked = false;
                textBoxFarWorOS.Enabled = false;
            }

            bool fish_cap = UserControlRSBSA._fish_capture == true ? checkBoxFFFishCap.Checked = true : checkBoxFFFishCap.Checked = false;
            bool aqua = UserControlRSBSA._aquaculture == true ? checkBoxFFAquaculture.Checked = true : checkBoxFFAquaculture.Checked = false;
            bool glea = UserControlRSBSA._gleaning == true ? checkBoxFFGleaning.Checked = true : checkBoxFFGleaning.Checked = false;
            bool fish_pro = UserControlRSBSA._fish_processing == true ? checkBoxFFFishProcessing.Checked = true : checkBoxFFFishProcessing.Checked = false;
            bool fish_ven = UserControlRSBSA._fish_vending == true ? checkBoxFFFishVending.Checked = true : checkBoxFFFishVending.Checked = false;
            if (!string.IsNullOrEmpty(UserControlRSBSA._others_fish))
            {
                checkBoxFFOS.Checked = true;
                textBoxFFOS.Text = UserControlRSBSA._others_fish;
            }
            else
            {
                checkBoxFFOS.Checked = false;
                textBoxFFOS.Enabled = false;
            }

            bool farm_hh = UserControlRSBSA._part_farm_hh == true ? checkBoxAYFH.Checked = true : checkBoxAYFH.Checked = false;
            bool form_afrc = UserControlRSBSA._att_form_afrc == true ? checkBoxAYAFARC.Checked = true : checkBoxAYAFARC.Checked = false;
            bool nonform_afrc = UserControlRSBSA._att_nonform_afrc == true ? checkBoxAYANFARC.Checked = true : checkBoxAYANFARC.Checked = false;
            bool participated = UserControlRSBSA._participated_aaap == true ? checkBoxAYPAAA.Checked = true : checkBoxAYPAAA.Checked = false;
            if (!string.IsNullOrEmpty(UserControlRSBSA._others_fish))
            {
                checkBoxAYOS.Checked = true;
                textBoxAYOS.Text = UserControlRSBSA._others_fish;
            }
            else
            {
                checkBoxAYOS.Checked = false;
                textBoxAYOS.Enabled = false;
            }
            textBoxFarmingGAILY.Text = UserControlRSBSA._income_farming;
            textBoxNonFarmingGAILY.Text = UserControlRSBSA._income_nonfarming;
        }

        private void RSBSAregistraionfrm_Load(object sender, EventArgs e)
        {
            TransitionsAPI.AnimateWindow(this.Handle, 100, TransitionsAPI.fadeIN);
            this.AutoScroll = true;
            
            if (UserControlRSBSA._methods == "Create")
            {
                textBoxSpecifyReligion.Enabled = false;

                textBoxNameSpouse.Enabled = false;

                textBoxMIGSpecify.Enabled = false;

                textBoxNameHH.Enabled = false;
                textBoxHHRelationship.Enabled = false;

                textBoxIDNum.Enabled = false;
                textBoxIDType.Enabled = false;

                textBoxMFASpecify.Enabled = false;

                groupBoxFarmers.Enabled = false;
                groupBoxFarmerworkers.Enabled = false;
                groupBoxFisher.Enabled = false;
                groupBoxAgriYouth.Enabled = false;
            }
            else if(UserControlRSBSA._methods == "Edit")
            {
                buttonSubmit.Text = "Update";
                labelId.Text = UserControlRSBSA._id;
                getData();
            }
            else if (UserControlRSBSA._methods == "Preview")
            {
                panel2.Enabled = false;
                buttonCancel.Visible = false;
                buttonSubmit.Visible = false;
                buttonClose.Visible = true;

                getData();
            }
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

        private void textBoxMobileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxLandlineNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxContactNumPNCE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumLHHM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumMale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumFemale_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void radioButtonGovIDYes_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGovIDYes.Checked)
            {
                textBoxIDType.Enabled = true; textBoxIDNum.Enabled = true;
            }
            else if (radioButtonGovIDNo.Checked)
            {
                textBoxIDType.Enabled = false; textBoxIDNum.Enabled = false;
            }
        }

        private void checkBoxFarOC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFarOC.Checked)
            {
                textBoxFarOC.Enabled = true;
            }
            else
            {
                textBoxFarOC.Enabled = false;
                textBoxFarOC.Clear();
            }
        }

        private void checkBoxFarOL_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFarOL.Checked)
            {
                textBoxFarOL.Enabled = true;
            }
            else
            {
                textBoxFarOL.Enabled = false;
                textBoxFarOL.Clear();
            }
        }

        private void checkBoxFarOP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFarOP.Checked)
            {
                textBoxFarOP.Enabled = true;
            }
            else
            {
                textBoxFarOP.Enabled = false;
                textBoxFarOP.Clear();
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = true;
            dashboardfrm.contentpanel.Enabled = true;
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
            if(UserControlRSBSA._methods == "Create")
            {
                functionCreateOrUpdate();
            }
            else if (UserControlRSBSA._methods == "Edit")
            {
                functionCreateOrUpdate();
            }
        }
    }

}
