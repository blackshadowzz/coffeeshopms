using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshopms
{
    internal class messageAlert
    {
        public static void info(string desc, string title)
        {
            MessageBox.Show(desc, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void error(string desc, string title)
        {
            MessageBox.Show(desc, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void question(string desc, string title)
        {
            MessageBox.Show(desc, title, MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        public static void Warning(string desc, string title)
        {
            MessageBox.Show(desc, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void yesNo(string desc,string title)
        {
            MessageBox.Show(desc, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
