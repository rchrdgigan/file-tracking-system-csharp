using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;


namespace FileTrackingSystem
{
    class CalamityDamageClass : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable = new DataTable();
        public DataTable dtable2 = new DataTable();

        public string message { get; set; }
        public string rsbsa_id { get; set; }
        public string budget_from { get; set; }
        public string date_from { get; set; }
        public string type_calamity { get; set; }
        public string amount_paid { get; set; }
        public string ctc_no { get; set; }
        public string ctc_date_issued { get; set; }
        public string ctc_place_issued { get; set; }

        //List function of RSBSA
        public void listRSBSA()
        {
            con.Open();
            DateTime today = DateTime.Now;
            string query = "SELECT rsbsa_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy FROM calamity_damage_tb INNER JOIN rsbsa_tb ON calamity_damage_tb.rsbsa_id = rsbsa_tb.id WHERE calamity_damage_tb.date_from ='" + date_from + "'";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable2 = dt;
            foreach (DataRow item in dtable2.Rows)
            {
                con.Close();
                con.Open();
                string qry = "SELECT * FROM `rsbsa_tb` WHERE id <>'{3,4}'";
                MySqlDataAdapter msda1 = new MySqlDataAdapter(qry, con);
                DataTable dt1 = new DataTable();
                msda1.Fill(dt1);
                dtable = dt1;
            }
            con.Close();
        }
    
        //Create function or generate list of Calamity Damage
        public void generateCalamityList()
        {
            try
            {
                con.Open();
                DateTime today = DateTime.Now;
                string query = ("INSERT INTO `calamity_damage_tb`(`id`, `rsbsa_id`, `budget_from`, `date_from`, `type_calamity`, `amount_paid`, `ctc_no`, `ctc_date_issued`, `ctc_place_issued`, `created_at`) VALUES (NULL,@rsbsa_id,@budget_from,@date_from,@type_calamity,@amount_paid,@ctc_no,@ctc_date_issued,@ctc_place_issued,@today)");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@rsbsa_id", rsbsa_id);
                cmd.Parameters.AddWithValue("@budget_from", budget_from);
                cmd.Parameters.AddWithValue("@date_from", date_from);
                cmd.Parameters.AddWithValue("@type_calamity", type_calamity);
                cmd.Parameters.AddWithValue("@amount_paid", amount_paid);
                cmd.Parameters.AddWithValue("@ctc_no", ctc_no);
                cmd.Parameters.AddWithValue("@ctc_date_issued", ctc_date_issued);
                cmd.Parameters.AddWithValue("@ctc_place_issued", ctc_place_issued);
                cmd.Parameters.AddWithValue("@today", today);
                cmd.ExecuteNonQuery();

                message = "Successfully Genearated!";
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        //List function of Generated Calamity Damage
        public void calamityList(string cat)
        {
            try
            {
                con.Open();
                DateTime today = DateTime.Now;
                string query = "SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.date_from BETWEEN '" + date_from + "' AND '" + today + "' AND calamity_damage_tb.type_calamity='"+ cat + "' ORDER BY calamity_damage_tb.id DESC";
                MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                dtable = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }
    }
}
