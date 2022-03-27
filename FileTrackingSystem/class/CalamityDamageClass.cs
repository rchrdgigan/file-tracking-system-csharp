using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;

namespace FileTrackingSystem
{
    class CalamityDamageClass : ConnectionClass
    {
        //public MySqlDataReader msdtr;
        public DataTable dtable = new DataTable();
        public DataTable dtable2 = new DataTable();
        public DataTable dtable3 = new DataTable();
        public string message { get; set; }
        public string rsbsa_id { get; set; }
        public string full_name { get; set; }
        public string address { get; set; }
        public string occupation { get; set; }
        public string budget_from { get; set; }
        public string date_from { get; set; }
        public string date_to { get; set; }
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
            string query = "SELECT `id`, `rsbsa_id`, `budget_from`, `date_from`, `type_calamity`, `amount_paid`, `ctc_no`, `ctc_date_issued`, `ctc_place_issued`, `created_at`, `updated_at` FROM `calamity_damage_tb` WHERE date_from ='" + date_from + "'";
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable2 = dt;
            if (dtable2.Rows.Count == 0)
            {
                string qry = "SELECT * FROM `rsbsa_tb` WHERE status='Normal' AND livelihood = '" + occupation + "'";
                MySqlDataAdapter msda1 = new MySqlDataAdapter(qry, con);
                DataTable dt1 = new DataTable();
                msda1.Fill(dt1);
                dtable = dt1;
            }
            else
            {
                con.Close();
                con.Open();
                string qry = "";
                string newx = "";
                string[] exe = new string[dt.Rows.Count];
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    exe[i]= dt.Rows[i][1].ToString();
                    newx = string.Join(",", exe);
                }
                qry = "SELECT * FROM `rsbsa_tb` WHERE id NOT in (" + newx + ") AND livelihood = '"+ occupation + "' AND status='Normal'";
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
                string query = "";
                DateTime today = DateTime.Now;
                if (!string.IsNullOrEmpty(cat))
                {
                    query = "SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.type_calamity='" + cat + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC";
                }
                else
                {
                    query = "SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.rsbsa_id = rsbsa_tb.id AND status='Normal' ORDER BY calamity_damage_tb.id DESC";
                }
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

        public void search(string cat)
        {
            try
            {
                string query = "";
                if (!string.IsNullOrEmpty(cat))
                {
                    if (full_name != "" || budget_from != "" || type_calamity != "")
                    {
                        query = ("SELECT calamity_damage_tb.id,rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE CONCAT(rsbsa_tb.fname,' ',rsbsa_tb.mname,' ',rsbsa_tb.surname,' ',rsbsa_tb.extension) LIKE '%" + full_name + "%' AND calamity_damage_tb.budget_from ='" + budget_from + "' AND calamity_damage_tb.type_calamity='" + cat + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (date_from != "" || date_to != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.created_at BETWEEN '" + date_from + "' AND '" + date_to + "' AND calamity_damage_tb.type_calamity='" + cat + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (full_name != "")
                    {
                        query = ("SELECT calamity_damage_tb.id,rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE CONCAT(rsbsa_tb.fname,' ',rsbsa_tb.mname,' ',rsbsa_tb.surname,' ',rsbsa_tb.extension) LIKE '%"+ full_name + "%' AND calamity_damage_tb.type_calamity='" + cat + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (budget_from != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.budget_from LIKE '%" + budget_from + "%' AND calamity_damage_tb.type_calamity='" + cat + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (address != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE rsbsa_tb.brgy = '" + address + "' AND calamity_damage_tb.type_calamity='" + cat + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.type_calamity='" + cat + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                }
                else
                {
                    if (full_name != "" || budget_from != "" || type_calamity != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE CONCAT(rsbsa_tb.fname,' ',rsbsa_tb.mname,' ',rsbsa_tb.surname,' ',rsbsa_tb.extension) LIKE '%" + full_name + "%' AND calamity_damage_tb.budget_from LIKE '%" + budget_from + "%' AND calamity_damage_tb.type_calamity='" + type_calamity + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (date_from != "" || date_to != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.created_at BETWEEN '" + date_from + "' AND '" + date_to + "' AND calamity_damage_tb.type_calamity='" + type_calamity + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (full_name != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE CONCAT(rsbsa_tb.fname,' ',rsbsa_tb.mname,' ',rsbsa_tb.surname,' ',rsbsa_tb.extension) LIKE '%" + full_name + "%' AND calamity_damage_tb.type_calamity='" + type_calamity + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (budget_from != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.budget_from LIKE '%" + budget_from + "%' AND calamity_damage_tb.type_calamity='" + type_calamity + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (type_calamity != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE calamity_damage_tb.type_calamity='" + type_calamity + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else if (address != "")
                    {
                        query = ("SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id WHERE rsbsa_tb.brgy = '" + address + "' AND calamity_damage_tb.type_calamity='" + type_calamity + "' AND status='Normal' ORDER BY calamity_damage_tb.id DESC");
                    }
                    else
                    {
                        query = "SELECT calamity_damage_tb.id, rsbsa_tb.fname, rsbsa_tb.mname, rsbsa_tb.surname, rsbsa_tb.extension, rsbsa_tb.livelihood, rsbsa_tb.brgy, calamity_damage_tb.amount_paid, calamity_damage_tb.ctc_no, calamity_damage_tb.ctc_date_issued, calamity_damage_tb.ctc_place_issued, calamity_damage_tb.created_at, calamity_damage_tb.updated_at, calamity_damage_tb.budget_from, calamity_damage_tb.date_from, calamity_damage_tb.type_calamity FROM rsbsa_tb LEFT JOIN calamity_damage_tb ON rsbsa_tb.id = calamity_damage_tb.rsbsa_id AND status='Normal' ORDER BY calamity_damage_tb.id DESC";
                    }
                }
                MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                dtable = dt;
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void searchGen()
        {
            try
            {
                string query = "";
                if (!string.IsNullOrEmpty(full_name))
                {
                    query = ("SELECT * FROM `rsbsa_tb` WHERE CONCAT(fname,' ',mname,' ',surname,' ',extension) LIKE '%" + full_name + "%' AND status='Normal'");
                }
                else if (!string.IsNullOrEmpty(address))
                {
                    query = ("SELECT * FROM `rsbsa_tb` WHERE CONCAT(fname,' ',mname,' ',surname,' ',extension) LIKE '%" + address + "%' AND status='Normal'");
                }
                else
                {
                    query = "SELECT * FROM `rsbsa_tb` WHERE status='Normal'";
                }
                MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                msda.Fill(dt);
                dtable = dt;
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

         public void archive(int id)
        {
            try
            {
                con.Open();
                DateTime updated_at = DateTime.Now;
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE `calamity_damage_tb` SET `status`='Archive' WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@updated_at", updated_at);
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void update(string id)
        {
            try
            {
                con.Open();
                DateTime updated_at = DateTime.Now;
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE `calamity_damage_tb` SET `budget_from` = @budget_from, `date_from` = @date_from, `amount_paid` = @amount_paid, `ctc_no` = @ctc_no, `ctc_date_issued` = @ctc_date_issued, `ctc_place_issued` = @ctc_place_issued, `updated_at` = @updated_at WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@budget_from", budget_from);
                    cmd.Parameters.AddWithValue("@date_from", date_from);
                    cmd.Parameters.AddWithValue("@type_calamity", type_calamity);
                    cmd.Parameters.AddWithValue("@amount_paid", amount_paid);
                    cmd.Parameters.AddWithValue("@ctc_no", ctc_no);
                    cmd.Parameters.AddWithValue("@ctc_date_issued", ctc_date_issued);
                    cmd.Parameters.AddWithValue("@ctc_place_issued", ctc_place_issued);
                    cmd.Parameters.AddWithValue("@updated_at", updated_at);
                    cmd.ExecuteNonQuery();

                    message = "Data Successfully Updated!";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void delete(int id)
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM calamity_damage_tb WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
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
