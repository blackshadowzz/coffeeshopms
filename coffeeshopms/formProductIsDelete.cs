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
    public partial class formProductIsDelete : Form
    {
        public formProductIsDelete()
        {
            InitializeComponent();
        }
        SqlConnection conn = dbconnection.connection();
        SqlDataAdapter adapter;
        DataTable table;
        private void formProductIsDelete_Load(object sender, EventArgs e)
        {
            reatRestore();
        }
        void reatRestore()
        {
            string read = "Select* from tbProduct Where isDeleted='" + 1 + "' ";
            adapter = new SqlDataAdapter(read, conn);
            table = new DataTable();
            adapter.Fill(table);


            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.DataSource = table;
            dataGridView1.Columns[10].Visible = false;

            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //dataGridView1.Columns[11].Visible = false; 
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false; dataGridView1.Columns[14].Visible = false;
            adapter.Dispose();
            table.Dispose();
            conn.Close();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            formProduct p=new formProduct();
            p.Show();
            this.Close();
        }

        private void btnRestoreOne_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                messageAlert.Warning("Please a product to restore!", "Restore Warning");

            }
            else
            {
                
                string name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (MessageBox.Show("Are you sure!  you want to restore a product '" + name + "'?",
                    "Product Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        SqlCommand re = new SqlCommand("restoreOnePro", conn);
                        re.CommandType = CommandType.StoredProcedure;
                        re.Parameters.AddWithValue("@id", int.Parse(id));
                        re.ExecuteNonQuery();

                        reatRestore();

                        messageAlert.info("One Product has been restored!", "Restore Alert");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearch.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            lbSearch.Text = "Product ID";
            btnSearch.Text = "Enable";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Enable")
            {
                btnSearch.Text = "Search";
                lbSearch.Text = "Search by Name";
                txtSearch.Clear();
            }
        }

        private void btnRestoreAll_Click(object sender, EventArgs e)
        {

        }
    }
}
