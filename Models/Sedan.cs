using System;

namespace AracKiralamaSistemi.Models
{
    public class Sedan : Arac
    {
        public int KapiSayisi { get; set; }
        public string BagajHacmi { get; set; } // Örn: "500 Lt"

        public Sedan()
        {
            // Varsayılan değerler atanabilir
            KapiSayisi = 4;
        }

        public override string OzellikleriGoster()
        {
            return $"Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Plaka: {Plaka}, Kapı Sayısı: {KapiSayisi}, Bagaj Hacmi: {BagajHacmi}, Günlük Bedel: {GunlukKiraBedeli:C}";
        }

        // Polimorfizm örneği: Sedan için farklı bir kira hesaplaması gerekirse
        // public override decimal KiraHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
        // {
        //     decimal temelKira = base.KiraHesapla(baslangicTarihi, bitisTarihi);
        //     // Sedan'a özel ek bir ücret veya indirim uygulanabilir.
        //     // Örneğin, 7 günden uzun kiralamalarda %10 indirim
        //     if ((bitisTarihi - baslangicTarihi).TotalDays > 7)
        //     {
        //         temelKira *= 0.90m;
        //     }
        //     return temelKira;
        // }
    }
}