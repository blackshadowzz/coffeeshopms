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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }
        SqlDataAdapter ad;
        DataTable dat;
        DataSet ds;
        SqlCommand cmd;
        SqlConnection conn = dbconnection.connection();
        private void formMenu_Load(object sender, EventArgs e)
        {
           
            ShowPro();
            readData();
            
        }
        void ShowPro()
        {
            string Sel_Data = "Select proID,proName from tbProduct";
            SqlDataAdapter adapter = new SqlDataAdapter(Sel_Data, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "pro");
            cbProID.DataSource = ds.Tables["pro"];
            cbProID.DisplayMember = "proName";
            cbProID.ValueMember = "proID";

            ds.Dispose();
            adapter.Dispose();

            conn.Close();

        }
        void readData()
        {  
                string read = "Select  * from tbMenu Where isDeleted='"+0+"'";
                ad = new SqlDataAdapter(read, conn);
                dat = new DataTable();
                ad.Fill(dat);
            dataGridViewMenu.RowTemplate.Height = 40;
            dataGridViewMenu.DataSource = dat;

            dataGridViewMenu.Columns[6].Visible = false;

            dataGridViewMenu.Columns[8].Visible = false; 
            dataGridViewMenu.Columns[7].Visible = false;
            

                ad.Dispose();

        }
        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void clearData()
        {
            txtMenuID.Clear();
            txtName.Clear();
            rbDesc.Clear();
            cbProID.Text = "";
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(btnAddNew.Text=="Add New")
            {
                btnAddNew.Text = "Save";
                btnUpdate.Text="Clear";
                btnDelete.Text = "Cancel";
                clearData();
            }else if (btnAddNew.Text == "Save")
            {
                if (txtName.Text != "")
                {
                    try
                    {
                        conn.Open();
                        string insert = "INSERT INTO tbMenu(proID,menuName,menuDesc,createBy) Values(@proID,@mName,@mDesc,@by)";
                        cmd = new SqlCommand(insert, conn);
                        cmd.Parameters.AddWithValue("@proID", cbProID.SelectedValue);
                        cmd.Parameters.AddWithValue("@mName", txtName.Text);
                        cmd.Parameters.AddWithValue("@mDesc", rbDesc.Text);
                        cmd.Parameters.AddWithValue("@by", userLogin.getUsername());
                        int row;
                        row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                           
                            readData();
                            messageAlert.info("One record added successful!", "Add Menu");
                            clearData();
                            btnAddNew.Text = "Add New";
                            btnUpdate.Text = "Update";
                            btnDelete.Text = "Delete";
                            cmd.Dispose();
                        }
                    }
                    catch(Exception ex)
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

        private void lbMorningCoffee_Click(object sender, EventArgs e)
        {
            formDashboard b = new formDashboard();
            b.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            formDashboard b = new formDashboard();
            b.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                if (string.IsNullOrEmpty(txtMenuID.Text))
                {
                    messageAlert.info("Please select the menu that you want to update", "Required Select");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        string update = "Update tbMenu Set proID=@proID, menuName=@name, menuDesc=@desc, updateDate=@date, updateBy=@by Where menuID=@id";
                        cmd = new SqlCommand(update, conn);
                        cmd.Parameters.AddWithValue("@proID",cbProID.SelectedValue);
                        cmd.Parameters.AddWithValue("@name",txtName.Text);
                        cmd.Parameters.AddWithValue("@desc", rbDesc.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@by", userLogin.getUsername());
                        cmd.Parameters.AddWithValue("@id",int.Parse(txtMenuID.Text));
                        cmd.ExecuteNonQuery();

                        readData();
                        messageAlert.info("One has been update successful!", "Update Menu");
                        clearData();
                        cmd.Dispose();


                    }catch(Exception ex)
                    {
                        messageAlert.error(ex.Message, "Error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }else if(btnUpdate.Text == "Clear")
            {
                clearData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchData = "Select * from tbMenu where menuName LIKE '%" + txtSearch.Text.Trim() + "%' and isDeleted='"+0+"'";
            //CREATE data adapter object 
            SqlDataAdapter adapter = new SqlDataAdapter(searchData, conn);
            //create datatable object
            DataTable dt = new DataTable();
            //fill data into datatable
            adapter.Fill(dt);
            dataGridViewMenu.DataSource = dt;

            dt.Dispose();
            adapter.Dispose();
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete")
            {

                if (MessageBox.Show("Do you want to delete data?", "Data Warning" +
                    txtName.Text + MessageBoxButtons.YesNo, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {


                        conn.Open();
                        string DeleteData = "Update tbMenu Set updateDate=@date,updateBy=@by, isDeleted=@delete Where menuID=@id";

                        SqlCommand Delete = new SqlCommand(DeleteData, conn);

                        Delete.Parameters.AddWithValue("@id", int.Parse(txtMenuID.Text));
                        Delete.Parameters.AddWithValue("@delete", 1);
                        Delete.Parameters.AddWithValue("@date", DateTime.Now);
                        Delete.Parameters.AddWithValue("@by",userLogin.getUsername());
                        Delete.ExecuteNonQuery();

                        readData();
                        messageAlert.Warning("One record has been deleted!", "Data Alert");
                        clearData();
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

        private void dataGridViewMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMenuID.Text = dataGridViewMenu.CurrentRow.Cells[0].Value.ToString();
            cbProID.Text = dataGridViewMenu.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dataGridViewMenu.CurrentRow.Cells[2].Value.ToString();
            rbDesc.Text = dataGridViewMenu.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
