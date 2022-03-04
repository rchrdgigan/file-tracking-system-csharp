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
        public string log_username { get; set; }
        public string log_password { get; set; }
        public string log_role { get; set; }
        public string fname { get; set; }

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
    }
}
