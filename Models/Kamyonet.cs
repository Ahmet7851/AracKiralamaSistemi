using System;

namespace AracKiralamaSistemi.Models
{
    public class Kamyonet : Arac
    {
        public double TasimaKapasitesiKg { get; set; }
        public string KasaTipi { get; set; } // Açık, Kapalı

        public override string OzellikleriGoster()
        {
            return $"Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Plaka: {Plaka}, Taşıma Kapasitesi: {TasimaKapasitesiKg} kg, Kasa: {KasaTipi}, Günlük Bedel: {GunlukKiraBedeli:C}";
        }

        // Polimorfizm: Kamyonetler için farklı kira hesaplaması
        public override decimal KiraHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            // Kamyonetler genelde daha pahalı olabilir veya farklı bir hesaplama mantığı olabilir
            decimal temelKira = base.KiraHesapla(baslangicTarihi, bitisTarihi);
            return temelKira * 1.20m; // Kamyonetler için %20 ek ücret (örnek)
        }
    }
}