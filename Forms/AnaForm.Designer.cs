namespace AracKiralamaSistemi
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAracYonetimi = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnKiralamaIslemleri = new System.Windows.Forms.Button();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAracYonetimi
            // 
            this.btnAracYonetimi.Location = new System.Drawing.Point(80, 297);
            this.btnAracYonetimi.Name = "btnAracYonetimi";
            this.btnAracYonetimi.Size = new System.Drawing.Size(108, 23);
            this.btnAracYonetimi.TabIndex = 0;
            this.btnAracYonetimi.Text = "Araç Yönetimi";
            this.btnAracYonetimi.UseVisualStyleBackColor = true;
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(80, 326);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(108, 23);
            this.btnMusteriYonetimi.TabIndex = 1;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnKiralamaIslemleri
            // 
            this.btnKiralamaIslemleri.Location = new System.Drawing.Point(80, 355);
            this.btnKiralamaIslemleri.Name = "btnKiralamaIslemleri";
            this.btnKiralamaIslemleri.Size = new System.Drawing.Size(108, 23);
            this.btnKiralamaIslemleri.TabIndex = 2;
            this.btnKiralamaIslemleri.Text = "Kiralama İşlemleri";
            this.btnKiralamaIslemleri.UseVisualStyleBackColor = true;
            this.btnKiralamaIslemleri.Click += new System.EventHandler(this.btnKiralamaIslemleri_Click);
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(80, 384);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(108, 23);
            this.btnRaporlar.TabIndex = 3;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 669);
            this.Controls.Add(this.btnRaporlar);
            this.Controls.Add(this.btnKiralamaIslemleri);
            this.Controls.Add(this.btnMusteriYonetimi);
            this.Controls.Add(this.btnAracYonetimi);
            this.Name = "AnaForm";
            this.Text = "Araç Kiralama Sistemi - Ana Menü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracYonetimi;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnKiralamaIslemleri;
        private System.Windows.Forms.Button btnRaporlar;
    }
}

