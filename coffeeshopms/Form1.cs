using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace coffeeshopms
{
    public partial class formUserLogin : Form
    {
        public formUserLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        SqlConnection conn = dbconnection.connection();

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //userLogin user = new userLogin();
        private void btnUserLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text!="" && txtPassword.Text !="")
            {
                try
                {
                    conn.Open();
                    string login = "Select * from tbUser Where Username='" + txtUsername.Text.Trim() + "' and Password='" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter adapter = new SqlDataAdapter(login, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        userLogin.setUserID(dt.Rows[0][0].ToString());
                        
                        userLogin.setUsername(dt.Rows[0]["Username"].ToString());
                        userLogin.setUserType(dt.Rows[0]["Usertype"].ToString());
                        userLogin.setPw(dt.Rows[0]["Password"].ToString());

                        formMain m = new formMain();
                        m.Show();
                        this.Hide();
                    }
                    else
                    {
                        messageAlert.Warning("Incorrect username or password!", "User Login");
                    }
                    conn.Close();
                    adapter.Dispose();

                }
                catch (Exception ex)
                {
                    messageAlert.error("Log in faild!", "Log In");
                }
            }
            else
            {
                messageAlert.info("Please enter username and password!", "User Login");
                txtUsername.Focus();
            }
            
        }

        private void formUserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
