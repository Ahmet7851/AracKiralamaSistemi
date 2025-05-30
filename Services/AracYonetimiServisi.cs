using AracKiralamaSistemi.Data;
using AracKiralamaSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSistemi.Services
{
    public class AracYonetimiServisi
    {
        public void AracEkle(Arac arac)
        {
            arac.Id = VeriDeposu.GetNextAracId();
            VeriDeposu.Araclar.Add(arac);
        }

        public void AracSil(int aracId)
        {
            var arac = VeriDeposu.Araclar.FirstOrDefault(a => a.Id == aracId);
            if (arac != null && !arac.KiralandiMi) // Sadece kirada olmayan araçlar silinebilir
            {
                VeriDeposu.Araclar.Remove(arac);
            }
            else if (arac != null && arac.KiralandiMi)
            {
                throw new InvalidOperationException("Kiradaki bir araç silinemez.");
            }
        }

        public void AracGuncelle(Arac guncelArac)
        {
            var mevcutArac = VeriDeposu.Araclar.FirstOrDefault(a => a.Id == guncelArac.Id);
            if (mevcutArac != null)
            {
                // Reflection veya manuel atama ile özellikler güncellenebilir.
                // Basitlik için manuel atama:
                mevcutArac.Marka = guncelArac.Marka;
                mevcutArac.Model = guncelArac.Model;
                mevcutArac.Yil = guncelArac.Yil;
                mevcutArac.Plaka = guncelArac.Plaka;
                mevcutArac.GunlukKiraBedeli = guncelArac.GunlukKiraBedeli;
                // Tipine göre özel özellikler de güncellenmeli (Sedan.KapiSayisi vs.)
                // Bu kısım daha detaylı bir implementasyon gerektirir.
            }
        }

        public List<Arac> TumAraclariGetir()
        {
            return VeriDeposu.Araclar;
        }

        public List<Arac> MusaitAraclariGetir()
        {
            return VeriDeposu.Araclar.Where(a => !a.KiralandiMi).ToList();
        }

        public Arac AraciBul(int aracId)
        {
            return VeriDeposu.Araclar.FirstOrDefault(a => a.Id == aracId);
        }
    }
}