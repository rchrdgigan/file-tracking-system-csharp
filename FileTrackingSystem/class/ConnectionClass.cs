using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;

namespace FileTrackingSystem
{
    class ConnectionClass
    {
        public MySqlConnection con;

        public ConnectionClass()
        {
            //string host = "localhost";
            //string db = "fts_db";
            //string port = "3306";
            //string username = "root";
            //string pass = "";
            //string con_str = "datasource =" + host + "; database =" + db +"; port =" + port + "; username =" + username + "; password =" + pass + "; SslMode=none;";

            string configLoc = Application.StartupPath + @"\config.txt";
            string[] config = File.ReadAllLines(configLoc);
            string ConnectionString = "datasource= '" + config[0] + "'; port= '" + config[1] + "'; username= '" + config[2] + "'; pwd = '" + config[3] + "'; database=fts_dbs; SslMode=none;";
            con = new MySqlConnection(ConnectionString);
        }

    }
}
