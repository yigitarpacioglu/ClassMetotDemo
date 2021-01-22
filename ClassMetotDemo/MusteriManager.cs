using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        private string _medeniDurum = "";
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " -- Eklendi");
        }
        public void Listele(Musteri musteri)
        {
            _medeniDurum = (musteri.MedeniDurum == true) ? "Evli" : "Bekar";
            Console.WriteLine(musteri.Id+". "+musteri.Ad + " " + musteri.Soyad + " Yaş: " + musteri.Yas + " Medeni Durum: " + _medeniDurum + " -- Listelendi");
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " -- Silindi");
        }
    }
}
