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
        public string relationship { get; set; }
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



    }
}
