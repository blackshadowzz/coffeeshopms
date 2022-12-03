using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshopms
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            lbUsername.Text=userLogin.getUsername();
            lbUserType.Text=userLogin.getUserType();    
            DateTime dt = DateTime.Now;
            lbTimer.Text = dt.ToString("f");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            formDashboard d=new formDashboard();
            d.Show();
            this.Hide();

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            formUserLogin l = new formUserLogin();
            l.Show();
            this.Hide();

        }

        private void formMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
