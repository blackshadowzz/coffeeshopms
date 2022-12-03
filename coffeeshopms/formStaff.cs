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
    public partial class formStaff : Form
    {
        public formStaff()
        {
            InitializeComponent();
        }
        SqlConnection conn = dbconnection.connection();
        SqlCommand cmd;
        string fname=string.Empty;
        string lname=string.Empty;
        string fullname;
        
        private void formStaff_Load(object sender, EventArgs e)
        {
            readData();
            staffTotal();
            cbGender.Items.Add("Male");
            cbGender.Items.Add("Female");
            cbGender.Items.Add("Others");
            txtID.Enabled = false;
            //txtFullName.Enabled = false;


        }
        void staffTotal()
        {
            conn.Open();
            string order = "SELECT COUNT(ID) from tbStaff Where isDeleted='"+0+"'";
            SqlCommand cmd = new SqlCommand(order, conn);
            Int32 total = (Int32)cmd.ExecuteScalar();
            lbTotalStaff.Text ="Total Staff: "+ total.ToString();

            cmd.Dispose();
            conn.Close();
        }
        void clearData()
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtFname.Clear();
            //txtFullName.Clear();
            txtID.Clear();
            txtLname.Clear();
            txtProvince.Clear();
            cbGender.Text = "";
            dateTimePickerDOB.Text = "";
            pictureBox1.Image = null;
        }
        void readData()
        {
            string select = "Select * From tbStaff Where isDeleted='" + 0 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select,conn);
            DataTable dt=new DataTable();
            adapter.Fill(dt);

            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.DataSource=dt;

            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[0].Width=50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[9].Width = 80;
            dataGridView1.Columns[11].Width = 90;

            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            adapter.Dispose();
            dt.Dispose();
            conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void insertData()
        {
            try
            {
                conn.Open();
                MemoryStream ms = new MemoryStream();
                //save into 
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                fullname=txtFname.Text +" "+txtLname.Text;
                string insert = "Insert Into tbStaff(FirstName,LastName,FullName,Gender,Dob,Address,City,Province,Photo,CreateBy)" +
                    "Values(@fname,@lname,@fullname,@gender,@dob,@address,@city,@province,@photo,@by)";
                
                cmd=new SqlCommand(insert,conn);
                cmd.Parameters.AddWithValue("@fname",txtFname.Text);
                cmd.Parameters.AddWithValue("@lname",txtLname.Text);
                cmd.Parameters.AddWithValue("@fullname",fullname);
                cmd.Parameters.AddWithValue("@gender",cbGender.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePickerDOB.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@city",txtCity.Text);
                cmd.Parameters.AddWithValue("@province", txtProvince.Text);
                cmd.Parameters.AddWithValue("@photo",ms.ToArray());
                cmd.Parameters.AddWithValue("@by", userLogin.getUsername());
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    readData();
                    clearData();
                    messageAlert.info("One record added successful!", "Add Staff");

                    
                }
                cmd.Dispose();

            }catch(Exception ex)
            {
                messageAlert.error("Error: " + ex.Message, "Error");

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

                MemoryStream ms = new MemoryStream(); 
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                fullname =txtFname.Text+" "+txtLname.Text;
                string update = "Update tbStaff Set FirstName=@fname, LastName=@lname, FullName=@fullname, Gender=@gender, Dob=@dob,Address=@address, City=@city,Province=@province,Photo=@photo, UpdateDate=@date,UpdateBy=@by Where ID=@id";
                cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@fname", txtFname.Text);
                cmd.Parameters.AddWithValue("@lname", txtLname.Text);
                cmd.Parameters.AddWithValue("@fullname",fullname);
                cmd.Parameters.AddWithValue("@gender",cbGender.Text);
                cmd.Parameters.AddWithValue("@dob",dateTimePickerDOB.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@city", txtCity.Text);
                cmd.Parameters.AddWithValue("@province", txtProvince.Text);
                cmd.Parameters.AddWithValue("@photo", ms.ToArray());
                cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                cmd.Parameters.AddWithValue("@by", userLogin.getUsername());
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));

                int r = cmd.ExecuteNonQuery();
                if(r == 1)
                {
                    readData();
                    messageAlert.info("One record updated successfull!", "Update Staff");
                    clearData();
                }
                cmd.Dispose();



            }catch(Exception ex)
            {
                messageAlert.error("Error: "+ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }
        void DeleteData()
        {
            try
            {
                conn.Open();
                string update = "Update tbStaff Set isDeleted=@delete Where ID=@id";
                cmd=new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@delete", 1);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtID.Text));
                int r=cmd.ExecuteNonQuery();
                if( r == 1)
                {
                    readData();
                    messageAlert.Warning("One record deleted successfull!", "Delete Staff");
                    clearData();
                }
                cmd.Dispose();

            }catch(Exception ex)
            {
                messageAlert.error("Error: "+ex.Message,"Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog file=new OpenFileDialog();
            file.Filter = "images | *.png; *jpeg; *jpg; *bmp;";
            file.FilterIndex = 4;
            file.FileName = "";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(btnAddNew.Text=="Add New")
            {
                btnAddNew.Text = "Save";
                btnUpdate.Text = "Clear";
                btnDelete.Text = "Cancel";
                clearData();
            }else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtFname.Text))
                {
                    messageAlert.Warning("Field is required", "Miss Data");

                }else if (string.IsNullOrEmpty(txtLname.Text))
                {
                    messageAlert.Warning("Field is required", "Miss Data");
                }
                //else if (string.IsNullOrEmpty(txtFullName.Text))
                //{
                //    messageAlert.Warning("Field is required", "Miss Data");
                //}
                else if (string.IsNullOrEmpty(cbGender.Text))
                {
                    messageAlert.Warning("Field is required", "Miss Data");
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    messageAlert.Warning("Field is required", "Miss Data");
                }
                else if (string.IsNullOrEmpty(txtProvince.Text))
                {
                    messageAlert.Warning("Field is required", "Miss Data");
                }
                else
                {
                    insertData();
                    btnAddNew.Text = "Add New";
                    btnUpdate.Text = "Update";
                    btnDelete.Text = "Delete";
                }
            }
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

            //this.txtFullName.Text=" "+ txtFname.Text;
            



        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtFullName.Text))
            //{
            //    txtFullName.Text = txtFullName.Text;
            //    txtFullName.Text = " " + txtLname.Text;

            //}
            

 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtLname.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbGender.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimePickerDOB.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtCity.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtProvince.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString() ;


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    messageAlert.Warning("Please select one record to update!", "Select Record");
                }
                else
                {
                    fullname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    if (MessageBox.Show("Are you sure to update this staff's record '" + ' ' + fullname + ' ' + "'?",
                    "Update Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                       UpdateData();
                    }
                }
            }
            else if(btnUpdate.Text=="Clear")
            {
                clearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    messageAlert.info("Please select the staff to delete!", "Delete Staff");
                    return;
                }
                else
                {
                    fullname = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    if (MessageBox.Show("Are you sure to delete this staff's record '" + ' ' + fullname + ' ' + "'?",
                    "Delete Staff", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DeleteData();
                    }
                }
            }
            else
            {
                btnAddNew.Text = "Add New";
                btnUpdate.Text = "Update";
                btnDelete.Text = "Delete";
                clearData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string select = "Select * From tbStaff Where FullName LIKE '%" + txtSearch.Text.Trim() + "%' and isDeleted='" + 0 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.RowTemplate.Height = 40;

            dataGridView1.DataSource = dt;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[12].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[4].Width = 70;
            dataGridView1.Columns[9].Width = 80;
            dataGridView1.Columns[11].Width = 90;

            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            adapter.Dispose();
            dt.Dispose();
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            formStaffRestore s=new formStaffRestore();
            s.Show();
            this.Close();
        }

        private void lbTotalStaff_Click(object sender, EventArgs e)
        {
            staffTotal();
        }
    }
}
