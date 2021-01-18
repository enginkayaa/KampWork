using System;

namespace KampÖdevlerim
{
    class Program
    {
        static void Main(string[] args)
        {
            Arabalarım arabam1 = new Arabalarım();
            arabam1.arabaMarka = "BMW";
            arabam1.rengi = "Kırmızı";
            arabam1.arabamınFiyatı = 500000;


            Arabalarım arabam2 = new Arabalarım();
            arabam2.arabaMarka = "Mecedes";
            arabam2.rengi = "Beyaz";
            arabam2.arabamınFiyatı = 650000;

            Arabalarım[] arabalar = new Arabalarım[] { arabam1, arabam2 };

            foreach (var arabalarım in arabalar)
            {
                Console.WriteLine("Arabamın Markası: " + arabalarım.arabaMarka + " Rengi: " + arabalarım.rengi + " Fiyatı: " + arabalarım.arabamınFiyatı);
            }



            urunler urun1 = new urunler();
            urun1.urunAdı = "Iphone";
            urun1.urunFiyatı = 5500;

            urunler urun2 = new urunler();
            urun2.urunAdı = "ipad";
            urun2.urunFiyatı = 6600;

            urunler urun3 = new urunler();
            urun3.urunAdı = "MacBook";
            urun3.urunFiyatı = 8500;
            urunler[] urunler = new urunler[] { urun1, urun2, urun3 };

            Console.WriteLine("Foreach döngüsü ile");

            foreach (var urunlerim in urunler)
            {
                Console.WriteLine(urunlerim.urunAdı + " " + urunlerim.urunFiyatı);
            }
            Console.WriteLine("For döngüsü ile");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Ürün Adı: "+urunler[i].urunAdı+", Ürün Fİyatı "+urunler[i].urunFiyatı );
            }
            Console.WriteLine("while Döngüsü ile");
            int j = 0;
            while (j<urunler.Length)
            {
                Console.WriteLine("Ürün Adı: " + urunler[j].urunAdı + ", Ürün Fİyatı " + urunler[j].urunFiyatı);
                j++;
            }
        }
    }


    class Arabalarım
    {
        public string arabaMarka { get; set; }
        public string rengi { get; set; }
        public int arabamınFiyatı { get; set; }

    }
    class urunler
    {
        public string urunAdı { get; set; }
        public int urunFiyatı { get; set; }

    }
}
