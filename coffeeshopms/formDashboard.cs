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
using System.IO;

namespace coffeeshopms
{
    public partial class formDashboard : Form
    {
        public formDashboard()
        {
            InitializeComponent();
        }

        private void formDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void formDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            formMain m=new formMain();
            m.Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            openForm(new formMenu(), "Menu Management Form");
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            openForm(new formProduct(), "Product Management Form");
        }

        void openForm( Form frm, string title)
        {
            bool isOpen = false; 
            foreach (Form form in Application.OpenForms) { 
                if (form.Text == title) {
                    isOpen = true; form.Focus(); 
                } 
            }
            if (isOpen == false) {
                //frm.MdiParent = this; 
                frm.Show(); 
            }
        }
        SqlConnection conn = dbconnection.connection();
        private void formDashboard_Load(object sender, EventArgs e)
        {
            lbUsername.Text ="Username: "+ userLogin.getUsername();
            lbUserType.Text ="Usertype: "+ userLogin.getUserType();
            DateTime dt = DateTime.Now;
            lbTimer.Text ="Time: "+ dt.ToString("f");

            readOrder();
        }
        void readOrder()
        {
            string read="Select *from tbOrderDetail Where isDeleted='"+0+"' ORDER BY DetailID DESC";
            SqlDataAdapter ad = new SqlDataAdapter(read, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource= dt;

            ad.Dispose();
            dt.Dispose();
            conn.Close();
        }
        bool sidebarExpand;
        private void timerBar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelNavbar.Width -= 15;
                if (panelNavbar.Width == panelNavbar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerBar.Stop();
                }
            }
            else
            {
                panelNavbar.Width += 15;
                if(panelNavbar.Width == panelNavbar.MaximumSize.Width)
                {
                    sidebarExpand=true;
                    timerBar.Stop();
                }
            }

            //permission to users
            if (userLogin.getUserType() == "Staff")
            {
                btnUser.Enabled = false;
                btnStaff.Enabled = false;
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            timerBar.Start();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
            formUserLogin l=new formUserLogin();
            l.Show();
        }

        private void btnBackHome_Click(object sender, EventArgs e)
        {
            formMain m=new formMain();
            m.Show();
            this.Hide();
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            openForm(new formItem(), "Item Management Form");
        }

        private void btnOrdering_Click(object sender, EventArgs e)
        {
            openForm(new formOrder(), "Order Management Form");
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            openForm(new formStaff(), "Staff Management Form");
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            openForm(new formUser(), "User Management Form");
        }
    }
}
