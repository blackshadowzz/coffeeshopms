using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace coffeeshopms
{
    internal class userLogin
    {
        //static fields
        private static string ID;
        //public static string UserID { get { return userID; } set { userID = value; } }
        private static string username;
        //public static string UserName { get { return username; } set { username = value; } }
        private static string userPassword;
        //public static string UserPassword { get { return userPassword; } set { userPassword = value; } }
        private static string userType;
        //public static string UserType { get { return userType; } set { userType = value; } }

        public static void setUserID(string Id)
        {
            ID = Id;
        }
        //static methods:getter methods
        public static string getUserId()
        {
            return ID;
        }
        public static void setUsername(string Username)
        {
            username = Username;
        }
        public static string getUsername()
        {
            return username;
        }
        public static void setPw(string UserPw)
        {
            userPassword = UserPw;
        }
        public static string getPw()
        {
            return userPassword;
        }
        public static void setUserType(string UserType)
        {
            userType = UserType;
        }
        public static string getUserType()
        {
            return userType;
        }

        public static void ClearUserinfo()
        {
            ID = string.Empty;
            username = string.Empty;
            userPassword = string.Empty;
            userType = string.Empty;
        }
    }
}
