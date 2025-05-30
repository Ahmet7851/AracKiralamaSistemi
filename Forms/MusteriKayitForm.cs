using AracKiralamaSistemi.Models;
using AracKiralamaSistemi.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AracKiralamaSistemi.Forms
{
    public partial class MusteriKayitForm : Form
    {
        private readonly MusteriYonetimiServisi _musteriServisi;
        private Musteri _seciliMusteri; // Güncelleme ve silme için
        public MusteriKayitForm()
        {
            InitializeComponent();
            _musteriServisi = new MusteriYonetimiServisi();
        }

        private void MusteriKayitForm_Load(object sender, EventArgs e)
        {
            MusteriListesiniYukle();
            AlanlariTemizle(); // Form ilk açıldığında alanlar temiz ve butonlar ayarlı olsun
        }

        private void MusteriListesiniYukle()
        {
            lstMusteriler.DataSource = null; // Önce mevcut kaynağı temizle
            lstMusteriler.DataSource = _musteriServisi.TumMusterileriGetir();
            // Musteri sınıfında ToString() override edildiği için DisplayMember belirtmeye gerek yok.
            // Eğer ID'ye göre işlem yapacaksanız lstMusteriler.ValueMember = "Id"; ekleyebilirsiniz.
        }
        private void AlanlariTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCKimlikNo.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();

            _seciliMusteri = null;
            lstMusteriler.ClearSelected(); // ListBox'taki seçimi kaldır

            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;

            txtAd.Focus(); // İmleci Ad alanına getir
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            // Basit validasyon
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTCKimlikNo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Ad, Soyad, TC Kimlik No ve Telefon alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTCKimlikNo.Text.Length != 11 || !txtTCKimlikNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("TC Kimlik No 11 haneli ve sadece rakamlardan oluşmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TC Kimlik No'nun benzersiz olup olmadığını kontrol et (isteğe bağlı ama önemli)
            if (_musteriServisi.TumMusterileriGetir().Any(m => m.TCKimlikNo == txtTCKimlikNo.Text))
            {
                MessageBox.Show("Bu TC Kimlik Numarası ile kayıtlı başka bir müşteri bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Musteri yeniMusteri = new Musteri
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    TCKimlikNo = txtTCKimlikNo.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    Adres = txtAdres.Text.Trim()
                };

                _musteriServisi.MusteriEkle(yeniMusteri);
                MusteriListesiniYukle(); // Listeyi güncelle
                AlanlariTemizle();       // Alanları temizle
                MessageBox.Show("Müşteri başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri eklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstMusteriler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMusteriler.SelectedItem is Musteri secilen)
            {
                _seciliMusteri = secilen;

                txtAd.Text = _seciliMusteri.Ad;
                txtSoyad.Text = _seciliMusteri.Soyad;
                txtTCKimlikNo.Text = _seciliMusteri.TCKimlikNo;
                txtTelefon.Text = _seciliMusteri.Telefon;
                txtAdres.Text = _seciliMusteri.Adres;

                btnEkle.Enabled = false; // Seçim varken ekleme pasif
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            else
            {
                // Eğer seçim kaldırılırsa (nadiren olur ama önlem)
                // AlanlariTemizle(); // Bu satır bazen istenmeyen temizlemelere yol açabilir, isteğe bağlı
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliMusteri == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasyonlar (Ekle'deki gibi)
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTCKimlikNo.Text) ||
                string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Ad, Soyad, TC Kimlik No ve Telefon alanları boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtTCKimlikNo.Text.Length != 11 || !txtTCKimlikNo.Text.All(char.IsDigit))
            {
                MessageBox.Show("TC Kimlik No 11 haneli ve sadece rakamlardan oluşmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // TC Kimlik No'nun benzersiz olup olmadığını kontrol et (kendisi hariç)
            if (_musteriServisi.TumMusterileriGetir().Any(m => m.TCKimlikNo == txtTCKimlikNo.Text && m.Id != _seciliMusteri.Id))
            {
                MessageBox.Show("Bu TC Kimlik Numarası ile kayıtlı başka bir müşteri bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                _seciliMusteri.Ad = txtAd.Text.Trim();
                _seciliMusteri.Soyad = txtSoyad.Text.Trim();
                _seciliMusteri.TCKimlikNo = txtTCKimlikNo.Text.Trim();
                _seciliMusteri.Telefon = txtTelefon.Text.Trim();
                _seciliMusteri.Adres = txtAdres.Text.Trim();

                _musteriServisi.MusteriGuncelle(_seciliMusteri); // Servis metodu zaten nesneyi alıyordu
                MusteriListesiniYukle();
                AlanlariTemizle();
                MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Müşteri güncellenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_seciliMusteri == null)
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult cevap = MessageBox.Show(
                $"{_seciliMusteri.Ad} {_seciliMusteri.Soyad} adlı müşteriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (cevap == DialogResult.Yes)
            {
                try
                {
                    _musteriServisi.MusteriSil(_seciliMusteri.Id);
                    MusteriListesiniYukle();
                    AlanlariTemizle();
                    MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidOperationException ex) // Aktif kiralaması olan müşteri silinemez hatası için
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Müşteri silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
