using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();
       public static void Ekle(Musteri musteri)
        {
            Console.WriteLine("Yeni müşteri eklendi");
            Console.WriteLine("-------------");
        }

        

        public static void Listeleme(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.Id);
                Console.WriteLine("-------------");
            }
        }

        public static void Silme(Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi");
            Console.WriteLine("-------------");
        }

}
}

