using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri()
            {
                Id = 1,
                Ad = "Yiğit",
                Soyad = "Arpacıoğlu",
                Yas = 25,
                MedeniDurum = false
            };
            Musteri musteri2 = new Musteri()
            {
                Id = 2,
                Ad = "Sabri",
                Soyad = "Arpacıoğlu",
                Yas = 61,
                MedeniDurum = true
            };
            Musteri musteri3 = new Musteri()
            {
                Id = 3,
                Ad = "Berkay",
                Soyad = "Aliç",
                Yas = 25,
                MedeniDurum = false
            };
            Musteri musteri4 = new Musteri()
            {
                Id = 4,
                Ad = "Kübra",
                Soyad = "Tetik",
                Yas = 26,
                MedeniDurum = true
            };

            MusteriManager manager = new MusteriManager();
            manager.Ekle(musteri1);
            manager.Listele(musteri2);
            manager.Sil(musteri3);
            
            //hepsini yazdırırsak

            Musteri[] musteriler = new Musteri[]{musteri1,musteri2,musteri3,musteri4};
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("***** Müşteri "+musteri.Id+": "+"*****");
                manager.Ekle(musteri);
                manager.Listele(musteri);
                manager.Sil(musteri);
            }
        }
    }
}
