using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 01;
            musteri1.Adi = "Olcay";
            musteri1.Soyadi = "Ağca";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 02;
            musteri2.Adi = "Berat";
            musteri2.Soyadi = "Çobanoğlu";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 03;
            musteri3.Adi = "Serdal";
            musteri3.Soyadi = "Bozkurt";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı:"+musteri.Adi + "  " + " Soyadı:" + musteri.Soyadi + " "+" Id:"+ musteri.Id);
            }

            Console.WriteLine("-------Metotlar----------");

            MusteriManager musterimeneger = new MusteriManager();
            musterimeneger.Ekle(musteri1);
            musterimeneger.Sil(musteri2);

        }
    }
}
