namespace WindowsForm_Proje
{
    partial class Siparislerim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Siparislerim));
            this.tablo_siparisler = new System.Windows.Forms.DataGridView();
            this.btn_geri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablo_siparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // tablo_siparisler
            // 
            this.tablo_siparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablo_siparisler.Location = new System.Drawing.Point(291, 12);
            this.tablo_siparisler.Name = "tablo_siparisler";
            this.tablo_siparisler.Size = new System.Drawing.Size(742, 354);
            this.tablo_siparisler.TabIndex = 1;
            // 
            // btn_geri
            // 
            this.btn_geri.Location = new System.Drawing.Point(1023, 511);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(84, 32);
            this.btn_geri.TabIndex = 52;
            this.btn_geri.Text = "Geri";
            this.btn_geri.UseVisualStyleBackColor = true;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // Siparislerim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1119, 555);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.tablo_siparisler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Siparislerim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siparisler";
            this.Load += new System.EventHandler(this.Siparislerim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablo_siparisler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablo_siparisler;
        private System.Windows.Forms.Button btn_geri;
    }
}