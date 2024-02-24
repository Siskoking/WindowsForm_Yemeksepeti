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
    public partial class Sepetim : Form
    {
        public static string tarih;
        public static string adres;
        public string urun;
        public string restoran;
        public static string kadi;
        public static string sifre;
        public Sepetim(string kadii, string sifree)
        {
            
            InitializeComponent();
            kadi = kadii;
            sifre = sifree;
            lbl_tarihgiriniz.Visible = false;
            datetimepicker_tarih.Visible = false;
            btn_siparisver.Visible = false;
            txt_adres.Visible = false;
            lbl_adres_giriniz.Visible = false;
           
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
            string query1 = $"select SiparisID,Ürün,PizzaSecim,KenarTipi,Promosyonİcecek,Fiyat,DukkanAdi from Sepetim where KullaniciID={kID}  and Siparismi='false'";

            SqlDataAdapter adapter = new SqlDataAdapter(query1, con.connection);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);
            tablo_ilanlar.DataSource = datatable;
        }

        private void Sepetim_Load(object sender, EventArgs e)
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
            string tutar_query = $"select Sum(Fiyat) from Sepetim  where KullaniciID={kID} and Siparismi='false'";
            SqlCommand comd = new SqlCommand (tutar_query , con.connection);
            SqlDataReader rdr = comd.ExecuteReader();
            
            while (rdr.Read())
            {
                lbl_para.Text = Convert.ToString(rdr.GetInt32(0));
            }
            rdr.Close();
            con.connection.Close();
            con.connection.Open();
            string query1 = $"select SiparisID,Ürün,PizzaSecim,KenarTipi,Promosyonİcecek,Fiyat,DukkanAdi from Sepetim where KullaniciID={kID}  and Siparismi='false'";
            SqlDataAdapter adapter = new SqlDataAdapter(query1, con.connection);
            DataTable datatable = new DataTable();
            adapter.Fill(datatable);
            tablo_ilanlar.DataSource = datatable;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txt_ilanID.Text);
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

            string query = $"delete from Sepetim where SiparisID='{id}'";

            SqlCommand command = new SqlCommand(query, con.connection);
            command.ExecuteNonQuery();




            

            string query2 = $"select SiparisID,Ürün,PizzaSecim,KenarTipi,Promosyonİcecek,Fiyat,DukkanAdi from Sepetim where KullaniciID={kID}   and Siparismi='false'";

            SqlDataAdapter adapter = new SqlDataAdapter(query2, con.connection);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);
            tablo_ilanlar.DataSource = datatable;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {

        }

        private void btn_devam_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (checkBox2.Checked) 
                {
                    lbl_tarihgiriniz.Visible = false;
                    datetimepicker_tarih.Visible = false;
                    lbl_adres_giriniz.Visible = false;
                    txt_adres.Visible = false;
                    btn_siparisver.Visible = false;
                    MessageBox.Show("LÜTFEN BİR KUTUCUĞU DOLDURUN"); 
                }
                else
                {
                    lbl_tarihgiriniz.Visible = false;
                    datetimepicker_tarih.Visible = false;
                    lbl_adres_giriniz.Visible = true;
                   txt_adres.Visible = true;
                    btn_siparisver.Visible = true;
                }
                
            }
            else if (checkBox2.Checked) 
            {
                if (checkBox1.Checked) 
                {
                    lbl_tarihgiriniz.Visible = false;
                    datetimepicker_tarih.Visible = false;
                    lbl_adres_giriniz.Visible = false;
                    txt_adres.Visible = false;
                    btn_siparisver.Visible = false;
                    MessageBox.Show("LÜTFEN BİR KUTUCUĞU DOLDURUN"); 
                }
                else 
                {
                    lbl_tarihgiriniz.Visible = true; 
                    datetimepicker_tarih.Visible = true;
                    lbl_adres_giriniz.Visible = true;
                    txt_adres.Visible = true;
                    btn_siparisver.Visible = true;
                }
            }
            else 
            {
                lbl_tarihgiriniz.Visible = false;
                datetimepicker_tarih.Visible = false;
                lbl_adres_giriniz.Visible = false;
                txt_adres.Visible = false;
                btn_siparisver.Visible = false;
                MessageBox.Show("LÜTFEN BİR KUTUCUĞU DOLDURUN"); 
            }
        }

        private void btn_siparisver_Click(object sender, EventArgs e)
        {
            adres = txt_adres.Text;
            
            if (checkBox1.Checked)
            {
                tarih = DateTime.Now.ToString();
            }
            else if (checkBox2.Checked)
            {
                tarih = datetimepicker_tarih.Text;
            }

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

            string queryimsi = $"select sum(Fiyat) from Sepetim where KullaniciID={kID} and Siparismi='false'";
            con.connection.Open();
            SqlCommand cum =new SqlCommand(queryimsi, con.connection);
            SqlDataReader reader2= cum.ExecuteReader();
            int tutar = 0;
            while(reader2.Read())
            {
                tutar= Convert.ToInt32(reader2.GetInt32(0));
            }
            reader2.Close();
            con.connection.Close();
            int para= 0;
            string querymiş = $"select Cüzdan from Kullanicilar where KullaniciID={kID}";
            con.connection.Open();
            SqlCommand com=new SqlCommand(querymiş, con.connection);
            SqlDataReader reader3= com.ExecuteReader();
            while (reader3.Read())
            {
                para= Convert.ToInt32(reader3.GetInt32(0));
            }
            reader3.Close();
            con.connection.Close();
            if (tutar>para)
            {
                MessageBox.Show("YETERLİ BAKİYENİZ YOK");
            }
            else
            {
                int par1 = para - tutar;
                para = par1;
                string yenipara = $"update Kullanicilar set Cüzdan={para} where KullaniciID={kID}";
                con.connection.Open();
                SqlCommand cos = new SqlCommand(yenipara, con.connection);
                cos.ExecuteNonQuery();
                con.connection.Close();

                string siparisquery = $"update Sepetim set Siparismi='true',Adres='{adres}',Tarih='{tarih}' where KullaniciID={kID} and Siparismi='false'";
                con.connection.Open();
                SqlCommand sin = new SqlCommand(siparisquery, con.connection);
                sin.ExecuteNonQuery();
                con.connection.Close();

                //MessageBox.Show($"şu tarihe siparişiniz verildi{tarih}");

                MessageBox.Show($"SİPARİŞİNİZ VERİLDİ");

              
                Anasayfa a = new Anasayfa(kadi, sifre);
                a.Show();
                this.Close();

            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Anasayfa a = new Anasayfa(kadi,sifre);
            a.Show();
            this.Close();
        }

       
    }
}
