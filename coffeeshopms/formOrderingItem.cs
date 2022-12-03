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
    public partial class formOrderingItem : Form
    {
        public formOrderingItem()
        {
            InitializeComponent();
        }
        SqlConnection conn = dbconnection.connection();
        private void formOrderingItem_Load(object sender, EventArgs e)
        {
            readItem();
            //fillOrder();

            txtTotalPrice.ForeColor = Color.Red;
            //receiptBindingSource.DataSource = new List<receipt>();

        }
        int itemID;
        public static Image img;
        public static double Price;
        void fillOrder()
        {
            //Where isDeleted = '"+0+"'
            string Sel_Data = "Select orderID,Customer from tbOrder ";
            SqlDataAdapter adapter = new SqlDataAdapter(Sel_Data, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "pro");
            cbOrderBy.DataSource = ds.Tables["pro"];
            cbOrderBy.DisplayMember = "Customer";
            cbOrderBy.ValueMember = "orderID";

            ds.Dispose();
            adapter.Dispose();

            conn.Close();
        }
        void readItem()
        {
            conn.Open();
            string item = "Select itemID,itemName From tbItem Where isDeleted='" + 0 + "'";
            SqlCommand cmd = new SqlCommand(item, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbItem.Items.Add(dr["itemName"]);
                cbItem.DisplayMember = (dr["itemName"].ToString());
                cbItem.ValueMember = (dr["itemID"].ToString());
            }

            //cbItem.DataSource = ds.Tables["item"];
            //cbItem.DisplayMember = "itemName";
            //cbItem.ValueMember = "itemID";
            //itemID =cbItem.ValueMember;
            //Price = double.Parse("Price")+"";
            //txtPrice.Text = itemID;
            cmd.Dispose();
            dr.Dispose();
            conn.Close();
        }
        int id,qty;
        string itemName,remark;
        double price,totalPrice=0,disc=0,subPrice,riel,allPrice;

        private void btnViewRecord_Click(object sender, EventArgs e)
        {
            if (userLogin.getUserType() == "Staff")
            {
                messageAlert.info("Your role cannot open this form! You need to request permission.", "View Order");
            }
            else
            {
                formViewOrderDetail v = new formViewOrderDetail();
                v.ShowDialog();
            }


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                qty = int.Parse(txtQty.Text);
                if (txtDiscount.Text == "")
                {
                    txtDiscount.Text = "0";
                    disc = double.Parse(txtDiscount.Text);
                }
                else
                {
                    disc = double.Parse(txtDiscount.Text);
                }

                subPrice = qty * price;
                totalPrice = subPrice - subPrice * (disc / 100);
                allPrice = 0;
                allPrice += totalPrice;
                txtTotalPrice.Text = allPrice.ToString("c2");

                dataGridView1.RowTemplate.Height = 40;

                dataGridView1.Rows.Add(itemID, itemName, price.ToString("#,###.00"), qty, disc, totalPrice.ToString("#,###.00"), pictureBox1.Image, cbOrderBy.SelectedValue, txtRemark.Text);
                DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[6];
                imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                totalPrice = 0;
                allPrice = 0;
                clearData();

                messageAlert.info("One record updated!", "Update");
            }
            else
            {
                messageAlert.info("Please select record to update!", "Update");
            }
        }



        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back &&
                e.KeyChar != '.' && (Keys)e.KeyChar != Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && (Keys)e.KeyChar != Keys.Back &&
                e.KeyChar != '.' && (Keys)e.KeyChar != Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
                {


                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    clearData();
                    txtTotalPrice.Text = "$ 0";
                    btnRiel.Text = "Riel 0";
                    totalPrice = 0;
                    allPrice = 0;

                }
                else
                {
                    messageAlert.info("Please select record!", "Record");
                }
            }
            else
            {
                messageAlert.info("No order", "Cancel");
            }
        }

        private void txtRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {



                itemID = int.Parse(dataGridView1.CurrentRow.Cells[0].Value + "");
                cbItem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtPrice.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtQty.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDiscount.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                cbOrderBy.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                pictureBox1.Image = (Image)dataGridView1.CurrentRow.Cells[6].Value;
                txtRemark.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            }catch(Exception ex)
            {
                messageAlert.info("Okay!", "Some Bug");
            }
        }

        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 0)
            {
                messageAlert.info("No data to save!", "Save Alert");
            }
            if (MessageBox.Show("Do you want to save records?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (dataGridView1.Rows.Count!=0)
                {
                    try
                    {
                        conn.Open();
                        Image imgs;
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            imgs=(Image)dataGridView1.Rows[i].Cells[6].Value;
                            

                            MemoryStream ms2 = new MemoryStream();
 
                            imgs.Save(ms2, imgs.RawFormat);

                            string insert = "Insert Into tbOrderDetail(itemID,orderID,Qty,Price,Discount,Photo,Payment,Remark,SaleBy)" +
                                "Values(@itemId,@orderId,@qty,@price,@disc,@photo,@pay,@remark,@by)";

                            SqlCommand cmd = new SqlCommand(insert, conn);
                            
                            cmd.Parameters.AddWithValue("@itemId",int.Parse(dataGridView1.Rows[i].Cells[0].Value+""));
                            cmd.Parameters.AddWithValue("@orderId",int.Parse(dataGridView1.Rows[i].Cells[7].Value+""));
                            cmd.Parameters.AddWithValue("@qty",int.Parse(dataGridView1.Rows[i].Cells[3].Value+""));
                            cmd.Parameters.AddWithValue("@price",decimal.Parse( dataGridView1.Rows[i].Cells[2].Value+""));
                            cmd.Parameters.AddWithValue("@disc",decimal.Parse(dataGridView1.Rows[i].Cells[4].Value+""));
                            cmd.Parameters.AddWithValue("@photo", ms2.ToArray());
                            cmd.Parameters.AddWithValue("@pay",decimal.Parse(dataGridView1.Rows[i].Cells[5].Value+""));
                            cmd.Parameters.AddWithValue("@remark", dataGridView1.Rows[i].Cells[8].Value+"");
                            cmd.Parameters.AddWithValue("@by", userLogin.getUsername());
                            cmd.ExecuteNonQuery();
                            
                                dataGridView1.Rows.RemoveAt(dataGridView1.Rows[i].Cells[0].RowIndex);
                                clearData();
                                txtTotalPrice.Text = "$ 0";
                                btnRiel.Text = "Riel 0";

                                    totalPrice = 0;
                                    allPrice = 0;

                            

                        }
                        messageAlert.info("Records has been saved!", "Save Record");


                    }
                    catch (Exception ex)
                    {
                        messageAlert.error("Error: " + ex.Message, "Error");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    messageAlert.info("No data to save!", "Save Alert");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //using(formPrint p=new formPrint(receiptBindingSource.DataSource as List<receipt>, String.Format(allPrice.ToString()), String.Format(btnRiel.Text), String.Format(DateTime.Now.ToString())))
            //{
            //    p.ShowDialog();
            //}
        }

        private void btnRiel_Click(object sender, EventArgs e)
        {
            btnRiel.ForeColor = Color.Red;
            riel = allPrice * 4100;
            btnRiel.Text = riel.ToString("Riel #,###.##");
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //readItem();
            clearData();
            conn.Open();
               //id = int.Parse(itemID);
            string select = "Select itemID,itemName,Price,Image From tbItem Where itemName='" + cbItem.SelectedItem+"' and isDeleted='" + 0 + "'";
            SqlCommand cmd = new SqlCommand(select, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                itemID = int.Parse(dr[0]+"");
                itemName = dr[1].ToString();
                price =double.Parse( dr[2].ToString());
                txtPrice.ForeColor = Color.Red;
                txtPrice.Text = price.ToString("c2");
                byte[] img = (byte[])dr[3];
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }
            conn.Close();
            fillOrder();
           
        }
        void clearData()
        {
            txtPrice.Text="";txtQty.Clear();
            txtRemark.Clear();
            txtDiscount.Clear();
            cbOrderBy.Text = "";
            cbItem.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            qty=int.Parse(txtQty.Text);
            if (txtDiscount.Text == "")
            {
                txtDiscount.Text = "0";
                disc = double.Parse(txtDiscount.Text);
            }
            else
            {
                disc = double.Parse(txtDiscount.Text);
            }
            
            subPrice = qty * price;
            totalPrice = subPrice - subPrice * (disc / 100);
           
            allPrice +=totalPrice;
            txtTotalPrice.Text=allPrice.ToString("c2");

            dataGridView1.RowTemplate.Height = 40;


            dataGridView1.Rows.Add(itemID, itemName, price.ToString("#,###.00"), qty, disc, totalPrice.ToString("#,###.00"), pictureBox1.Image, cbOrderBy.SelectedValue, txtRemark.Text);
            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            totalPrice = 0;
            

            //receipt receipt = new receipt();
            //receipt.ID =itemID;
            //receipt.Coffee_Name= itemName;
            //receipt.Price = price;
            //receipt.Qty = qty;
            //receipt.Discount = disc;
            //receipt.Total_Price= totalPrice;
            //receipt.Order_By = cbOrderBy.Text;
            //receipt.Remark = txtRemark.Text;
            
            clearData();
        }
    }
}
