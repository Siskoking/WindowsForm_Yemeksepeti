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
    public partial class HamidiyeSu : Form
    {
        public string kadi;
            public string sifre;
        public HamidiyeSu(string kadii, string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
        }

        private void btn_Gerİ_Click(object sender, EventArgs e)
        {
            Anasayfa menu = new Anasayfa(kadi, sifre);
            menu.Show();
            this.Close();
        }

        private void btn_siparis_Click(object sender, EventArgs e)
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
            string query = $"insert into Sepetim(Ürün,Fiyat,DukkanAdi,KullaniciID,Siparismi)values('Damacana',50,'Hamidiye Su',{kID},'false')";
            con.connection.Open();
            SqlCommand su = new SqlCommand(query,con.connection);
            su.ExecuteNonQuery();
            con.connection.Close();
            MessageBox.Show("Ürün Sepetinize eklenmiştir");
            Anasayfa menu = new Anasayfa(kadi,sifre);
            this.Close();
            menu.Show();


        }
    }
}
