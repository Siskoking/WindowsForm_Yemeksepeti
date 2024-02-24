namespace WindowsForm_Proje
{
    partial class XLpizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XLpizza));
            this.btn_Geri = new System.Windows.Forms.Button();
            this.cmb_kenartipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_pizzasecim = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_icecek = new System.Windows.Forms.ComboBox();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Geri
            // 
            this.btn_Geri.Location = new System.Drawing.Point(713, 415);
            this.btn_Geri.Name = "btn_Geri";
            this.btn_Geri.Size = new System.Drawing.Size(75, 23);
            this.btn_Geri.TabIndex = 0;
            this.btn_Geri.Text = "Geri";
            this.btn_Geri.UseVisualStyleBackColor = true;
            this.btn_Geri.Click += new System.EventHandler(this.btn_Geri_Click);
            // 
            // cmb_kenartipi
            // 
            this.cmb_kenartipi.FormattingEnabled = true;
            this.cmb_kenartipi.Items.AddRange(new object[] {
            "İnce",
            "Normal",
            "Kalın",
            "Peynirli Normal"});
            this.cmb_kenartipi.Location = new System.Drawing.Point(317, 104);
            this.cmb_kenartipi.Name = "cmb_kenartipi";
            this.cmb_kenartipi.Size = new System.Drawing.Size(121, 21);
            this.cmb_kenartipi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(152, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kenar tipi";
            // 
            // cmb_pizzasecim
            // 
            this.cmb_pizzasecim.FormattingEnabled = true;
            this.cmb_pizzasecim.Items.AddRange(new object[] {
            "Margarita(XL)",
            "Mantarsever(XL)",
            "Sucuksever(XL)",
            "Karışık(XL)"});
            this.cmb_pizzasecim.Location = new System.Drawing.Point(317, 61);
            this.cmb_pizzasecim.Name = "cmb_pizzasecim";
            this.cmb_pizzasecim.Size = new System.Drawing.Size(121, 21);
            this.cmb_pizzasecim.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Pizza Seçimi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(152, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prosmosyon İçecek";
            // 
            // cmb_icecek
            // 
            this.cmb_icecek.FormattingEnabled = true;
            this.cmb_icecek.Items.AddRange(new object[] {
            "Promosyon Coca Cola (1 L.)",
            "Promosyon Coca Cola  Zero (1 L.)",
            "Promosyon Sprite (1 L.)",
            "Promosyon Fanta (1 L.)",
            "Promosyon Sütaş Ayran (1 L.)",
            "Promosyon İçecek İstemiyorum"});
            this.cmb_icecek.Location = new System.Drawing.Point(317, 145);
            this.cmb_icecek.Name = "cmb_icecek";
            this.cmb_icecek.Size = new System.Drawing.Size(218, 21);
            this.cmb_icecek.TabIndex = 6;
            // 
            // btn_siparis
            // 
            this.btn_siparis.Location = new System.Drawing.Point(312, 331);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(126, 23);
            this.btn_siparis.TabIndex = 7;
            this.btn_siparis.Text = "Sepetime Ekle";
            this.btn_siparis.UseVisualStyleBackColor = true;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(541, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "İçeceklerin hepsi ekstra 20TLdir.";
            // 
            // XLpizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.cmb_icecek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_pizzasecim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_kenartipi);
            this.Controls.Add(this.btn_Geri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "XLpizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dominos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Geri;
        private System.Windows.Forms.ComboBox cmb_kenartipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_pizzasecim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_icecek;
        private System.Windows.Forms.Button btn_siparis;
        private System.Windows.Forms.Label label4;
    }
}