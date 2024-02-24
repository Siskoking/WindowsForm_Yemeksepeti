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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsForm_Proje
{
    public partial class BurgerKing : Form
    {
        public string kadi;
        public string sifre;
        public BurgerKing(string kadii, string sifree)
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

        private void btn_siparis_whopper_Click(object sender, EventArgs e)
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
            string query = $"insert into Sepetim(Ürün,Promosyonİcecek,Fiyat,DukkanAdi,KullaniciID,Siparismi)values('Soğan Halkalı Double Whopper Jr Menü','Coca cola 300ml',140,'Burger King','{kID}','false')";
            SqlCommand pizzaekleme = new SqlCommand(query, con.connection);
            pizzaekleme.ExecuteNonQuery();
            MessageBox.Show("Ürün Sepetinize eklenmiştir");
            con.connection.Close();
            Anasayfa menu = new Anasayfa(kadi, sifre);
            this.Close();
            menu.Show();

        }

        private void btn_siparis_bigking_Click(object sender, EventArgs e)
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
            string query = $"insert into Sepetim(Ürün,Promosyonİcecek,Fiyat,DukkanAdi,KullaniciID,Siparismi)values('Big King Menü','Coca cola 300ml',125,'Burger King','{kID}','false')";
            SqlCommand pizzaekleme = new SqlCommand(query, con.connection);
            pizzaekleme.ExecuteNonQuery();
            MessageBox.Show("Ürün Sepetinize eklenmiştir");
            con.connection.Close();
            Anasayfa menu = new Anasayfa(kadi, sifre);
            this.Close();
            menu.Show();
        }

        private void btn_siparis_kingbeef_Click(object sender, EventArgs e)
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
            string query = $"insert into Sepetim(Ürün,Promosyonİcecek,Fiyat,DukkanAdi,KullaniciID,Siparismi)values('King Beef Menü','Coca cola 300ml',190,'Burger King','{kID}','false')";
            SqlCommand pizzaekleme = new SqlCommand(query, con.connection);
            pizzaekleme.ExecuteNonQuery();
            MessageBox.Show("Ürün Sepetinize eklenmiştir");
            con.connection.Close();
            Anasayfa menu = new Anasayfa(kadi, sifre);
            this.Close();
            menu.Show();
        }
    }
}
