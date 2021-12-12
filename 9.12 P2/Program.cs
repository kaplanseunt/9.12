using System;

namespace _9._12_P2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "62123";
            musteri1.Adi = "Taha";
            musteri1.Soyadi = "Kaplan";
            musteri1.TcNo = "111111111";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri1.Id = 2;
            musteri2.MusteriNo = "313131";
            musteri2.SirketAdi = "Facebook";
            musteri2.VergiNo = "69696969";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

        }
    }
}
