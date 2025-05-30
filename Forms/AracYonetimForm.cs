using AracKiralamaSistemi.Models;
using AracKiralamaSistemi.Services;
using System;
using System.Linq; // LINQ kullanacağız
using System.Windows.Forms;

namespace AracKiralamaSistemi.Forms
{
    public partial class AracYonetimForm : Form
    {

        private readonly AracYonetimiServisi _aracServisi;
        private Arac _seciliArac; // Güncelleme ve silme için

       


        public AracYonetimForm()
        {
            InitializeComponent();
            _aracServisi = new AracYonetimiServisi();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AracYonetimForm_Load(object sender, EventArgs e)
        {
            AracListesiniYukle();
            AracTipleriniYukle();
            PanelleriGizle(); // Başlangıçta tüm özel alan panelleri gizli
            AlanlariTemizle(); // Formu temizle
        }
        private void AracTipleriniYukle()
        {
            cmbAracTipi.Items.Clear();
            cmbAracTipi.Items.Add("Sedan");
            cmbAracTipi.Items.Add("SUV");
            cmbAracTipi.Items.Add("Kamyonet");
            cmbAracTipi.SelectedIndex = -1; // Seçim yok
        }
        private void PanelleriGizle()
        {
            pnlSedanOzellikler.Visible = false;
            pnlSUVOzellikler.Visible = false;
            pnlKamyonetOzellikler.Visible = false;
        }
        private void AracListesiniYukle()
        {
            lstAraclar.DataSource = null;
            lstAraclar.DataSource = _aracServisi.TumAraclariGetir();
            // lstAraclar.DisplayMember = "Plaka"; // Arac.ToString() override edildiği için gerek yok
        }

        private void cmbAracTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            PanelleriGizle();
            if (cmbAracTipi.SelectedItem == null) return;

            string seciliTip = cmbAracTipi.SelectedItem.ToString();
            if (seciliTip == "Sedan")
            {
                pnlSedanOzellikler.Visible = true;
            }
            else if (seciliTip == "SUV")
            {
                pnlSUVOzellikler.Visible = true;
            }
            else if (seciliTip == "Kamyonet")
            {
                pnlKamyonetOzellikler.Visible = true;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbAracTipi.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen araç tipi seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Temel validasyonlar
                if (string.IsNullOrWhiteSpace(txtMarka.Text) ||
                    string.IsNullOrWhiteSpace(txtModel.Text) ||
                    string.IsNullOrWhiteSpace(txtPlaka.Text) ||
                    string.IsNullOrWhiteSpace(txtYil.Text) ||
                    string.IsNullOrWhiteSpace(txtGunlukKira.Text))
                {
                    MessageBox.Show("Lütfen tüm temel araç bilgilerini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                Arac yeniArac = null;
                string aracTipi = cmbAracTipi.SelectedItem.ToString();

                // Temel araç bilgilerini al
                string marka = txtMarka.Text;
                string model = txtModel.Text;
                int yil = int.Parse(txtYil.Text); // Hata kontrolü eklenmeli
                string plaka = txtPlaka.Text;
                decimal gunlukKira = decimal.Parse(txtGunlukKira.Text); // Hata kontrolü eklenmeli

                if (aracTipi == "Sedan")
                {
                    // Sedan özel alanları validasyonu
                    if (string.IsNullOrWhiteSpace(txtKapiSayisi.Text) || string.IsNullOrWhiteSpace(txtBagajHacmi.Text))
                    {
                        MessageBox.Show("Lütfen Sedan için kapı sayısı ve bagaj hacmini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    yeniArac = new Sedan
                    {
                        Marka = marka,
                        Model = model,
                        Yil = yil,
                        Plaka = plaka,
                        GunlukKiraBedeli = gunlukKira,
                        KapiSayisi = int.Parse(txtKapiSayisi.Text),
                        BagajHacmi = txtBagajHacmi.Text
                    };
                }
                else if (aracTipi == "SUV")
                {
                    // SUV özel alanları validasyonu
                    if (string.IsNullOrWhiteSpace(txtKoltukSayisi.Text))
                    {
                        MessageBox.Show("Lütfen SUV için koltuk sayısını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    yeniArac = new SUV
                    {
                        Marka = marka,
                        Model = model,
                        Yil = yil,
                        Plaka = plaka,
                        GunlukKiraBedeli = gunlukKira,
                        DortCekerMi = chkDortCeker.Checked,
                        KoltukSayisi = int.Parse(txtKoltukSayisi.Text)
                    };
                }
                else if (aracTipi == "Kamyonet")
                {
                    // Kamyonet özel alanları validasyonu
                    if (string.IsNullOrWhiteSpace(txtTasimaKapasitesi.Text) || string.IsNullOrWhiteSpace(txtKasaTipi.Text))
                    {
                        MessageBox.Show("Lütfen Kamyonet için taşıma kapasitesi ve kasa tipini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    yeniArac = new Kamyonet
                    {
                        Marka = marka,
                        Model = model,
                        Yil = yil,
                        Plaka = plaka,
                        GunlukKiraBedeli = gunlukKira,
                        TasimaKapasitesiKg = double.Parse(txtTasimaKapasitesi.Text),
                        KasaTipi = txtKasaTipi.Text
                    };
                }

                if (yeniArac != null)
                {
                    _aracServisi.AracEkle(yeniArac);
                    AracListesiniYukle();
                    AlanlariTemizle();
                    MessageBox.Show("Araç başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal alanlara geçerli değerler girin (Yıl, Günlük Kira, Kapı Sayısı vb.).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAraclar.SelectedItem is Arac secilen)
            {
                _seciliArac = secilen;
                PanelleriGizle(); // Önce hepsini gizle

                // Temel bilgileri doldur
                txtMarka.Text = _seciliArac.Marka;
                txtModel.Text = _seciliArac.Model;
                txtYil.Text = _seciliArac.Yil.ToString();
                txtPlaka.Text = _seciliArac.Plaka;
                txtGunlukKira.Text = _seciliArac.GunlukKiraBedeli.ToString("F2"); // İki ondalık basamak

                // Araç tipine göre özel alanları doldur ve ilgili paneli göster
                if (_seciliArac is Sedan sedan)
                {
                    cmbAracTipi.SelectedItem = "Sedan";
                    pnlSedanOzellikler.Visible = true;
                    txtKapiSayisi.Text = sedan.KapiSayisi.ToString();
                    txtBagajHacmi.Text = sedan.BagajHacmi;
                }
                else if (_seciliArac is SUV suv)
                {
                    cmbAracTipi.SelectedItem = "SUV";
                    pnlSUVOzellikler.Visible = true;
                    chkDortCeker.Checked = suv.DortCekerMi;
                    txtKoltukSayisi.Text = suv.KoltukSayisi.ToString();
                }
                else if (_seciliArac is Kamyonet kamyonet)
                {
                    cmbAracTipi.SelectedItem = "Kamyonet";
                    pnlKamyonetOzellikler.Visible = true;
                    txtTasimaKapasitesi.Text = kamyonet.TasimaKapasitesiKg.ToString();
                    txtKasaTipi.Text = kamyonet.KasaTipi;
                }
                cmbAracTipi.Enabled = false; // Güncelleme sırasında tip değiştirilemesin
                btnEkle.Enabled = false;
                btnGuncelle.Enabled = true;
                btnSil.Enabled = true;
            }
            else
            {
                _seciliArac = null;
                AlanlariTemizle(); // Eğer seçim kalkarsa veya null ise temizle
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_seciliArac == null)
            {
                MessageBox.Show("Lütfen silmek için bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"{_seciliArac.Plaka} plakalı aracı silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _aracServisi.AracSil(_seciliArac.Id); // Servis metodunu çağır
                    AracListesiniYukle();
                    AlanlariTemizle();
                    MessageBox.Show("Araç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (InvalidOperationException ex) // Kiradaki araç silinemez hatası için
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_seciliArac == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir araç seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Temel validasyonlar
            if (string.IsNullOrWhiteSpace(txtMarka.Text) || /* ...diğer temel alanlar... */ string.IsNullOrWhiteSpace(txtGunlukKira.Text))
            {
                MessageBox.Show("Lütfen tüm temel araç bilgilerini girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Seçili aracı güncelle
                _seciliArac.Marka = txtMarka.Text;
                _seciliArac.Model = txtModel.Text;
                _seciliArac.Yil = int.Parse(txtYil.Text);
                _seciliArac.Plaka = txtPlaka.Text;
                _seciliArac.GunlukKiraBedeli = decimal.Parse(txtGunlukKira.Text);

                if (_seciliArac is Sedan sedan)
                {
                    if (string.IsNullOrWhiteSpace(txtKapiSayisi.Text) || string.IsNullOrWhiteSpace(txtBagajHacmi.Text)) { /* Hata mesajı */ return; }
                    sedan.KapiSayisi = int.Parse(txtKapiSayisi.Text);
                    sedan.BagajHacmi = txtBagajHacmi.Text;
                }
                else if (_seciliArac is SUV suv)
                {
                    if (string.IsNullOrWhiteSpace(txtKoltukSayisi.Text)) { /* Hata mesajı */ return; }
                    suv.KoltukSayisi = int.Parse(txtKoltukSayisi.Text);
                    suv.DortCekerMi = chkDortCeker.Checked;
                }
                else if (_seciliArac is Kamyonet kamyonet)
                {
                    if (string.IsNullOrWhiteSpace(txtTasimaKapasitesi.Text) || string.IsNullOrWhiteSpace(txtKasaTipi.Text)) { /* Hata mesajı */ return; }
                    kamyonet.TasimaKapasitesiKg = double.Parse(txtTasimaKapasitesi.Text);
                    kamyonet.KasaTipi = txtKasaTipi.Text;
                }

                _aracServisi.AracGuncelle(_seciliArac); // Servis metodu direkt nesneyi alacak şekilde tasarlanmıştı.
                AracListesiniYukle();
                AlanlariTemizle();
                MessageBox.Show("Araç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen sayısal alanlara geçerli değerler girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlanlariTemizle()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtYil.Clear();
            txtPlaka.Clear();
            txtGunlukKira.Clear();

            txtKapiSayisi.Clear();
            txtBagajHacmi.Clear();
            txtKoltukSayisi.Clear();
            chkDortCeker.Checked = false;
            txtTasimaKapasitesi.Clear();
            txtKasaTipi.Clear();

            cmbAracTipi.SelectedIndex = -1; // Seçimi kaldır
            cmbAracTipi.Enabled = true; // Tip seçimi tekrar aktif
            PanelleriGizle();

            lstAraclar.ClearSelected(); // ListBox'taki seçimi kaldır
            _seciliArac = null;

            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
        }
    }
}
