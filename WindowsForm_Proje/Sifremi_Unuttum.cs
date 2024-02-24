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
    public partial class Sifremi_Unuttum : Form
    {
        string connection = "Server=DESKTOP-KK1TKIO\\SQLDERS;Database=Yemeksepeti;Trusted_Connection=True;";
        public Sifremi_Unuttum()
        {
            InitializeComponent();


            lbl_sifre.Visible = false;
            txt_yenisifre.Visible = false;
            btn_sifredegis.Visible = false;
            lbl_kullaniciadi.Visible = true;
            lbl_ozelsoru.Visible = true;
            lbl_cevap.Visible = true;
            button3.Visible = true;
            txt_cevap.Visible=true;
            txt_kullaniciadi.Visible = true;
            cmb_ozelsoru.Visible=true;

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query3 = "select * from OzelSorular";
            SqlCommand command3 = new SqlCommand(query3, con);
            SqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                cmb_ozelsoru.Items.Add(reader3["Soru"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ka = txt_kullaniciadi.Text;
            string ozel_soru = cmb_ozelsoru.Text;
            string cevap = txt_cevap.Text;

            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string query3 = $"select COUNT(*) from Kullanicilar where KullaniciAdi='{ka}' and KullaniciOzelSoru='{ozel_soru}' and KullaniciCevap='{cevap}'";
            SqlCommand command = new SqlCommand(query3, con);
            int count = (int)command.ExecuteScalar();
            if (count > 0)
            {
                lbl_sifre.Visible = true;
                btn_sifredegis.Visible = true;
                txt_yenisifre.Visible = true;
                lbl_kullaniciadi.Visible = false;
                lbl_ozelsoru.Visible = false;
                lbl_cevap.Visible = false;
                button3.Visible = false;
                txt_cevap.Visible = false;
                txt_kullaniciadi.Visible = false;
                cmb_ozelsoru.Visible = false;
            }
            else
            {
                MessageBox.Show("Hatalı bilgiler");
            }
        }

        private void btn_sifredegis_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string ka = txt_kullaniciadi.Text;
            string cevap = txt_cevap.Text;
            string soru = cmb_ozelsoru.Text;
            string sifre = txt_yenisifre.Text;

            string sifre_degis = $"update Kullanicilar set KullaniciSifre ='{sifre}' where KullaniciAdi ='{ka}'and KullaniciOzelSoru='{soru}' and KullaniciCevap='{cevap}'";
            SqlCommand command2 = new SqlCommand(sifre_degis, con);
            command2.ExecuteNonQuery();
            MessageBox.Show("Başarıyla şifre değiştirme işlemi gerçekleşti.");
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }
    }
}
