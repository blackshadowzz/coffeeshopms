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
    public partial class formViewOrderDetail : Form
    {
        public formViewOrderDetail()
        {
            InitializeComponent();
        }
        SqlConnection conn = dbconnection.connection();
        private void formViewOrderDetail_Load(object sender, EventArgs e)
        {
            readOrder();
            OrderTotal();
        }
        void readOrder()
        {
            string read = "Select *from tbOrderDetail Where isDeleted='" + 0 + "' ORDER BY DetailID DESC";
            SqlDataAdapter ad = new SqlDataAdapter(read, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.RowTemplate.Height = 65;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[11].Visible = true;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            ad.Dispose();
            dt.Dispose();
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formOrderingItem o=new formOrderingItem();
            o.Show();
            this.Close();
        }
        void searchData()
        {
            string select = "Select * From tbOrderDetail Where FullName LIKE '%" + txtSearch.Text.Trim() + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[11].Visible = true;
            dataGridView1.Columns[0].Width = 70;
            dataGridView1.Columns[1].Width = 70;
            dataGridView1.Columns[2].Width = 70;
            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            adapter.Dispose();
            dt.Dispose();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            searchData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchData();
        }
        void OrderTotal()
        {
            conn.Open();
            string order = "SELECT COUNT(DetailID) from tbOrderDetail";
            SqlCommand cmd = new SqlCommand(order, conn);
            Int32 total = (Int32)cmd.ExecuteScalar();
            lbTotalOrder.Text ="Total Order: "+ total.ToString();

            cmd.Dispose();
            conn.Close();
        }
        private void lbTotalOrder_Click(object sender, EventArgs e)
        {
            OrderTotal();
        }
    }
}
