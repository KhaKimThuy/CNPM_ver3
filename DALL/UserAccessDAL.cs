using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTOO;
using System.Runtime.Remoting.Contexts;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Web;

namespace DALL
{
    public class UserAccessDAL : DataAccessDAL
    {

        public string[] GetAccountByEmail(string email)    
        {
            String query = String.Format("call GET_INFO_BY_EMAIL(@email)");
            MySqlCommand command = new MySqlCommand(query, con);
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);


            if (table.Rows.Count > 0)
            {
                string id = "";
                string pass = "";
                foreach (DataRow row in table.Rows)
                {
                    id = row["U_LOGIN"].ToString();
                    pass = row["U_PASS"].ToString();
                }
                string[] id_pass = {id,pass};
                return id_pass;
            } 
            else
            {
                string[] non_result = { "", "" };
                return non_result;
            }
        }


        public bool verifyEmail(string to_email, string title, string m)
        {
            if (m != null && m != "")
            {
                string from = "epdcsver0@gmail.com";
                // pass: 123456789epdcs
                string email_app_pass = "tmum fbnp gabm evpt";

                MailMessage message = new MailMessage();
                message.To.Add(to_email);
                message.From = new MailAddress(from);
                message.Subject = title;
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                message.Body = m;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(from, email_app_pass);
                try
                {
                    smtpClient.Send(message);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public DataTable getUserInfoAll()
        {
            String query = String.Format("call GET_INFO_USER_ALL()");
            MySqlCommand command = new MySqlCommand(query, con);

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

        public bool insertUser(string vt_name, string username, DateTime birthdate, string address, string cccd, byte[] image, string email, string gender, string dp, string lv, string phone)
        {
            MySqlCommand command = new MySqlCommand("SELECT ADD_USER (@vt_name, @uname, @bd, @addr, @cccd, @img, @email, @gd, @lv, @dp, @phone) as Result", con);

            command.Parameters.Add("@vt_name", MySqlDbType.VarChar).Value = vt_name;
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@cccd", MySqlDbType.VarChar).Value = cccd;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@lv", MySqlDbType.VarChar).Value = lv;
            command.Parameters.Add("@dp", MySqlDbType.VarChar).Value = dp;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            // `Fill` để lấy dữ liệu từ cơ sở dữ liệu MySQL vào một đối tượng `DataSet` hoặc `DataTable`
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

        public bool UpdateUserInfo(string pk, string u_name, DateTime bd, string cccd, string addr, string gd, string email, string vt_name, string u_pass, string lv_name, string dp_name, string u_phone, byte[] img)
        {
            MySqlCommand command = new MySqlCommand("SELECT UPDATE_USER_INFO (@pk, @u_name, @bd, @cccd, @addr, @gd, @email, @vt_name, @u_pass, @lv_name, @dp_name, @u_phone, @img) as Result", con);

            command.Parameters.Add("@pk", MySqlDbType.VarChar).Value = pk;
            command.Parameters.Add("@u_name", MySqlDbType.VarChar).Value = u_name;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = bd;
            command.Parameters.Add("@cccd", MySqlDbType.VarChar).Value = cccd;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = addr;
            command.Parameters.Add("@gd", MySqlDbType.VarChar).Value = gd;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@vt_name", MySqlDbType.VarChar).Value = vt_name;
            command.Parameters.Add("@u_pass", MySqlDbType.VarChar).Value = u_pass;
            command.Parameters.Add("@lv_name", MySqlDbType.VarChar).Value = lv_name;
            command.Parameters.Add("@dp_name", MySqlDbType.VarChar).Value = dp_name;
            command.Parameters.Add("@u_phone", MySqlDbType.VarChar).Value = u_phone;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = img;

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

        public DataRow getUserInfo(string id)
        {
            String query = String.Format("call GET_INFO_USER('{0}')", id);
            MySqlCommand command = new MySqlCommand(query, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    Users.PK = row["USER_ID"].ToString();
                    Users.USER_LOGIN = row["U_LOGIN"].ToString();
                    Users.USER_NAME = row["USER_NAME"].ToString();
                    Users.USER_BIRTH = (DateTime)row["USER_BIRTH"];
                    Users.USER_ADDRESS = row["USER_ADDRESS"].ToString();
                    Users.USER_CCCD = row["USER_CCCD"].ToString();
                    Users.USER_EMAIL = row["USER_EMAIL"].ToString();
                    Users.USER_GENDER = row["USER_GENDER"].ToString();
                    Users.USER_PHONE = row["USER_PHONE"].ToString();

                    try
                    {
                        Users.USER_IMAGE = (byte[])row["USER_IMAGE"];
                    }
                    catch
                    {
                        Users.USER_IMAGE = null;
                    }

                    Users.PASSWORD = row["U_PASS"].ToString();
                    Users.ENABLE = Int32.Parse(row["U_EN"].ToString());
                    Users.VT_NAME = row["VT_NAME"].ToString();
                    Users.LV_NAME = row["LV_NAME"].ToString();
                    Users.DP_NAME = row["PB_NAME"].ToString();
                }
                return table.Rows[0];
            }
            else
            {
                return null;
            }
        }


        public bool loginCheck(string user_login, string pass)
        {
            String query = String.Format("call LOGIN_CHECK('{0}', '{1}')", user_login, pass);
            MySqlCommand command = new MySqlCommand(query, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                DataRow row = table.Rows[0];
                string id = row["USER_ID"].ToString(); 
                getUserInfo(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable GetAllProjectOfUser(string u_id)
        {
            String query = String.Format("call GET_PJ_USER(@u_id)");
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

        //function to add request
        public int addRequest(string req, string s_id, string r_id)
        {


            string query = string.Format("select ADD_REQUEST('{0}','{1}', '{2}') as Result", req, s_id, r_id);
            MySqlCommand command = new MySqlCommand(query, con);


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataRow dr = table.Rows[0];



            string str_value = dr["Result"].ToString();
            int value = Convert.ToInt32(str_value);

            return value;
        }

        //function to check if request is exist

        public DataRow checkRequest(string s_id)
        {

            String query = String.Format("call CHECK_E_R('{0}')", s_id);
            MySqlCommand command = new MySqlCommand(query, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return table.Rows[0];
            }
            else
            {
                return null;
            }
        }

        //function to update status of req
        public int updateRequest(string s_id)
        {
            string query = string.Format("select UPDATE_R_STATUS('{0}') as Result", s_id);
            MySqlCommand command = new MySqlCommand(query, con);


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataRow dr = table.Rows[0];

            return Convert.ToInt32(dr["Result"].ToString());
        }

        // function to update password

        public int updatePassword(string s_id, string pass)
        {
            string query = string.Format("select UPDATE_PASSWORD('{0}', '{1}') as Result", s_id, pass);
            MySqlCommand command = new MySqlCommand(query, con);


            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            DataRow dr = table.Rows[0];

            return Convert.ToInt32(dr["Result"].ToString());
        }
    }
}
