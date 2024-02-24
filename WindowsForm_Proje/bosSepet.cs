using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Proje
{
    public partial class bosSepet : Form
    {
        public static string kadi;
        public static string sifre;
        public bosSepet(string kadii,string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
        }

      
    }
}
