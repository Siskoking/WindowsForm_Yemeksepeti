namespace WindowsForm_Proje
{
    partial class Sepetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sepetim));
            this.tablo_ilanlar = new System.Windows.Forms.DataGridView();
            this.btn_sil = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ilanID = new System.Windows.Forms.TextBox();
            this.lbl_para = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datetimepicker_tarih = new System.Windows.Forms.DateTimePicker();
            this.lbl_tarihgiriniz = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btn_devam = new System.Windows.Forms.Button();
            this.btn_siparisver = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.txt_adres = new System.Windows.Forms.TextBox();
            this.lbl_adres_giriniz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablo_ilanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // tablo_ilanlar
            // 
            this.tablo_ilanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo_ilanlar.Location = new System.Drawing.Point(239, 12);
            this.tablo_ilanlar.Name = "tablo_ilanlar";
            this.tablo_ilanlar.Size = new System.Drawing.Size(742, 354);
            this.tablo_ilanlar.TabIndex = 0;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(494, 372);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 20);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(330, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Sipariş ID";
            // 
            // txt_ilanID
            // 
            this.txt_ilanID.Location = new System.Drawing.Point(388, 372);
            this.txt_ilanID.Name = "txt_ilanID";
            this.txt_ilanID.Size = new System.Drawing.Size(100, 20);
            this.txt_ilanID.TabIndex = 37;
            // 
            // lbl_para
            // 
            this.lbl_para.BackColor = System.Drawing.Color.White;
            this.lbl_para.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_para.Location = new System.Drawing.Point(707, 372);
            this.lbl_para.Name = "lbl_para";
            this.lbl_para.Size = new System.Drawing.Size(92, 20);
            this.lbl_para.TabIndex = 39;
            this.lbl_para.Text = "0";
            this.lbl_para.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(662, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Tutar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1004, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Sipariş Tarihi Giriniz";
            // 
            // datetimepicker_tarih
            // 
            this.datetimepicker_tarih.Location = new System.Drawing.Point(1019, 185);
            this.datetimepicker_tarih.Name = "datetimepicker_tarih";
            this.datetimepicker_tarih.Size = new System.Drawing.Size(200, 20);
            this.datetimepicker_tarih.TabIndex = 43;
            // 
            // lbl_tarihgiriniz
            // 
            this.lbl_tarihgiriniz.AutoSize = true;
            this.lbl_tarihgiriniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarihgiriniz.Location = new System.Drawing.Point(1015, 150);
            this.lbl_tarihgiriniz.Name = "lbl_tarihgiriniz";
            this.lbl_tarihgiriniz.Size = new System.Drawing.Size(92, 20);
            this.lbl_tarihgiriniz.TabIndex = 44;
            this.lbl_tarihgiriniz.Text = "Tarih Giriniz";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1014, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "HEMEN";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1100, 45);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(98, 17);
            this.checkBox2.TabIndex = 46;
            this.checkBox2.Text = "İLERİ TARİHLİ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // btn_devam
            // 
            this.btn_devam.Location = new System.Drawing.Point(1019, 116);
            this.btn_devam.Name = "btn_devam";
            this.btn_devam.Size = new System.Drawing.Size(75, 20);
            this.btn_devam.TabIndex = 47;
            this.btn_devam.Text = "Devam";
            this.btn_devam.UseVisualStyleBackColor = true;
            this.btn_devam.Click += new System.EventHandler(this.btn_devam_Click);
            // 
            // btn_siparisver
            // 
            this.btn_siparisver.Location = new System.Drawing.Point(1080, 376);
            this.btn_siparisver.Name = "btn_siparisver";
            this.btn_siparisver.Size = new System.Drawing.Size(84, 32);
            this.btn_siparisver.TabIndex = 50;
            this.btn_siparisver.Text = "Sepeti Onayla";
            this.btn_siparisver.UseVisualStyleBackColor = true;
            this.btn_siparisver.Click += new System.EventHandler(this.btn_siparisver_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(1135, 474);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(84, 32);
            this.btn_geri.TabIndex = 51;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(1019, 263);
            this.txt_adres.Multiline = true;
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(200, 107);
            this.txt_adres.TabIndex = 52;
            // 
            // lbl_adres_giriniz
            // 
            this.lbl_adres_giriniz.AutoSize = true;
            this.lbl_adres_giriniz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adres_giriniz.Location = new System.Drawing.Point(1015, 221);
            this.lbl_adres_giriniz.Name = "lbl_adres_giriniz";
            this.lbl_adres_giriniz.Size = new System.Drawing.Size(99, 20);
            this.lbl_adres_giriniz.TabIndex = 53;
            this.lbl_adres_giriniz.Text = "Adres Giriniz";
            // 
            // Sepetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 518);
            this.Controls.Add(this.lbl_adres_giriniz);
            this.Controls.Add(this.txt_adres);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.btn_siparisver);
            this.Controls.Add(this.btn_devam);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_tarihgiriniz);
            this.Controls.Add(this.datetimepicker_tarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_para);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_ilanID);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.tablo_ilanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sepetim";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Sepetim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo_ilanlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablo_ilanlar;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_ilanID;
        private System.Windows.Forms.Label lbl_para;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datetimepicker_tarih;
        private System.Windows.Forms.Label lbl_tarihgiriniz;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btn_devam;
        private System.Windows.Forms.Button btn_siparisver;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.TextBox txt_adres;
        private System.Windows.Forms.Label lbl_adres_giriniz;
    }
}