using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOO;
using DALL;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL
{
    public class UserBLL
    {
        UserAccessDAL user_access = new UserAccessDAL();


        public bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9_%+-]+@[a-zA-Z0-9-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }


        public bool insertUser(string vt_name, string username, DateTime birthdate, string address, string cccd, byte[] image, string email, string gender)
        {
            if (user_access.insertUser(vt_name, username, birthdate, address, cccd, image, email, gender))
            {
                string[] id_pass = user_access.GetAccountByEmail(email);
                string id = id_pass[0];
                string pass = id_pass[1];
                string message = String.Format("Your USER ID: {0}\nYour PASSWORD: {1}", id, pass);
                string title = "Your SK account have just been created";
                return user_access.verifyEmail(email, title, message);
            }
            else
            {
                return false;
            }
        }


        public DataRow getUserInfo(string id)
        {
            return user_access.getUserInfo(id);
        }

        public DataTable getUserInfoAll()
        {
            return user_access.getUserInfoAll();
        }

        public bool loginCheck(string userID, string pass)
        {
            if (user_access.loginCheck(userID, pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string[] GetAccountByEmail(string email)
        {
            return user_access.GetAccountByEmail(email);
        }

        public bool verifyEmail(string to_email, string title, string m)
        {
            return user_access.verifyEmail(to_email, title, m);
        }

        public DataTable GetAllProjectOfUser(string u_id)
        {
            return user_access.GetAllProjectOfUser(u_id);
        }

        // function to add request
        public int addRequest(string req, string s_id, string r_id)
        {
            return user_access.addRequest(req, s_id, r_id);
        }

        // function to check exist request

        public DataRow checkRequest(string r_id)
        {
            return user_access.checkRequest(r_id);
        }

        // function to update status of req

        public int updateRequest(string s_id)
        {
            return user_access.updateRequest(s_id);
        }

        // function to update password

        public int updatePassword(string s_id, string s_password)
        {
            return user_access.updatePassword(s_id, s_password);
        }

    }
}
