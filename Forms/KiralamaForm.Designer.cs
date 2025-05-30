namespace AracKiralamaSistemi.Forms
{
    partial class KiralamaForm
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
            this.gbKiralamaBilgileri = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMusteriler = new System.Windows.Forms.ComboBox();
            this.cmbMusaitAraclar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpKiralamaBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpKiralamaBitis = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAracOzellikleri = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnKirala = new System.Windows.Forms.Button();
            this.btnFiyatHesapla = new System.Windows.Forms.Button();
            this.gbKiralamaBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbKiralamaBilgileri
            // 
            this.gbKiralamaBilgileri.Controls.Add(this.btnFiyatHesapla);
            this.gbKiralamaBilgileri.Controls.Add(this.btnKirala);
            this.gbKiralamaBilgileri.Controls.Add(this.lblToplamTutar);
            this.gbKiralamaBilgileri.Controls.Add(this.lblAracOzellikleri);
            this.gbKiralamaBilgileri.Controls.Add(this.label5);
            this.gbKiralamaBilgileri.Controls.Add(this.dtpKiralamaBitis);
            this.gbKiralamaBilgileri.Controls.Add(this.dtpKiralamaBaslangic);
            this.gbKiralamaBilgileri.Controls.Add(this.label4);
            this.gbKiralamaBilgileri.Controls.Add(this.label3);
            this.gbKiralamaBilgileri.Controls.Add(this.cmbMusaitAraclar);
            this.gbKiralamaBilgileri.Controls.Add(this.cmbMusteriler);
            this.gbKiralamaBilgileri.Controls.Add(this.label2);
            this.gbKiralamaBilgileri.Controls.Add(this.label1);
            this.gbKiralamaBilgileri.Location = new System.Drawing.Point(35, 41);
            this.gbKiralamaBilgileri.Name = "gbKiralamaBilgileri";
            this.gbKiralamaBilgileri.Size = new System.Drawing.Size(474, 349);
            this.gbKiralamaBilgileri.TabIndex = 0;
            this.gbKiralamaBilgileri.TabStop = false;
            this.gbKiralamaBilgileri.Text = "Kiralama Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Müsait Araç Seçin:";
            // 
            // cmbMusteriler
            // 
            this.cmbMusteriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriler.FormattingEnabled = true;
            this.cmbMusteriler.Location = new System.Drawing.Point(136, 19);
            this.cmbMusteriler.Name = "cmbMusteriler";
            this.cmbMusteriler.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteriler.TabIndex = 2;
            this.cmbMusteriler.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriler_SelectedIndexChanged);
            // 
            // cmbMusaitAraclar
            // 
            this.cmbMusaitAraclar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusaitAraclar.FormattingEnabled = true;
            this.cmbMusaitAraclar.Location = new System.Drawing.Point(136, 57);
            this.cmbMusaitAraclar.Name = "cmbMusaitAraclar";
            this.cmbMusaitAraclar.Size = new System.Drawing.Size(121, 21);
            this.cmbMusaitAraclar.TabIndex = 3;
            this.cmbMusaitAraclar.SelectedIndexChanged += new System.EventHandler(this.cmbMusaitAraclar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kiralama Başlangıç Tarihi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kiralama Bitiş Tarihi:";
            // 
            // dtpKiralamaBaslangic
            // 
            this.dtpKiralamaBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKiralamaBaslangic.Location = new System.Drawing.Point(136, 105);
            this.dtpKiralamaBaslangic.Name = "dtpKiralamaBaslangic";
            this.dtpKiralamaBaslangic.Size = new System.Drawing.Size(121, 20);
            this.dtpKiralamaBaslangic.TabIndex = 6;
            this.dtpKiralamaBaslangic.ValueChanged += new System.EventHandler(this.dtpKiralamaBaslangic_ValueChanged);
            // 
            // dtpKiralamaBitis
            // 
            this.dtpKiralamaBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKiralamaBitis.Location = new System.Drawing.Point(136, 143);
            this.dtpKiralamaBitis.Name = "dtpKiralamaBitis";
            this.dtpKiralamaBitis.Size = new System.Drawing.Size(121, 20);
            this.dtpKiralamaBitis.TabIndex = 7;
            this.dtpKiralamaBitis.ValueChanged += new System.EventHandler(this.dtpKiralamaBitis_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Seçilen Araç Özellikleri:";
            // 
            // lblAracOzellikleri
            // 
            this.lblAracOzellikleri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAracOzellikleri.Location = new System.Drawing.Point(152, 188);
            this.lblAracOzellikleri.Name = "lblAracOzellikleri";
            this.lblAracOzellikleri.Size = new System.Drawing.Size(100, 60);
            this.lblAracOzellikleri.TabIndex = 9;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblToplamTutar.Location = new System.Drawing.Point(281, 188);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(123, 23);
            this.lblToplamTutar.TabIndex = 10;
            this.lblToplamTutar.Text = "Toplam Tutar: - TL";
            this.lblToplamTutar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(37, 294);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 39);
            this.btnKirala.TabIndex = 11;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // btnFiyatHesapla
            // 
            this.btnFiyatHesapla.Location = new System.Drawing.Point(118, 294);
            this.btnFiyatHesapla.Name = "btnFiyatHesapla";
            this.btnFiyatHesapla.Size = new System.Drawing.Size(75, 39);
            this.btnFiyatHesapla.TabIndex = 12;
            this.btnFiyatHesapla.Text = "Fiyatı Hesapla";
            this.btnFiyatHesapla.UseVisualStyleBackColor = true;
            this.btnFiyatHesapla.Click += new System.EventHandler(this.btnFiyatHesapla_Click);
            // 
            // KiralamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbKiralamaBilgileri);
            this.Name = "KiralamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Kiralama Sözleşmesi";
            this.Load += new System.EventHandler(this.KiralamaForm_Load);
            this.gbKiralamaBilgileri.ResumeLayout(false);
            this.gbKiralamaBilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKiralamaBilgileri;
        private System.Windows.Forms.Button btnFiyatHesapla;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label lblAracOzellikleri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpKiralamaBitis;
        private System.Windows.Forms.DateTimePicker dtpKiralamaBaslangic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMusaitAraclar;
        private System.Windows.Forms.ComboBox cmbMusteriler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}