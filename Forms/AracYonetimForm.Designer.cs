namespace AracKiralamaSistemi.Forms
{
    partial class AracYonetimForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAracTipi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtGunlukKira = new System.Windows.Forms.TextBox();
            this.pnlSedanOzellikler = new System.Windows.Forms.Panel();
            this.pnlSUVOzellikler = new System.Windows.Forms.Panel();
            this.pnlKamyonetOzellikler = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKapiSayisi = new System.Windows.Forms.TextBox();
            this.txtBagajHacmi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKoltukSayisi = new System.Windows.Forms.TextBox();
            this.chkDortCeker = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTasimaKapasitesi = new System.Windows.Forms.TextBox();
            this.txtKasaTipi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.pnlSedanOzellikler.SuspendLayout();
            this.pnlSUVOzellikler.SuspendLayout();
            this.pnlKamyonetOzellikler.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlKamyonetOzellikler);
            this.groupBox1.Controls.Add(this.pnlSUVOzellikler);
            this.groupBox1.Controls.Add(this.pnlSedanOzellikler);
            this.groupBox1.Controls.Add(this.txtGunlukKira);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.txtYil);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.txtMarka);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbAracTipi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Araç Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Tipi:";
            // 
            // cmbAracTipi
            // 
            this.cmbAracTipi.FormattingEnabled = true;
            this.cmbAracTipi.Location = new System.Drawing.Point(121, 70);
            this.cmbAracTipi.Name = "cmbAracTipi";
            this.cmbAracTipi.Size = new System.Drawing.Size(121, 21);
            this.cmbAracTipi.TabIndex = 1;
            this.cmbAracTipi.SelectedIndexChanged += new System.EventHandler(this.cmbAracTipi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Yıl:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plaka:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Günlük Kira Bedeli:";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(121, 97);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(121, 124);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 8;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(121, 151);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 9;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(121, 178);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 20);
            this.txtPlaka.TabIndex = 10;
            // 
            // txtGunlukKira
            // 
            this.txtGunlukKira.Location = new System.Drawing.Point(121, 205);
            this.txtGunlukKira.Name = "txtGunlukKira";
            this.txtGunlukKira.Size = new System.Drawing.Size(100, 20);
            this.txtGunlukKira.TabIndex = 11;
            // 
            // pnlSedanOzellikler
            // 
            this.pnlSedanOzellikler.Controls.Add(this.txtBagajHacmi);
            this.pnlSedanOzellikler.Controls.Add(this.txtKapiSayisi);
            this.pnlSedanOzellikler.Controls.Add(this.label8);
            this.pnlSedanOzellikler.Controls.Add(this.label7);
            this.pnlSedanOzellikler.Location = new System.Drawing.Point(6, 273);
            this.pnlSedanOzellikler.Name = "pnlSedanOzellikler";
            this.pnlSedanOzellikler.Size = new System.Drawing.Size(200, 100);
            this.pnlSedanOzellikler.TabIndex = 12;
            this.pnlSedanOzellikler.Visible = false;
            // 
            // pnlSUVOzellikler
            // 
            this.pnlSUVOzellikler.Controls.Add(this.chkDortCeker);
            this.pnlSUVOzellikler.Controls.Add(this.txtKoltukSayisi);
            this.pnlSUVOzellikler.Controls.Add(this.label9);
            this.pnlSUVOzellikler.Location = new System.Drawing.Point(252, 273);
            this.pnlSUVOzellikler.Name = "pnlSUVOzellikler";
            this.pnlSUVOzellikler.Size = new System.Drawing.Size(200, 100);
            this.pnlSUVOzellikler.TabIndex = 13;
            this.pnlSUVOzellikler.Visible = false;
            // 
            // pnlKamyonetOzellikler
            // 
            this.pnlKamyonetOzellikler.Controls.Add(this.txtKasaTipi);
            this.pnlKamyonetOzellikler.Controls.Add(this.txtTasimaKapasitesi);
            this.pnlKamyonetOzellikler.Controls.Add(this.label11);
            this.pnlKamyonetOzellikler.Controls.Add(this.label10);
            this.pnlKamyonetOzellikler.Location = new System.Drawing.Point(504, 273);
            this.pnlKamyonetOzellikler.Name = "pnlKamyonetOzellikler";
            this.pnlKamyonetOzellikler.Size = new System.Drawing.Size(200, 100);
            this.pnlKamyonetOzellikler.TabIndex = 14;
            this.pnlKamyonetOzellikler.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kapı Sayısı:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Bagaj Hacmi:";
            // 
            // txtKapiSayisi
            // 
            this.txtKapiSayisi.Location = new System.Drawing.Point(70, 18);
            this.txtKapiSayisi.Name = "txtKapiSayisi";
            this.txtKapiSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKapiSayisi.TabIndex = 2;
            // 
            // txtBagajHacmi
            // 
            this.txtBagajHacmi.Location = new System.Drawing.Point(70, 49);
            this.txtBagajHacmi.Name = "txtBagajHacmi";
            this.txtBagajHacmi.Size = new System.Drawing.Size(100, 20);
            this.txtBagajHacmi.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Koltuk Sayısı:";
            // 
            // txtKoltukSayisi
            // 
            this.txtKoltukSayisi.Location = new System.Drawing.Point(80, 18);
            this.txtKoltukSayisi.Name = "txtKoltukSayisi";
            this.txtKoltukSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKoltukSayisi.TabIndex = 1;
            this.txtKoltukSayisi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // chkDortCeker
            // 
            this.chkDortCeker.AutoSize = true;
            this.chkDortCeker.Location = new System.Drawing.Point(80, 48);
            this.chkDortCeker.Name = "chkDortCeker";
            this.chkDortCeker.Size = new System.Drawing.Size(83, 17);
            this.chkDortCeker.TabIndex = 2;
            this.chkDortCeker.Text = "4 Çeker Mi?";
            this.chkDortCeker.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Taşıma Kapasitesi (Kg):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Kasa Tipi:";
            // 
            // txtTasimaKapasitesi
            // 
            this.txtTasimaKapasitesi.Location = new System.Drawing.Point(126, 21);
            this.txtTasimaKapasitesi.Name = "txtTasimaKapasitesi";
            this.txtTasimaKapasitesi.Size = new System.Drawing.Size(56, 20);
            this.txtTasimaKapasitesi.TabIndex = 2;
            // 
            // txtKasaTipi
            // 
            this.txtKasaTipi.Location = new System.Drawing.Point(82, 52);
            this.txtKasaTipi.Name = "txtKasaTipi";
            this.txtKasaTipi.Size = new System.Drawing.Size(100, 20);
            this.txtKasaTipi.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(18, 519);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(113, 519);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(209, 519);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(308, 519);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAraclar);
            this.groupBox2.Location = new System.Drawing.Point(823, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 421);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Listesi";
            // 
            // lstAraclar
            // 
            this.lstAraclar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.Location = new System.Drawing.Point(3, 16);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(194, 402);
            this.lstAraclar.TabIndex = 0;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // AracYonetimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 583);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Name = "AracYonetimForm";
            this.Text = "Araç Yönetimi";
            this.Load += new System.EventHandler(this.AracYonetimForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlSedanOzellikler.ResumeLayout(false);
            this.pnlSedanOzellikler.PerformLayout();
            this.pnlSUVOzellikler.ResumeLayout(false);
            this.pnlSUVOzellikler.PerformLayout();
            this.pnlKamyonetOzellikler.ResumeLayout(false);
            this.pnlKamyonetOzellikler.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAracTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGunlukKira;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.Panel pnlKamyonetOzellikler;
        private System.Windows.Forms.Panel pnlSUVOzellikler;
        private System.Windows.Forms.Panel pnlSedanOzellikler;
        private System.Windows.Forms.TextBox txtBagajHacmi;
        private System.Windows.Forms.TextBox txtKapiSayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkDortCeker;
        private System.Windows.Forms.TextBox txtKoltukSayisi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKasaTipi;
        private System.Windows.Forms.TextBox txtTasimaKapasitesi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAraclar;
    }
}