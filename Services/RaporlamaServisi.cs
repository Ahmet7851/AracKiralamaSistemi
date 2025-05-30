using AracKiralamaSistemi.Data;
using AracKiralamaSistemi.Models;
using System.Collections.Generic;
using System.Linq;

namespace AracKiralamaSistemi.Services
{
    public class RaporlamaServisi
    {
        public List<KiralamaSozlesmesi> AktifKiralamalar()
        {
            return VeriDeposu.KiralamaSozlesmeleri
                .Where(ks => ks.Durum == KiralamaDurumu.Aktif)
                .ToList();
        }

        public List<KeyValuePair<Arac, int>> EnCokKiralananAraclar(int topN = 5)
        {
            return VeriDeposu.KiralamaSozlesmeleri
                .Where(ks => ks.Durum == KiralamaDurumu.Tamamlandi || ks.Durum == KiralamaDurumu.Aktif) // Tamamlanmış veya aktif kiralamaları say
                .GroupBy(ks => ks.KiralananArac)
                .Select(g => new KeyValuePair<Arac, int>(g.Key, g.Count()))
                .OrderByDescending(kvp => kvp.Value)
                .Take(topN)
                .ToList();
        }

        // İleride eklenebilecek diğer raporlar:
        // - Aylık gelir raporu
        // - Müşteriye göre kiralama geçmişi
    }
}