namespace AracKiralamaSistemi.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TCKimlikNo { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }

        public override string ToString()
        {
            return $"{Ad} {Soyad} ({TCKimlikNo})";
        }
    }
}