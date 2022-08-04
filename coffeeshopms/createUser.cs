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
    public partial class createUser : Form
    {
        public createUser()
        {
            InitializeComponent();
        }

        private void btnBackTologin_Click(object sender, EventArgs e)
        {
            formUserLogin form1 = new formUserLogin();
            form1.Show();
            this.Close();
        }

        private void createUser_Load(object sender, EventArgs e)
        {

        }
    }
}
