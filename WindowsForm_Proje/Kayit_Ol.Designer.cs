namespace WindowsForm_Proje
{
    partial class Kayit_Ol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit_Ol));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.btn_kayitol = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.txt_ozelsorucevap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_soru = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_cüzdan = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(275, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıt Olma Ekranı";
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Font = new System.Drawing.Font("VDS", 8.25F);
            this.txt_kullaniciadi.Location = new System.Drawing.Point(339, 111);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciadi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(202, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(202, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı Şifre :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(202, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kullanıcı Mail :";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("VDS", 8.25F);
            this.txt_sifre.Location = new System.Drawing.Point(339, 150);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 5;
            // 
            // txt_mail
            // 
            this.txt_mail.Font = new System.Drawing.Font("VDS", 8.25F);
            this.txt_mail.Location = new System.Drawing.Point(339, 264);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(100, 20);
            this.txt_mail.TabIndex = 6;
            // 
            // btn_kayitol
            // 
            this.btn_kayitol.Location = new System.Drawing.Point(281, 361);
            this.btn_kayitol.Name = "btn_kayitol";
            this.btn_kayitol.Size = new System.Drawing.Size(75, 23);
            this.btn_kayitol.TabIndex = 7;
            this.btn_kayitol.Text = "Kayıt Ol";
            this.btn_kayitol.UseVisualStyleBackColor = true;
            this.btn_kayitol.Click += new System.EventHandler(this.btn_kayitol_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(391, 361);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(75, 23);
            this.btn_geri.TabIndex = 8;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // txt_ozelsorucevap
            // 
            this.txt_ozelsorucevap.Font = new System.Drawing.Font("VDS", 8.25F);
            this.txt_ozelsorucevap.Location = new System.Drawing.Point(339, 225);
            this.txt_ozelsorucevap.Name = "txt_ozelsorucevap";
            this.txt_ozelsorucevap.Size = new System.Drawing.Size(100, 20);
            this.txt_ozelsorucevap.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(202, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Özel Soru :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(202, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cevap :";
            // 
            // cmb_soru
            // 
            this.cmb_soru.FormattingEnabled = true;
            this.cmb_soru.Location = new System.Drawing.Point(339, 185);
            this.cmb_soru.Name = "cmb_soru";
            this.cmb_soru.Size = new System.Drawing.Size(150, 21);
            this.cmb_soru.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(202, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cüzdan :";
            // 
            // cmb_cüzdan
            // 
            this.cmb_cüzdan.FormattingEnabled = true;
            this.cmb_cüzdan.Items.AddRange(new object[] {
            "20",
            "40",
            "80",
            "100",
            "200",
            "500",
            "1000"});
            this.cmb_cüzdan.Location = new System.Drawing.Point(339, 310);
            this.cmb_cüzdan.Name = "cmb_cüzdan";
            this.cmb_cüzdan.Size = new System.Drawing.Size(100, 21);
            this.cmb_cüzdan.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(458, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Gireceğiniz para türü TL cinsindedir.";
            // 
            // Kayit_Ol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_cüzdan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_soru);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ozelsorucevap);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_kayitol);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kayit_Ol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit_Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Button btn_kayitol;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TextBox txt_ozelsorucevap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_soru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_cüzdan;
        private System.Windows.Forms.Label label8;
    }
}