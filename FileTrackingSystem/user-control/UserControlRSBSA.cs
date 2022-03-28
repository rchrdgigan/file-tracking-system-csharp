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
    public partial class UserControlRSBSA : UserControl
    {
        User user = new User();
        RSBSAClass rsbsa = new RSBSAClass();
        public static Button _refresh;

        public static string _methods;
        public static string _id;
        public static string _surname;
        public static string _fname;
        public static string _mname;
        public static string _extension;
        public static string _gender;
        public static string _purok;
        public static string _street;
        public static string _brgy;
        public static string _municipality;
        public static string _province;
        public static string _region;
        public static string _mobile_no;
        public static string _landline_no;
        public static string _birthdate;
        public static string _birth_place;
        public static string _religion;
        public static string _civil_stat;
        public static string _spouse_name;
        public static string _mother_maiden;
        public static string _household_head;
        public static string _hh_relationship;
        public static string _no_living_mem;
        public static string _num_male;
        public static string _num_female;
        public static string _high_formal_educ;
        public static bool _pdw;
        public static bool _four_ps;
        public static string _mem_indigenous_group;
        public static string _govID_type;
        public static string _ID_no;
        public static string _mem_farmer_association;
        public static string _person_case_emergency;
        public static string _contact_num;
        public static string _livelihood;
        //for farmers
        public static bool _rice;
        public static bool _corn;
        public static string _other_crops;
        public static string _other_livestock;
        public static string _other_poultry;
        //for farmerworkers
        public static bool _land_preparation;
        public static bool _planting;
        public static bool _cultivation;
        public static bool _harvesting;
        public static string _others_farm;
        //for fisherfolk
        public static bool _fish_capture;
        public static bool _aquaculture;
        public static bool _gleaning;
        public static bool _fish_processing;
        public static bool _fish_vending;
        public static string _others_fish;
        //for agri youth
        public static bool _part_farm_hh;
        public static bool _att_form_afrc;
        public static bool _att_nonform_afrc;
        public static bool _participated_aaap;
        public static string _others_agri_youth;

        public static string _income_farming;
        public static string _income_nonfarming;

        public UserControlRSBSA()
        {
            InitializeComponent();
        }

        private void loadData()
        {
            rsbsa.listRSBSA();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rsbsa.dtable;
        }

        private void loadSearch()
        {
            rsbsa.search();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = rsbsa.dtable;
        }

        private void showData()
        {
            bool verify = rsbsa.show(SelectedIdLbl.Text);
            if (verify == true)
            {
                _id = rsbsa.rsbsaId;
                _surname = rsbsa.surname;
                _fname = rsbsa.fname;
                _mname = rsbsa.mname;
                _extension = rsbsa.extension;
                _gender = rsbsa.gender;
                _purok = rsbsa.purok;
                _street = rsbsa.street;
                _brgy = rsbsa.brgy;
                _municipality = rsbsa.municipality;
                _province = rsbsa.province;
                _region = rsbsa.region;
                _mobile_no = rsbsa.mobile_no;
                _landline_no = rsbsa.landline_no;
                _birthdate = rsbsa.birthdate;
                _birth_place = rsbsa.birth_place;
                _religion = rsbsa.religion;
                _civil_stat = rsbsa.civil_stat;
                _spouse_name = rsbsa.spouse_name;
                _mother_maiden = rsbsa.mother_maiden;
                _household_head = rsbsa.household_head;
                _hh_relationship = rsbsa.hh_relationship;
                _no_living_mem = rsbsa.no_living_mem;
                _num_male = rsbsa.num_male;
                _num_female = rsbsa.num_female;
                _high_formal_educ = rsbsa.high_formal_educ;
                _pdw = rsbsa.pdw;
                _four_ps = rsbsa.four_ps;
                _mem_indigenous_group = rsbsa.mem_indigenous_group;
                _govID_type = rsbsa.govID_type;
                _ID_no = rsbsa.ID_no;
                _mem_farmer_association = rsbsa.mem_farmer_association;
                _person_case_emergency = rsbsa.person_case_emergency;
                _contact_num = rsbsa.contact_num;
                _livelihood = rsbsa.livelihood;
                //for farmers
                _rice = rsbsa.rice;
                _corn = rsbsa.corn;
                _other_crops = rsbsa.other_crops;
                _other_livestock = rsbsa.other_livestock;
                _other_poultry = rsbsa.other_poultry;
                //for farmerworkers
                _land_preparation = rsbsa.land_preparation;
                _planting = rsbsa.planting;
                _cultivation = rsbsa.cultivation;
                _harvesting = rsbsa.harvesting;
                _others_farm = rsbsa.others_farm;
                //for fisherfolk
                _fish_capture = rsbsa.fish_capture;
                _aquaculture = rsbsa.aquaculture;
                _gleaning = rsbsa.gleaning;
                _fish_processing = rsbsa.fish_processing;
                _fish_vending = rsbsa.fish_vending;
                _others_fish = rsbsa.others_fish;
                //for agri youth
                _part_farm_hh = rsbsa.part_farm_hh;
                _att_form_afrc = rsbsa.att_form_afrc;
                _att_nonform_afrc = rsbsa.att_nonform_afrc;
                _participated_aaap = rsbsa.participated_aaap;
                _others_agri_youth = rsbsa.others_agri_youth;

                _income_farming = rsbsa.income_farming;
                _income_nonfarming = rsbsa.income_nonfarming;
            }
            RSBSAregistraionfrm rsbsa_form = new RSBSAregistraionfrm();
            rsbsa_form.Show();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = false;
            dashboardfrm.contentpanel.Enabled = false;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _methods = "Create";
            RSBSAregistraionfrm rsbsa_form = new RSBSAregistraionfrm();
            rsbsa_form.Show();

            //To disable navbar and body
            dashboardfrm.navpanel.Enabled = false;
            dashboardfrm.contentpanel.Enabled = false;
        }

        private void UserControlRSBSA_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void ArchiveBtn_Click(object sender, EventArgs e)
        {
            //To Do Delete
            if (SelectedIdLbl.Text == "")
            {
                MessageBox.Show("Please select an specific data to archived!", "Archive Data?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure want to archive this Data?", "Archive Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //History Log
                    user.activity = "Archived RSBSA Data...";
                    user.user_id = loginfrm._log_id;
                    user.createLog();
                    //End Log

                    rsbsa.archiveRSBSA(SelectedIdLbl.Text);
                    loadData();
                    MessageBox.Show("RSBSA data successfully archived!", "Archive Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Select data by cell
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    SelectedIdLbl.Text = row.Cells["rsbsa_id"].Value.ToString();
                }
            }
            catch
            {
                //catch if error
            }
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            //To Do Delete
            if (SelectedIdLbl.Text == "")
            {
                MessageBox.Show("Please select an specific data to delete!", "Deleting Data?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure want to delete this Data?", "Deleting Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //History Log
                    user.activity = "Removed RSBSA Data...";
                    user.user_id = loginfrm._log_id;
                    user.createLog();
                    //End Log

                    rsbsa.delRSBSA(SelectedIdLbl.Text);
                    loadData();
                    MessageBox.Show("RSBSA data successfully deleted!", "Deleted Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            //To Do Delete
            if (SelectedIdLbl.Text == "")
            {
                MessageBox.Show("Please select an specific data to edit!", "Edit Data?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure want to edit this Data?", "Editing Data", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _methods = "Edit";
                    showData();
                }
            }

        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            if (SelectedIdLbl.Text == "")
            {
                MessageBox.Show("Please select an specific data to preview!", "Viewing Data?", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _methods = "Preview";
                showData();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            rsbsa.fname = textBox1.Text;
            loadSearch();
        }

        private void textBoxMname_TextChanged(object sender, EventArgs e)
        {
            rsbsa.mname = textBoxMname.Text;
            loadSearch();
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {
            rsbsa.surname = textBoxSurname.Text;
            loadSearch();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rsbsa.livelihood = comboBox1.Text;
            loadSearch();
        }
    }
}
