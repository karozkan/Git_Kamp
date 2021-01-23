using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Özkan GÖktaş
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Özkan";
            musteri1.Soyadi = "Göktaş";
            musteri1.TcNo = "111111111111";

            //Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "23456";
            musteri2.SirketAdi = "MEB";
            musteri2.VergiNo = "1235465464";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);



        }
    }
}
