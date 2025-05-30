using AracKiralamaSistemi.Models;
using AracKiralamaSistemi.Services;
using System;
using System.Collections.Generic; // KeyValuePair için
using System.Linq;
using System.Windows.Forms;

namespace AracKiralamaSistemi.Forms
{
    public partial class RaporForm : Form
    {
        private readonly RaporlamaServisi _raporServisi;
        private readonly KiralamaServisi _kiralamaServisi; // Teslim alma işlemi için
        public RaporForm()
        {
            InitializeComponent();
            _raporServisi = new RaporlamaServisi();
            _kiralamaServisi = new KiralamaServisi();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            AktifKiralamalariYukle();
            EnCokKiralananlariYukle();
        }
        private void AktifKiralamalariYukle()
        {
            var aktifKiralamalar = _raporServisi.AktifKiralamalar();
            // DataGridView'i daha okunaklı göstermek için anonim tip veya özel bir DTO kullanabiliriz.
            dgvAktifKiralamalar.DataSource = null;
            dgvAktifKiralamalar.DataSource = aktifKiralamalar.Select(s => new
            {
                SozlesmeID = s.Id,
                Plaka = s.KiralananArac.Plaka,
                Arac = s.KiralananArac.Marka + " " + s.KiralananArac.Model,
                Musteri = s.KiralayanMusteri.Ad + " " + s.KiralayanMusteri.Soyad,
                TCKN = s.KiralayanMusteri.TCKimlikNo,
                Baslangic = s.KiralamaBaslangicTarihi.ToShortDateString(),
                Bitis = s.KiralamaBitisTarihi.ToShortDateString(),
                ToplamUcret = s.ToplamUcret.ToString("C"),
                Durum = s.Durum.ToString()
            }).ToList();

            // İsterseniz sütun başlıklarını Türkçeleştirebilirsiniz:
            if (dgvAktifKiralamalar.Columns["SozlesmeID"] != null) dgvAktifKiralamalar.Columns["SozlesmeID"].HeaderText = "Söz. ID";
            if (dgvAktifKiralamalar.Columns["Baslangic"] != null) dgvAktifKiralamalar.Columns["Baslangic"].HeaderText = "Başlangıç T.";
            if (dgvAktifKiralamalar.Columns["Bitis"] != null) dgvAktifKiralamalar.Columns["Bitis"].HeaderText = "Bitiş T.";
            // ... diğer sütunlar
        }

        private void EnCokKiralananlariYukle()
        {
            var enCokListesi = _raporServisi.EnCokKiralananAraclar(5); // Top 5
            dgvEnCokKiralananlar.DataSource = null;
            dgvEnCokKiralananlar.DataSource = enCokListesi.Select(kvp => new
            {
                Plaka = kvp.Key.Plaka,
                Marka = kvp.Key.Marka,
                Model = kvp.Key.Model,
                KiralamaSayisi = kvp.Value
            }).ToList();

            if (dgvEnCokKiralananlar.Columns["KiralamaSayisi"] != null) dgvEnCokKiralananlar.Columns["KiralamaSayisi"].HeaderText = "Kiralama Sayısı";
        }

        private void dgvAktifKiralamalar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAktifKiralamalar.SelectedRows.Count > 0)
            {
                btnTeslimAl.Enabled = true;
            }
            else
            {
                btnTeslimAl.Enabled = false;
            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            if (dgvAktifKiralamalar.SelectedRows.Count > 0)
            {
                // Seçili satırdan SözleşmeID'yi almamız gerekiyor.
                // DataGridView'in DataSource'u anonim bir tip olduğu için direkt cast edemeyiz.
                // SözleşmeID'yi DataGridView hücresinden okuyacağız.
                var selectedRow = dgvAktifKiralamalar.SelectedRows[0];
                if (selectedRow.Cells["SozlesmeID"].Value != null &&
                    int.TryParse(selectedRow.Cells["SozlesmeID"].Value.ToString(), out int sozlesmeId))
                {
                    try
                    {
                        var sozlesme = _kiralamaServisi.TumSozlesmeleriGetir().FirstOrDefault(s => s.Id == sozlesmeId);
                        if (sozlesme != null && sozlesme.Durum == KiralamaDurumu.Aktif)
                        {
                            DialogResult cevap = MessageBox.Show(
                                $"{sozlesme.KiralananArac.Plaka} plakalı aracı teslim almak ve sözleşmeyi tamamlamak istiyor musunuz?",
                                "Teslim Alma Onayı",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            if (cevap == DialogResult.Yes)
                            {
                                _kiralamaServisi.KiralamaTamamla(sozlesmeId);
                                MessageBox.Show("Araç başarıyla teslim alındı ve sözleşme tamamlandı.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AktifKiralamalariYukle(); // Listeyi yenile
                                                          // En çok kiralananlar listesini de yenilemek isteyebilirsiniz.
                                EnCokKiralananlariYukle();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seçili sözleşme aktif değil veya bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Teslim alma işlemi sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Sözleşme ID'si alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen teslim alınacak bir kiralama seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvAktifKiralamalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
