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
    public partial class Kayit_Ol : Form
    {
       
        public Kayit_Ol()
        {
            InitializeComponent();
            Connection con = new Connection();
            con.connection.Open();
            string query3 = "select * from OzelSorular";
            SqlCommand command3 = new SqlCommand(query3, con.connection);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                cmb_soru.Items.Add(reader3["Soru"].ToString());
            }
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            string ka = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string ozel_soru =cmb_soru.Text;
            string cevap = txt_ozelsorucevap.Text;
            string mail = txt_mail.Text;
            Connection con = new Connection();
            con.connection.Open();
            string query = $"insert into Kullanicilar (KullaniciAdi,KullaniciSifre,KullaniciMail,KullaniciOzelSoru,KullaniciCevap,Cüzdan)values('{ka}','{sifre}','{mail}','{ozel_soru}','{cevap}',{cmb_cüzdan.Text}) ";
            SqlCommand command = new SqlCommand(query, con.connection);

            command.ExecuteNonQuery();
            MessageBox.Show("Başarıyla kayıt işlemi gerçekleşti.");
            con.connection.Close();
            Form1 form1 = new Form1();
            this.Close();
            form1.Show();


        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        
    }
}
