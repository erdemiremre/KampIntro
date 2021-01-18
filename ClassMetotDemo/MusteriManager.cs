using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd+" "+musteri.MusteriSoyad+" "+"müşteri listesine eklendi.");
        }

        public void MusteriListele(Musteri[] musteris)
        {
            foreach (var musteri in musteris)
            {
                Console.WriteLine("Adı : "+musteri.MusteriAd);
                Console.WriteLine("Soyadı : "+musteri.MusteriSoyad);
                Console.WriteLine("Meslek : "+musteri.Meslek);
                Console.WriteLine("Adres : "+musteri.MusteriAdres);
                Console.WriteLine("------------------------------");
            }
        }

        public void MusteriSil(int id)
        {
            Console.WriteLine("Müşteri silme işlemi gerçekleşti.");
        }
    }

}
