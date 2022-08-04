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
    public partial class formUser : Form
    {
        public formUser()
        {
            InitializeComponent();
        }

        SqlConnection conn = dbconnection.connection();
        private void formUser_Load(object sender, EventArgs e)
        {
            readData();
           // ShowStaff();

            cbUsertype.Items.Add("Admin");
            cbUsertype.Items.Add("Staff");
            cbUsertype.Items.Add("Sale");
            txtID.Enabled = false;
           
        }
        void readData()
        {
            string query = "Select * From tbUser Where isDeleted='" + 0 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.Columns[8].Visible = false;
            adapter.Dispose();
            dt.Dispose();
            conn.Close();
        }
        void clearData()
        {
            txtPhone.Clear();
            txtID.Clear();
            txtFullname.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtRole.Clear();
            cbUsertype.Text = "";
            txtUsername.Clear();


        }
        void insert()
        {
            try
            {
                conn.Open();
                string insert = "Insert Into tbUser(FullName,Username,Password,Usertype,Role,Email,Phone) Values(@FullName,@Username,@Password,@Usertype,@Role,@Email,@Phone)";
                SqlCommand cmd=new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@FullName", txtFullname.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Usertype", cbUsertype.Text);
                cmd.Parameters.AddWithValue("@Role", txtRole.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);

                int row=cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    messageAlert.info("One record added successful!", "Add User");
                    readData();
                }
                clearData();
                cmd.Dispose();
                
            }
            catch(Exception ex)
            {
                messageAlert.error("Error : " + ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }
        void UpdateData()
        {
            try
            {
                conn.Open();
                string update = "Update tbUser Set FullName=@fullname,Username=@username,Password=@pw,Usertype=@usertype,Role=@role,Email=@email,Phone=@phone Where ID=@id";
                SqlCommand cmd=new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@fullname",txtFullname.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@pw", txtPassword.Text);
                cmd.Parameters.AddWithValue("@usertype",cbUsertype.Text);
                cmd.Parameters.AddWithValue("@role",txtRole.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));

                int row=cmd.ExecuteNonQuery();
                
                if(row == 1)
                {
                    messageAlert.info("One record is updated successful!", "Update User");
                    readData();
                    clearData();
                   
                }
                cmd.Dispose();

            }
            catch(Exception ex)
            {
                messageAlert.error("Error: "+ex.Message,"Error");
            }
            finally
            {
                conn.Close();
            }

        }
        void deleteData()
        {
            try
            {
                conn.Open();
                string delete = "Update tbUser Set isDeleted=@delete Where ID=@id";
                SqlCommand cmd=new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@delete", 1);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                int rows=cmd.ExecuteNonQuery();
                if(rows == 1)
                {
                    readData();
                    clearData();
                    messageAlert.Warning("One record deleted successful!", "Delete User");

                }
                cmd.Dispose();

            }catch(Exception ex)
            {
                messageAlert.error("Error: " + ex.Message, "Delete Data");
            }
            finally
            {
                conn.Close();
            }
        }
        //void ShowStaff()
        //{
        //    string Sel_Data = "Select ID,FullName from tbStaff";
        //    SqlDataAdapter adapter = new SqlDataAdapter(Sel_Data, conn);
        //    DataSet ds = new DataSet();
        //    adapter.Fill(ds, "staff");
           
        //    cbStaffFullName.DataSource = ds.Tables["staff"];
        //    //cbStaffFullName.Items.Add("Admin");
        //    cbStaffFullName.DisplayMember = "FullName";
        //    cbStaffFullName.ValueMember = "FullName";

        //    //cbFullName.ValueMember = "FirstName " + "LastName";

        //    ds.Dispose();
        //    adapter.Dispose();

        //    conn.Close();

        //}
        private void btnBack_Click(object sender, EventArgs e)
        {
                    this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(btnAddNew.Text=="Add New")
            {
                btnAddNew.Text = "Save";
                btnDelete.Text = "Cancel";
                btnUpdate.Text = "Clear";
                clearData();
            }else if (btnAddNew.Text == "Save")
            {
                if(string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text)&& string.IsNullOrEmpty(cbUsertype.Text))
                {
                    messageAlert.Warning("Field is required", "Add New User");
                    txtUsername.Focus();
                }
                else
                {
                    insert();
                    btnAddNew.Text = "Add New";
                    btnDelete.Text = "Delete";
                    btnUpdate.Text = "Update";
                    clearData();
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFullname.Text=dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUsername.Text=dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPassword.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cbUsertype.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtRole.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                if (txtID.Text != "")
                {
                    if(MessageBox.Show("Do you want to update this record '" + ' ' + txtUsername.Text + ' ' + "'?",
                    "User Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                        UpdateData();
                    }
                    
                }
                else
                {
                    messageAlert.Warning("Please select one record to update", "Update User");
                }
            }else if(btnUpdate.Text == "Clear")
            {
                clearData();
            }
            else
            {
                messageAlert.error("Error somethings!", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(btnDelete.Text == "Delete")
            {
                if (txtID.Text != "")
                {
                    if(MessageBox.Show("Do you want to update this record '" + ' ' + txtUsername.Text + ' ' + "'?",
                    "User Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        deleteData();
                    }
                }
                else
                {
                    messageAlert.info("Please select one record to delete!", "Delete User");
                }
            }else if (btnDelete.Text == "Cancel")
            {
                btnAddNew.Text = "Add New";
                btnDelete.Text = "Delete";
                btnUpdate.Text = "Update";
                clearData();
            }
        }
    }
}
