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
    public partial class Siparislerim : Form
    {
        public static string kadi;
        public static string sifre;
        public Siparislerim(string kadii, string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
        }
        public void EkranListele()
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
            string query1 = $"select SiparisID,Ürün,PizzaSecim,KenarTipi,Promosyonİcecek,Fiyat,DukkanAdi,Tarih,Adres from Sepetim where KullaniciID={kID} and Siparismi='true'";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, con.connection);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            tablo_siparisler.DataSource = datatable;
        }
       

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa(kadi,sifre);
            this.Close();
            a.Show();
        }

        private void Siparislerim_Load(object sender, EventArgs e)
        {
            EkranListele();
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
            string query1 = $"select SiparisID,Ürün,PizzaSecim,KenarTipi,Promosyonİcecek,Fiyat,DukkanAdi,Tarih,Adres from Sepetim where KullaniciID={kID}  and Siparismi='true'";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, con.connection);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            tablo_siparisler.DataSource = datatable;
        }

        
    }
}
