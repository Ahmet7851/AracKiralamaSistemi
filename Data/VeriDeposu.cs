using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralamaSistemi.Models;

namespace AracKiralamaSistemi.Data
{
    public static class VeriDeposu
    {
        public static List<Arac> Araclar { get; private set; } = new List<Arac>();
        public static List<Musteri> Musteriler { get; private set; } = new List<Musteri>();
        public static List<KiralamaSozlesmesi> KiralamaSozlesmeleri { get; private set; } = new List<KiralamaSozlesmesi>();

        private static int _sonAracId = 0;
        private static int _sonMusteriId = 0;
        private static int _sonSozlesmeId = 0;

        public static int GetNextAracId() => ++_sonAracId;
        public static int GetNextMusteriId() => ++_sonMusteriId;
        public static int GetNextSozlesmeId() => ++_sonSozlesmeId;

        static VeriDeposu() // Örnek veriler ekleyelim
        {
            Araclar.Add(new Sedan { Id = GetNextAracId(), Marka = "Renault", Model = "Clio", Yil = 2022, Plaka = "34ABC01", GunlukKiraBedeli = 500, KapiSayisi = 4, BagajHacmi = "300 Lt" });
            Araclar.Add(new SUV { Id = GetNextAracId(), Marka = "Nissan", Model = "Qashqai", Yil = 2023, Plaka = "34XYZ78", GunlukKiraBedeli = 800, DortCekerMi = true, KoltukSayisi = 5 });
            // ... diğer örnek veriler
        }
    }
}
