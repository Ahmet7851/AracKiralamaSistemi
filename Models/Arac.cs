using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracKiralamaSistemi.Interfaces;

namespace AracKiralamaSistemi.Models
{
    public abstract class Arac : IKiralik, IAracOzellikleri
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Plaka { get; set; }
        public decimal GunlukKiraBedeli { get; set; }
        public bool KiralandiMi { get; set; } = false; // Başlangıçta kiralanmamış

        public virtual decimal KiraHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            // ... (Daha önceki yanıttaki kod) ...
            if (baslangicTarihi >= bitisTarihi)
            {
                throw new ArgumentException("Bitiş tarihi başlangıç tarihinden önce veya eşit olamaz.");
            }
            TimeSpan kiralamaSuresi = bitisTarihi - baslangicTarihi;
            int gunSayisi = (int)Math.Ceiling(kiralamaSuresi.TotalDays);
            if (gunSayisi <= 0) gunSayisi = 1;
            return gunSayisi * GunlukKiraBedeli;
        }

        public void Kirala()
        {
            if (KiralandiMi)
            {
                throw new InvalidOperationException("Bu araç zaten kiralanmış durumda.");
            }
            KiralandiMi = true;
        }

        public void TeslimAl()
        {
            KiralandiMi = false;
        }

        public abstract string OzellikleriGoster();

        public override string ToString()
        {
            return $"{Marka} {Model} ({Plaka}) - {(KiralandiMi ? "Kirada" : "Müsait")}";
        }
    }
}
