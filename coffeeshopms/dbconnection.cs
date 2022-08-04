using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace coffeeshopms
{
    internal class dbconnection
    {
        private static SqlConnection conn;

        public static SqlConnection connection()
        {
            try
            {
                string str = "Server = MANGOO; Database=coffeeshopms;Trusted_Connection=true;";
                conn = new SqlConnection(str);
                conn.ConnectionString = str;
                //Connect.Open();
                //MessageBox.Show("ok");
                return conn;

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                return null;
            }
        }
    }
}
