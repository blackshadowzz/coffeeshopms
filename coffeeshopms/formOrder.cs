using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace coffeeshopms
{
    public partial class formOrder : Form
    {
        orderControl o=new orderControl();
        public formOrder()
        {
            InitializeComponent();

           

            //int c=1, r=0;
            //for (int i = 0;i < or.Length; i++)
            //{
            //    tableLayoutPanel1.Controls.Add(or[i], c, r);
            //    c++;
            //    if (c > 4)
            //    {
            //        c = 1;
            //        r++;
            //    }
            //}
            
        }

        //public static int ID;
        SqlConnection conn = dbconnection.connection();
        private void formOrder_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "Select * from tbItem Where isDeleted='" + 0 + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                int c=1,r=0;
                while (read.Read())
                {
                    int id = int.Parse(read[0] + "");
                    string iname=""+read[2];
                    string price = double.Parse(read[3]+"").ToString("c2");
                    int menuid = int.Parse(read[1] + "");
                    byte[] img = (byte[])read[5];
                    MemoryStream ms = new MemoryStream(img);
                    Image imgs= Image.FromStream(ms);
                    orderControl item=new orderControl(id,iname,menuid,price,imgs);

                    tableLayoutPanel1.Controls.Add(item, c, r);
                    c++;
                    if(c > 2)
                    {
                        c = 1;
                        r++;
                    }
                }

                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            orderControl.Rows = order.getRow();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private btnUnitTotalPrice order = new btnUnitTotalPrice();
        private void btnViewOrder_Click(object sender, EventArgs e)
        {
           
            order.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
