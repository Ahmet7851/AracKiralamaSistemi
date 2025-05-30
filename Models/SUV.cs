using System;

namespace AracKiralamaSistemi.Models
{
    public class SUV : Arac
    {
        public bool DortCekerMi { get; set; }
        public int KoltukSayisi { get; set; }

        public SUV()
        {
            KoltukSayisi = 5; // Varsayılan
        }

        public override string OzellikleriGoster()
        {
            return $"Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Plaka: {Plaka}, 4x4: {(DortCekerMi ? "Evet" : "Hayır")}, Koltuk: {KoltukSayisi}, Günlük Bedel: {GunlukKiraBedeli:C}";
        }

        // Polimorfizm: SUV'lar için günlük kira bedeli %15 daha fazla olabilir.
        // Bu, GunlukKiraBedeli set edilirken ayarlanabilir ya da KiraHesapla'da yapılabilir.
        // Örneğin, aşağıdaki gibi KiraHesapla'yı override edebiliriz:
        public override decimal KiraHesapla(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            decimal temelKira = base.KiraHesapla(baslangicTarihi, bitisTarihi);
            return temelKira * 1.10m; // SUV'lar için %10 ek ücret (örnek)
        }
    }
}