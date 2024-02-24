using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Proje
{
    public partial class Anasayfa : Form
    {
        public static string siparis;
        public static string sepet;
        public static string kadi;
        public static string sifre;
        public Anasayfa(string kadii, string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dominos dominos = new Dominos(kadi,sifre);
            this.Close();
            dominos.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Dominos dominos = new Dominos(kadi,sifre);
            this.Close();
            dominos.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BurgerKing burgerKing = new BurgerKing(kadi,sifre);
            this.Close();
            burgerKing.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            BurgerKing burgerKing = new BurgerKing(kadi,sifre);
            this.Close();
            burgerKing.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PideLahmacun pideLahmacun = new PideLahmacun(kadi,sifre);
            this.Close();
            pideLahmacun.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            PideLahmacun pideLahmacun = new PideLahmacun(kadi,sifre);
            this.Close();
            pideLahmacun.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Hatay hatay = new Hatay(kadi,sifre);
            this.Close();
            hatay.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Hatay hatay = new Hatay(kadi,sifre);
            this.Close();
            hatay.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cigkofte cigkofte = new Cigkofte(kadi,sifre);
            this.Close();
            cigkofte.Show();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Cigkofte cigkofte = new Cigkofte(kadi,sifre);
            this.Close();
            cigkofte.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            HamidiyeSu su = new HamidiyeSu(kadi, sifre);
            this.Close();
            su.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            HamidiyeSu su = new HamidiyeSu(kadi, sifre);
            this.Close();
            su.Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label15_Click(object sender, EventArgs e)
        {
           
            Connection con = new Connection();

            con.connection.Open();
            SqlCommand cmd = new SqlCommand($"select KullaniciID from Kullanicilar where KullaniciAdi = '{Anasayfa.kadi}' and KullaniciSifre = '{Anasayfa.sifre}'", con.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int kID = 0;
            while (reader.Read())
            {
                kID = reader.GetInt32(0);
            }
            reader.Close();
            con.connection.Close();
            con.connection.Open();
            string tutar_query = $"select * from Sepetim  where KullaniciID={kID}  and Siparismi='false'";
            SqlCommand comd = new SqlCommand(tutar_query, con.connection);
            SqlDataReader rdr = comd.ExecuteReader();

            while (rdr.Read())
            {
                sepet = Convert.ToString(rdr.GetInt32(0));
            }
            rdr.Close();
            con.connection.Close();
            if (sepet == "" || sepet ==" "|| sepet ==null)
            {
                BosSepett bos = new BosSepett(kadi, sifre);
                this.Close();
                bos.Show();
            }
            else
            {


                Sepetim sepetim = new Sepetim(kadi, sifre);
                this.Close();
                sepetim.Show();
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {
            ParaYukle paraYukle = new ParaYukle(kadi, sifre);
            this.Close();
            paraYukle.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Connection con = new Connection();

            con.connection.Open();
            SqlCommand cmd = new SqlCommand($"select KullaniciID from Kullanicilar where KullaniciAdi = '{Anasayfa.kadi}' and KullaniciSifre = '{Anasayfa.sifre}'", con.connection);
            SqlDataReader reader = cmd.ExecuteReader();
            int kID = 0;
            while (reader.Read())
            {
                kID = reader.GetInt32(0);
            }
            reader.Close();
            con.connection.Close();
            con.connection.Open();
            string tutar_query = $"select * from Sepetim  where KullaniciID={kID}  and Siparismi='true'";
            SqlCommand comd = new SqlCommand(tutar_query, con.connection);
            SqlDataReader rdr = comd.ExecuteReader();
            while (rdr.Read())
            {
                siparis= Convert.ToString(rdr.GetInt32(0));
            }
            if (siparis == "" || siparis == " " || siparis == null)
            {
                Bos_Siparisler bos_Siparisler = new Bos_Siparisler(kadi, sifre);
                bos_Siparisler.Show();
                this.Close();
            }
            else
            {


                Siparislerim siparislerim = new Siparislerim(kadi, sifre);
                this.Close();
                siparislerim.Show();
            }
        }
    }
}
