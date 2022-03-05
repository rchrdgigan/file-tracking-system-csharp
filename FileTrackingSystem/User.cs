using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace FileTrackingSystem
{
    class User : ConnectionClass
    {
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string log_username { get; set; }
        public string log_password { get; set; }
        public string log_role { get; set; }
        public string message { get; set; }

        public bool userVerification()
        {
            con.Open();
            MySqlDataReader rd;
            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM users_tb WHERE username=@uname AND password=@pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = log_username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = log_password;

                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    log_role = rd.GetString("role");
                    fname = rd.GetString("fname");
                    check = true;
                }
                con.Close();
            }
            return check;
        }

        public void create()
        {
            try
            {
                con.Open();
                MySqlDataReader rd;
                using (var cmd_chkuser = new MySqlCommand())
                {
                    cmd_chkuser.CommandText = "SELECT * FROM users_tb WHERE username=@uname";
                    cmd_chkuser.CommandType = CommandType.Text;
                    cmd_chkuser.Connection = con;

                    cmd_chkuser.Parameters.Add("@uname", MySqlDbType.VarChar).Value = log_username;
                    rd = cmd_chkuser.ExecuteReader();
                    
                    if(rd.Read())
                    {
                        message = "User Already Exist!";
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        DateTime today = DateTime.Today;
                        string role = "Staff";
                        string query = ("INSERT INTO `users_tb`(`id`, `fname`, `lname`, `email`, `contact`, `username`, `password`, `role`, `created_at`) VALUES (NULL,@fname,@lname,@email,@contact,@username,@password,@role,@today)");
                        MySqlCommand cmd = new MySqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@fname", fname);
                        cmd.Parameters.AddWithValue("@lname", lname);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@contact", contact);
                        cmd.Parameters.AddWithValue("@username", log_username);
                        cmd.Parameters.AddWithValue("@password", log_password);
                        cmd.Parameters.AddWithValue("@role", role);
                        cmd.Parameters.AddWithValue("@today", today);
                        cmd.ExecuteNonQuery();

                        message = "User Successfully Registered";
                    }
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
