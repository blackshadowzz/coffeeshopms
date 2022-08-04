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
    public partial class formShowReportCate : Form
    {
        public formShowReportCate()
        {
            InitializeComponent();
        }
        SqlConnection conn = dbconnection.connection();
        private void formShowReportCate_Load(object sender, EventArgs e)
        {

            string q = "Select * From tbCategory";
            SqlDataAdapter adapter = new SqlDataAdapter(q,conn);
            DataSet1 ds = new DataSet1();
            adapter.Fill(ds,"cate");

            CrystalReport1 report = new CrystalReport1();
            report.SetDataSource(ds. Tables["cate"]);
            crystalReportViewer1.ReportSource = report;

            conn.Close();

            
        }
    }
}
