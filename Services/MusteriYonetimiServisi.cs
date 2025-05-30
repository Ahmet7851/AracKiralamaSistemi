using AracKiralamaSistemi.Data;
using AracKiralamaSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSistemi.Services
{
    public class MusteriYonetimiServisi
    {
        public void MusteriEkle(Musteri musteri)
        {
            musteri.Id = VeriDeposu.GetNextMusteriId();
            VeriDeposu.Musteriler.Add(musteri);
        }

        public void MusteriSil(int musteriId)
        {
            // Müşterinin aktif kiralaması var mı kontrol edilebilir
            bool aktifKiralamasiVar = VeriDeposu.KiralamaSozlesmeleri.Any(ks => ks.KiralayanMusteri.Id == musteriId && ks.Durum == KiralamaDurumu.Aktif);
            if (aktifKiralamasiVar)
            {
                throw new InvalidOperationException("Bu müşterinin aktif bir kiralaması bulunmaktadır. Önce kiralama tamamlanmalı veya iptal edilmelidir.");
            }

            var musteri = VeriDeposu.Musteriler.FirstOrDefault(m => m.Id == musteriId);
            if (musteri != null)
            {
                VeriDeposu.Musteriler.Remove(musteri);
            }
        }

        public void MusteriGuncelle(Musteri guncelMusteri)
        {
            var mevcutMusteri = VeriDeposu.Musteriler.FirstOrDefault(m => m.Id == guncelMusteri.Id);
            if (mevcutMusteri != null)
            {
                mevcutMusteri.Ad = guncelMusteri.Ad;
                mevcutMusteri.Soyad = guncelMusteri.Soyad;
                mevcutMusteri.TCKimlikNo = guncelMusteri.TCKimlikNo;
                mevcutMusteri.Telefon = guncelMusteri.Telefon;
                mevcutMusteri.Adres = guncelMusteri.Adres;
            }
        }

        public List<Musteri> TumMusterileriGetir()
        {
            return VeriDeposu.Musteriler;
        }

        public Musteri MusteriBul(int musteriId)
        {
            return VeriDeposu.Musteriler.FirstOrDefault(m => m.Id == musteriId);
        }
    }
}