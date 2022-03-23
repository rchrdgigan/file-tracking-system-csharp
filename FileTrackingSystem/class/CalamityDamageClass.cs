using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;



namespace FileTrackingSystem
{
    class CalamityDamageClass : ConnectionClass
    {
        public DataTable dtable = new DataTable();
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
            string query = ("SELECT * FROM rsbsa_tb WHERE status='Normal' ORDER BY id DESC");
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }


        //List function of RSBSA
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
    }
}
