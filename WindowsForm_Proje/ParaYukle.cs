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
    public partial class ParaYukle : Form
    {
        public string  kadi;
        public string  sifre;
        public ParaYukle(string kadii,string sifree)
        {
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anasayfa anasayfa=new Anasayfa(kadi,sifre);
            this.Close();
            anasayfa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string para_ = comboBox1.Text;
            //int para =Convert.ToInt32(comboBox1.Text);
            if (para_ == "0" || para_ == null || para_ == "" || para_ == " ")
            {
                MessageBox.Show("LÜTFEN BİR PARA DEĞERİ GİRİNİZ");
            }
            else
            {
                Convert.ToInt32(para_); 
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
                string query = $"update Kullanicilar set Cüzdan +={para_} where KullaniciID={kID}";
                con.connection.Open();
                SqlCommand parayukleme = new SqlCommand(query, con.connection);
                parayukleme.ExecuteNonQuery();
                con.connection.Close();
                MessageBox.Show("Para yükleme işlemi başarıyla tamamlanmıştır");
                Anasayfa anasayfa = new Anasayfa(kadi, sifre);
                this.Close();
                anasayfa.Show();
            }
            /*
             
             sepet tablosuna veriyi ekle 

            sepetten veriyi tabloya aktarcak

            sepet tablosundan bu veriyi değişkenlere aktar

            sepeti onayla seçeneği olsun. o seçeneğe basılırsa

            kişinin o anda sepetinden siparişlere ekle (insert ile birlikte siparişler)

             
             
             
             
             
             
             */



        }
    }
}
