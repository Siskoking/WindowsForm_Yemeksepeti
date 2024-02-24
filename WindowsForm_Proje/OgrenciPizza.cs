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

namespace WindowsForm_Proje
{
    public partial class OgrenciPizza : Form
    {
        public string kadi;
        public string sifre;
        public OgrenciPizza(string kadii, string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
        }

        private void btn_siparis_Click(object sender, EventArgs e)
        {
            string kenar = cmb_kenartipi.Text;
            string pizzasecim = cmb_pizzasecim.Text;
            string icecek = cmb_icecek.Text;
            Connection con = new Connection();
            if (icecek == null || icecek == "Promosyon İçecek İstemiyorum" || icecek == "" || icecek == " ")
            {
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
                string query = $"insert into Sepetim(Ürün,PizzaSecim,KenarTipi,Promosyonİcecek,Fiyat,DukkanAdi,KullaniciID,Siparismi)values('Öğrenci Dostu Orta Boy','{pizzasecim}','{kenar}','{icecek}',50,'Dominos','{kID}','false')";
                SqlCommand pizzaekleme = new SqlCommand(query, con.connection);
                pizzaekleme.ExecuteNonQuery();
                MessageBox.Show("Ürün Sepetinize eklenmiştir");
                con.connection.Close();
                Anasayfa menu = new Anasayfa(kadi, sifre);
                this.Close();
                menu.Show();

            }
            else
            {
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
                string query = $"insert into Sepetim(Ürün,PizzaSecim,KenarTipi,Promosyonİcecek,Fiyat,DukkanAdi,KullaniciID,Siparismi)values('Öğrenci Dostu Orta Boy','{pizzasecim}','{kenar}','{icecek}',70,'Dominos','{kID}','false')";
                SqlCommand pizzaekleme = new SqlCommand(query, con.connection);
                pizzaekleme.ExecuteNonQuery();
                MessageBox.Show("Ürün Sepetinize eklenmiştir");
                con.connection.Close();
                Anasayfa menu = new Anasayfa(kadi, sifre);
                this.Close();
                menu.Show();
            }
        }

        private void cmb_icecek_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmb_pizzasecim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_kenartipi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
