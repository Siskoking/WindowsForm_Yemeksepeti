namespace WindowsForm_Proje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_yemeksepeticom = new System.Windows.Forms.Label();
            this.btn_girisyap = new System.Windows.Forms.Button();
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sifregoster = new System.Windows.Forms.Button();
            this.btn_sifremiunuttum = new System.Windows.Forms.Button();
            this.lbl_hata = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cıkıs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_yemeksepeticom
            // 
            this.lbl_yemeksepeticom.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yemeksepeticom.Location = new System.Drawing.Point(144, 63);
            this.lbl_yemeksepeticom.Name = "lbl_yemeksepeticom";
            this.lbl_yemeksepeticom.Size = new System.Drawing.Size(453, 71);
            this.lbl_yemeksepeticom.TabIndex = 0;
            this.lbl_yemeksepeticom.Text = "YEMEKSEPETİ.COM";
            this.lbl_yemeksepeticom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_girisyap
            // 
            this.btn_girisyap.Location = new System.Drawing.Point(306, 339);
            this.btn_girisyap.Name = "btn_girisyap";
            this.btn_girisyap.Size = new System.Drawing.Size(75, 23);
            this.btn_girisyap.TabIndex = 1;
            this.btn_girisyap.Text = "Giriş Yap";
            this.btn_girisyap.UseVisualStyleBackColor = true;
            this.btn_girisyap.Click += new System.EventHandler(this.btn_girisyap_Click);
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.Location = new System.Drawing.Point(415, 339);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(75, 23);
            this.btn_kayitol.TabIndex = 2;
            this.btn_kayitol.Text = "Kayıt Ol";
            this.btn_kayitol.UseVisualStyleBackColor = true;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(339, 251);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciadi.TabIndex = 3;
           
            this.txt_kullaniciadi.Enter += new System.EventHandler(this.txt_kullaniciadi_Enter);
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(339, 294);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(233, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(234, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre :";
            // 
            // btn_sifregoster
            // 
            this.btn_sifregoster.Location = new System.Drawing.Point(480, 291);
            this.btn_sifregoster.Name = "btn_sifregoster";
            this.btn_sifregoster.Size = new System.Drawing.Size(25, 23);
            this.btn_sifregoster.TabIndex = 7;
            this.btn_sifregoster.Text = "*";
            this.btn_sifregoster.UseVisualStyleBackColor = true;
            this.btn_sifregoster.Click += new System.EventHandler(this.btn_sifregoster_Click);
            // 
            // btn_sifremiunuttum
            // 
            this.btn_sifremiunuttum.Location = new System.Drawing.Point(348, 368);
            this.btn_sifremiunuttum.Name = "btn_sifremiunuttum";
            this.btn_sifremiunuttum.Size = new System.Drawing.Size(91, 23);
            this.btn_sifremiunuttum.TabIndex = 8;
            this.btn_sifremiunuttum.Text = "Şifremi Unuttum";
            this.btn_sifremiunuttum.UseVisualStyleBackColor = true;
            this.btn_sifremiunuttum.Click += new System.EventHandler(this.btn_sifremiunuttum_Click);
            // 
            // lbl_hata
            // 
            this.lbl_hata.BackColor = System.Drawing.Color.White;
            this.lbl_hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_hata.ForeColor = System.Drawing.Color.Firebrick;
            this.lbl_hata.Location = new System.Drawing.Point(163, 178);
            this.lbl_hata.Name = "lbl_hata";
            this.lbl_hata.Size = new System.Drawing.Size(453, 71);
            this.lbl_hata.TabIndex = 9;
            this.lbl_hata.Text = "KULLANICI ADI VEYA ŞİFRE HATALI";
            this.lbl_hata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cıkıs
            // 
            this.btn_cıkıs.Location = new System.Drawing.Point(680, 415);
            this.btn_cıkıs.Name = "btn_cıkıs";
            this.btn_cıkıs.Size = new System.Drawing.Size(75, 23);
            this.btn_cıkıs.TabIndex = 11;
            this.btn_cıkıs.Text = "Çıkış Yap";
            this.btn_cıkıs.UseVisualStyleBackColor = true;
            this.btn_cıkıs.Click += new System.EventHandler(this.btn_cıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.btn_cıkıs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_hata);
            this.Controls.Add(this.btn_sifremiunuttum);
            this.Controls.Add(this.btn_sifregoster);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.btn_girisyap);
            this.Controls.Add(this.lbl_yemeksepeticom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yemeksepeti.com";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yemeksepeticom;
        private System.Windows.Forms.Button btn_girisyap;
        private System.Windows.Forms.Button btn_kayitol;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sifregoster;
        private System.Windows.Forms.Button btn_sifremiunuttum;
        private System.Windows.Forms.Label lbl_hata;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cıkıs;
    }
}

