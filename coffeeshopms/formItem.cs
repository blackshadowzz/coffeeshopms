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
    public partial class formItem : Form
    {
        public formItem()
        {
            InitializeComponent();
        }
        SqlConnection conn = dbconnection.connection();
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void totalItem()
        {
            conn.Open();
            string item = "SELECT COUNT(itemID) from tbItem Where isDeleted='" + 0 + "'";
            SqlCommand cmd = new SqlCommand(item, conn);
            Int32 total = (Int32)cmd.ExecuteScalar();
            lbTotalOrder.Text = "Total Item: " + total.ToString();

            cmd.Dispose();
            conn.Close();
        }
        private void formItem_Load(object sender, EventArgs e)
        {
            ShowMenu();
            showItem();
            totalItem();
            txtItemID.Enabled = false;
        }
        void ShowMenu()
        {
            string Sel_Data = "Select menuID,menuName from tbMenu Where isDeleted='" + 0 + "'";
            adapter = new SqlDataAdapter(Sel_Data, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "menu");
            cbMenuID.DataSource = ds.Tables["menu"];
            cbMenuID.DisplayMember = "menuName";
            cbMenuID.ValueMember = "menuID";

            ds.Dispose();
            adapter.Dispose();

            conn.Close();

        }
        void showItem()
        {
            string show = "Select * from tbItem Where isDeleted='" + 0 + "'";
            adapter = new SqlDataAdapter(show, conn);
            dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = dt;

            dataGridView1.Columns[6].Visible = false;
            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;

            adapter.Dispose();
            dt.Dispose();
            conn.Close();
        }
        void clearData()
        {
            txtItemID.Clear();
            txtName.Clear();
            txtPrice.Clear();
            cbMenuID.Text = "";
            rbDesc.Clear();
        }
        void insertData()
        {
            try
            {
                conn.Open();
                MemoryStream ms = new MemoryStream();
                //save into 
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                string insert = "Insert into tbItem(menuID,itemName,Price,Descrip,Image,createBy) Values(@menuid,@name,@price,@desc,@image,@by)";
                cmd = new SqlCommand(insert, conn);
                cmd.Parameters.AddWithValue("@menuid", cbMenuID.SelectedValue);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                cmd.Parameters.AddWithValue("@desc", rbDesc.Text);
                cmd.Parameters.AddWithValue("@image", ms.ToArray());
                cmd.Parameters.AddWithValue("@by", userLogin.getUsername());

                int row = cmd.ExecuteNonQuery();
                if (row > 0)
                {
                    showItem();
                    messageAlert.info("One record added successful!", "Add New Item");
                    clearData();

                }
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
        void update()
        {
            try
            {
                conn.Open();
                MemoryStream ms = new MemoryStream();
                //save into 
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);

                string update = "Update tbItem Set menuID=@menuid, itemName=@name,Price=@price, Descrip=@desc, Image=@img, updateDate=@date,updateBy=@by Where itemID=@id";
                cmd = new SqlCommand(update, conn);
                cmd.Parameters.AddWithValue("@menuid", cbMenuID.SelectedValue);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@desc", rbDesc.Text);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@img", ms.ToArray());
                cmd.Parameters.AddWithValue("@by", userLogin.getUsername());
                cmd.Parameters.AddWithValue("@id", int.Parse(txtItemID.Text));
                cmd.ExecuteNonQuery();

                showItem();
                messageAlert.info("One record updated successful!", "Update Data");
                clearData();
                cmd.Dispose();
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
        void delete()
        {
            try
            {
                conn.Open();
                string delete = "Update tbItem Set updateBy=@by, isDeleted=@delete Where itemID=@id";
                cmd = new SqlCommand(delete, conn);
                cmd.Parameters.AddWithValue("@delete", 1);
                cmd.Parameters.AddWithValue("@id", int.Parse(txtItemID.Text));
                cmd.Parameters.AddWithValue("@by", userLogin.getUsername());
                cmd.ExecuteNonQuery();

                messageAlert.info("One record deleted successful", "Delete Data");
                showItem();
                clearData();
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (btnAddNew.Text == "Add New")
            {
                btnAddNew.Text = "Save";
                btnDelete.Text = "Cancel";
                btnUpdate.Text = "Clear";
                btnRestore.Enabled = false;
                clearData();
            }
            else if (btnAddNew.Text == "Save")
            {
                if (string.IsNullOrEmpty(txtName.Text) && string.IsNullOrEmpty(txtPrice.Text))
                {
                    messageAlert.Warning("Field is required", "Add Data");
                    return;
                }
                else
                {
                    insertData();

                    btnAddNew.Text = "Add New";
                    btnDelete.Text = "Delete";
                    btnUpdate.Text = "Update";
                    btnRestore.Enabled = true;
                }
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "images | *.png; *jpeg; *jpg; *bmp;";
            dlg.FilterIndex = 4;
            dlg.FileName = "";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text == "Update")
            {

                update();
            }
            else
            {
                clearData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Text == "Delete")
            {
                delete();
            }
            else
            {
                btnAddNew.Text = "Add New";
                btnDelete.Text = "Delete";
                btnUpdate.Text = "Update";
                btnRestore.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            byte[] img = (byte[])dataGridView1.CurrentRow.Cells[5].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);

            txtItemID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            cbMenuID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtPrice.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            rbDesc.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();



        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string select = "Select * From tbItem Where FullName LIKE '%" + txtSearch.Text.Trim() + "%' and isDeleted='" + 0 + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(select, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[6].Visible = false;
            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[5];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            adapter.Dispose();
            dt.Dispose();
        }

        private void lbTotalOrder_Click(object sender, EventArgs e)
        {
            totalItem();
        }
    }
}
