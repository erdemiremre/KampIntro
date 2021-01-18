using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAd = "Ali";
            musteri1.MusteriSoyad = "Tarak";
            musteri1.Meslek = "Öğretmen";
            musteri1.MusteriAdres = "Sivas";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAd = "Musa";
            musteri2.MusteriSoyad = "Vurgun";
            musteri2.Meslek = "Serbest Çalışan";
            musteri2.MusteriAdres = "Diyarbakır";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAd = "Murat";
            musteri3.MusteriSoyad = "Duran";
            musteri3.Meslek = "Serbest Çalışan";
            musteri3.MusteriAdres = "İzmir";

            Musteri musteri4 = new Musteri();
            musteri4.MusteriId = 4;
            musteri4.MusteriAd = "Derya";
            musteri4.MusteriSoyad = "Periz";
            musteri4.Meslek = "Doktor";
            musteri4.MusteriAdres = "Ankara";

            Musteri musteri5 = new Musteri();
            musteri5.MusteriId = 5;
            musteri5.MusteriAd = "Kamil";
            musteri5.MusteriSoyad = "Koç";
            musteri5.Meslek = "Öğrenci";
            musteri5.MusteriAdres = "Erzurum";


            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3,musteri4,musteri5 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("-----------------MÜŞTERİ EKLE--------------------");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);
            musteriManager.MusteriEkle(musteri5);
            Console.WriteLine("-----------------MÜŞTERİ LİSTESİ--------------------");
            musteriManager.MusteriListele(musteriler);

            Console.WriteLine("-----------------MÜŞTERİ SİLME İŞLEMLERİ--------------------");
            musteriManager.MusteriSil(1);

        }
    }
}
