using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";
            urun2.StokAdedi = 5;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Adı: " + urun.Adi);
                Console.WriteLine("Fiyatı: " + urun.Fiyati);
                Console.WriteLine("Açıklaması: " + urun.Aciklama);
                Console.WriteLine("Stok: " + urun.StokAdedi);
                Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
                Console.WriteLine("---------------------------------");
            }

            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun1);

            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");

            sepetManager.Ekle2("Armut", "Yeşil", 12, 5);
            sepetManager.Ekle2("Elma", "Kırmızı", 35, 8);
            sepetManager.Ekle2("Karpuz", "Sulu", 92, 2);

        }
    }
}
