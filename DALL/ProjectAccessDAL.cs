using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DALL
{

    //git fetch && git checkout FETCH_HEAD -- DALL/UserAccessDAL.cs
    public class ProjectAccessDAL : DataAccessDAL
    {
        public bool InsertPJ(string name, string desc, DateTime exp, DateTime start, DateTime end, string ver, string u_id)
        {
            MySqlCommand command = new MySqlCommand("SELECT ADD_PJ (@name, @desc, @exp, @start, @end, @ver, @u_id) as Result", con);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@exp", MySqlDbType.Date).Value = exp;
            command.Parameters.Add("@start", MySqlDbType.Date).Value = start;
            command.Parameters.Add("@end", MySqlDbType.Date).Value = end;
            command.Parameters.Add("@ver", MySqlDbType.Int32).Value = Int32.Parse(ver);
            command.Parameters.Add("@u_id", MySqlDbType.VarChar).Value = u_id;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                string r = row["Result"].ToString();
                i = Int32.Parse(r);
            }

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetProjectInfoAllOfMan(string u_id)
        {
            String query = String.Format("call GET_PJ_USER_MANAGE(@u_id)");
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.Add("@u_id", MySqlDbType.VarChar).Value = u_id;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        public bool AddMember2Project(string u_id, string u_email, string pj_id)
        {
            MySqlCommand command = new MySqlCommand("SELECT ADD_U_PJ_NG (@u_id, @pj_id) as Result", con);

            command.Parameters.Add("@u_id", MySqlDbType.VarChar).Value = u_id;
            command.Parameters.Add("@pj_id", MySqlDbType.VarChar).Value = pj_id;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            int i = 0;
            foreach (DataRow row in table.Rows)
            {
                string r = row["Result"].ToString();
                i = Int32.Parse(r);
            }

            if (i > 0)
            {
                UserAccessDAL ul = new UserAccessDAL();
                string title = "Welcome to new project!";
                string message = "You've just been added to Project:" + pj_id;
                ul.verifyEmail(u_email, title, message);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetUserOfProject(string pj_id)
        {
            String query = String.Format("call GET_USER_OF_PJ(@pj_id)");
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.Add("@pj_id", MySqlDbType.VarChar).Value = pj_id;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }
    }
}
