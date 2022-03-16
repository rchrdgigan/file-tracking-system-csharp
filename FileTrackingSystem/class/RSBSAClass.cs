using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
using System.Text.RegularExpressions;

namespace FileTrackingSystem
{
    class RSBSAClass : ConnectionClass
    {
        public DataTable dtable { get; set; }
        public string message { get; set; }
        public string surname { get; set; }
        public string fname { get; set; }
        public string mname { get; set; }
        public string extension { get; set; }
        public string gender { get; set; }
        public string purok { get; set; }
        public string street { get; set; }
        public string brgy { get; set; }
        public string municipality { get; set; }
        public string province { get; set; }
        public string region { get; set; }
        public string mobile_no { get; set; }
        public string landline_no { get; set; }
        public string birthdate { get; set; }
        public string birth_place { get; set; }
        public string religion { get; set; }
        public string civil_stat { get; set; }
        public string spouse_name { get; set; }
        public string mother_maiden { get; set; }
        public string household_head { get; set; }
        public string hh_relationship { get; set; }
        public string no_living_mem { get; set; }
        public string num_male { get; set; }
        public string num_female { get; set; }
        public string high_formal_educ { get; set; }
        public bool pdw { get; set; }
        public bool four_ps { get; set; }
        public string mem_indigenous_group { get; set; }
        public string govID_type { get; set; }
        public string ID_no { get; set; }
        public string mem_farmer_association { get; set; }
        public string person_case_emergency { get; set; }
        public string contact_num { get; set; }
        public string livelihood { get; set; }
        //for farmers
        public bool rice { get; set; }
        public bool corn { get; set; }
        public string other_crops { get; set; }
        public string other_livestock { get; set; }
        public string other_poultry { get; set; }
        //for farmerworkers
        public bool land_preparation { get; set; }
        public bool planting { get; set; }
        public bool cultivation { get; set; }
        public bool harvesting { get; set; }
        public string others_farm{ get; set; }
        //for fisherfolk
        public bool fish_capture { get; set; }
        public bool aquaculture { get; set; }
        public bool gleaning { get; set; }
        public bool fish_processing { get; set; }
        public bool fish_vending { get; set; }
        public string others_fish { get; set; }
        //for agri youth
        public bool part_farm_hh { get; set; }
        public bool att_form_afrc { get; set; }
        public bool att_nonform_afrc { get; set; }
        public bool participated_aaap { get; set; }
        public string others_agri_youth { get; set; }

        public string income_farming { get; set; }
        public string income_nonfarming { get; set; }

        public void createRSBSA()
        {
            try
            {
                con.Open();
                using (var cmd_chkuser = new MySqlCommand())
                {
                    DateTime today = DateTime.Today;
                    string query = ("INSERT INTO `rsbsa_tb`(`id`, `surname`, `fname`, `mname`, `extension`, `gender`, `purok`, `street`, `brgy`, `municipality`, `province`, `region`, `mobile_no`, `landline_no`, `birthdate`, `birth_place`, `religion`, `civil_stat`, `spouse_name`, `mother_maiden`, "
                        + "`household_head`, `hh_relationship`, `no_living_mem`, `num_male`, `num_female`, `high_formal_educ`, `pdw`, `four_ps`, `mem_indigenous_group`, `govID_type`, `ID_no`, `mem_farmer_association`, `person_case_emergency`, `contact_num`, `livelihood`,"
                        + "`rice`, `corn`, `other_crops`, `other_livestock`, `other_poultry`, `land_preparation`, `planting`, `cultivation`, `harvesting`, `others_farm`, `fish_capture`, `aquaculture`, `gleaning`, `fish_processing`, `fish_vending`, `others_fish`,"
                        + "`part_farm_hh`, `att_form_afrc`, `att_nonform_afrc`, `participated_aaap`, `others_agri_youth`, income_farming, income_nonfarming,`created_at`) VALUES (NULL,@surname,@fname,@mname,@extension,@gender,@purok,@street,@brgy,@municipality,@province,@region,@mobile_no,@landline_no,@birthdate,@birth_place,@religion,@civil_stat,@spouse_name,@mother_maiden,"
                        + "@household_head,@hh_relationship,@no_living_mem,@num_male,@num_female,@high_formal_educ,@pdw,@four_ps,@mem_indigenous_group,@govID_type,@ID_no,@mem_farmer_association,@person_case_emergency,@contact_num,@livelihood,@rice,@corn,@other_crops,@other_livestock,@other_poultry,@land_preparation,"
                        + "@planting,@cultivation,@harvesting,@others_farm,@fish_capture,@aquaculture,@gleaning,@fish_processing,@fish_vending,@others_fish,@part_farm_hh,@att_form_afrc,@att_nonform_afrc,@participated_aaap,@others_agri_youth,@income_farming,@income_nonfarming,@today)");
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@mname", mname);
                    cmd.Parameters.AddWithValue("@extension", extension);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@purok", purok);
                    cmd.Parameters.AddWithValue("@street", street);
                    cmd.Parameters.AddWithValue("@brgy", brgy);
                    cmd.Parameters.AddWithValue("@municipality", municipality);
                    cmd.Parameters.AddWithValue("@province", province);
                    cmd.Parameters.AddWithValue("@region", region);
                    cmd.Parameters.AddWithValue("@mobile_no", mobile_no);
                    cmd.Parameters.AddWithValue("@landline_no", landline_no);
                    cmd.Parameters.AddWithValue("@birthdate", birthdate);
                    cmd.Parameters.AddWithValue("@birth_place", birth_place);
                    cmd.Parameters.AddWithValue("@religion", religion);
                    cmd.Parameters.AddWithValue("@civil_stat", civil_stat);
                    cmd.Parameters.AddWithValue("@spouse_name", spouse_name);
                    cmd.Parameters.AddWithValue("@mother_maiden", mother_maiden);
                    cmd.Parameters.AddWithValue("@household_head", household_head);
                    cmd.Parameters.AddWithValue("@hh_relationship", hh_relationship);
                    cmd.Parameters.AddWithValue("@no_living_mem", no_living_mem);
                    cmd.Parameters.AddWithValue("@num_male", num_male);
                    cmd.Parameters.AddWithValue("@num_female", num_female);
                    cmd.Parameters.AddWithValue("@high_formal_educ", high_formal_educ);
                    cmd.Parameters.AddWithValue("@pdw", pdw);
                    cmd.Parameters.AddWithValue("@four_ps", four_ps);
                    cmd.Parameters.AddWithValue("@mem_indigenous_group", mem_indigenous_group);
                    cmd.Parameters.AddWithValue("@govID_type", govID_type);
                    cmd.Parameters.AddWithValue("@ID_no", ID_no);
                    cmd.Parameters.AddWithValue("@mem_farmer_association", mem_farmer_association);
                    cmd.Parameters.AddWithValue("@person_case_emergency", person_case_emergency);
                    cmd.Parameters.AddWithValue("@contact_num", contact_num);
                    cmd.Parameters.AddWithValue("@livelihood", livelihood);

                    cmd.Parameters.AddWithValue("@rice", rice);
                    cmd.Parameters.AddWithValue("@corn", corn);
                    cmd.Parameters.AddWithValue("@other_crops", other_crops);
                    cmd.Parameters.AddWithValue("@other_livestock", other_livestock);
                    cmd.Parameters.AddWithValue("@other_poultry", other_poultry);

                    cmd.Parameters.AddWithValue("@land_preparation", land_preparation);
                    cmd.Parameters.AddWithValue("@planting", planting);
                    cmd.Parameters.AddWithValue("@cultivation", cultivation);
                    cmd.Parameters.AddWithValue("@harvesting", harvesting);
                    cmd.Parameters.AddWithValue("@others_farm", others_farm);

                    cmd.Parameters.AddWithValue("@fish_capture", fish_capture);
                    cmd.Parameters.AddWithValue("@aquaculture", aquaculture);
                    cmd.Parameters.AddWithValue("@gleaning", gleaning);
                    cmd.Parameters.AddWithValue("@fish_processing", fish_processing);
                    cmd.Parameters.AddWithValue("@fish_vending", fish_vending);
                    cmd.Parameters.AddWithValue("@others_fish", others_fish);

                    cmd.Parameters.AddWithValue("@part_farm_hh", part_farm_hh);
                    cmd.Parameters.AddWithValue("@att_form_afrc", att_form_afrc);
                    cmd.Parameters.AddWithValue("@att_nonform_afrc", att_nonform_afrc);
                    cmd.Parameters.AddWithValue("@participated_aaap", participated_aaap);
                    cmd.Parameters.AddWithValue("@others_agri_youth", others_agri_youth);

                    cmd.Parameters.AddWithValue("@income_farming", income_farming);
                    cmd.Parameters.AddWithValue("@income_nonfarming", income_nonfarming);

                    cmd.Parameters.AddWithValue("@today", today);
                    cmd.ExecuteNonQuery();

                    message = "User Successfully Registered";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }



    }
}
