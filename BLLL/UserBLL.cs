using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOO;
using DALL;
using System.Data.SqlClient;
using System.Data;

namespace BLL
{
    public class UserBLL
    {
        UserAccessDAL user_access = new UserAccessDAL();


        public bool insertUser(string vt_name, string username, DateTime birthdate, string address, string cccd, byte[] image, string email, string gender)
        {
            if (user_access.insertUser(vt_name, username, birthdate, address, cccd, image, email, gender))
            {
                return verifyEmail(email);
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

        public bool verifyEmail(string to_email)
        {
            return user_access.verifyEmail(to_email);
        }
    }
}
