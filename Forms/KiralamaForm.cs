using AracKiralamaSistemi.Models;
using AracKiralamaSistemi.Services;
using System;
using System.Windows.Forms;

namespace AracKiralamaSistemi.Forms
{
    public partial class KiralamaForm : Form
    {
        private readonly KiralamaServisi _kiralamaServisi;
        private readonly AracYonetimiServisi _aracServisi;
        private readonly MusteriYonetimiServisi _musteriServisi;
        public KiralamaForm()
        {
            InitializeComponent();
            _kiralamaServisi = new KiralamaServisi();
            _aracServisi = new AracYonetimiServisi();
            _musteriServisi = new MusteriYonetimiServisi();
        }

        private void KiralamaForm_Load(object sender, EventArgs e)
        {
            MusterileriYukle();
            MusaitAraclariYukle();
            TarihAyarlariniYap();
            FiyatiHesaplaVeGoster(); // İlk yüklemede de bir hesaplama yapabilir.
        }
        private void MusterileriYukle()
        {
            cmbMusteriler.DataSource = null;
            cmbMusteriler.DataSource = _musteriServisi.TumMusterileriGetir();
            cmbMusteriler.DisplayMember = "ToString"; // Musteri.ToString() override edilmişti.
            cmbMusteriler.ValueMember = "Id"; // ID'yi arka planda tutmak için
            cmbMusteriler.SelectedIndex = -1; // Başlangıçta seçim olmasın
        }

        private void MusaitAraclariYukle()
        {
            cmbMusaitAraclar.DataSource = null;
            cmbMusaitAraclar.DataSource = _aracServisi.MusaitAraclariGetir(); // Sadece müsait olanlar
            cmbMusaitAraclar.DisplayMember = "ToString"; // Arac.ToString() override edilmişti.
            cmbMusaitAraclar.ValueMember = "Id";
            cmbMusaitAraclar.SelectedIndex = -1;
            lblAracOzellikleri.Text = ""; // Araç listesi yenilendiğinde özellikleri temizle
        }

        private void TarihAyarlariniYap()
        {
            dtpKiralamaBaslangic.MinDate = DateTime.Today;
            dtpKiralamaBaslangic.Value = DateTime.Today; // Varsayılan bugünün tarihi
            dtpKiralamaBitis.MinDate = DateTime.Today.AddDays(1); // Bitiş en az yarın olabilir
            dtpKiralamaBitis.Value = DateTime.Today.AddDays(1); // Varsayılan olarak yarının tarihi
        }

        private void FiyatiHesaplaVeGoster()
        {
            if (cmbMusaitAraclar.SelectedItem is Arac seciliArac &&
                dtpKiralamaBaslangic.Value < dtpKiralamaBitis.Value)
            {
                try
                {
                    // Polimorfizm burada! Aracın kendi KiraHesapla metodu çağrılacak.
                    decimal toplamTutar = seciliArac.KiraHesapla(dtpKiralamaBaslangic.Value, dtpKiralamaBitis.Value);
                    lblToplamTutar.Text = $"Toplam Tutar: {toplamTutar:C}"; // C formatı para birimini gösterir
                }
                catch (ArgumentException ex) // KiraHesapla içindeki tarih kontrolü için
                {
                    lblToplamTutar.Text = "Tarih aralığı geçersiz.";
                    // MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    lblToplamTutar.Text = "Hesaplama hatası.";
                    // MessageBox.Show($"Hesaplama hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblToplamTutar.Text = "Toplam Tutar: - TL";
            }
        }

        private void btnFiyatHesapla_Click(object sender, EventArgs e)
        {
            FiyatiHesaplaVeGoster();     
        }

        private void cmbMusaitAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMusaitAraclar.SelectedItem is Arac seciliArac)
            {
                lblAracOzellikleri.Text = seciliArac.OzellikleriGoster(); // IAracOzellikleri arayüzünden
            }
            else
            {
                lblAracOzellikleri.Text = "";
            }
            FiyatiHesaplaVeGoster();
        }

        private void dtpKiralamaBaslangic_ValueChanged(object sender, EventArgs e)
        {
            // Bitiş tarihi, başlangıç tarihinden en az 1 gün sonra olmalı
            if (dtpKiralamaBitis.Value <= dtpKiralamaBaslangic.Value)
            {
                dtpKiralamaBitis.Value = dtpKiralamaBaslangic.Value.AddDays(1);
            }
            dtpKiralamaBitis.MinDate = dtpKiralamaBaslangic.Value.AddDays(1);
            FiyatiHesaplaVeGoster();
        }

        private void dtpKiralamaBitis_ValueChanged(object sender, EventArgs e)
        {
            FiyatiHesaplaVeGoster();
        }

        private void cmbMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Müşteri seçildiğinde bir işlem yapmak isterseniz buraya kod yazabilirsiniz.
            // Örneğin, müşterinin önceki kiralamalarını gösterme gibi.
            // Fiyatı doğrudan etkilemediği için FiyatiHesaplaVeGoster() çağrılmıyor.
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (cmbMusteriler.SelectedItem is Musteri seciliMusteri &&
        cmbMusaitAraclar.SelectedItem is Arac seciliArac)
            {
                if (dtpKiralamaBaslangic.Value >= dtpKiralamaBitis.Value)
                {
                    MessageBox.Show("Kiralama bitiş tarihi, başlangıç tarihinden sonra olmalıdır.", "Geçersiz Tarih", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    KiralamaSozlesmesi yeniSozlesme = _kiralamaServisi.KiralamaYap(
                        seciliArac,
                        seciliMusteri,
                        dtpKiralamaBaslangic.Value,
                        dtpKiralamaBitis.Value);

                    MessageBox.Show($"Kiralama işlemi başarılı!\nSözleşme No: {yeniSozlesme.Id}\nAraç: {seciliArac.Marka} {seciliArac.Model}\nMüşteri: {seciliMusteri.Ad} {seciliMusteri.Soyad}\nToplam Tutar: {yeniSozlesme.ToplamUcret:C}",
                        "Kiralama Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu sıfırla ve listeleri yenile
                    MusaitAraclariYukle(); // Araç artık müsait olmayabilir
                    cmbMusteriler.SelectedIndex = -1;
                    cmbMusaitAraclar.SelectedIndex = -1;
                    lblAracOzellikleri.Text = "";
                    TarihAyarlariniYap(); // Tarihleri varsayılana döndür
                    lblToplamTutar.Text = "Toplam Tutar: - TL";
                }
                catch (InvalidOperationException ex) // Araç zaten kirada, vb.
                {
                    MessageBox.Show(ex.Message, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ArgumentException ex) // Tarih hatası vb.
                {
                    MessageBox.Show(ex.Message, "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Beklenmedik bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir müşteri ve bir araç seçin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
