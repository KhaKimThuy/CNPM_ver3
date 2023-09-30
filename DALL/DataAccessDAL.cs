using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DTOO;

namespace DALL
{
    public class DataAccessDAL
    {
        public static string connstring = "server=s88d91.cloudnetwork.vn;PORT=3306;uid=sho27414_admin;pwd=admin21112023;database=sho27414_epdcs";
        public static MySqlConnection con = new MySqlConnection(connstring);


        public static MySqlConnection getConnection
        {
            get { return con; }
        }

        // Open connection
        public static void openConnect()
        {
            if (con == null)
            {
                con = new MySqlConnection(connstring);
            }
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }

        // Close connection
        public static void closeConnect()
        {
            if (con != null && con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
