using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaSistemi.Interfaces
{
    internal interface IKiralik
    {
        decimal GunlukKiraBedeli { get; set; }
        bool KiralandiMi { get; set; }
        decimal KiraHesapla(DateTime baslangicTarihi, DateTime bitisTarihi);
        void Kirala();
        void TeslimAl();
    }
}
