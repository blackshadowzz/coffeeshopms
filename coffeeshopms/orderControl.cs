using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshopms
{
    public partial class orderControl : UserControl
    {
        public orderControl()
        {
            InitializeComponent();
        }


        private void orderControl_Load(object sender, EventArgs e)
        {
            

        }
        public orderControl(int id,string itemName,int menuId,string price, Image img)
        {
            InitializeComponent();
            itemID = id;
            ItemName = itemName;
            Price = price;
            menuID = menuId;
            picItem=img;

        }
        public static DataGridViewRowCollection Rows { get; set; }
        //public static int ID;

        public int itemID
        {
            get;
            set;
        }
        public int menuID { get; set; }
        public Image picItem
        {
            get => pictureBoxOrder.Image;
            set => pictureBoxOrder.Image = value;
        }
        public string ItemName
        {
            get => lbName.Text;
            set => lbName.Text = value;
        }
        public string Price
        {
            get => lbPrice.Text;
            set => lbPrice.Text = value;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ItemQty++;

            btnOrder.Text = $"Order ({ItemQty})";
            btnCancel.Visible = true;
            int indexRow = findRow(itemID);
            double totalPrice;
            if (indexRow >= 0)
            {
                Rows[indexRow].Cells[3].Value = ItemQty;
                totalPrice = double.Parse(Price.Replace("$", "")) * ItemQty;
                Rows[indexRow].Cells[5].Value = totalPrice.ToString("c2");

                //Rows.Add(itemID, ItemName, menuID, ItemQty, Price, totalPrice, picItem);
            }
            else
            {
                if (ItemQty == 1)
                {
                    TotalPrice = double.Parse(Price.Replace("$", ""));
                    Rows.Add(itemID, ItemName, menuID, ItemQty, Price, TotalPrice.ToString("c2"), picItem);
                }
                //else
                //{
                //    Rows[indexRow].Cells[3].Value = ItemQty;
                //    totalPrice = double.Parse(Price.Replace("$", "")) * ItemQty;
                //    Rows[indexRow].Cells[5].Value = totalPrice.ToString("c2");
                //    //Rows.Add(itemID, ItemName, menuID, ItemQty, Price, TotalPrice, picItem);
                //}
            }


           
        }
        public int ItemQty
        {
            get;
            set;
        }
        public double TotalPrice
        {
            get;
            set;
        }
        public int findRow(int id)
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                int idOrder = int.Parse(Rows[i].Cells[0].Value + "");
                if (id == idOrder)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ItemQty--;
            int row = findRow(itemID);

            if (ItemQty == 0)
            {
                Rows.RemoveAt(row);
                btnOrder.Text = "Order";
                btnCancel.Visible = false;

            }
            else
            {
                btnOrder.Text = $"Order ({ItemQty})";
                Rows[row].Cells[3].Value = ItemQty;
                decimal totalPrice = decimal.Parse(Price.Replace("$", "")) * ItemQty;
                Rows[row].Cells[5].Value = totalPrice.ToString("c2");
            }
        }
    }
}
