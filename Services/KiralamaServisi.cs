using AracKiralamaSistemi.Data;
using AracKiralamaSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSistemi.Services
{
    public class KiralamaServisi
    {
        public KiralamaSozlesmesi KiralamaYap(Arac arac, Musteri musteri, DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            if (arac.KiralandiMi)
            {
                throw new InvalidOperationException("Araç zaten kiralanmış.");
            }
            if (baslangicTarihi < DateTime.Today)
            {
                throw new ArgumentException("Başlangıç tarihi geçmiş bir tarih olamaz.");
            }
            if (bitisTarihi <= baslangicTarihi)
            {
                throw new ArgumentException("Bitiş tarihi başlangıç tarihinden sonra olmalıdır.");
            }

            var sozlesme = new KiralamaSozlesmesi
            {
                Id = VeriDeposu.GetNextSozlesmeId(),
                KiralananArac = arac,
                KiralayanMusteri = musteri,
                KiralamaBaslangicTarihi = baslangicTarihi,
                KiralamaBitisTarihi = bitisTarihi,
                Durum = KiralamaDurumu.Aktif
            };
            sozlesme.HesaplaVeAyarlaToplamUcret(); // Polimorfik KiraHesapla çağrılır

            arac.Kirala(); // Aracın durumunu güncelle
            VeriDeposu.KiralamaSozlesmeleri.Add(sozlesme);
            return sozlesme;
        }

        public void KiralamaTamamla(int sozlesmeId)
        {
            var sozlesme = VeriDeposu.KiralamaSozlesmeleri.FirstOrDefault(s => s.Id == sozlesmeId);
            if (sozlesme != null && sozlesme.Durum == KiralamaDurumu.Aktif)
            {
                sozlesme.KiralananArac.TeslimAl(); // Aracın durumunu güncelle
                sozlesme.Durum = KiralamaDurumu.Tamamlandi;
            }
            else
            {
                throw new InvalidOperationException("Sözleşme bulunamadı veya zaten tamamlanmış/iptal edilmiş.");
            }
        }

        public List<KiralamaSozlesmesi> TumSozlesmeleriGetir()
        {
            return VeriDeposu.KiralamaSozlesmeleri;
        }

        public List<KiralamaSozlesmesi> AktifKiralamalariGetir()
        {
            return VeriDeposu.KiralamaSozlesmeleri.Where(s => s.Durum == KiralamaDurumu.Aktif).ToList();
        }
    }
}