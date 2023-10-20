using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALL
{
    public class TaskAccessDAL : DataAccessDAL
    {
        public bool InsertTask(string name, string desc, DateTime? exp, DateTime? start, DateTime? end, string isHL, string status, string pjID)
        {
            MySqlCommand command = new MySqlCommand("SELECT ADD_JOB (@name, @desc, @exp, @start, @end, @isHL, @status, @pjID) as Result", con);

            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = desc;
            command.Parameters.Add("@exp", MySqlDbType.Date).Value = exp;
            command.Parameters.Add("@start", MySqlDbType.Date).Value = start;
            command.Parameters.Add("@end", MySqlDbType.Date).Value = end;
            command.Parameters.Add("@isHL", MySqlDbType.Int32).Value = Int32.Parse(isHL);
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@pjID", MySqlDbType.VarChar).Value = pjID;

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
    }
}
