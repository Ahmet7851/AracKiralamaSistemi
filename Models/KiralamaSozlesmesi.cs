using System;

namespace AracKiralamaSistemi.Models
{
    public enum KiralamaDurumu
    {
        Aktif,
        Tamamlandi,
        IptalEdildi
    }

    public class KiralamaSozlesmesi
    {
        public int Id { get; set; }
        public Arac KiralananArac { get; set; }
        public Musteri KiralayanMusteri { get; set; }
        public DateTime KiralamaBaslangicTarihi { get; set; }
        public DateTime KiralamaBitisTarihi { get; set; }
        public decimal ToplamUcret { get; set; }
        public KiralamaDurumu Durum { get; set; }

        public KiralamaSozlesmesi()
        {
            Durum = KiralamaDurumu.Aktif;
        }

        public void HesaplaVeAyarlaToplamUcret()
        {
            if (KiralananArac != null)
            {
                ToplamUcret = KiralananArac.KiraHesapla(KiralamaBaslangicTarihi, KiralamaBitisTarihi);
            }
        }

        public override string ToString()
        {
            return $"Sözleşme ID: {Id} - Araç: {KiralananArac?.Plaka} - Müşteri: {KiralayanMusteri?.Ad} {KiralayanMusteri?.Soyad} - Tutar: {ToplamUcret:C} - Durum: {Durum}";
        }
    }
}