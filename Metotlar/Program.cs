using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //
            // string urunAdi = "Elma";
            // double fiyati = 15;
            // string aciklama = "Amasya Elmasi";
            // string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = ("Elma");
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = ("Karpuz");
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyerbakir karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            // type safe = tip guvenli
            foreach (var Urun in urunler)
            {
                Console.WriteLine(Urun.Adi);
                Console.WriteLine(Urun.Fiyati);
                Console.WriteLine(Urun.Aciklama);
                Console.WriteLine("===============");
            }

            Console.WriteLine("------Metotlar-----");

            // instance = ornek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yesil Armut", 12, 5);
            sepetManager.Ekle2("Elma", "Yesil Elma", 15, 25);
            sepetManager.Ekle2("Karpuz", "Yesil Karpuz", 80, 15);

        }
    }
}