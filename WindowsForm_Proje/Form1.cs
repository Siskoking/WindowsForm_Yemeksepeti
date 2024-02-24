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
    public partial class Form1 : Form
    {
        public string kadi;
        public string sifre;
        public Form1()
        {
            InitializeComponent();
            lbl_hata.Visible = false;
        }

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
           Connection con = new Connection();
            try
            {
                string ka = txt_kullaniciadi.Text;
                string sfr = txt_sifre.Text;
                con.connection.Open();
                string query = $"select count(*) from Kullanicilar where KullaniciAdi='{ka}' and KullaniciSifre='{sfr}'";
                SqlCommand command = new SqlCommand(query, con.connection);
                int count = (int)command.ExecuteScalar();
                if (count>0)
                {
                    kadi = ka;
                    sifre = sfr;
                    this.Hide();
                    Anasayfa menu = new Anasayfa(kadi,sifre);
                    menu.Show();
                }
                else
                {
                    lbl_hata.Visible=true;
                }
            }
            catch 
            {
                MessageBox.Show("HATALI");
                
            }
            finally { con.connection.Close(); } 
          
            Console.ReadLine();
            
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayit_Ol kayit_ol = new Kayit_Ol();
            kayit_ol.Show();
        }

        private void btn_sifregoster_Click(object sender, EventArgs e)
        {
            if (txt_sifre.PasswordChar=='*')
            {
                txt_sifre.PasswordChar = '\0';
            }
            else
            {
                txt_sifre.PasswordChar = '*';
            }
        }

        private void btn_sifremiunuttum_Click(object sender, EventArgs e)
        {
            this.Hide ();
            Sifremi_Unuttum sifremi_Unuttum = new Sifremi_Unuttum();
            sifremi_Unuttum.Show();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
  
            
            this.Close();
        }

        private void txt_kullaniciadi_Enter(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_kullaniciadi.Text))
            {
                txt_kullaniciadi.ForeColor = Color.Red;
                txt_kullaniciadi.BackColor = Color.Black;
                // Move the selection pointer to the end of the text of the control.
                txt_kullaniciadi.Select(txt_kullaniciadi.Text.Length, 0);
            }
        }

       
    }
}
