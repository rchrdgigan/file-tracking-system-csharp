using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FileTrackingSystem
{
    class ConnectionClass
    {
        public MySqlConnection con;

        public ConnectionClass()
        {
            string host = "localhost";
            string db = "fts_db";
            string port = "3306";
            string username = "root";
            string pass = "";

            string con_str = "datasource =" + host + "; database =" + db +"; port =" + port + "; username =" + username + "; password =" + pass + "; SslMode=none;";

            con = new MySqlConnection(con_str);
        }

    }
}
