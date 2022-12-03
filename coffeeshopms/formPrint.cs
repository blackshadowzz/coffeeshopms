using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace coffeeshopms
{
    public partial class formPrint : Form
    {
        List<receipt> _list;
        string _total, _exChange, _date;
        public formPrint(List<receipt> datasource,string total,string exchange,string date)
        {
            InitializeComponent();
            _list = datasource;
            _total = total;
            _exChange = exchange;
            _date = date;
        }

        private void formPrint_Load(object sender, EventArgs e)
         {
            //receipt receipt = new receipt();    
            //formOrderingItem f = new formOrderingItem();
            //f.receiptBindingSource.DataSource = _list;
            //Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[];
            //{
            //    new Microsoft.Reporting.WinForms.ReportParameter("cTotal", _total);
            //    new Microsoft.Reporting.WinForms.ReportParameter("cExchange", _exChange);
            //    new Microsoft.Reporting.WinForms.ReportParameter("cDate", _date);
            //}
            //this.reportViewer1.LocalReport.SetParameters(para);
            //this.reportViewer1.RefreshReport();
            //this.reportViewer1.RefreshReport();
        }
    }
}
