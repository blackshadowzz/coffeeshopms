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
    public partial class formStaffRestore : Form
    {
        public formStaffRestore()
        {
            InitializeComponent();
        }

        SqlConnection conn = dbconnection.connection();

        private void btnBack_Click(object sender, EventArgs e)
        {
            formStaff s=new formStaff();
            s.Show();
            this.Close();
        }
        void readData()
        {
            string read = "Select * from tbStaff Where isDeleted='" + 1 + "'";
            SqlDataAdapter ad=new SqlDataAdapter(read,conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            ad.Dispose();
            dt.Dispose();
            conn.Close();
        }

        private void formStaffRestore_Load(object sender, EventArgs e)
        {
            readData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (btnSearch.Text == "Enable")
            {
                lbSearchID.Text = "Search by name";
                btnSearch.Text = "Search";
                txtSearch.Clear();
            }else if (btnSearch.Text == "Search")
            {
                string select = "Select * From tbStaff Where FullName LIKE '%" + txtSearch.Text.Trim() + "%' and isDeleted='" + 1 + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(select, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.RowTemplate.Height = 30;

                dataGridView1.DataSource = dt;
                adapter.Dispose();
                dt.Dispose();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearch.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lbSearchID.Text = "Staff ID";
            btnSearch.Text = "Enable";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string select = "Select * From tbStaff Where FullName LIKE '%" + txtSearch.Text.Trim() + "%' and isDeleted='" + 1 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.RowTemplate.Height = 30;

            dataGridView1.DataSource = dt;
            adapter.Dispose();
            dt.Dispose();
        }

        private void btnRestoreOne_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                messageAlert.Warning("Please a product to restore!", "Restore Warning");

            }
            else
            {

                string name = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                if (MessageBox.Show("Are you sure!  you want to restore a staff '" + name + "'?",
                    "Staff Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        SqlCommand re = new SqlCommand("restoreOneStaff", conn);
                        re.CommandType = CommandType.StoredProcedure;
                        re.Parameters.AddWithValue("@id", int.Parse(id));
                        re.ExecuteNonQuery();

                        readData();

                        messageAlert.info("One Staff has been restored!", "Restore Alert");
                        re.Dispose();
                    }
                    catch (Exception ex)
                    {
                        messageAlert.error(ex.Message, "Error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnRestoreAll_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                SqlCommand restore = new SqlCommand("restoreStaffAll", conn);
                restore.CommandType = CommandType.StoredProcedure;

                restore.ExecuteNonQuery();

                readData();
                MessageBox.Show("One record has been restore!", "Restore Alert");
                restore.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
