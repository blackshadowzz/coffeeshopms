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
    public partial class formProduct : Form
    {
        public formProduct()
        {
            InitializeComponent();
        }
        SqlConnection conn = dbconnection.connection();
        SqlCommand cmd;
        DataTable table;
        SqlDataAdapter adapter;
        private void lbMorningCoffee_Click(object sender, EventArgs e)
        {
            formDashboard b = new formDashboard();
            b.Show();
            this.Hide();
        }
        void clearData()
        {
            txtProductID.Clear();
            txtProName.Clear();
            txtQty.Clear();
            txtPriceOut.Clear();
            txtPriceIn.Clear();
            txtBarcode.Clear();
            cbCateID.Text = "";
            rbDesc.Clear();
            dtpExpireDate.Text = "";
            pictureBox1.Image= null;
            
        }
        private void formProduct_Load(object sender, EventArgs e)
        {
        //    lbUsername.Text = userLogin.getUsername();
        //    lbUserType.Text = userLogin.getUserType();
        //    DateTime dt = DateTime.Now;
        //    lbTimer.Text = dt.ToString("f");
            readData();
            fillCate();
            txtProductID.Enabled = false;
        }

        private void formProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();

        }
        void fillCate()
        {
            //Where isDeleted = '"+0+"'
            string Sel_Data = "Select cateID,cateName from tbCategory ";
            SqlDataAdapter adapter = new SqlDataAdapter(Sel_Data, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "pro");
            cbCateID.DataSource = ds.Tables["pro"];
            cbCateID.DisplayMember = "cateName";
            cbCateID.ValueMember = "cateID";

            ds.Dispose();
            adapter.Dispose();

            conn.Close();
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if(btnAddNew.Text=="Add New")
            {
                clearData();
                btnAddNew.Text = "Save";
                btnDelete.Text = "Cancel";
                btnUpdate.Text = "Clear";
                btnRestore.Enabled= false;
            }else if (btnAddNew.Text == "Save")
            {
                if(cbCateID.Text=="")
                {
                    messageAlert.info("Please Select category!", "Product");
                }else if (txtProName.Text == "")
                {
                    messageAlert.info("Please input product name!", "Product");
                }else if (txtQty.Text == "")
                {
                    messageAlert.info("Please input product qty!", "Product");
                }else if (txtPriceIn.Text == "")
                {
                    messageAlert.info("Please input product unit price in!", "Product");
                }
                else
                {
                    try
                    {
                        conn.Open();
                        //create memorysrteam object
                        MemoryStream ms = new MemoryStream();
                        //save into 
                        pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                        cmd = new SqlCommand("AddProduct", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        //set value for parameter to store procedure
                        cmd.Parameters.AddWithValue("@pName", txtProName.Text);
                        cmd.Parameters.AddWithValue("@pDesc", rbDesc.Text);
                        cmd.Parameters.AddWithValue("@cateID", cbCateID.SelectedValue);
                        cmd.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                        cmd.Parameters.AddWithValue("@exDate", dtpExpireDate.Value);
                        cmd.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                        cmd.Parameters.AddWithValue("@priceIn", decimal.Parse(txtPriceIn.Text));
                        cmd.Parameters.AddWithValue("@priceOut", decimal.Parse(txtPriceOut.Text));
                        cmd.Parameters.AddWithValue("@image", ms.ToArray());
                        cmd.Parameters.AddWithValue("@createBy", userLogin.getUsername());
                        cmd.ExecuteNonQuery();

                        btnAddNew.Text = "Add New";
                        btnDelete.Text = "Delete"; 
                        btnRestore.Enabled = true;
                        btnUpdate.Text = "Update";

                        readData();
                        clearData();
                        messageAlert.info("One record added successful!", "Product");
                        conn.Close();
                        adapter.Dispose();
                    }
                    catch (Exception ex)
                    {
                        messageAlert.error(ex.Message, "Error");
                    }

                   
                }
            }
        }
        void readData()
        {
            string read = "Select* from tbProduct Where isDeleted='" + 0 + "'";
            adapter = new SqlDataAdapter(read, conn);
            table= new DataTable();
            adapter.Fill(table);
            

            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = table;

            dataGridView1.Columns[10].Visible = false;

            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[9];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            //dataGridView1.Columns[11].Visible = false; 
            dataGridView1.Columns[12].Visible=false;
            dataGridView1.Columns[13].Visible=false; dataGridView1.Columns[14].Visible=false;
            adapter.Dispose();
            table.Dispose();
            conn.Close();
        }
        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter= "images | *.png; *jpeg; *jpg; *bmp;";
            dlg.FilterIndex = 4;
            dlg.FileName = "";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

            txtProductID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtProName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            cbCateID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rbDesc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtBarcode.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtpExpireDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPriceIn.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtPriceOut.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {
                try
                {
                    conn.Open();
                    MemoryStream ms = new MemoryStream();
                    //save into 
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                    SqlCommand update = new SqlCommand("UpdateProduct", conn);
                    update.CommandType = CommandType.StoredProcedure;
                    update.Parameters.AddWithValue("@pid", int.Parse(txtProductID.Text));
                    update.Parameters.AddWithValue("@pname", txtProName.Text);
                    update.Parameters.AddWithValue("@desc", rbDesc.Text);
                    update.Parameters.AddWithValue("@catid", cbCateID.SelectedValue);
                    update.Parameters.AddWithValue("@barcode", txtBarcode.Text);
                    update.Parameters.AddWithValue("@expdate", dtpExpireDate.Text);
                    update.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    update.Parameters.AddWithValue("@pricein", decimal.Parse(txtPriceIn.Text));
                    update.Parameters.AddWithValue("@priceout", decimal.Parse(txtPriceOut.Text));
                    update.Parameters.AddWithValue("@img", ms.ToArray());
                    update.Parameters.AddWithValue("@updateBy", userLogin.getUsername());
                    update.ExecuteNonQuery();

                    clearData();
                    readData();
                    messageAlert.info("One record updated successfull!", "Update Alert");
                    update.Dispose();
                }catch(Exception ex)
                {
                    messageAlert.error(ex.Message, "Error Udpate");
                }
                finally
                {
                    conn.Close();
                }
                

            }else if (btnUpdate.Text == "Clear")
            {
                clearData();

            }
            else
            {
                messageAlert.error("Error Update", "Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete")
            {
                if (string.IsNullOrEmpty(txtProductID.Text))
                {
                    messageAlert.info("Please select the product to delete", "Delete Alert");
                    return;
                }if (MessageBox.Show("Are you sure to delete this product '" + ' ' + txtProName.Text + ' ' + "'?",
                    "Product Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    try
                    {
                        conn.Open();
                        SqlCommand delete = new SqlCommand("UpdateisDelete", conn);
                        delete.CommandType = CommandType.StoredProcedure;
                        delete.Parameters.AddWithValue("@pid", int.Parse(txtProductID.Text));
                        delete.Parameters.AddWithValue("@isdelete", 1);
                        delete.ExecuteNonQuery();

                        readData();
                        messageAlert.info("One record has been delete!", "Delete Alert");
                        delete.Dispose();
                    } catch (Exception ex)
                    {
                        messageAlert.error(ex.Message, "Delete Error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else if(btnDelete.Text == "Cancel")
            {
                clearData();
                btnUpdate.Text = "Update";
                btnAddNew.Text = "Add New";
                btnDelete.Text = "Delete";
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            formProductIsDelete p=new formProductIsDelete();
            p.Show();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchData = "Select * from tbProduct where proName  LIKE '%" + txtSearch.Text.Trim() + "%'";
            //CREATE data adapter object 
            SqlDataAdapter adapter = new SqlDataAdapter(searchData, conn);
            //create datatable object
            DataTable dt = new DataTable();
            //fill data into datatable
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            dt.Dispose();
            adapter.Dispose();
        }
    }
}
