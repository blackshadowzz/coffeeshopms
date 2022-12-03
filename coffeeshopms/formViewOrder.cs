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
    public partial class formViewOrder : Form
    {
        public formViewOrder()
        {
            InitializeComponent();
        }
        public DataGridViewRowCollection getRow()
        {
            return dataGridView1.Rows;
        }
        SqlConnection conn = dbconnection.connection();
        private void formViewOrder_Load(object sender, EventArgs e)
        {
            fillOrder();
            //dataGridView1.RowTemplate.Height = 40;
            DataGridViewImageColumn imcol = (DataGridViewImageColumn)dataGridView1.Columns[6];
            imcol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            double pay = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string p = dataGridView1.Rows[i].Cells[5].Value + "";
                pay += double.Parse(p.Replace("$", ""));

            }
            lbPayment.Text=pay.ToString("c2");

        }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtItemName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtUnitPrice.Text=dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtQty.Text=dataGridView1.CurrentRow.Cells[3].Value.ToString();
            lbUnitPrice.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            picOrdering.Image = (Image)dataGridView1.CurrentRow.Cells[6].Value;
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double dis;

            double disPrice = 0, price;
            string p = dataGridView1.CurrentRow.Cells[5].Value + "";
            price = double.Parse(p.Replace("$", ""));

            if (txtDiscountUnit.Text == "")
            {
                txtDiscountUnit.Text = "0";
                dis = double.Parse(txtDiscountUnit.Text);
                disPrice = price - price * (dis / 100);
                
            }
            else
            {
                dis = double.Parse(txtDiscountUnit.Text);
                if (dis > 0)
                {
                    
                    disPrice = price - price * (dis / 100);
                    //btnUnitPrice.ForeColor = Color.DarkRed;

                    
                }
                else
                {
                    disPrice = double.Parse(p.Replace("$", ""));
                    
                }
                
            }
            //btnUnitPrice.Text = disPrice.ToString("c2");
            lbUnitPayDollar.Text = disPrice.ToString("c2");
            double riel=disPrice * 4100;
            lbUnitPayRiel.Text = riel.ToString("Riel #,###.##");

        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Please save all record before back to new order","Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                formOrder o = new formOrder();
                o.Close();
                this.Close();
            }

        }

        private void btnUnitTotalPrice_FormClosing(object sender, FormClosingEventArgs e)
        {
            //btnAllPrice.Enabled = true;
            //this.Close();

        }

        private void btnAllPrice_Click(object sender, EventArgs e)
        {

            double disTotal, disTotalPrice = 0, totalPrice;
            totalPrice = double.Parse(lbPayment.Text.Replace("$",""));
            if (txtTotalDiscount.Text == "")
            {
                txtTotalDiscount.Text = "0";
                disTotal = double.Parse(txtTotalDiscount.Text);
                disTotalPrice = totalPrice - totalPrice * (disTotal / 100);

            }
            else
            {
                disTotal = double.Parse(txtTotalDiscount.Text);
                if (disTotal > 0)
                {

                    disTotalPrice = totalPrice - totalPrice * (disTotal / 100);
                    //btnUnitPrice.ForeColor = Color.DarkRed;


                }
                else
                {
                    disTotalPrice = totalPrice;

                }
            }

                // btnAllPrice.Text = disPrice.ToString("c2");
                //btnAllPrice.Enabled = false;
            lbPayTotalDollar.Text = disTotalPrice.ToString("c2");
            double riel = disTotalPrice * 4100;
            lbPayTotalRiel.Text = riel.ToString("Riel #,###.##");
        }
        public static DataGridViewRowCollection Rows { get; set; }
        //private int findRow(int id)
        //{
        //    for (int i = 0; i < Rows.Count; i++)
        //    {
        //        int idOrder = int.Parse(Rows[i].Cells[0].Value + "");
        //        if (id == idOrder)
        //        {
        //            return i;
        //        }
        //    }
        //    return -1;
        //}
        private void btnSaveRecord_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                messageAlert.Warning("Please select record to save!", "Save Record");
                return;
            }
            else
            {
                try
                {
                    conn.Open();
                    MemoryStream ms = new MemoryStream();
                    //save into 
                    picOrdering.Image.Save(ms, picOrdering.Image.RawFormat);
                    string query = "Insert Into tbOrderDetail(itemID,orderID,Qty,Price,Discount,Photo,Payment,Remark,SaleBy) Values(@itemID,@orderID,@Qty,@Price,@Discount,@Photo,@Payment,@Remark,@SaleBy)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemID", int.Parse(txtID.Text));
                    cmd.Parameters.AddWithValue("@orderID", cbOrderBy.SelectedValue);
                    cmd.Parameters.AddWithValue("@Qty", int.Parse(txtQty.Text));
                    cmd.Parameters.AddWithValue("@Price", decimal.Parse(txtUnitPrice.Text.Replace("$", "")));
                    cmd.Parameters.AddWithValue("@Discount", decimal.Parse(txtDiscountUnit.Text));
                    cmd.Parameters.AddWithValue("@Photo", ms.ToArray());
                    cmd.Parameters.AddWithValue("@Payment", decimal.Parse(lbUnitPayDollar.Text.Replace("$", "")));
                    cmd.Parameters.AddWithValue("@Remark", rbRemark.Text);
                    cmd.Parameters.AddWithValue("@SaleBy", userLogin.getUsername());

                    int r = cmd.ExecuteNonQuery();
                    if (r == 1)
                    {
                        messageAlert.info("One record saved successfull!", "Save Record");

                    }
                    cmd.Dispose();

                    if (this.dataGridView1.SelectedRows.Count > 0)
                    {
                        if (dataGridView1.RowCount == 1)
                        {
                            int id = int.Parse(txtID.Text);
                            orderControl o = new orderControl();
                            int rw = o.findRow(id);
                            o.ItemQty--;
                            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                            formOrder d = new formOrder();
                            d.Close();
                        }
                        else
                        {
                            int id = int.Parse(txtID.Text);
                            orderControl o = new orderControl();
                            int rw = o.findRow(id);
                            o.ItemQty--;
                            dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                        }



                    }


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
        }
    }
}
