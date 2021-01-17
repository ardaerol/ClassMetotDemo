using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Arda erol";
            musteri1.Yasi = 20;
            musteri1.Id = 1;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Eren alp";
            musteri2.Yasi = 19;
            musteri2.Id = 2;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ahmet ark";
            musteri3.Yasi = 21;
            musteri3.Id = 3;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            MusteriManager.Ekle(musteri3);

            MusteriManager.Listeleme(musteriler);
            MusteriManager.Silme(musteri1);
            MusteriManager.Listeleme(musteriler);


        }
    }
}
