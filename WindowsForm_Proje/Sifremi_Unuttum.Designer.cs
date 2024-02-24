namespace WindowsForm_Proje
{
    partial class Sifremi_Unuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sifremi_Unuttum));
            this.lbl_kullaniciadi = new System.Windows.Forms.Label();
            this.lbl_ozelsoru = new System.Windows.Forms.Label();
            this.lbl_cevap = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.cmb_ozelsoru = new System.Windows.Forms.ComboBox();
            this.txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.btn_sifredegis = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_cevap = new System.Windows.Forms.TextBox();
            this.txt_yenisifre = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kullaniciadi
            // 
            this.lbl_kullaniciadi.AutoSize = true;
            this.lbl_kullaniciadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kullaniciadi.Location = new System.Drawing.Point(233, 74);
            this.lbl_kullaniciadi.Name = "lbl_kullaniciadi";
            this.lbl_kullaniciadi.Size = new System.Drawing.Size(101, 20);
            this.lbl_kullaniciadi.TabIndex = 0;
            this.lbl_kullaniciadi.Text = "Kullanıcı Adı :";
            // 
            // lbl_ozelsoru
            // 
            this.lbl_ozelsoru.AutoSize = true;
            this.lbl_ozelsoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ozelsoru.Location = new System.Drawing.Point(233, 138);
            this.lbl_ozelsoru.Name = "lbl_ozelsoru";
            this.lbl_ozelsoru.Size = new System.Drawing.Size(87, 20);
            this.lbl_ozelsoru.TabIndex = 1;
            this.lbl_ozelsoru.Text = "Özel Soru :";
            // 
            // lbl_cevap
            // 
            this.lbl_cevap.AutoSize = true;
            this.lbl_cevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cevap.Location = new System.Drawing.Point(233, 208);
            this.lbl_cevap.Name = "lbl_cevap";
            this.lbl_cevap.Size = new System.Drawing.Size(62, 20);
            this.lbl_cevap.TabIndex = 2;
            this.lbl_cevap.Text = "Cevap :";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(233, 303);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(86, 20);
            this.lbl_sifre.TabIndex = 3;
            this.lbl_sifre.Text = "Yeni Şifre :";
            // 
            // cmb_ozelsoru
            // 
            this.cmb_ozelsoru.FormattingEnabled = true;
            this.cmb_ozelsoru.Location = new System.Drawing.Point(413, 140);
            this.cmb_ozelsoru.Name = "cmb_ozelsoru";
            this.cmb_ozelsoru.Size = new System.Drawing.Size(121, 21);
            this.cmb_ozelsoru.TabIndex = 4;
            // 
            // txt_kullaniciadi
            // 
            this.txt_kullaniciadi.Location = new System.Drawing.Point(413, 76);
            this.txt_kullaniciadi.Name = "txt_kullaniciadi";
            this.txt_kullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.txt_kullaniciadi.TabIndex = 5;
            // 
            // btn_sifredegis
            // 
            this.btn_sifredegis.Location = new System.Drawing.Point(365, 360);
            this.btn_sifredegis.Name = "btn_sifredegis";
            this.btn_sifredegis.Size = new System.Drawing.Size(75, 23);
            this.btn_sifredegis.TabIndex = 6;
            this.btn_sifredegis.Text = "Şifre Değiş";
            this.btn_sifredegis.UseVisualStyleBackColor = true;
            this.btn_sifredegis.Click += new System.EventHandler(this.btn_sifredegis_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(459, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_cevap
            // 
            this.txt_cevap.Location = new System.Drawing.Point(413, 210);
            this.txt_cevap.Name = "txt_cevap";
            this.txt_cevap.Size = new System.Drawing.Size(100, 20);
            this.txt_cevap.TabIndex = 8;
            // 
            // txt_yenisifre
            // 
            this.txt_yenisifre.Location = new System.Drawing.Point(413, 305);
            this.txt_yenisifre.Name = "txt_yenisifre";
            this.txt_yenisifre.Size = new System.Drawing.Size(100, 20);
            this.txt_yenisifre.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(426, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Sifremi_Unuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txt_yenisifre);
            this.Controls.Add(this.txt_cevap);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_sifredegis);
            this.Controls.Add(this.txt_kullaniciadi);
            this.Controls.Add(this.cmb_ozelsoru);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_cevap);
            this.Controls.Add(this.lbl_ozelsoru);
            this.Controls.Add(this.lbl_kullaniciadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Sifremi_Unuttum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifremi_Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_kullaniciadi;
        private System.Windows.Forms.Label lbl_ozelsoru;
        private System.Windows.Forms.Label lbl_cevap;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.ComboBox cmb_ozelsoru;
        private System.Windows.Forms.TextBox txt_kullaniciadi;
        private System.Windows.Forms.Button btn_sifredegis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_cevap;
        private System.Windows.Forms.TextBox txt_yenisifre;
        private System.Windows.Forms.Button button3;
    }
}