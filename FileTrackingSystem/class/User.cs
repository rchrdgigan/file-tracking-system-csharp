using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace FileTrackingSystem
{
    class User : ConnectionClass
    {
        public MySqlDataReader msdtr;
        public DataTable dtable { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string contact { get; set; }
        public string log_username { get; set; }
        public string log_password { get; set; }
        public string log_role { get; set; }
        public string log_id { get; set; }
        public long modifId { get; set; }
        public string message { get; set; }
        public Int32 count { get; set; }
        public string user_id { get; set; }

        public string activity { get; set; }

        //Validate email function
        public bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        //Register function
        public void create(string roles)
        {
            try
            {
                con.Open();
                using (var cmd_chkuser = new MySqlCommand())
                {
                    cmd_chkuser.CommandText = "SELECT * FROM users_tb WHERE username=@uname";
                    cmd_chkuser.CommandType = CommandType.Text;
                    cmd_chkuser.Connection = con;

                    cmd_chkuser.Parameters.Add("@uname", MySqlDbType.VarChar).Value = log_username;
                    msdtr = cmd_chkuser.ExecuteReader();

                    if (msdtr.Read())
                    {
                        message = "User Already Exist!";
                    }
                    else
                    {
                        con.Close();
                        con.Open();
                        DateTime today = DateTime.Now;
                        string role = "";
                        string query = "";
                        if (roles == "")
                        {
                            role = "Staff";
                            query = ("INSERT INTO `users_tb`(`fname`, `lname`, `email`, `contact`, `username`, `password`, `role`, `created_at`) VALUES (@fname,@lname,@email,@contact,@username,@password,@role,@today);");
                        }
                        else
                        {
                            role = roles;
                            query = ("INSERT INTO `users_tb`(`fname`, `lname`, `email`, `contact`, `username`, `password`, `role`, `created_at`) VALUES (@fname,@lname,@email,@contact,@username,@password,@role,@today)");
                        }
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
                        modifId = cmd.LastInsertedId;
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

        //Login function
        public bool userVerification()
        {
            con.Open();

            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM users_tb WHERE username=@uname AND password=@pass AND status='Normal'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = log_username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = log_password;

                msdtr = cmd.ExecuteReader();

                while (msdtr.Read())
                {
                    log_id = msdtr.GetString("id");
                    log_role = msdtr.GetString("role");
                    fname = msdtr.GetString("fname");
                    check = true;
                }
                con.Close();
            }
            return check;
        }

        //Display User list function
        public void listUser()
        {
            string query = ("SELECT * FROM users_tb WHERE status='Normal' ORDER BY id DESC");
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }

        //Delete User function
        public void delUser(string uname)
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM users_tb WHERE username=@uname";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        //Search User function
        public void search()
        {
            try
            {
                string query = "";

                if (fname != "" || lname != "")
                {
                    query = ("SELECT * FROM users_tb WHERE fname LIKE '%" + fname + "%' AND lname LIKE '%" + lname + "%' AND status='Normal' ORDER BY id DESC");
                }
                else if (fname != "")
                {
                    query = ("SELECT * FROM users_tb WHERE fname LIKE '%" + fname + "%' AND status='Normal' ORDER BY id DESC");
                }
                else if (lname != "")
                {
                    query = ("SELECT * FROM users_tb WHERE fname LIKE '%" + lname + "%' AND status='Normal' ORDER BY id DESC");
                }
                else
                {
                    query = ("SELECT * FROM users_tb WHERE status='Normal' ORDER BY id DESC");
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

        //Archive User function
        public void archive(string uname)
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "UPDATE `users_tb` SET `status`='Archive' WHERE username=@uname";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname;
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        //Count User function
        public void countUser()
        {
            try
            {
                con.Open();
                using (var cmd = new MySqlCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) FROM users_tb WHERE status='Normal'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;
                    count = Convert.ToInt32(cmd.ExecuteScalar());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }


        //Add History Log in User Management
        public void createLog()
        {
            try
            {
                con.Close();
                con.Open();
                DateTime today = DateTime.Now;
                string time = DateTime.Now.ToString("h:mm:ss tt");
                string query = "";
                query = ("INSERT INTO `history_log_tb`(`id`, `user_id`, `activity`, `date`, `time`) VALUES(NULL, @user_id, @activity, @today, @time)"); 
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@activity", activity);
                cmd.Parameters.AddWithValue("@today", today);
                cmd.Parameters.AddWithValue("@time", time);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                message = "error" + ex.ToString();
            }
        }

        //Display History log
        public void diplayHistoryLog()
        {
            try
            {
                string query = ("SELECT history_log_tb.id, history_log_tb.date, history_log_tb.time, history_log_tb.activity, users_tb.fname, users_tb.lname, users_tb.role FROM history_log_tb LEFT JOIN users_tb ON history_log_tb.user_id = users_tb.id ORDER BY history_log_tb.id DESC");
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

        //Activity Display History log
        public void seachHistoryLog()
        {
            try
            {
                string query = ("SELECT history_log_tb.id, history_log_tb.date, history_log_tb.time, history_log_tb.activity, users_tb.fname, users_tb.lname, users_tb.role FROM history_log_tb LEFT JOIN users_tb ON history_log_tb.user_id = users_tb.id ORDER BY history_log_tb.id DESC");
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

    }
}
