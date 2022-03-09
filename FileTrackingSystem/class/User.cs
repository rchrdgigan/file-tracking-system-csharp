﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections;
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
        public string message { get; set; }

        public bool IsValidEmail(string email)
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase);
            return regex.IsMatch(email);
        }

        //Login function
        public bool userVerification()
        {
            con.Open();
          
            bool check = false;
            using (var cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT * FROM users_tb WHERE username=@uname AND password=@pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;

                cmd.Parameters.Add("@uname", MySqlDbType.VarChar).Value = log_username;
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = log_password;

                msdtr = cmd.ExecuteReader();

                while (msdtr.Read())
                {
                    log_role = msdtr.GetString("role");
                    fname = msdtr.GetString("fname");
                    check = true;
                }
                con.Close();
            }
            return check;
        }

        //Register function
        public void create()
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
                    
                    if(msdtr.Read())
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

        public void listUser()
        {
            string query = ("SELECT * FROM users_tb");
            MySqlDataAdapter msda = new MySqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            msda.Fill(dt);
            dtable = dt;
        }
    }
}