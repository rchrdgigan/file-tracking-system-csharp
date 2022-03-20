using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FileTrackingSystem
{
    class FarmerClass : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string file_name { get; set; }
        public string fname_extension { get; set; }
        public string category { get; set; }
        public string message { get; set; }

        public void create()
        {
            try
            {
                con.Open();
                DateTime today = DateTime.Now;
                string query = ("INSERT INTO `farmers_files_tb`(`id`, `file_name`, `fname_extension`, `category`, `created_at`) VALUES (NULL,@file_name,@fname_extension,@category,@today)");
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@file_name", file_name);
                cmd.Parameters.AddWithValue("@fname_extension", fname_extension);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@today", today);
                cmd.ExecuteNonQuery();

                message = "File successfully uploaded!";
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        public void list(string category)
        {
            string query = "";
            if (category == "Masterlist of Rice Farmers")
            {
                query = ("SELECT * FROM farmers_files_tb WHERE category='Masterlist of Rice Farmers' AND status='Normal'");
            }
            else if (category == "Hybrid Users")
            {
                query = ("SELECT * FROM farmers_files_tb WHERE category='Hybrid Users' AND status='Normal'");
            }
            else if (category == "Certified Seeds User")
            {
                query = ("SELECT * FROM farmers_files_tb WHERE category='Certified Seeds User' AND status='Normal'");
            }
            else if (category == "Fertilizer Users")
            {
                query = ("SELECT * FROM farmers_files_tb WHERE category='Fertilizer Users' AND status='Normal'");
            }
            else
            {
                query = ("SELECT * FROM farmers_files_tb WHERE status='Normal'");
            }
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        public void update(string id)
        {
            try
            {
                con.Open();
                DateTime updated_at = DateTime.Now;
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE `farmers_files_tb` SET `file_name`= @file_name,`fname_extension`= @fname_extension,`category`= @category,`updated_at`= @updated_at WHERE id=@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                    cmd.Parameters.AddWithValue("@file_name", file_name);
                    cmd.Parameters.AddWithValue("@fname_extension", fname_extension);
                    cmd.Parameters.AddWithValue("@category", category);
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
                    cmd.CommandText = "DELETE FROM farmers_files_tb WHERE id=@id";
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
