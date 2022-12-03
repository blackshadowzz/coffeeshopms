using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coffeeshopms
{
    public class receipt
    {
        public int ID { get; set; }
        public string Coffee_Name { get; set; }
       
        public double Price { get; set; }
        public int Qty { get; set; }
        public double Discount { get; set; }
        public double Total_Price { get; set; }
      
        public string Order_By { get; set; }
        public string Remark { get; set; }
        
    }
}
