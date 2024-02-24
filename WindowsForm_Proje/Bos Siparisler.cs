using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Proje
{
    public partial class Bos_Siparisler : Form
    {
        public static string kadi;
        public static string sifre;
        public Bos_Siparisler(string kadii,string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa(kadi, sifre);
            this.Close();
            a.Show();
        }
    }
}
