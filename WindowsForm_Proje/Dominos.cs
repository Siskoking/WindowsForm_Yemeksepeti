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
    public partial class Dominos : Form
    {
        public string kadi;
        public string sifre;
        public Dominos(string kadii,string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
        }

        private void btn_Geri_Click(object sender, EventArgs e)
        {
            Anasayfa menu = new Anasayfa(kadi,sifre);
            menu.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            XLpizza xl  = new XLpizza(kadi, sifre);
            xl.Show();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            XLpizza xl = new XLpizza(kadi, sifre);
            xl.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            OgrenciPizza ogrenciPizza = new OgrenciPizza(kadi, sifre);
            ogrenciPizza.Show();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            OgrenciPizza ogrenciPizza = new OgrenciPizza(kadi, sifre);
            ogrenciPizza.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HesaplıPizza hp = new HesaplıPizza(kadi, sifre);
            hp.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            HesaplıPizza hp = new HesaplıPizza(kadi, sifre);
            hp.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            KucukPizza kp = new KucukPizza(kadi, sifre);
            kp.Show();
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            KucukPizza kp = new KucukPizza(kadi, sifre);
            kp.Show();
            this.Close();
        }

       
    }
}
