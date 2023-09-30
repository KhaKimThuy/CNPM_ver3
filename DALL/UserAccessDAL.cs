using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using DTOO;
using System.Runtime.Remoting.Contexts;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace DALL
{
    public class UserAccessDAL : DataAccessDAL
    {

        public bool verifyEmail(string to_email)
        {

            MySqlCommand command = new MySqlCommand("select * from" +
                                                    " USERS inner join USER_INFORMATION" +
                                                    " on USERS.USER_ID=USER_INFORMATION.USER_ID" +
                                                    " where USER_INFORMATION.USER_EMAIL=@email", con);
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = to_email;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            string user_id = null;
            string user_pass = null;
            foreach (DataRow row in table.Rows)
            {
                user_id = row["USER_ID"].ToString();
                user_pass = row["PASSWORD"].ToString();
            }

            if (user_id!=null && user_pass != null)
            {
                string from = "huonghvus2862003@gmail.com";
                //string to = textBox_email.Text;
                string email_app_pass = "bcem bcwl sbfm tcuc";

                MailMessage message = new MailMessage();
                message.To.Add(to_email);
                message.From = new MailAddress(from);
                message.Subject = "HI, Your account have just been created";
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                message.Body = "Your USER ID is " + user_id + "\n Your PASSWORD is " + user_pass;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Credentials = new NetworkCredential(from, email_app_pass);
                try
                {
                    smtpClient.Send(message);
                    return true;
                }
                catch (Exception ex)
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

        public bool insertUser(string vt_name, string username, DateTime birthdate, string address, string cccd, byte[] image, string email, string gender)
        {
            MySqlCommand command = new MySqlCommand("SELECT ADD_USER (@vt_name, @uname, @bd, @addr, @cccd, @img, @email, @gd) as Result", con);

            command.Parameters.Add("@vt_name", MySqlDbType.VarChar).Value = vt_name;
            command.Parameters.Add("@uname", MySqlDbType.VarChar).Value = username;
            command.Parameters.Add("@bd", MySqlDbType.Date).Value = birthdate;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@cccd", MySqlDbType.VarChar).Value = cccd;
            command.Parameters.Add("@img", MySqlDbType.LongBlob).Value = image;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
            command.Parameters.Add("@gd", MySqlDbType.  VarChar).Value = gender;

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
                    Users.USER_ID = row["USER_ID"].ToString();
                    Users.USER_NAME = row["USER_NAME"].ToString();
                    Users.USER_BIRTH = (DateTime)row["USER_BIRTH"];
                    Users.USER_ADDRESS = row["USER_ADDRESS"].ToString();
                    Users.USER_CCCD = row["USER_CCCD"].ToString();
                    Users.USER_IMAGE = (byte[])row["USER_IMAGE"];
                    Users.USER_EMAIL = row["USER_EMAIL"].ToString();
                    Users.USER_GENDER = row["USER_GENDER"].ToString();
                    Users.PASSWORD = row["PASSWORD"].ToString();
                    Users.ENABLE = Int32.Parse(row["ENABLE"].ToString());
                    Users.VT_ID = Int32.Parse(row["VT_ID"].ToString());
                    Users.VT_NAME = row["VT_NAME"].ToString();
                }
                return table.Rows[0];
            }
            else
            {
                return null;
            }

        }


        public bool loginCheck(string userID, string pass)
        {
            String query = String.Format("SELECT * FROM USERS WHERE USER_ID='{0}' AND PASSWORD='{1}'", userID, pass);
            MySqlCommand command = new MySqlCommand(query, con);

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                getUserInfo(userID);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
